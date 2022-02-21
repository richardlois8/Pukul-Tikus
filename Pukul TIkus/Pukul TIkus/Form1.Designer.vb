<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSkor = New System.Windows.Forms.Label()
        Me.lblRandom = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.TimerTikus = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TikusIlang = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblSkor
        '
        Me.lblSkor.AutoSize = True
        Me.lblSkor.Location = New System.Drawing.Point(20, 296)
        Me.lblSkor.Name = "lblSkor"
        Me.lblSkor.Size = New System.Drawing.Size(45, 15)
        Me.lblSkor.TabIndex = 0
        Me.lblSkor.Text = "Skor : 0"
        '
        'lblRandom
        '
        Me.lblRandom.AutoSize = True
        Me.lblRandom.Location = New System.Drawing.Point(20, 323)
        Me.lblRandom.Name = "lblRandom"
        Me.lblRandom.Size = New System.Drawing.Size(58, 15)
        Me.lblRandom.TabIndex = 1
        Me.lblRandom.Text = "Random: "
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(165, 306)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'TimerTikus
        '
        Me.TimerTikus.Interval = 1200
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 274)
        Me.Panel1.TabIndex = 3
        '
        'TikusIlang
        '
        Me.TikusIlang.Enabled = True
        Me.TikusIlang.Interval = 1250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 356)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblRandom)
        Me.Controls.Add(Me.lblSkor)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Pukul Tikus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSkor As Label
    Friend WithEvents lblRandom As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents TimerTikus As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TikusIlang As Timer
End Class
