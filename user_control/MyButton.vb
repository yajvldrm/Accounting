Public Class MyButton
#Region "Variable Declaration"
    Private _ButtonType As MyList.ButtonType = MyList.ButtonType.ButtonAdd
#End Region
#Region "Property Declaration"
    Public Property ButtonType() As MyList.ButtonType
        Get
            Return _ButtonType
        End Get
        Set(value As MyList.ButtonType)
            _ButtonType = value
            If value = MyList.ButtonType.ButtonSave Or value = MyList.ButtonType.ButtonOK Then
                Me.BackColor = Drawing.Color.Green
                Me.FlatAppearance.MouseDownBackColor = Drawing.Color.Lime
                Me.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(0, 192, 0)
                If value = MyList.ButtonType.ButtonSave Then
                    Me.Text = "&Save"
                Else
                    Me.Text = "&OK"
                End If
            ElseIf value = MyList.ButtonType.ButtonNotSave Or value = MyList.ButtonType.ButtonCancel Then
                Me.BackColor = Drawing.Color.Maroon
                Me.FlatAppearance.MouseDownBackColor = Drawing.Color.Red
                Me.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(192, 0, 0)
                If value = MyList.ButtonType.ButtonNotSave Then
                    Me.Text = "&Cancel"
                Else
                    Me.Text = "Ca&ncel"
                End If
            Else
                Me.BackColor = Drawing.Color.FromArgb(50, 50, 50)
                Me.FlatAppearance.MouseDownBackColor = Drawing.Color.Silver
                Me.FlatAppearance.MouseOverBackColor = Drawing.Color.Gray
                Select Case value
                    Case MyList.ButtonType.ButtonAdd
                        Me.Text = "F2 Add"
                    Case MyList.ButtonType.ButtonEdit
                        Me.Text = "F3 Edit"
                    Case MyList.ButtonType.ButtonDelete
                        Me.Text = "F4 Delete"
                    Case MyList.ButtonType.ButtonInsert
                        Me.Text = "&Insert"
                    Case MyList.ButtonType.ButtonUpdate
                        Me.Text = "&Update"
                    Case MyList.ButtonType.ButtonRemove
                        Me.Text = "&Remove"
                End Select
            End If
        End Set
    End Property
#End Region
End Class
