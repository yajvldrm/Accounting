Imports System.ComponentModel

<Serializable> <TypeConverter(GetType(String))>
Public Class MyTextBoxList
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Control As String
    Public Sub New()
        Control = ""
    End Sub

    Public Sub New(c As String)
        Control = c
    End Sub

    Public Overrides Function ToString() As String
        Return Control
    End Function
End Class
