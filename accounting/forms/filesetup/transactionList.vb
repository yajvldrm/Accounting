Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class transactionList

    Private _frm As Form
    Public Property frm() As Form
        Get
            Return _frm
        End Get
        Set(value As Form)
            _frm = value
        End Set
    End Property
    Public Property mainform As Form = main

End Class