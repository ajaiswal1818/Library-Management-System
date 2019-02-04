Imports System.Data.OleDb

Public Class LMS
    'Create a connection
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                         "Data Source=Library Management System.accdb;")

    'Prepare DB Command
    Private DBCmd As OleDbCommand

    'DB DATA
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    'Manage Query Paramters  --> Handling errors /SQL attacks
    Public Params As New List(Of OleDbParameter)

    'Query Statistics
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        'Reset query statistics
        RecordCount = 0
        Exception = ""

        Try
            'Open a connection
            DBCon.Open()

            'Create a database command
            DBCmd = New OleDbCommand(Query, DBCon)

            'Load  params into DB Command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Clear params list
            Params.Clear()

            'Execute command and fill dataset
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try


        'Close database conneection
        If DBCon.State = ConnectionState.Open Then DBCon.Close()

    End Sub

    'Include query and command parameters
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

End Class
