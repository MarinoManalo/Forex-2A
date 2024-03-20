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
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtB1 = New System.Windows.Forms.TextBox()
        Me.TxtB2 = New System.Windows.Forms.TextBox()
        Me.CB2 = New System.Windows.Forms.ComboBox()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PicB1 = New System.Windows.Forms.PictureBox()
        Me.PicB2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PicB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicB2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB1
        '
        Me.CB1.AccessibleName = ""
        Me.CB1.BackColor = System.Drawing.Color.Gray
        Me.CB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB1.ForeColor = System.Drawing.Color.Black
        Me.CB1.FormattingEnabled = True
        Me.CB1.ItemHeight = 19
        Me.CB1.Items.AddRange(New Object() {"US Dollar", "HKG Dollar" & Global.Microsoft.VisualBasic.ChrW(9), "CND Dollar", "IND Rufee", "SRL Rufee", "UAE Dinar", "PHP Peso", "UK Pound", "JPN Yen", "EURO"})
        Me.CB1.Location = New System.Drawing.Point(111, 152)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(161, 27)
        Me.CB1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(145, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Currency Converter"
        '
        'TxtB1
        '
        Me.TxtB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TxtB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtB1.Location = New System.Drawing.Point(122, 227)
        Me.TxtB1.Name = "TxtB1"
        Me.TxtB1.Size = New System.Drawing.Size(131, 32)
        Me.TxtB1.TabIndex = 2
        '
        'TxtB2
        '
        Me.TxtB2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtB2.Enabled = False
        Me.TxtB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TxtB2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtB2.Location = New System.Drawing.Point(383, 227)
        Me.TxtB2.Name = "TxtB2"
        Me.TxtB2.Size = New System.Drawing.Size(131, 32)
        Me.TxtB2.TabIndex = 3
        '
        'CB2
        '
        Me.CB2.BackColor = System.Drawing.Color.Gray
        Me.CB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB2.ForeColor = System.Drawing.Color.Black
        Me.CB2.FormattingEnabled = True
        Me.CB2.ItemHeight = 19
        Me.CB2.Items.AddRange(New Object() {"US Dollar", "HKG Dollar" & Global.Microsoft.VisualBasic.ChrW(9), "CND Dollar", "IND Rufee", "SRL Rufee", "UAE Dinar", "PHP Peso", "UK Pound", "JPN Yen", "EURO"})
        Me.CB2.Location = New System.Drawing.Point(364, 152)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(161, 27)
        Me.CB2.TabIndex = 4
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn2.Font = New System.Drawing.Font("Segoe UI Historic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(372, 351)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(153, 35)
        Me.btn2.TabIndex = 6
        Me.btn2.Text = "Reset"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'PicB1
        '
        Me.PicB1.BackColor = System.Drawing.Color.Transparent
        Me.PicB1.Location = New System.Drawing.Point(152, 105)
        Me.PicB1.Name = "PicB1"
        Me.PicB1.Size = New System.Drawing.Size(76, 41)
        Me.PicB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicB1.TabIndex = 7
        Me.PicB1.TabStop = False
        '
        'PicB2
        '
        Me.PicB2.BackColor = System.Drawing.Color.Transparent
        Me.PicB2.Location = New System.Drawing.Point(405, 105)
        Me.PicB2.Name = "PicB2"
        Me.PicB2.Size = New System.Drawing.Size(76, 41)
        Me.PicB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicB2.TabIndex = 8
        Me.PicB2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Historic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(111, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Forex.My.Resources.Resources.Untitled_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 452)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicB2)
        Me.Controls.Add(Me.PicB1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.CB2)
        Me.Controls.Add(Me.TxtB2)
        Me.Controls.Add(Me.TxtB1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forex"
        CType(Me.PicB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicB2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtB1 As TextBox
    Friend WithEvents TxtB2 As TextBox
    Friend WithEvents CB2 As ComboBox
    Friend WithEvents btn2 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicB1 As PictureBox
    Friend WithEvents PicB2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
