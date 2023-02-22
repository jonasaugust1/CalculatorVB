Public Class Form1
    Private Sub ButtonOpDiv_Click(sender As Object, e As EventArgs) Handles ButtonOpDiv.Click
        'CStr convert a number or an object to a string
        TextBoxResult.Text = CStr(Divide(CDec(TextBoxNumber1.Text), CDec(TextBoxNumber2.Text)))
    End Sub

    Private Sub ButtonOpMult_Click(sender As Object, e As EventArgs) Handles ButtonOpMult.Click
        TextBoxResult.Text = CStr(Multiply(CDec(TextBoxNumber1.Text), CDec(TextBoxNumber2.Text)))
    End Sub

    Private Sub ButtonOpSub_Click(sender As Object, e As EventArgs) Handles ButtonOpSub.Click
        TextBoxResult.Text = CStr(Subtract(CDec(TextBoxNumber1.Text), CDec(TextBoxNumber2.Text)))
    End Sub

    Private Sub ButtonOpSum_Click(sender As Object, e As EventArgs) Handles ButtonOpSum.Click
        TextBoxResult.Text = CStr(Sum(CDec(TextBoxNumber1.Text), CDec(TextBoxNumber2.Text)))
    End Sub

    Private Sub ButtonOpExp_Click(sender As Object, e As EventArgs) Handles ButtonOpExp.Click
        TextBoxResult.Text = CStr(Exponencial(CDec(TextBoxNumber1.Text), CDec(TextBoxNumber2.Text)))
    End Sub

    Private Sub ButtonOpFactorial_Click(sender As Object, e As EventArgs) Handles ButtonOpFactorial.Click
        TextBoxResult.Text = CStr(Factorial(CDec(TextBoxNumber1.Text)))
    End Sub

    'Operations
    Function Divide(ByVal number1 As Decimal, ByVal number2 As Decimal) As Decimal
        Return number1 / number2
    End Function

    Function Multiply(ByVal number1 As Decimal, ByVal number2 As Decimal) As Decimal
        Return number1 * number2
    End Function

    Function Subtract(ByVal number1 As Decimal, ByVal number2 As Decimal) As Decimal
        Return number1 - number2
    End Function

    Function Sum(ByVal number1 As Decimal, ByVal number2 As Decimal) As Decimal
        Return number1 + number2
    End Function

    Function Exponencial(ByVal number1 As Decimal, ByVal number2 As Decimal) As Decimal
        Return number1 ^ number2
    End Function

    Function Factorial(ByVal number1 As Decimal) As Decimal
        Dim result As Decimal = 1

        For number1 = number1 To 1 Step -1
            result *= number1
        Next

        Return result
    End Function
End Class
