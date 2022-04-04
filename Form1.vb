Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Dim f2 As New Form2()
        f2.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        For Each Form In My.Application.OpenForms
            Form.Close()
        Next
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim Message As String
        Message = "MUHAMMAD LUKMAN NURHAKIM, 10DDT20F1039, JTMK"
        MessageBox.Show(Message, "Verification ")
    End Sub
End Class
