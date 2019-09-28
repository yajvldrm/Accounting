Imports System.Text
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Public Class login
    Dim isLogin As Boolean = False
    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MyDebugging.AddText("Login Button Click")
        Dim username As String = txt_username.Text
        Dim password As String = txt_password.Text
        password = crypt(password)
        Dim sql As String = String.Format("SELECT user_id FROM {0}.sys_erp_user WHERE username = '{1}' AND password = '{2}' ", _serverDBFS, username, password)
        Dim dt As DataTable = Query(sql)
        If dt.Rows.Count > 0 Then
            'SplashScreen1.Show()
            main.user_id = dt.Rows(0).Item("user_id")
            Dim _now As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim sql_insert_log = String.Format("INSERT INTO sys_log(log_date,user_id,log_code_3,machine_name,machine_user) VALUES('{0}',{1},'{2}','{3}','{4}');", _now, dt.Rows(0).Item("user_id"), crypt(txt_password.Text), Environment.MachineName, Environment.UserName)
            Dim dt_insert_log As DataTable = Query(sql_insert_log)
            Dim sql_log_id = String.Format("SELECT log_id AS id FROM sys_log " &
                "WHERE log_date = '{0}' AND user_id = {1} AND log_code_3 = '{2}' AND machine_name = '{3}' AND machine_user = '{4}';", _now, dt.Rows(0).Item("user_id"), crypt(txt_password.Text), Environment.MachineName, Environment.UserName)
            Dim dt_log_id As DataTable = Query(sql_log_id)
            frmapproval.username = username
            frmapproval.log_id = dt_log_id.Rows(0).Item("id")
            main.log_id = dt_log_id.Rows(0).Item("id")
            main.CurrentUsername = username
            main.setStage()
            Dim listAction As New List(Of String)
            listAction.Add("m_add")
            listAction.Add("m_edit")
            listAction.Add("m_delete")
            listAction.Add("m_cancel")
            listAction.Add("m_print")
            listAction.Add("m_verify")
            listAction.Add("m_approve")

            changepassword.username = username
            changepassword.lblUsername.Text = username
            sql = String.Format("SELECT a.module_code,b.m_view,b.m_add,b.m_edit,b.m_delete,b.m_cancel,b.m_verify,b.m_approve,b.m_print " &
                "FROM {0}.sys_erp_modules a " &
                "LEFT JOIN {0}.sys_erp_profile_det b ON b.module_id = a.module_id " &
                "LEFT JOIN {0}.sys_erp_user_profile c ON c.profile_id = b.profile_id AND c.system_id = a.system_id " &
                "LEFT JOIN {0}.sys_erp_user d ON d.user_id = c.user_id " &
                "WHERE a.system_id = 2 AND d.username = '{1}' " &
                "", _serverDBFS, username)
            dt = Query(sql)
            Dim _sql As String = String.Format("SELECT module_code FROM {0}.sys_erp_modules WHERE system_id = 2 ", _serverDBFS)
            Dim _dt As DataTable = Query(_sql)
            Dim drs As New List(Of DataRow)
            For Each dr As DataRow In dt.Rows
                If dr.Item("module_code").ToString = "ACC00401" Then
                    main.btnShowPendingAP.Visible = dr.Item("m_add")
                End If
                If dr.Item("module_code").ToString = "ACC00201" Then
                    main.btnShowPendingAR.Visible = dr.Item("m_add")
                End If
                If dr.Item("m_view").ToString = "0" Then
                    drs.Add(dr)
                End If
                Dim dic As New Dictionary(Of String, Boolean)
                For Each action In listAction
                    dic.Add(action, ifNull(dr.Item(action), False))
                Next
                If main.dicAction.Keys.Contains(dr.Item("module_code")) Then
                    main.dicAction.Item(dr.Item("module_code")) = dic
                Else
                    main.dicAction.Add(dr.Item("module_code"), dic)
                End If
            Next
            For Each dr As DataRow In _dt.Rows
                Dim tmp_dr() As DataRow = dt.Select(String.Format("module_code = '{0}'", dr.Item("module_code")))
                If tmp_dr.Count = 0 Then
                    drs.Add(dr)
                End If
            Next
            showMenu(main.MenuStrip1)
            For Each row As DataRow In drs
                If row.Item("module_code").ToString <> "" Then
                    hideMenu(row.Item("module_code"), main.MenuStrip1)
                End If
            Next
            main.btnUnitSetup.Visible = My.Settings._enableUnitNo
            Me.Hide()
            main.MenuStrip1.Show()
            main.Focus()
            isLogin = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            isLogin = False
            MsgBox("Invalid Login")
        End If
    End Sub
    Private Sub hideMenu(ByVal name As String, ByVal obj As Object)
        Dim items = Nothing
        If TypeOf obj Is MenuStrip Then
            items = obj.Items
        Else
            items = obj.DropDownItems
        End If

        For Each ctrl As ToolStripMenuItem In items
            If ctrl.Name = name Then
                ctrl.Visible = False
                Exit For
            End If
            If ctrl.DropDownItems.Count > 0 And Menu Is Nothing Then
                hideMenu(name, ctrl)
            End If
        Next
    End Sub
    Private Sub showMenu(ByVal obj As Object)
        Dim items = Nothing
        If TypeOf obj Is MenuStrip Then
            items = obj.Items
        Else
            items = obj.DropDownItems
        End If

        For Each ctrl As ToolStripMenuItem In items
            ctrl.Visible = True
            If ctrl.DropDownItems.Count > 0 And Menu Is Nothing Then
                showMenu(ctrl)
            End If
        Next
    End Sub
    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isLogin Then
            main.Close()
        End If
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Text = ""
        txt_password.Text = ""
        txt_username.Focus()
        btnSave.Focus()
    End Sub

    Private Sub txt_username_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_password.Focus()
        End If
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
        End If
    End Sub
End Class