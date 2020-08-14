Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        REM changes box password type to hide text
        TextBox1.PasswordChar = "*"
        REM Align the text in the center of the TextBox control.
        TextBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        success.Visible = False
        success.Text = "Incorrect Login"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "0530" Then
            success.Visible = True
        Else
            Me.Hide()
            Dim frm2 As New Form2
            frm2.Show()
        End If

    End Sub

End Class
