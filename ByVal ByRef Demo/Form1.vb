Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intNumber As Integer = 100

        IstOutPut.Items.Add("Inside btnGo_Click the value of " & "intNumber is " & intNumber.ToString())

        IstOutPut.Items.Add("Now I am calling ChangeArg.")

        ChangeArg(intNumber)
        IstOutPut.Items.Add("Now Back in btnGo_click, " & "the value of intNumber is " & intNumber.ToString())
    End Sub
    Sub ChangeArg(ByRef intArg As Integer)
        ' Display the value of intArg
        IstOutPut.Items.Add(" ")
        IstOutPut.Items.Add("Inside the ChangeArg procedure, " & "intArg is " & intArg.ToString())
        IstOutPut.Items.Add("I will change the value of intArg.")

        'Assign 0 to intArg
        intArg = 0

        'Display the value of intArg
        IstOutPut.Items.Add("intArg is now " & intArg.ToString())
        IstOutPut.Items.Add(" ")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'By Quincy Muzik
End Class
