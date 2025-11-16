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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstColor = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rad38 = New System.Windows.Forms.RadioButton()
        Me.rad35 = New System.Windows.Forms.RadioButton()
        Me.rad24 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkDVD = New System.Windows.Forms.CheckBox()
        Me.chkLeather = New System.Windows.Forms.CheckBox()
        Me.chkHeatedSeats = New System.Windows.Forms.CheckBox()
        Me.chkSideBags = New System.Windows.Forms.CheckBox()
        Me.chkBrakes = New System.Windows.Forms.CheckBox()
        Me.chkAC = New System.Windows.Forms.CheckBox()
        Me.chkCD = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnConfirmOrder = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPaymentOptions = New System.Windows.Forms.ComboBox()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.chkUser = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quincy's Car Dealership"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstColor)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose a Color"
        '
        'lstColor
        '
        Me.lstColor.FormattingEnabled = True
        Me.lstColor.Items.AddRange(New Object() {"Blue", "Red", "Green", "Yellow"})
        Me.lstColor.Location = New System.Drawing.Point(6, 19)
        Me.lstColor.Name = "lstColor"
        Me.lstColor.Size = New System.Drawing.Size(128, 56)
        Me.lstColor.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rad38)
        Me.GroupBox2.Controls.Add(Me.rad35)
        Me.GroupBox2.Controls.Add(Me.rad24)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Engine Type"
        '
        'rad38
        '
        Me.rad38.AutoSize = True
        Me.rad38.Location = New System.Drawing.Point(6, 70)
        Me.rad38.Name = "rad38"
        Me.rad38.Size = New System.Drawing.Size(46, 17)
        Me.rad38.TabIndex = 2
        Me.rad38.TabStop = True
        Me.rad38.Text = "3.8L"
        Me.rad38.UseVisualStyleBackColor = True
        '
        'rad35
        '
        Me.rad35.AutoSize = True
        Me.rad35.Location = New System.Drawing.Point(6, 47)
        Me.rad35.Name = "rad35"
        Me.rad35.Size = New System.Drawing.Size(46, 17)
        Me.rad35.TabIndex = 1
        Me.rad35.TabStop = True
        Me.rad35.Text = "3.5L"
        Me.rad35.UseVisualStyleBackColor = True
        '
        'rad24
        '
        Me.rad24.AutoSize = True
        Me.rad24.Location = New System.Drawing.Point(6, 24)
        Me.rad24.Name = "rad24"
        Me.rad24.Size = New System.Drawing.Size(46, 17)
        Me.rad24.TabIndex = 0
        Me.rad24.TabStop = True
        Me.rad24.Text = "2.4L"
        Me.rad24.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkDVD)
        Me.GroupBox3.Controls.Add(Me.chkLeather)
        Me.GroupBox3.Controls.Add(Me.chkHeatedSeats)
        Me.GroupBox3.Controls.Add(Me.chkSideBags)
        Me.GroupBox3.Controls.Add(Me.chkBrakes)
        Me.GroupBox3.Controls.Add(Me.chkAC)
        Me.GroupBox3.Controls.Add(Me.chkCD)
        Me.GroupBox3.Location = New System.Drawing.Point(34, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 120)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additonal Options"
        '
        'chkDVD
        '
        Me.chkDVD.AutoSize = True
        Me.chkDVD.Location = New System.Drawing.Point(113, 65)
        Me.chkDVD.Name = "chkDVD"
        Me.chkDVD.Size = New System.Drawing.Size(81, 17)
        Me.chkDVD.TabIndex = 6
        Me.chkDVD.Text = "DVD Player"
        Me.chkDVD.UseVisualStyleBackColor = True
        '
        'chkLeather
        '
        Me.chkLeather.AutoSize = True
        Me.chkLeather.Location = New System.Drawing.Point(113, 42)
        Me.chkLeather.Name = "chkLeather"
        Me.chkLeather.Size = New System.Drawing.Size(97, 17)
        Me.chkLeather.TabIndex = 5
        Me.chkLeather.Text = "Leather Interior"
        Me.chkLeather.UseVisualStyleBackColor = True
        '
        'chkHeatedSeats
        '
        Me.chkHeatedSeats.AutoSize = True
        Me.chkHeatedSeats.Location = New System.Drawing.Point(113, 19)
        Me.chkHeatedSeats.Name = "chkHeatedSeats"
        Me.chkHeatedSeats.Size = New System.Drawing.Size(91, 17)
        Me.chkHeatedSeats.TabIndex = 4
        Me.chkHeatedSeats.Text = "Heated Seats"
        Me.chkHeatedSeats.UseVisualStyleBackColor = True
        '
        'chkSideBags
        '
        Me.chkSideBags.AutoSize = True
        Me.chkSideBags.Location = New System.Drawing.Point(6, 88)
        Me.chkSideBags.Name = "chkSideBags"
        Me.chkSideBags.Size = New System.Drawing.Size(89, 17)
        Me.chkSideBags.TabIndex = 3
        Me.chkSideBags.Text = "Side-Air Bags"
        Me.chkSideBags.UseVisualStyleBackColor = True
        '
        'chkBrakes
        '
        Me.chkBrakes.AutoSize = True
        Me.chkBrakes.Location = New System.Drawing.Point(6, 65)
        Me.chkBrakes.Name = "chkBrakes"
        Me.chkBrakes.Size = New System.Drawing.Size(107, 17)
        Me.chkBrakes.TabIndex = 2
        Me.chkBrakes.Text = "Anti-Lock Brakes"
        Me.chkBrakes.UseVisualStyleBackColor = True
        '
        'chkAC
        '
        Me.chkAC.AutoSize = True
        Me.chkAC.Location = New System.Drawing.Point(6, 42)
        Me.chkAC.Name = "chkAC"
        Me.chkAC.Size = New System.Drawing.Size(99, 17)
        Me.chkAC.TabIndex = 1
        Me.chkAC.Text = "Air-Conditioning"
        Me.chkAC.UseVisualStyleBackColor = True
        '
        'chkCD
        '
        Me.chkCD.AutoSize = True
        Me.chkCD.Location = New System.Drawing.Point(6, 19)
        Me.chkCD.Name = "chkCD"
        Me.chkCD.Size = New System.Drawing.Size(73, 17)
        Me.chkCD.TabIndex = 0
        Me.chkCD.Text = "CD Player"
        Me.chkCD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(56, 63)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(170, 20)
        Me.txtName.TabIndex = 4
        '
        'btnConfirmOrder
        '
        Me.btnConfirmOrder.Location = New System.Drawing.Point(328, 310)
        Me.btnConfirmOrder.Name = "btnConfirmOrder"
        Me.btnConfirmOrder.Size = New System.Drawing.Size(83, 23)
        Me.btnConfirmOrder.TabIndex = 0
        Me.btnConfirmOrder.Text = "Confirm Order"
        Me.btnConfirmOrder.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Form of Payment"
        '
        'cboPaymentOptions
        '
        Me.cboPaymentOptions.FormattingEnabled = True
        Me.cboPaymentOptions.Location = New System.Drawing.Point(309, 263)
        Me.cboPaymentOptions.Name = "cboPaymentOptions"
        Me.cboPaymentOptions.Size = New System.Drawing.Size(121, 21)
        Me.cboPaymentOptions.TabIndex = 6
        '
        'txtOrder
        '
        Me.txtOrder.Enabled = False
        Me.txtOrder.Location = New System.Drawing.Point(12, 363)
        Me.txtOrder.Multiline = True
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(574, 75)
        Me.txtOrder.TabIndex = 7
        '
        'chkUser
        '
        Me.chkUser.AutoSize = True
        Me.chkUser.Location = New System.Drawing.Point(261, 66)
        Me.chkUser.Name = "chkUser"
        Me.chkUser.Size = New System.Drawing.Size(73, 17)
        Me.chkUser.TabIndex = 8
        Me.chkUser.Text = "New User"
        Me.chkUser.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 450)
        Me.Controls.Add(Me.chkUser)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.cboPaymentOptions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConfirmOrder)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstColor As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rad38 As RadioButton
    Friend WithEvents rad35 As RadioButton
    Friend WithEvents rad24 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkDVD As CheckBox
    Friend WithEvents chkLeather As CheckBox
    Friend WithEvents chkHeatedSeats As CheckBox
    Friend WithEvents chkSideBags As CheckBox
    Friend WithEvents chkBrakes As CheckBox
    Friend WithEvents chkAC As CheckBox
    Friend WithEvents chkCD As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnConfirmOrder As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cboPaymentOptions As ComboBox
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents chkUser As CheckBox
End Class
