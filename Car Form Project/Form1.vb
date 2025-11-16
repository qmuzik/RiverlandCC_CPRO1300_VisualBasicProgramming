Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the combo box
        cboPaymentOptions.Items.Add("Cash")
        cboPaymentOptions.Items.Add("Leasing")
        cboPaymentOptions.Items.Add("Financing")
    End Sub

    Private Sub btnConfirmOrder_Click(sender As Object, e As EventArgs) Handles btnConfirmOrder.Click
        Dim pstrOrder As String
        If chkUser.Checked Then
            pstrOrder = "Welcome " & txtName.Text & ","
        Else
            pstrOrder = "Welcome Back " & txtName.Text & ","
        End If

        'Displays color choice in list box
        pstrOrder &= " you have selected a " & lstColor.SelectedItem & " car "

        'Which engine is selected
        Select Case True
            Case rad24.Checked
                pstrOrder = pstrOrder & "with a 2.4L engine"
            Case rad35.Checked
                pstrOrder = pstrOrder & "with a 3.5L engine"
            Case rad38.Checked
                pstrOrder = pstrOrder & "with a 3.8L engine"
        End Select

        'Which Additonal options are selected
        If chkCD.Checked Then
            pstrOrder &= ", CD Player"
        End If
        If chkAC.Checked Then
            pstrOrder &= ", Air Conditioning"
        End If
        If chkBrakes.Checked Then
            pstrOrder &= ", Anti-Lock Brakes"
        End If
        If chkSideBags.Checked Then
            pstrOrder &= ", Side Air-Bags"
        End If
        If chkHeatedSeats.Checked Then
            pstrOrder &= ", Heated Seats"
        End If
        If chkLeather.Checked Then
            pstrOrder &= ", Leather Interior"
        End If
        If chkDVD.Checked Then
            pstrOrder &= ", DVD Player"
        End If

        'Select the delivery method
        If cboPaymentOptions.SelectedIndex = 0 Then
            pstrOrder &= " and you will be paying with Cash today. Thank you for choosing Quincy's Car Dealership."
        End If
        If cboPaymentOptions.SelectedIndex = 1 Then
            pstrOrder &= " and you will be paying with Leasing today. Thank you for choosing Quincy's Car Dealership."
        End If
        If cboPaymentOptions.SelectedIndex = 2 Then
            pstrOrder &= " and you will be paying with Financing today. Thank you for choosing Quincy's Car Dealership."
        End If

        'Display the order
        txtOrder.Text = pstrOrder
    End Sub
End Class
