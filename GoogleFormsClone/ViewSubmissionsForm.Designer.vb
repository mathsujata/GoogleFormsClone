﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SkyBlue
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(477, 135)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(121, 55)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "&Next(CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Yellow
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.Location = New System.Drawing.Point(215, 135)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(120, 55)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "&Previous(CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(148, 66)
        Me.Label1.MaximumSize = New System.Drawing.Size(299, 299)
        Me.Label1.MinimumSize = New System.Drawing.Size(526, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 335)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&John Doe, Slidely Task 2 - View Submissions"
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label1 As Label
End Class
