Imports System.Data
Imports System.Data.SqlClient

Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pradnyesh bhoge\Documents\entry.mdf;Integrated Security=True;Connect Timeout=30")

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As New SqlCommand("INSERT INTO entry (id, name, department, acno, ifsc, status) VALUES (@id, @name, @department, @acno, @ifsc, @status)", connection)

            command.Parameters.AddWithValue("@id", TextBox1.Text)
            command.Parameters.AddWithValue("@name", TextBox5.Text)
            command.Parameters.AddWithValue("@department", ComboBox1.SelectedItem.ToString())
            command.Parameters.AddWithValue("@acno", TextBox3.Text)
            command.Parameters.AddWithValue("@ifsc", TextBox2.Text)
            command.Parameters.AddWithValue("@status", ComboBox2.SelectedItem.ToString())

            command.ExecuteNonQuery()
            MessageBox.Show("entry is sucesfull")
        End Using


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)

    End Sub
End Class