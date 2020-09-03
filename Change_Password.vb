Public Class Form4

    Private check As Boolean
    Private workDirectory = My.Computer.FileSystem.CurrentDirectory
    Private rw As System.IO.StreamReader

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub srchService_Click(sender As Object, e As EventArgs) Handles srchService.Click

        Dim FileName As String = System.IO.Path.Combine(workDirectory, "pass.txt")
        For Each line As String In System.IO.File.ReadLines(FileName)
            Dim values() As String = line.Split(",".ToCharArray)
        Next
        rw = My.Computer.FileSystem.OpenTextFileReader(workDirectory)
        fileContents = rw.ReadToEnd()
        splitData = fileContents.Split(New Char() {","c})

    End Sub

    Private Sub serviceName_TextChanged(sender As Object, e As EventArgs) Handles serviceName.TextChanged

    End Sub

    Private Sub passOld_TextChanged(sender As Object, e As EventArgs) Handles passOld.TextChanged

    End Sub

    Private Sub passNew1_TextChanged(sender As Object, e As EventArgs) Handles passNew1.TextChanged

        If passNew1.Text <> passNew2.Text Then
            passMatch.Text = "Passwords Do Not Match"
            passMatch.ForeColor = Color.Red
            passMatch.Visible = True
            check = False
        End If
        If passNew1.Text = passNew2.Text Then
            passMatch.Text = "Passwords Match"
            passMatch.ForeColor = Color.Green
            check = True
        End If

    End Sub

    Private Sub passNew2_TextChanged(sender As Object, e As EventArgs) Handles passNew2.TextChanged

        If passNew1.Text <> passNew2.Text Then
            passMatch.Text = "Passwords Do Not Match"
            passMatch.ForeColor = Color.Red
            passMatch.Visible = True
            check = False
        End If
        If passNew1.Text = passNew2.Text Then
            passMatch.Text = "Passwords Match"
            passMatch.ForeColor = Color.Green
            check = True
        End If

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub passMatch_Click(sender As Object, e As EventArgs) Handles passMatch.Click

    End Sub

End Class
