Public Class Form1
    Private cstrOperator As String = "+" 'hold the operation we're performing' 
    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        cstrOperator = "+"
        lblOperator.Text = cstrOperator
    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        cstrOperator = "-"
        lblOperator.Text = cstrOperator
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        cstrOperator = "*"
        lblOperator.Text = cstrOperator
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        cstrOperator = "/"
        lblOperator.Text = cstrOperator
    End Sub

    Private Sub BtnEqaul_Click(sender As Object, e As EventArgs) Handles btnEqaul.Click
        Dim ldblNum1 As Double
        Dim ldblNum2 As Double
        Dim ldblAnswer As Double

        Try
            ldblNum1 = CDec(txtNum1.Text) 'converts the text to a decimal 
            ldblNum2 = CDec(txtNum2.Text)
        Catch ex As Exception
            MessageBox.Show("You must enter numbers into the text boxes!")
            Exit Sub
        End Try

        If cstrOperator = "+" Then
            ldblAnswer = ldblNum1 + ldblNum2

        ElseIf cstrOperator = "-" Then
            ldblAnswer = ldblNum1 - ldblNum2

        ElseIf cstrOperator = "*" Then
            ldblAnswer = ldblNum1 * ldblNum2

        Else
            ldblAnswer = ldblNum1 / ldblNum2
        End If
        lblAnswer.Text = CStr(ldblAnswer) 'displaying the results"

    End Sub

    Private Sub TxtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged

    End Sub

    Private Sub txtNum1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum1.KeyPress
        If e.KeyChar = "+" Then
            cstrOperator = "+"
            lblOperator.Text = cstrOperator
            e.Handled = True 'we handeld the key press, computer you don't need to anything with it 
            txtNum2.Focus() 'puts txt num into text box
        End If

        If e.KeyChar = "-" Then
            cstrOperator = "-"
            lblOperator.Text = cstrOperator
            e.Handled = True 'we handeld the key press, computer you don't need to anything with it 
            txtNum2.Focus() 'puts txt num into text box
        End If

        If e.KeyChar = "*" Then
            cstrOperator = "*"
            lblOperator.Text = cstrOperator
            e.Handled = True 'we handeld the key press, computer you don't need to anything with it 
            txtNum2.Focus() 'puts txt num into text box
        End If

        If e.KeyChar = "/" Then
            cstrOperator = "/"
            lblOperator.Text = cstrOperator
            e.Handled = True 'we handeld the key press, computer you don't need to anything with it 
            txtNum2.Focus() 'puts txt num into text box
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtNum1.Focus() 'put the cursor in the txt num1 text box when the program starts
    End Sub
End Class
