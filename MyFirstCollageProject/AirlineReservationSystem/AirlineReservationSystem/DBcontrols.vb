﻿
Imports System.Data.OleDb

Public Class DBControls
    ' CREATE YOUR DB CONNECTION
    Public DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=.\Flight1.accdb;")

    ' PREPARE DB COMMAND
    Private DBCmd As OleDbCommand

    ' DB DATA
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable


    ' QUERY PARAMETERS
    Public Params As New List(Of OleDbParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(ByVal Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            ' OPEN A CONNECTION
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New OleDbCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAMS LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATATABLE
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' CLOSE YOUR CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

    ' INCLUDE QUERY & COMMAND PARAMETERS
    Public Sub AddParam(ByVal Name As String, ByVal Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

End Class
