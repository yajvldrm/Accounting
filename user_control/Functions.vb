Imports System.Windows.Forms
Imports connectionlib.connectionlib

Public Class Functions
    Public Shared Function getBrowseQuery(ByVal TextBrowse As MyTextBox) As String
        Dim BrowseQuery As String = ""
        Dim MyForm = TextBrowse.FindForm
        Select Case TextBrowse.BrowseDataSource
            Case "[month]"
                BrowseQuery = "SELECT 1 as month_id,'JAN' AS month_code,'JANUARY' AS month_name " & _
                    "UNION SELECT 2,'FEB','FEBRUARY' " & _
                    "UNION SELECT 3,'MAR','MARCH' " & _
                    "UNION SELECT 4,'APR','APRIL' " & _
                    "UNION SELECT 5,'MAY','MAY' " & _
                    "UNION SELECT 6,'JUN','JUNE' " & _
                    "UNION SELECT 7,'JUL','JULY' " & _
                    "UNION SELECT 8,'AUG','AUGUST' " & _
                    "UNION SELECT 9,'SEP','SEPTEMBER' " & _
                    "UNION SELECT 10,'OCT','OCTOBER' " & _
                    "UNION SELECT 11,'NOV','NOVEMBER' " & _
                    "UNION SELECT 12,'DEC','DECEMBER' "
            Case "[general_client]" '231
                BrowseQuery = "SELECT a.general_id,a.general_code,a.general_name,a.terms_id " & _
                    ",b.terms_code,b.terms_name,IFNULL(a.nodays,b.nodays) AS nodays,b.fixed_day " & _
                    "FROM lib_erp_general a " & _
                    "LEFT JOIN lib_erp_terms b ON b.terms_id = a.terms_id " & _
                    "ORDER BY FIELD(a.category_id,1,2),a.general_code ASC "
            Case "[general_supplier]" '132
                BrowseQuery = "SELECT a.general_id,a.general_code,a.general_name,a.terms_id " & _
                    ",b.terms_code,b.terms_name,IFNULL(a.nodays,b.nodays) AS nodays,b.fixed_day " & _
                    "FROM lib_erp_general a " & _
                    "LEFT JOIN lib_erp_terms b ON b.terms_id = a.terms_id " & _
                    "ORDER BY FIELD(a.category_id,2,1),a.general_code ASC "
            Case "[currency]"
                Dim txtmonth = CType(MyForm.Controls.Find("txt_month", True)(0), MyTextBox)
                Dim txtyear = CType(MyForm.Controls.Find("txt_year", True)(0), MyTextBox)
                Dim txtday = CType(MyForm.Controls.Find("txt_day", True)(0), MyTextBox)
                Dim where As String = "" '& txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & "-" & txtday.Text.PadLeft(2, "0") & ""
                If MyForm.AccessibleName = 1 Then
                    where = "" & txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & ""
                    BrowseQuery = String.Format("select a.currency_id,a.currency_code,a.currency_name " &
                    ",b.exchange_rate,b.based_rate " &
                    "from lib_erp_currency a " &
                    "inner join (select a.currency_id,a.exchange_rate,a.based_rate " &
                    "from lib_erp_currency_rate a " &
                    "inner join (SELECT currency_id,max(effectivitydate) as effectivitydate " &
                            "FROM lib_erp_currency_rate " &
                            "where left(effectivitydate,7) <= '" & where & "' " &
                    "group by currency_id) b on a.currency_id = b.currency_id " &
                    "and a.effectivitydate = b.effectivitydate) b on a.currency_id = b.currency_id")
                Else
                    where = "" & txtyear.Text & "-" & txtmonth.Value.PadLeft(2, "0") & "-" & txtday.Text.PadLeft(2, "0") & ""
                    BrowseQuery = String.Format("select a.currency_id,a.currency_code,a.currency_name " &
                    ",b.exchange_rate,b.based_rate " &
                    "from lib_erp_currency a " &
                    "inner join (select a.currency_id,a.exchange_rate,a.based_rate " &
                    "from lib_erp_currency_rate a " &
                    "inner join (SELECT currency_id,max(effectivitydate) as effectivitydate " &
                            "FROM lib_erp_currency_rate " &
                            "where left(effectivitydate,7) <= '" & where & "' " &
                    "group by currency_id) b on a.currency_id = b.currency_id " &
                    "and a.effectivitydate = '" & where & "') b on a.currency_id = b.currency_id")
                End If


                'BrowseQuery = "select a.currency_id,a.currency_code,a.currency_name " &
                '                ",b.exchange_rate,b.based_rate " &
                '                "from lib_erp_currency a " &
                '                "inner join (select a.currency_id,a.exchange_rate,a.based_rate " &
                '                        "from lib_erp_currency_rate a " &
                '                        "inner join (SELECT currency_id,max(effectivitydate) as effectivitydate " &
                '                                "FROM lib_erp_currency_rate " & where &
                '                        "group by currency_id) b on a.currency_id = b.currency_id " &
                '                    "and a.effectivitydate = b.effectivitydate) b on a.currency_id = b.currency_id"
            Case "[terms_payment]"
                BrowseQuery = "SELECT * FROM lib_erp_terms WHERE terms_type = 1 OR terms_type = 3"
            Case "[terms_selling]"
                BrowseQuery = "SELECT * FROM lib_erp_terms WHERE terms_type = 2 OR terms_type = 3"
            Case "[terms]"
                BrowseQuery = "SELECT * FROM lib_erp_terms"
                If TextBrowse.BrowseFilter IsNot Nothing Then
                    If TextBrowse.BrowseFilter.RowData IsNot Nothing Then
                        Dim validation = TextBrowse.BrowseFilter.RowData
                        If validation.Item("validation").ToString = "2" Then
                            BrowseQuery &= " WHERE terms_type = 1 or terms_type = 3"
                        Else
                            BrowseQuery &= " WHERE terms_type = 2 or terms_type = 3"
                        End If
                    End If
                End If
            Case "[accounting_transaction]"
                BrowseQuery = String.Format("SELECT a.module_id,a.module_code,a.module_name " &
                    "FROM sys_erp_modules a " &
                    "WHERE module_type = 2 AND system_id = 2 " &
                    "")
            Case "[chart_type]"
                BrowseQuery = String.Format("SELECT 'A' AS chart_type,'Assets' AS chart_type_name " &
                    "UNION SELECT 'L','Liabilities' " &
                    "UNION SELECT 'C','Capital' " &
                    "UNION SELECT 'I','Income' " &
                    "UNION SELECT 'E','Expense' " &
                    "")
            Case "[ref_jbooks]"
                BrowseQuery = ""
            Case "[accounting_journal]"
                BrowseQuery = String.Format("SELECT a.journal_id,a.journal_code,a.journal_name " &
                                            "FROM lib_erp_journal a " &
                                            "WHERE journal_id <> 8 " &
                                            "")
            Case "[at_filter]"
                BrowseQuery = String.Format("SELECT * FROM (" &
                    "SELECT '1' AS at_filer_id,'ALL' AS at_filter_name " &
                    "UNION SELECT '2','Name' " &
                    "UNION SELECT '3','Date' " &
                    "UNION SELECT '4','Process' " &
                    "UNION SELECT '5','Reference' " &
                    ") a ")
            Case "[journal_book]"
                BrowseQuery = String.Format("SELECT a.journal_id,b.book_id,b.book_code,b.book_name " &
                    "FROM sys_acc_journal_book a " &
                    "LEFT JOIN lib_erp_book b ON b.book_id = a.book_id" &
                    "")
            Case "[lib_erp_chart]"
                BrowseQuery = String.Format("SELECT a.* " &
                    "FROM lib_erp_chart a " &
                    "LEFT JOIN lib_erp_allocation_account b ON b.account_id = a.account_id" &
                    "")
            Case "[lib_erp_allocation]"
                BrowseQuery = String.Format("SELECT a.*,b.* " &
                    "FROM lib_erp_allocation a " &
                    "LEFT JOIN lib_erp_allocation_account b ON b.allocation_id = a.allocation_id " &
                    "")
            Case Else
                BrowseQuery = "SELECT * FROM " & TextBrowse.BrowseDataSource
        End Select
        Return BrowseQuery
    End Function
    Public Shared Function getCustomQuery(ByVal str As String, Optional frm As Object = Nothing) As String
        Dim sql As String = ""
        Dim filter As Control = Nothing
        If frm IsNot Nothing Then
            If frm.Controls.Find("txt_filter", True).Length > 0 Then
                filter = frm.Controls.Find("txt_filter", True)(0)
            End If
        End If
        Select Case str
            Case "[lib_erp_book]"
                sql = String.Format("SELECT book_id,book_code,book_name,company_id " &
                                    "FROM lib_erp_book ")
                If filter IsNot Nothing Then
                    If TypeOf filter Is MyTextBox Then
                        Dim txt_filter = CType(filter, MyTextBox)
                        If txt_filter.Value.ToString <> "" Then
                            sql &= String.Format("WHERE company_id = '{0}'", txt_filter.Value)
                        End If
                    End If
                End If
            Case "[lib_erp_allocation_account]"
                sql = String.Format("SELECT a.allocation_account_id,a.allocation_id,a.account_id " &
                    ",b.account_code,b.account_name " &
                    "FROM lib_erp_allocation_account a " &
                    "LEFT JOIN lib_erp_chart b ON b.account_id = a.account_id ")
            Case "[approval_setup]"
                sql = String.Format("SELECT a.approval_id,a.module_id,a.stage_id,a.approval_order,a.order_no " &
                    ",b.module_code,b.module_name " &
                    ",c.stage_code,c.stage_name " &
                    "FROM sys_erp_approval a " &
                    "LEFT JOIN sys_erp_modules b ON b.module_id = a.module_id " &
                    "LEFT JOIN sys_erp_stage c ON c.stage_id = a.stage_id " &
                    "")
            Case "[approval_setup_user]"
                sql = String.Format("SELECT a.approval_user_id,a.approval_id,a.user_id,a.approval_order,a.order_no" &
                    ",b.username,b.user_fullname " &
                    "FROM sys_erp_approval_user a " &
                    "LEFT JOIN sys_erp_user b ON b.user_id = a.user_id " &
                    "")
            Case "[chart_class]"
                sql = String.Format("SELECT a.chart_class_id,a.chart_class_code,a.chart_class_name,a.chart_type " &
                    ",b.chart_type_name " &
                    "FROM lib_acc_chart_class a " &
                    "LEFT JOIN (" &
                    "   SELECT 'A' AS chart_type,'Assets' AS chart_type_name " &
                    "   UNION SELECT 'L','Liabilities'" &
                    "   UNION SELECT 'C','Capital'" &
                    "   UNION SELECT 'I','Income'" &
                    "   UNION SELECT 'E','Expense'" &
                    ") b ON b.chart_type = a.chart_type " &
                    "")
            Case "[transaction_locking]"
                sql = String.Format("SELECT a.transaction_locking_id,a.journal_id,a.date_from,a.date_to,a.isLock,a.book_id " &
                    ",b.journal_code,b.journal_name " &
                    ",c.book_code,c.book_name " &
                    "FROM transaction_locking_book a " &
                    "LEFT JOIN {0}.lib_erp_journal b ON b.journal_id = a.journal_id " &
                    "LEFT JOIN {0}.lib_erp_book c ON c.book_id = a.book_id " &
                    "", _serverDBFS)
        End Select
        Return sql
    End Function
    '#Region "Emon - 2017-08-27"
    '    Public Shared Sub InitialiseMyForm(ByVal MyParent As Control, ByRef MyControls As List(Of Control), ByRef MyPK As MyTextBox, ByRef MyDGView As DataGridView, ByRef MyChildren As List(Of MyPanel))
    '        For Each ctrl As Control In MyParent.Controls
    '            If TypeOf ctrl Is MyCheckBox Then
    '                Dim ctr = CType(ctrl, MyCheckBox)
    '                MyControls.Add(ctr)
    '            ElseIf TypeOf ctrl Is MyTextBox Then
    '                Dim ctr = CType(ctrl, MyTextBox)
    '                If ctr.ID Then
    '                    MyPK = ctr
    '                End If
    '                MyControls.Add(ctr)
    '            ElseIf TypeOf ctrl Is DataGridView Then
    '                Dim ctr = CType(ctrl, DataGridView)
    '                MyDGView = ctr
    '            ElseIf TypeOf ctrl Is MyPanel Then
    '                Dim ctr = CType(ctrl, MyPanel)
    '                MyChildren.Add(ctr)
    '                InitialiseMyForm(ctr, ctr.MyConrols, ctr.MyPK, ctr.MyDGView, ctr.MyChildren)
    '            ElseIf TypeOf ctrl Is Panel Then
    '                Dim ctr = CType(ctrl, Panel)
    '                InitialiseMyForm(ctr, MyControls, MyPK, MyDGView, MyChildren)
    '            ElseIf TypeOf ctrl Is GroupBox Then
    '                Dim ctr = CType(ctrl, GroupBox)
    '                InitialiseMyForm(ctr, MyControls, MyPK, MyDGView, MyChildren)
    '            ElseIf TypeOf ctrl Is MyButton Then
    '                Dim ctr = CType(ctrl, MyButton)
    '                Select Case ctr.ButtonType
    '                    Case MyList.ButtonType.ButtonAdd
    '                        AddHandler ctr.Click, AddressOf ButtonAddEvent
    '                    Case MyList.ButtonType.ButtonEdit
    '                        AddHandler ctr.Click, AddressOf ButtonEditEvent
    '                    Case MyList.ButtonType.ButtonDelete
    '                        AddHandler ctr.Click, AddressOf ButtonDeleteEvent
    '                    Case MyList.ButtonType.ButtonSave
    '                        AddHandler ctr.Click, AddressOf ButtonSaveEvent
    '                    Case MyList.ButtonType.ButtonNotSave
    '                        AddHandler ctr.Click, AddressOf ButtonNotSaveEvent
    '                    Case MyList.ButtonType.ButtonInsert
    '                        AddHandler ctr.Click, AddressOf ButtonInsertEvent
    '                    Case MyList.ButtonType.ButtonUpdate
    '                        AddHandler ctr.Click, AddressOf ButtonUpdateEvent
    '                    Case MyList.ButtonType.ButtonRemove
    '                        AddHandler ctr.Click, AddressOf ButtonRemoveEvent
    '                    Case MyList.ButtonType.ButtonOK
    '                        AddHandler ctr.Click, AddressOf ButtonOKEvent
    '                    Case MyList.ButtonType.ButtonCancel
    '                        AddHandler ctr.Click, AddressOf ButtonCancelEvent
    '                End Select
    '            End If
    '        Next
    '    End Sub
    '    Public Shared Sub ButtonAddEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub ButtonEditEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub ButtonDeleteEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub ButtonSaveEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub ButtonNotSaveEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub ButtonInsertEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub ButtonUpdateEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub ButtonRemoveEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub ButtonOKEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub ButtonCancelEvent(sender As Object, e As EventArgs)
    '    End Sub
    '    Public Shared Sub EnableMyControl(ByVal MyChildren As List(Of MyPanel) _
    '            , ByVal MyControls As List(Of Control) _
    '            , ByVal MyButtons As List(Of MyButton) _
    '            , Optional ToEnable As Boolean = True _
    '            , Optional EnableButton As Boolean = False _
    '            , Optional EnableSaving As Boolean = True)
    '        For Each ctrl In MyControls
    '            If TypeOf ctrl Is MyCheckBox Then
    '                Dim ctr = CType(ctrl, MyCheckBox)
    '                If ToEnable Then
    '                    If Not ctr.AlwaysDisable Then
    '                        ctrl.Enabled = ToEnable
    '                    End If
    '                Else
    '                    If Not ctr.AlwaysEnable Then
    '                        ctrl.Enabled = ToEnable
    '                    End If
    '                End If
    '            ElseIf TypeOf ctrl Is MyTextBox Then
    '                Dim ctr = CType(ctrl, MyTextBox)
    '                If ToEnable Then
    '                    If Not ctr.AlwaysDisable Then
    '                        ctrl.Enabled = ToEnable
    '                    End If
    '                Else
    '                    If Not ctr.AlwaysEnable Then
    '                        ctrl.Enabled = ToEnable
    '                    End If
    '                End If
    '            End If
    '        Next
    '        For Each btn As MyButton In MyButtons
    '            If btn.ButtonType = MyList.ButtonType.ButtonAdd _
    '                Or btn.ButtonType = MyList.ButtonType.ButtonEdit _
    '                Or btn.ButtonType = MyList.ButtonType.ButtonDelete _
    '                Or btn.ButtonType = MyList.ButtonType.ButtonInsert _
    '                Or btn.ButtonType = MyList.ButtonType.ButtonUpdate _
    '                Or btn.ButtonType = MyList.ButtonType.ButtonRemove Then
    '                btn.Visible = EnableButton
    '            Else
    '                btn.Visible = If(EnableSaving, Not EnableButton, False)
    '            End If
    '        Next
    '        For Each child As MyPanel In MyChildren
    '            EnableMyControl(child.MyChildren, child.MyConrols, child.MyButton, False, False, False)
    '        Next
    '    End Sub
    '    Public Shared Sub ClearMyControl(ByVal MyChildren As List(Of MyPanel), ByVal MyControls As List(Of Control))
    '        For Each ctrl In MyControls
    '            If TypeOf ctrl Is MyTextBox Then
    '                Dim ctr = CType(ctrl, MyTextBox)
    '                If Not ctr.NoClear Then
    '                    ctr.Text = ""
    '                    If ctr.ValueSource <> "" Then
    '                        ctr.Value = ""
    '                    End If
    '                    If ctr.NumberFormat.Contains("#") Then
    '                        ctr.DecimalValue = 0
    '                    End If
    '                End If
    '            ElseIf TypeOf ctrl Is MyCheckBox Then
    '                Dim ctr = CType(ctrl, MyCheckBox)
    '                ctr.Checked = False
    '            End If
    '        Next
    '    End Sub
    '#End Region
End Class
