Public Class Form2

    Private thedatatable As New DataTable
    Private workDirectory = My.Computer.FileSystem.CurrentDirectory
    Private rw As System.IO.StreamReader
    Private fileContents As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With thedatatable
            .Columns.Add("Service", System.Type.GetType("System.String"))
            .Columns.Add("Last Changed", System.Type.GetType("System.String"))
            .Columns.Add("Password", System.Type.GetType("System.String"))
        End With

        Dim FileName As String = System.IO.Path.Combine(workDirectory, "pass.txt")
        For Each line As String In System.IO.File.ReadLines(FileName)
            Dim values() As String = line.Split(",".ToCharArray)
            If values.Length >= 3 Then
                Dim newrow As DataRow = thedatatable.NewRow
                newrow("Service") = values(0)
                newrow("Last Changed") = values(1)
                newrow("Password") = values(2)
                thedatatable.Rows.Add(newrow)
            End If
        Next

        DataGridView1.DataSource = thedatatable

    End Sub

    Private Sub newAdd_Click(sender As Object, e As EventArgs) Handles newAdd.Click

        Dim frm3 As New Form3
        frm3.Show()

    End Sub

    Private Sub newChange_Click(sender As Object, e As EventArgs) Handles newChange.Click

    End Sub

    Private Sub newRemove_Click(sender As Object, e As EventArgs) Handles newRemove.Click

    End Sub
End Class
