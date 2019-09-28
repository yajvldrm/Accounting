Imports System.Windows.Forms
Imports libacctng.myFunctions
Imports connectionlib.connectionlib
Public Class connectionsettings
    Private module_code As String = "ACC00908"

    Private Sub connectionsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If enableUnitNo.Checked = True Then
            If enableBookUnit.Checked = True And enableProjectUnit.Checked = True Then
                enableBookUnit.Checked = True
            Else
                enableBookUnit.Checked = False
            End If
        End If
        txt_server.Text = My.Settings._serverIP
        txt_file_setup.Text = My.Settings._serverDBFS
        txt_main.Text = My.Settings._serverDBMain
        txt_username.Text = My.Settings._serverUser
        txt_password.Text = My.Settings._serverPass
        txt_port.Text = My.Settings._serverPort
        mysqlError.Checked = My.Settings.mysqlError
        enableUnitNo.Checked = My.Settings._enableUnitNo
        withPM.Checked = My.Settings._withPM
        enableBookUnit.Checked = My.Settings._enableBookUnit
        enableProjectUnit.Checked = CBool(My.Settings._enableProjectUnit)
    End Sub

    Private Sub btnNotSave_Click(sender As Object, e As EventArgs) Handles btnNotSave.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not dbConnected(txt_file_setup.Text, txt_server.Text, txt_username.Text, txt_password.Text, txt_port.Text) Then
            MsgBox("Unable to Connect to Main Database.")
            Exit Sub
        End If
        If Not dbConnected(txt_main.Text, txt_server.Text, txt_username.Text, txt_password.Text, txt_port.Text) Then
            MsgBox("Unable to Connect to FS Database.")
            Exit Sub
        End If
        With My.MySettings.Default
            ._serverIP = txt_server.Text
            ._serverDBFS = txt_file_setup.Text
            ._serverDBMain = txt_main.Text
            ._serverUser = txt_username.Text
            ._serverPass = txt_password.Text
            ._serverPort = txt_port.Text
            .mysqlError = mysqlError.Checked
            ._enableUnitNo = enableUnitNo.Checked
            ._withPM = withPM.Checked

            ._enableBookUnit = enableBookUnit.Checked
            ._enableProjectUnit = enableProjectUnit.Checked

            .Save()
        End With
        MsgBox("Connection Save.")
        main.main_Load(Nothing, Nothing)
        Me.Close()
    End Sub

    Private Sub enableUnitNo_CheckedChanged(sender As Object, e As EventArgs) Handles enableUnitNo.CheckedChanged
        If enableUnitNo.Checked Then
            enableBookUnit.Enabled = True
            enableProjectUnit.Enabled = True
            enableBookUnit.Checked = My.Settings._enableBookUnit
            enableProjectUnit.Checked = My.Settings._enableProjectUnit
        Else
            enableBookUnit.Enabled = False
            enableBookUnit.Checked = False
            enableProjectUnit.Enabled = False
            enableProjectUnit.Checked = False
        End If
    End Sub
End Class