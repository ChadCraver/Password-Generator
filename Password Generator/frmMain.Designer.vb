<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblMaxChars = New System.Windows.Forms.Label()
        Me.spinMaxChars = New System.Windows.Forms.NumericUpDown()
        Me.lblExclude = New System.Windows.Forms.Label()
        Me.txtExclude = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblContainsSpecialChar = New System.Windows.Forms.Label()
        Me.lblContainsNumber = New System.Windows.Forms.Label()
        Me.lblContainsLower = New System.Windows.Forms.Label()
        Me.lblContainsUpper = New System.Windows.Forms.Label()
        CType(Me.spinMaxChars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(11, 124)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(322, 20)
        Me.txtOutput.TabIndex = 3
        '
        'lblMaxChars
        '
        Me.lblMaxChars.AutoSize = True
        Me.lblMaxChars.Location = New System.Drawing.Point(9, 24)
        Me.lblMaxChars.Name = "lblMaxChars"
        Me.lblMaxChars.Size = New System.Drawing.Size(108, 13)
        Me.lblMaxChars.TabIndex = 1
        Me.lblMaxChars.Text = "Maximum Characters:"
        '
        'spinMaxChars
        '
        Me.spinMaxChars.Location = New System.Drawing.Point(123, 22)
        Me.spinMaxChars.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.spinMaxChars.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinMaxChars.Name = "spinMaxChars"
        Me.spinMaxChars.Size = New System.Drawing.Size(59, 20)
        Me.spinMaxChars.TabIndex = 0
        Me.spinMaxChars.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'lblExclude
        '
        Me.lblExclude.AutoSize = True
        Me.lblExclude.Location = New System.Drawing.Point(40, 48)
        Me.lblExclude.Name = "lblExclude"
        Me.lblExclude.Size = New System.Drawing.Size(77, 13)
        Me.lblExclude.TabIndex = 3
        Me.lblExclude.Text = "Exclude these:"
        '
        'txtExclude
        '
        Me.txtExclude.Location = New System.Drawing.Point(123, 45)
        Me.txtExclude.Name = "txtExclude"
        Me.txtExclude.Size = New System.Drawing.Size(210, 20)
        Me.txtExclude.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(135, 84)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblContainsSpecialChar
        '
        Me.lblContainsSpecialChar.AutoSize = True
        Me.lblContainsSpecialChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainsSpecialChar.ForeColor = System.Drawing.Color.Red
        Me.lblContainsSpecialChar.Location = New System.Drawing.Point(40, 169)
        Me.lblContainsSpecialChar.Name = "lblContainsSpecialChar"
        Me.lblContainsSpecialChar.Size = New System.Drawing.Size(263, 15)
        Me.lblContainsSpecialChar.TabIndex = 4
        Me.lblContainsSpecialChar.Text = "Password does not contain a special character."
        '
        'lblContainsNumber
        '
        Me.lblContainsNumber.AutoSize = True
        Me.lblContainsNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainsNumber.ForeColor = System.Drawing.Color.Red
        Me.lblContainsNumber.Location = New System.Drawing.Point(40, 191)
        Me.lblContainsNumber.Name = "lblContainsNumber"
        Me.lblContainsNumber.Size = New System.Drawing.Size(213, 15)
        Me.lblContainsNumber.TabIndex = 4
        Me.lblContainsNumber.Text = "Password does not contain a number."
        '
        'lblContainsLower
        '
        Me.lblContainsLower.AutoSize = True
        Me.lblContainsLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainsLower.ForeColor = System.Drawing.Color.Red
        Me.lblContainsLower.Location = New System.Drawing.Point(40, 213)
        Me.lblContainsLower.Name = "lblContainsLower"
        Me.lblContainsLower.Size = New System.Drawing.Size(259, 15)
        Me.lblContainsLower.TabIndex = 4
        Me.lblContainsLower.Text = "Password does not contain a lower case letter."
        '
        'lblContainsUpper
        '
        Me.lblContainsUpper.AutoSize = True
        Me.lblContainsUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContainsUpper.ForeColor = System.Drawing.Color.Red
        Me.lblContainsUpper.Location = New System.Drawing.Point(40, 235)
        Me.lblContainsUpper.Name = "lblContainsUpper"
        Me.lblContainsUpper.Size = New System.Drawing.Size(268, 15)
        Me.lblContainsUpper.TabIndex = 4
        Me.lblContainsUpper.Text = "Password does not contain an upper case letter."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 288)
        Me.Controls.Add(Me.lblContainsUpper)
        Me.Controls.Add(Me.lblContainsLower)
        Me.Controls.Add(Me.lblContainsNumber)
        Me.Controls.Add(Me.lblContainsSpecialChar)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtExclude)
        Me.Controls.Add(Me.lblExclude)
        Me.Controls.Add(Me.spinMaxChars)
        Me.Controls.Add(Me.lblMaxChars)
        Me.Controls.Add(Me.txtOutput)
        Me.Name = "frmMain"
        Me.Text = "Password Generator"
        CType(Me.spinMaxChars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lblMaxChars As Label
    Friend WithEvents spinMaxChars As NumericUpDown
    Friend WithEvents lblExclude As Label
    Friend WithEvents txtExclude As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblContainsSpecialChar As Label
    Friend WithEvents lblContainsNumber As Label
    Friend WithEvents lblContainsLower As Label
    Friend WithEvents lblContainsUpper As Label
End Class
