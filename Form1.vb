Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("The sum is =" & Val(TextBox1.Text) + Val(TextBox2.Text))
    End Sub

    Private Sub btnsubtract_Click(sender As Object, e As EventArgs) Handles btnsubtract.Click
        MsgBox("The subtraction is =" & Val(TextBox1.Text) - Val(TextBox2.Text))
    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        MsgBox("The multiplication is =" & Val(TextBox1.Text) * Val(TextBox2.Text))
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        MsgBox("The division is =" & Val(TextBox1.Text) / Val(TextBox2.Text))
    End Sub
End Class
