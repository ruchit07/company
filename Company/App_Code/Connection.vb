Imports System.Data.SqlClient
Imports System.Configuration
Public Class Connection

    Public DBConn As SqlConnection
    Public DBCommand As SqlCommand

    Dim DSPageData As New DataSet

    Public Sub SetConnection()
        Dim strConnectionString = ConfigurationManager.AppSettings("ConnectionString")
        DBConn = New SqlConnection(strConnectionString)
        'DBConn = New SqlConnection("Server=db718187879.db.1and1.com;Database=db718187879;uid=dbo718187879;pwd=Rest.2018; Trusted_Connection=False")
        DBCommand = New SqlCommand("select * from jillo")

        DBConn.Open()
        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter("select * from jillo", DBConn)

        Dim dsResult As New DataSet("Result")


        ' Fill data into dataset

        da.Fill(ds)
        DBConn.Close()

        'Return ds

    End Sub
End Class
