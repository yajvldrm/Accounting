Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports libacctng.myFunctions
Imports connectionlib.connectionlib

Public Class classCon
    Public con As New MySqlConnection
    Public Sub vbcon()

        Try
            con = New MySqlConnection
            con.ConnectionString = ConnectionStringFS
            con.ConnectionString = ConnectionStringMain
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub dgvloader(ByVal sql As String, ByVal dgv As DataGridView)
        Try
            Call vbcon()
            Dim da As New MySqlDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub cmbLoader(ByVal sql As String, ByVal cmb As Windows.Forms.ComboBox, ByVal cmbID As String, ByVal cmbDisplay As String)
        Try
            Dim da As New MySqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            cmb.DataSource = dt
            cmb.ValueMember = cmbID
            cmb.DisplayMember = cmbDisplay
            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub cleaner(ByVal pnl As Panel)

        Dim obj As Object
        For Each obj In pnl.Controls
            If TypeOf obj Is TextBox Then
                obj.text = ""
            End If
            If TypeOf obj Is TextEdit Then
                obj.text = "0"

            End If
            If TypeOf obj Is user_control.textbox Then
                Dim txt As user_control.textbox = obj
                txt.Text = ""
                txt.Value = ""
                txt.RowData = Nothing
            End If
        Next

    End Sub
End Class
