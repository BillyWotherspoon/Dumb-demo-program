Public Class Form1

    'Simple Calculator with advanced functions  
    'created on 16/03/2022
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'clear all Values from boxes
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'declare variables

        Dim num1 As Single
        Dim num2 As Single
        Dim sum As Single

        'get user input
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        'Perform operation
        sum = num1 + num2

        TextBox3.Text = sum
        ListBox1.Items.Add(sum)

    End Sub

    Private Sub Subtract_Click(sender As Object, e As EventArgs) Handles Subtract.Click

        Dim num1 As Single
        Dim num2 As Single
        Dim sum As Single

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 - num2
        ListBox1.Items.Add(sum)
        TextBox3.Text = sum
    End Sub

    Private Sub Devide_Click(sender As Object, e As EventArgs) Handles Devide.Click

        Dim num1 As Single
        Dim num2 As Single
        Dim sum As Single

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 / num2

        TextBox3.Text = sum
        ListBox1.Items.Add(sum)
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click

        Dim num1 As Single
        Dim num2 As Single
        Dim sum As Single

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 * num2

        TextBox3.Text = sum
        ListBox1.Items.Add(sum)
    End Sub

    Private Sub exponentiate_Click(sender As Object, e As EventArgs) Handles exponentiate.Click
        Dim num1 As Single
        Dim num2 As Single
        Dim sum As Single


        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 ^ num2

        TextBox3.Text = sum
        ListBox1.Items.Add(sum)
    End Sub

    Private Sub Modulus_Click(sender As Object, e As EventArgs) Handles Modulus.Click

        Dim num1 As Single
        Dim num2 As Single
        Dim sum As Single


        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 Mod num2

        TextBox3.Text = sum
        ListBox1.Items.Add(sum)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub
End Class
