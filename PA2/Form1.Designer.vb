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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cButton = New System.Windows.Forms.Button()
        Me.eButton = New System.Windows.Forms.Button()
        Me.clrButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.colButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.delButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericRAD = New System.Windows.Forms.NumericUpDown()
        Me.NumericA = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericB = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rfshButton = New System.Windows.Forms.Button()
        Me.NumericThickness = New System.Windows.Forms.NumericUpDown()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NumericRAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericThickness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 600)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cButton
        '
        Me.cButton.Location = New System.Drawing.Point(642, 36)
        Me.cButton.Name = "cButton"
        Me.cButton.Size = New System.Drawing.Size(112, 35)
        Me.cButton.TabIndex = 1
        Me.cButton.Text = "Circle"
        Me.cButton.UseVisualStyleBackColor = True
        '
        'eButton
        '
        Me.eButton.Location = New System.Drawing.Point(642, 123)
        Me.eButton.Name = "eButton"
        Me.eButton.Size = New System.Drawing.Size(112, 35)
        Me.eButton.TabIndex = 2
        Me.eButton.Text = "Ellipse"
        Me.eButton.UseVisualStyleBackColor = True
        '
        'clrButton
        '
        Me.clrButton.Location = New System.Drawing.Point(700, 540)
        Me.clrButton.Name = "clrButton"
        Me.clrButton.Size = New System.Drawing.Size(54, 35)
        Me.clrButton.TabIndex = 3
        Me.clrButton.Text = "Clear"
        Me.clrButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(639, 587)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(639, 609)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Y:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'colButton
        '
        Me.colButton.Location = New System.Drawing.Point(642, 244)
        Me.colButton.Name = "colButton"
        Me.colButton.Size = New System.Drawing.Size(112, 35)
        Me.colButton.TabIndex = 8
        Me.colButton.Text = "Color"
        Me.colButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(642, 322)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(112, 160)
        Me.ListBox1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(639, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Thickness"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(679, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Object"
        '
        'delButton
        '
        Me.delButton.Enabled = False
        Me.delButton.Location = New System.Drawing.Point(642, 540)
        Me.delButton.Name = "delButton"
        Me.delButton.Size = New System.Drawing.Size(54, 35)
        Me.delButton.TabIndex = 12
        Me.delButton.Text = "Delete"
        Me.delButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(639, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Radius"
        '
        'NumericRAD
        '
        Me.NumericRAD.Location = New System.Drawing.Point(685, 85)
        Me.NumericRAD.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericRAD.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericRAD.Name = "NumericRAD"
        Me.NumericRAD.Size = New System.Drawing.Size(69, 20)
        Me.NumericRAD.TabIndex = 15
        Me.NumericRAD.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericA
        '
        Me.NumericA.Location = New System.Drawing.Point(659, 178)
        Me.NumericA.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericA.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericA.Name = "NumericA"
        Me.NumericA.Size = New System.Drawing.Size(37, 20)
        Me.NumericA.TabIndex = 17
        Me.NumericA.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(639, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "A"
        '
        'NumericB
        '
        Me.NumericB.Location = New System.Drawing.Point(717, 178)
        Me.NumericB.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericB.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericB.Name = "NumericB"
        Me.NumericB.Size = New System.Drawing.Size(37, 20)
        Me.NumericB.TabIndex = 19
        Me.NumericB.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(702, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "B"
        '
        'rfshButton
        '
        Me.rfshButton.Location = New System.Drawing.Point(642, 492)
        Me.rfshButton.Name = "rfshButton"
        Me.rfshButton.Size = New System.Drawing.Size(112, 42)
        Me.rfshButton.TabIndex = 20
        Me.rfshButton.Text = "Refresh"
        Me.rfshButton.UseVisualStyleBackColor = True
        '
        'NumericThickness
        '
        Me.NumericThickness.Location = New System.Drawing.Point(700, 218)
        Me.NumericThickness.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericThickness.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericThickness.Name = "NumericThickness"
        Me.NumericThickness.Size = New System.Drawing.Size(54, 20)
        Me.NumericThickness.TabIndex = 21
        Me.NumericThickness.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 640)
        Me.Controls.Add(Me.NumericThickness)
        Me.Controls.Add(Me.rfshButton)
        Me.Controls.Add(Me.NumericB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericRAD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.delButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.colButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clrButton)
        Me.Controls.Add(Me.eButton)
        Me.Controls.Add(Me.cButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NumericRAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericThickness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cButton As Button
    Friend WithEvents eButton As Button
    Friend WithEvents clrButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents delButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericRAD As NumericUpDown
    Friend WithEvents NumericA As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericB As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents rfshButton As Button
    Friend WithEvents NumericThickness As NumericUpDown
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
