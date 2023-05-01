Imports MySql.Data.MySqlClient

Module database

    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable


    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost; username=root; password =; database=ltrs;")
    End Function



    Public Sub create(ByVal sql As String)  'insert data into database
        Try
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery    'data executed
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reloaData(ByVal sql As String, ByVal dtg As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dtg.datasource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery    'data executed
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery    'data executed
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reloadData(ByVal sql As String)  'insert data into database
        Try
            strcon.Open()
            With cmd                            'call data
                .Connection = strcon
                .CommandText = sql

            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, strcon)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message & "reload text")
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
                da.Dispose()
            End If
        End Try
    End Sub
End Module
