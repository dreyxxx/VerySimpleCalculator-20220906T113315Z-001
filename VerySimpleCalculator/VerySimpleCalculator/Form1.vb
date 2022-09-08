Public Class Form1

    Dim firstNum, secondNum, sum, product, quotient As Double

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        '****RAMOS*****  
        firstNum = txtBox1.Text
        secondNum = txtBox2.Text
        product = firstNum * secondNum
        MsgBox("The product of " & firstNum & " and " & secondNum & " is " & product)

        lblResult.Text = lblResult.Text & " " & product
        lblResult.Text = "The product is " & product

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        MessageBox.Show("The sum of 2 and 3 is 5.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDifference.Click


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnQuotient.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblResult.Click
        

    End Sub
End Class
