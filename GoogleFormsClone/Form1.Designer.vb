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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Label1.MaximumSize = New System.Drawing.Size(453, 342)
        Me.Label1.MinimumSize = New System.Drawing.Size(465, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(465, 264)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "John Doe, Slidely &Task 2 - Slidely Form App"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(133, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(376, 55)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&View Submissions(CTRL + V)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SkyBlue
        Me.Button3.Location = New System.Drawing.Point(133, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(376, 54)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "&Create New Submission(CTRL + N)"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 504)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximumSize = New System.Drawing.Size(654, 543)
        Me.Name = "Form1"
        Me.Text = "&View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
