<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class password_generator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(password_generator))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudPassSize = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPasswords = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.chkEasyChars = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkHardChars = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.nudPassSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Generator"
        '
        'nudPassSize
        '
        Me.nudPassSize.Location = New System.Drawing.Point(98, 36)
        Me.nudPassSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPassSize.Name = "nudPassSize"
        Me.nudPassSize.Size = New System.Drawing.Size(49, 20)
        Me.nudPassSize.TabIndex = 1
        Me.nudPassSize.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password Size:"
        '
        'txtPasswords
        '
        Me.txtPasswords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasswords.Location = New System.Drawing.Point(16, 62)
        Me.txtPasswords.Multiline = True
        Me.txtPasswords.Name = "txtPasswords"
        Me.txtPasswords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPasswords.Size = New System.Drawing.Size(307, 155)
        Me.txtPasswords.TabIndex = 3
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.Location = New System.Drawing.Point(64, 223)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(104, 23)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'chkEasyChars
        '
        Me.chkEasyChars.AutoSize = True
        Me.chkEasyChars.Location = New System.Drawing.Point(169, 36)
        Me.chkEasyChars.Name = "chkEasyChars"
        Me.chkEasyChars.Size = New System.Drawing.Size(79, 17)
        Me.chkEasyChars.TabIndex = 5
        Me.chkEasyChars.Text = "Easy Chars"
        Me.chkEasyChars.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCopy})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(328, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'menuCopy
        '
        Me.menuCopy.Name = "menuCopy"
        Me.menuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.menuCopy.Size = New System.Drawing.Size(47, 20)
        Me.menuCopy.Text = "Copy"
        '
        'chkHardChars
        '
        Me.chkHardChars.AutoSize = True
        Me.chkHardChars.Location = New System.Drawing.Point(255, 36)
        Me.chkHardChars.Name = "chkHardChars"
        Me.chkHardChars.Size = New System.Drawing.Size(79, 17)
        Me.chkHardChars.TabIndex = 7
        Me.chkHardChars.Text = "Hard Chars"
        Me.chkHardChars.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(174, 223)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'password_generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 251)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkHardChars)
        Me.Controls.Add(Me.chkEasyChars)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtPasswords)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudPassSize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "password_generator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Generator"
        CType(Me.nudPassSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudPassSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPasswords As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents chkEasyChars As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkHardChars As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
