<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pic10ofSpades = New System.Windows.Forms.PictureBox()
        Me.picJackofSpades = New System.Windows.Forms.PictureBox()
        Me.picQueenofSpades = New System.Windows.Forms.PictureBox()
        Me.picKingofSpades = New System.Windows.Forms.PictureBox()
        Me.picAceofSpades = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.pic10ofSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJackofSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQueenofSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingofSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAceofSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic10ofSpades
        '
        Me.pic10ofSpades.Image = Global.Card_Identifier.My.Resources.Resources._10_Spades
        Me.pic10ofSpades.Location = New System.Drawing.Point(95, 143)
        Me.pic10ofSpades.Name = "pic10ofSpades"
        Me.pic10ofSpades.Size = New System.Drawing.Size(83, 112)
        Me.pic10ofSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic10ofSpades.TabIndex = 0
        Me.pic10ofSpades.TabStop = False
        '
        'picJackofSpades
        '
        Me.picJackofSpades.Image = Global.Card_Identifier.My.Resources.Resources.Jack_Spades
        Me.picJackofSpades.Location = New System.Drawing.Point(226, 143)
        Me.picJackofSpades.Name = "picJackofSpades"
        Me.picJackofSpades.Size = New System.Drawing.Size(84, 112)
        Me.picJackofSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJackofSpades.TabIndex = 1
        Me.picJackofSpades.TabStop = False
        '
        'picQueenofSpades
        '
        Me.picQueenofSpades.Image = Global.Card_Identifier.My.Resources.Resources.Queen_Spades
        Me.picQueenofSpades.Location = New System.Drawing.Point(352, 143)
        Me.picQueenofSpades.Name = "picQueenofSpades"
        Me.picQueenofSpades.Size = New System.Drawing.Size(85, 112)
        Me.picQueenofSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQueenofSpades.TabIndex = 2
        Me.picQueenofSpades.TabStop = False
        '
        'picKingofSpades
        '
        Me.picKingofSpades.Image = Global.Card_Identifier.My.Resources.Resources.King_Spades
        Me.picKingofSpades.Location = New System.Drawing.Point(480, 143)
        Me.picKingofSpades.Name = "picKingofSpades"
        Me.picKingofSpades.Size = New System.Drawing.Size(84, 112)
        Me.picKingofSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingofSpades.TabIndex = 3
        Me.picKingofSpades.TabStop = False
        '
        'picAceofSpades
        '
        Me.picAceofSpades.Image = Global.Card_Identifier.My.Resources.Resources.Ace_Spades
        Me.picAceofSpades.Location = New System.Drawing.Point(617, 143)
        Me.picAceofSpades.Name = "picAceofSpades"
        Me.picAceofSpades.Size = New System.Drawing.Size(82, 112)
        Me.picAceofSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAceofSpades.TabIndex = 4
        Me.picAceofSpades.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(362, 360)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Click a Card to See Its Name"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(376, 295)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 13)
        Me.lblName.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picAceofSpades)
        Me.Controls.Add(Me.picKingofSpades)
        Me.Controls.Add(Me.picQueenofSpades)
        Me.Controls.Add(Me.picJackofSpades)
        Me.Controls.Add(Me.pic10ofSpades)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic10ofSpades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJackofSpades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQueenofSpades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingofSpades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAceofSpades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic10ofSpades As PictureBox
    Friend WithEvents picJackofSpades As PictureBox
    Friend WithEvents picQueenofSpades As PictureBox
    Friend WithEvents picKingofSpades As PictureBox
    Friend WithEvents picAceofSpades As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
End Class
