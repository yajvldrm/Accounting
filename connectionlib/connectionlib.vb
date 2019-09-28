Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class connectionlib
    Public Shared vtxtIP As String
    Public Shared vcmbdb As String = "MySQL"
    Public Shared _serverDBFS As String
    Public Shared _serverDBMain As String
    Public Shared _serverUser As String
    Public Shared _serverPass As String
    Public Shared sqlcon As New SqlConnection
    Public Shared mysqlcon As New MySqlConnection

    Public Shared Function IsOpen()
        Dim conStr As String = "Server=" & vtxtIP & ";User Id=" & _serverUser & ";Password=" & _serverPass & ";Database=" & _serverDBMain & ";Convert Zero Datetime=True;Connect Timeout=32000"
        Dim returns As String
        Try
            If vcmbdb = "MySQL" Then
                mysqlcon.ConnectionString = conStr
                mysqlcon.Open()
                returns = mysqlcon.State()
                mysqlcon.Close()
                Return returns
            Else
                sqlcon.ConnectionString = conStr
                sqlcon.Open()
                returns = sqlcon.State()
                sqlcon.Close()
                Return returns
            End If
        Catch ex As Exception
            If vcmbdb = "MySQL" Then
                mysqlcon.Close()
            Else
                sqlcon.Close()
            End If
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function
    Public Shared Function dbConnected(ByVal db As String, Optional server As String = "", Optional user As String = "", Optional pass As String = "") As Boolean
        Dim conStr As String = ""
        If server <> "" Then
            conStr = "Server=" & server & ";User Id=" & user & ";Password=" & pass & ";Database=" & db & ";Connect Timeout=6000"
        Else
            conStr = "Server=" & vtxtIP & ";User Id=" & _serverUser & ";Password=" & _serverPass & ";Database=" & db & ";Connect Timeout=6000"
        End If
        Dim connected As Boolean = False
        'Dim returns As String
        Try
            If vcmbdb = "MySQL" Then
                mysqlcon.ConnectionString = conStr
                mysqlcon.Open()
                'returns = mysqlcon.State()
                connected = True
                mysqlcon.Close()
                'Return returns
            Else
                sqlcon.ConnectionString = conStr
                sqlcon.Open()
                connected = True
                'returns = sqlcon.State()
                sqlcon.Close()
                'Return returns
            End If
        Catch ex As Exception
            If vcmbdb = "MySQL" Then
                mysqlcon.Close()
            Else
                sqlcon.Close()
            End If
            MsgBox(ex.Message)
        End Try
        Return connected
    End Function
    Public Shared Function bakQuery(ByVal sql As String)
        Dim conStr As String = "Server=" & vtxtIP & ";User Id=" & _serverUser & ";Password=" & _serverPass & ";Database=" & _serverDBMain & ";Convert Zero Datetime=True;Connect Timeout=6000"
        Try
            If vcmbdb = "MsSQL" Then
                sqlcon.ConnectionString = conStr
                Dim cmd As New SqlCommand
                Dim reader As SqlDataReader
                Dim dt = New DataTable()
                cmd.CommandText = sql
                cmd.CommandType = CommandType.Text
                cmd.Connection = sqlcon

                sqlcon.Open()

                reader = cmd.ExecuteReader()
                ' Data is accessible through the DataReader object here.

                sqlcon.Close()
                SqlConnection.ClearAllPools()
                Return dt
            Else
                mysqlcon.ConnectionString = conStr
                mysqlcon.Open()

                Dim ds = New DataSet
                Dim cmd As New MySqlCommand
                Dim reader As MySqlDataReader
                Dim dt = New DataTable()
                cmd.CommandText = sql
                cmd.CommandType = CommandType.Text
                cmd.Connection = mysqlcon

                reader = cmd.ExecuteReader()
                ds.Tables.Add(dt)
                ds.EnforceConstraints = False
                dt.Load(reader)
                ' Data is accessible through the DataReader object here.

                mysqlcon.Close()
                MySqlConnection.ClearAllPools()
                Return dt
            End If
        Catch ex As Exception
            If vcmbdb = "MySQL" Then
                mysqlcon.Close()
            Else
                sqlcon.Close()
            End If
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function
    Public Shared Function Query(ByVal sql As String)
        Dim conStr As String = "Server=" & vtxtIP & ";User Id=" & _serverUser & ";Password=" & _serverPass & ";Database=" & _serverDBMain & ";Convert Zero Datetime=True;Connect Timeout=6000"
        Try
            If vcmbdb = "MsSQL" Then
                sqlcon.ConnectionString = conStr
                Dim cmd As New SqlCommand
                Dim reader As SqlDataReader
                Dim dt = New DataTable()
                cmd.CommandText = sql
                cmd.CommandType = CommandType.Text
                cmd.Connection = sqlcon

                sqlcon.Open()

                reader = cmd.ExecuteReader()
                ' Data is accessible through the DataReader object here.

                sqlcon.Close()
                SqlConnection.ClearAllPools()
                Return dt
            Else
                mysqlcon.ConnectionString = conStr
                mysqlcon.Open()

                Dim ds = New DataSet
                Dim cmd As New MySqlCommand
                Dim dt = New DataTable()
                cmd.CommandText = sql
                cmd.CommandType = CommandType.Text
                cmd.Connection = mysqlcon

                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                ' Data is accessible through the DataReader object here.

                mysqlcon.Close()
                MySqlConnection.ClearAllPools()
                Return dt
            End If
        Catch ex As Exception
            If vcmbdb = "MySQL" Then
                mysqlcon.Close()
            Else
                sqlcon.Close()
            End If
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function
    Public Shared Function FsQuery(ByVal sql As String)
        Dim conStr As String = "Server=" & vtxtIP & ";User Id=" & _serverUser & ";Password=" & _serverPass & ";Database=" & _serverDBFS & ";Convert Zero Datetime=True;Connect Timeout=6000"
        Try
            If vcmbdb = "MsSQL" Then
                sqlcon.ConnectionString = conStr
                sqlcon.Open()

                Dim cmd As New SqlCommand
                Dim reader As SqlDataReader
                Dim dt = New DataTable()
                cmd.CommandText = sql
                cmd.CommandType = CommandType.Text
                cmd.Connection = sqlcon
                reader = cmd.ExecuteReader()
                dt.Load(reader)
                ' Data is accessible through the DataReader object here.

                sqlcon.Close()
                Return dt
            Else
                mysqlcon.ConnectionString = conStr
                mysqlcon.Open()

                Dim ds = New DataSet
                Dim cmd As New MySqlCommand
                Dim dt = New DataTable()
                cmd.CommandText = sql
                cmd.CommandType = CommandType.Text
                cmd.Connection = mysqlcon

                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                ' Data is accessible through the DataReader object here.

                mysqlcon.Close()

                Return dt
            End If
        Catch ex As Exception
            If vcmbdb = "MySQL" Then
                mysqlcon.Close()
            Else
                sqlcon.Close()
            End If
            msgbox(ex.message)
        End Try
        Return ""
    End Function

    Public Shared Function PayQuery(ByVal sql As String)
        Dim conStr As String = "Server=" & vtxtIP & ";User Id=" & _serverUser & ";Password=" & _serverPass & ";Database=" & _serverDBMain & ";Convert Zero Datetime=True;Connect Timeout=6000"
        Try
            If vcmbdb = "MsSQL" Then
                sqlcon.ConnectionString = conStr
                sqlcon.Open()

                Dim cmd As New SqlCommand
                Dim reader As SqlDataReader
                Dim dt = New DataTable()
                cmd.CommandText = sql
                cmd.CommandType = CommandType.Text
                cmd.Connection = sqlcon
                reader = cmd.ExecuteReader()
                dt.Load(reader)
                ' Data is accessible through the DataReader object here.

                sqlcon.Close()
                SqlConnection.ClearAllPools()
                Return dt
            Else
                mysqlcon.ConnectionString = conStr
                mysqlcon.Open()

                Dim ds = New DataSet
                Dim cmd As New MySqlCommand
                Dim reader As MySqlDataReader
                Dim dt = New DataTable()
                cmd.CommandText = sql
                cmd.CommandType = CommandType.Text
                cmd.Connection = mysqlcon

                reader = cmd.ExecuteReader()
                ds.Tables.Add(dt)
                ds.EnforceConstraints = False
                dt.Load(reader)
                ' Data is accessible through the DataReader object here.

                mysqlcon.Close()
                MySqlConnection.ClearAllPools()
                Return dt
            End If
        Catch ex As Exception
            If vcmbdb = "MySQL" Then
                mysqlcon.Close()
            Else
                sqlcon.Close()
            End If
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

    Public Shared Sub RefreshFs(ByVal obj As Object, ByVal sql As String)
        Dim data As DataTable = FsQuery(sql)
        If Not data Is Nothing Then
            obj.AutoGenerateColumns = False
            obj.datasource = data
        End If
    End Sub

    Public Shared Sub clearDataTable(ByVal obj As Object)

        Dim cols = obj.columns()
        Dim counter As Integer = obj.columns.count
        Dim count As Integer = 0
        Dim dict As New Dictionary(Of String, String)

        For i As Integer = 0 To counter - 1
            Try
                dict.Add(cols(i).headertext, cols(i).visible)
            Catch ex As Exception
                MsgBox(cols(i).headertext & " name:" & cols(i).name)
            End Try
        Next

        obj.datasource = Nothing
        obj.ColumnCount = counter
        obj.ColumnHeadersVisible = True

        For Each item In dict
            obj.columns(count).headertext = item.Key
            obj.columns(count).visible = item.Value
            count += 1
        Next

    End Sub

    Public Shared Function genInsert(ByVal table As String, ByVal array As Dictionary(Of String, String))
        Dim qry As String = ""
        Dim field As String = ""
        Dim isId As Boolean = True
        For Each items In array
            If isId = False Then
                If items.Value Is Nothing Then
                    qry &= ",default"
                    field &= "," & items.Key
                Else
                    qry &= ",'" & If(items.Value.Contains("'"), items.Value.Replace("'", "\'"), items.Value) & "'"
                    field &= "," & items.Key
                End If
            End If
            isId = False
        Next
        Return "INSERT INTO " & table & "(" & field.Substring(1) & ") VALUES (" & qry.Substring(1) & ")"
    End Function

    Public Shared Function genUpdate(ByVal table As String, ByVal array As Dictionary(Of String, String))
        'Dim s As String = String.Join(".", array)
        'MsgBox(s)
        Dim qry As String = ""
        Dim isId As Boolean = True
        For Each items In array
            If isId = False Then
                If items.Value Is Nothing Then
                    qry &= "," & items.Key & "=default"
                Else
                    qry &= "," & items.Key & "='" & If(items.Value.Contains("'"), items.Value.Replace("'", "\'"), items.Value) & "'"
                End If
            End If
            isId = False
        Next
        Return "UPDATE " & table & " SET " & qry.Substring(1) & " WHERE " & array.Keys.First & "=" & array.Values.First
    End Function

    Public Shared Sub genDelete(table As String, field As String, list As List(Of String))
        For Each item In list
            FsQuery("delete from " & table & " where " & field & "='" & item.ToString & "'")
        Next
    End Sub
End Class
