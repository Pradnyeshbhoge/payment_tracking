Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim frm As New Form2
        frm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frm As New Form2
        frm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim frm As New Form3
        frm.Show()


    End Sub
End Class