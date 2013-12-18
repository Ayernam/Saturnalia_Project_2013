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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Easy = New System.Windows.Forms.RadioButton()
        Me.Medium = New System.Windows.Forms.RadioButton()
        Me.Hard = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 25)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(592, 244)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 293)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(589, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Player 1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(592, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Hard)
        Me.GroupBox1.Controls.Add(Me.Medium)
        Me.GroupBox1.Controls.Add(Me.Easy)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 438)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Start"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(622, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 438)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control panel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Time: 0:00"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 30)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Pause"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(5, 85)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(139, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Restart"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Distance left: 1000 m"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Health: 3 lives"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(600, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 462)
        Me.Panel1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mode"
        '
        'Easy
        '
        Me.Easy.AutoSize = True
        Me.Easy.Checked = True
        Me.Easy.Location = New System.Drawing.Point(60, 332)
        Me.Easy.Name = "Easy"
        Me.Easy.Size = New System.Drawing.Size(89, 22)
        Me.Easy.TabIndex = 5
        Me.Easy.TabStop = True
        Me.Easy.Text = "Beginner"
        Me.Easy.UseVisualStyleBackColor = True
        '
        'Medium
        '
        Me.Medium.AutoSize = True
        Me.Medium.Location = New System.Drawing.Point(155, 332)
        Me.Medium.Name = "Medium"
        Me.Medium.Size = New System.Drawing.Size(112, 22)
        Me.Medium.TabIndex = 6
        Me.Medium.Text = "Intermediate"
        Me.Medium.UseVisualStyleBackColor = True
        '
        'Hard
        '
        Me.Hard.AutoSize = True
        Me.Hard.Location = New System.Drawing.Point(273, 332)
        Me.Hard.Name = "Hard"
        Me.Hard.Size = New System.Drawing.Size(71, 22)
        Me.Hard.TabIndex = 7
        Me.Hard.TabStop = True
        Me.Hard.Text = "Expert"
        Me.Hard.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Saturnalia Project"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Hard As System.Windows.Forms.RadioButton
    Friend WithEvents Medium As System.Windows.Forms.RadioButton
    Friend WithEvents Easy As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
