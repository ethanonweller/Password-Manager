Public Class Form3
    Dim wr As System.IO.StreamWriter
    Dim check As Boolean
    Private workDirectory = My.Computer.FileSystem.CurrentDirectory
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passMatch.Visible = False
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If check = True Then
            Dim FileName As String = System.IO.Path.Combine(workDirectory, "pass.txt")      REM appends working directory string data with pass.txt where all data is r/w from
            Dim dt As Date = Today              REM gets current date
            wr = My.Computer.FileSystem.OpenTextFileWriter(workDirectory, True)     REM checks if file is there and in the correct location
            wr.WriteLine(serviceText.Text & "," & dt & "," & passText1.Text & ",")        REM writes service name, current date and password to file split by commas
            wr.Close()          REM closes file
        Else
            MsgBox("Cannot save, passwords do not match")
        End If

    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click
        serviceText.Text = ""
        passText1.Text = ""
        passText2.Text = ""
        passMatch.Visible = False
    End Sub

    Private Sub passText2_TextChanged(sender As Object, e As EventArgs) Handles passText2.TextChanged

        If passText1.Text <> passText2.Text Then
            passMatch.Text = "Passwords Do Not Match"
            passMatch.ForeColor = Color.Red
            passMatch.Visible = True
            check = False
        End If
        If passText1.Text = passText2.Text Then
            passMatch.Text = "Passwords Match"
            passMatch.ForeColor = Color.Green
            check = True
        End If

    End Sub

    Private Sub passText1_TextChanged(sender As Object, e As EventArgs) Handles passText1.TextChanged

        If passText1.Text <> passText2.Text Then
            passMatch.Text = "Passwords Do Not Match"
            passMatch.ForeColor = Color.Red
            passMatch.Visible = True
            check = False
        End If
        If passText1.Text = passText2.Text Then
            passMatch.Text = "Passwords Match"
            passMatch.ForeColor = Color.Green
            check = True
        End If

    End Sub
End Class
