<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnStartPause = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnToggleStopwatch = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(346, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "txtName"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(346, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "txtEmail"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(346, 91)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "txtPhone"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(346, 117)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "txtGithubLink"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(382, 174)
        Me.lblStopwatch.Margin = New System.Windows.Forms.Padding(8, 0, 9, 0)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(49, 13)
        Me.lblStopwatch.TabIndex = 4
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnStartPause
        '
        Me.btnStartPause.Location = New System.Drawing.Point(261, 233)
        Me.btnStartPause.MinimumSize = New System.Drawing.Size(211, 46)
        Me.btnStartPause.Name = "btnStartPause"
        Me.btnStartPause.Size = New System.Drawing.Size(211, 46)
        Me.btnStartPause.TabIndex = 6
        Me.btnStartPause.Text = "Start"
        Me.btnStartPause.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSubmit.Location = New System.Drawing.Point(147, 312)
        Me.btnSubmit.MinimumSize = New System.Drawing.Size(211, 45)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(428, 56)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "&Submit(CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.AutoSize = True
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.Yellow
        Me.btnToggleStopwatch.ForeColor = System.Drawing.Color.Black
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(222, 174)
        Me.btnToggleStopwatch.MinimumSize = New System.Drawing.Size(21, 20)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(147, 20)
        Me.btnToggleStopwatch.TabIndex = 8
        Me.btnToggleStopwatch.Text = "&Toggle Stopwatch(CTRL + T)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "&Phone num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "& Github Link For Task 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "John Doe, Slidely Task 2 - Create Submission"
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnStartPause)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnStartPause As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnToggleStopwatch As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
