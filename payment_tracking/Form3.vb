Imports System.Data
Imports System.Data.SqlClient
Public Class Form3
    Private Sub NewentryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NewentryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NewentryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.newentry' table. You can move, or remove it, as needed.
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pradnyesh bhoge\Documents\entry.mdf;Integrated Security=True;Connect Timeout=30"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As New SqlCommand("SELECT * FROM entry", connection)

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using


    End Sub

    Private Sub NewentryDataGridView_CellContentClick(sender As Object, e As Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub NewentryBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles NewentryBindingNavigator.RefreshItems

    End Sub
End Class