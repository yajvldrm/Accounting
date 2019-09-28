Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions

Public Class frmBook

    Private _pkName As String = "book_id"
    Private _pkID As String = 0
    Private _mainList As form
    Private _transMode As String

    Public Property pkName() As String
        Get
            Return _pkName
        End Get
        Set(value As String)
            _pkName = value
        End Set
    End Property
    Public Property pkID() As String
        Get
            Return _pkID
        End Get
        Set(value As String)
            _pkID = value
        End Set
    End Property
    Public Property mainList() As Form
        Get
            Return _mainList
        End Get
        Set(value As Form)
            _mainList = value
        End Set
    End Property
    Public Property transmode() As String
        Get
            Return _transMode
        End Get
        Set(value As String)
            _transMode = value
        End Set
    End Property

    Public Property colhdr As String = "Code,Name"
    Public Property colfld As String = "book_code,book_name"
    Public Property dbName As String = _serverDBFS
    Public Property tblName As String = "lib_erp_book"

    Private Sub frmBook_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
        loadTransactionList(mainList, dbName, tblName, pkName, colhdr, colfld, mainList.Controls.Find("dglist", True)(0))
        mainList.Show()
    End Sub

End Class