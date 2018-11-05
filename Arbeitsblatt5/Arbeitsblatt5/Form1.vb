Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub alleziele_SelectedIndexChanged(sender As Object, e As EventArgs) Handles alleziele.SelectedIndexChanged
        ortcode.Text = alleziele.Text
    End Sub

    Private Sub ortcode_TextChanged(sender As Object, e As EventArgs) Handles ortcode.TextChanged
        alleziele.Text = ortcode.Text
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
