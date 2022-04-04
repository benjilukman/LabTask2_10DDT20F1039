Public Class Form3



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f1 As New Form1()
        f1.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = txt1.Text
        num2 = txt2.Text
        sum = num1 + num2
        txt3.Text = sum





    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, num1.TextChanged, txt1.TextChanged

    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged

    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = txt1.Text
        num2 = txt2.Text
        sum = num1 - num2
        txt3.Text = sum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = txt1.Text
        num2 = txt2.Text
        sum = num1 * num2
        txt3.Text = sum
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = txt1.Text
        num2 = txt2.Text
        sum = num1 / num2
        txt3.Text = sum
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each Form In My.Application.OpenForms
            Form.Close()
        Next
    End Sub
End Class