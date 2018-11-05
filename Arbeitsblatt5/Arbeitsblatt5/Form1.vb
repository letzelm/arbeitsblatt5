Public Class Form1
    Dim input() As String = {"Frankfurt Hbf (10)",
                "Frankfurt Niederrad(11)",
                "Frankfurt Süd(12)",
                "Gustavsburg (103)",
                "Mainz-Kastel (33)",
                "Mainz-Nord (32)",
                "Mainz Hbf(30)",
                "Mainz Römisches Theater (31)",
                "Offenbach Hbf(20)",
                "Wiesbaden Hbf(40)",
                "Rüsselsheim (101)",
                "Bischofsheim (102)",
                "10 Frankfurt Hbf",
                "11 Frankfurt Niederrad",
                "12 Frankfurt Süd",
                "103 Gustavsburg",
                "33 Mainz-Kastel",
                "32 Mainz-Nord",
                "30 Mainz Hbf",
                "31 Mainz Römisches Theater",
                "20 Offenbach Hbf",
                "40 Wiesbaden Hbf",
                "101 Rüsselsheim",
                "102 Bischofsheim",
    }
    Private alldest As List(Of String) = New List(Of String)(input)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub alleziele_SelectedIndexChanged(sender As Object, e As EventArgs) Handles alleziele.SelectedIndexChanged
        ortcode.Text = alleziele.text
    End Sub

    Private Sub ortcode_TextChanged(sender As Object, e As EventArgs) Handles ortcode.TextChanged
        alleziele.Text = ortcode.Text

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
