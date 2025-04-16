Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports Microsoft.SqlServer.Management.Smo


Public Class SQLBackupHandler

    Public Async Function LoadServer() As Task(Of DataTable)

        Dim dtServers As New DataTable


        Try
            'True gives a list of local available instances of SQL Server, instances on other computers not wanted

            dtServers = Await Task(Of DataTable).Run(Function() SqlDataSourceEnumerator.Instance.GetDataSources())


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try


        Return dtServers

    End Function
    Public Function LoadDatabases() As List(Of String)
        Dim DatabaseList As New List(Of String)
        Try
            Dim sqlConn As SqlConnection = New SqlConnection(DBManger.DataSource)
        sqlConn.Open()
        Dim tblDatabases As DataTable = sqlConn.GetSchema("Databases")
        sqlConn.Close()

        DatabaseList.AddRange(tblDatabases.AsEnumerable().Select(Function(r) r("database_name").ToString()).ToArray())

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return DatabaseList
    End Function

    Public Function LoadDatabases(ByVal ServerName As String) As List(Of String)

        Dim DatabaseList As New List(Of String)
        Try

            Dim server As New Server(ServerName)


            For Each database As Database In server.Databases
                DatabaseList.Add(database.Name)
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return DatabaseList

    End Function


End Class
