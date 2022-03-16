Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 + num2

        MessageBox.Show(sum)


    End Sub

    Private Sub Subtract_Click(sender As Object, e As EventArgs) Handles Subtract.Click

        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 - num2

        MessageBox.Show(sum)

    End Sub

    Private Sub Devide_Click(sender As Object, e As EventArgs) Handles Devide.Click

        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 / num2

        MessageBox.Show(sum)

    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click

        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 * num2

        MessageBox.Show(sum)

    End Sub
End Class
