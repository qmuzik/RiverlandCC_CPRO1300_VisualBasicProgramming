Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'This closes the program
    End Sub

    Private Sub Pic10ofSpades_Click(sender As Object, e As EventArgs) Handles pic10ofSpades.Click
        lblName.Text = "10 of Spades"
    End Sub

    Private Sub PicJackofSpades_Click(sender As Object, e As EventArgs) Handles picJackofSpades.Click
        lblName.Text = "Jack of Spades"
    End Sub

    Private Sub PicQueenofSpades_Click(sender As Object, e As EventArgs) Handles picQueenofSpades.Click
        lblName.Text = "Queen of Spades"
    End Sub

    Private Sub PicKingofSpades_Click(sender As Object, e As EventArgs) Handles picKingofSpades.Click
        lblName.Text = "King of Spades"
    End Sub

    Private Sub PicAceofSpades_Click(sender As Object, e As EventArgs) Handles picAceofSpades.Click
        lblName.Text = "Ace of Spades"
    End Sub
End Class
