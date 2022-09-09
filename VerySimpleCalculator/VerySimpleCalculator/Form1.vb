Public Class Form1

    Dim firstNum, secondNum, sum, difference, product, quotient As Double 'naka provide na variable guys eto lang gamitin sa codes nyo


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        '***Erwin***
        firstNum = txtBox1.Text
        secondNum = txtBox2.Text
        sum = firstNum + secondNum
        MsgBox("The sum of " & firstNum & " and " & secondNum & " is " & sum)

        lblResult.Text = lblResult.Text & " " & sum
        lblResult.Text = "The sum is " & sum

    End Sub



    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        '****RAMOS*****  
        firstNum = txtBox1.Text
        secondNum = txtBox2.Text
        product = firstNum * secondNum
        MsgBox("The product of " & firstNum & " and " & secondNum & " is " & product)

        lblResult.Text = lblResult.Text & " " & product
        lblResult.Text = "The product is " & product

    End Sub


    Private Sub btnDifference_Click(sender As Object, e As EventArgs) Handles btnDifference.Click
        '****OCARES****
        firstNum = txtBox1.Text
        secondNum = txtBox2.Text
        difference = firstNum - secondNum
        MsgBox("The difference of " & firstNum & " and " & secondNum & " is " & product)

        lblResult.Text = lblResult.Text & " " & difference
        lblResult.Text = "The difference is " & difference
    End Sub

    Private Sub btnQuotient_Click(sender As Object, e As EventArgs) Handles btnQuotient.Click
        firstNum = txtBox1.Text
        secondNum = txtBox2.Text
        quotient = firstNum / secondNum
        MessageBox.Show(" The quotient of " & firstNum & " and " & secondNum & " is " & quotient & ".")
        lblResult.Text = " The quotient is " & quotient & "."

    End Sub


End Class
