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
        Me.NupHours = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NupMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NupSecondes = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CpbCountDown = New CircularProgressBar.CircularProgressBar()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.TimerCountDown = New System.Windows.Forms.Timer(Me.components)
        CType(Me.NupHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupSecondes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NupHours
        '
        Me.NupHours.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NupHours.Location = New System.Drawing.Point(216, 82)
        Me.NupHours.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NupHours.Name = "NupHours"
        Me.NupHours.ReadOnly = True
        Me.NupHours.Size = New System.Drawing.Size(60, 39)
        Me.NupHours.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Heures"
        '
        'NupMinutes
        '
        Me.NupMinutes.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NupMinutes.Location = New System.Drawing.Point(282, 82)
        Me.NupMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NupMinutes.Name = "NupMinutes"
        Me.NupMinutes.ReadOnly = True
        Me.NupMinutes.Size = New System.Drawing.Size(60, 39)
        Me.NupMinutes.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "minutes"
        '
        'NupSecondes
        '
        Me.NupSecondes.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NupSecondes.Location = New System.Drawing.Point(348, 82)
        Me.NupSecondes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NupSecondes.Name = "NupSecondes"
        Me.NupSecondes.ReadOnly = True
        Me.NupSecondes.Size = New System.Drawing.Size(60, 39)
        Me.NupSecondes.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Secondes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(152, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(307, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Séléctionner le temps du compte à rebours"
        '
        'CpbCountDown
        '
        Me.CpbCountDown.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CpbCountDown.AnimationSpeed = 500
        Me.CpbCountDown.BackColor = System.Drawing.Color.Transparent
        Me.CpbCountDown.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CpbCountDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CpbCountDown.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CpbCountDown.InnerMargin = 2
        Me.CpbCountDown.InnerWidth = -1
        Me.CpbCountDown.Location = New System.Drawing.Point(152, 127)
        Me.CpbCountDown.MarqueeAnimationSpeed = 2000
        Me.CpbCountDown.Name = "CpbCountDown"
        Me.CpbCountDown.OuterColor = System.Drawing.Color.Gray
        Me.CpbCountDown.OuterMargin = -25
        Me.CpbCountDown.OuterWidth = 26
        Me.CpbCountDown.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CpbCountDown.ProgressWidth = 25
        Me.CpbCountDown.SecondaryFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CpbCountDown.Size = New System.Drawing.Size(320, 320)
        Me.CpbCountDown.StartAngle = 270
        Me.CpbCountDown.Step = 1
        Me.CpbCountDown.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CpbCountDown.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CpbCountDown.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CpbCountDown.SubscriptText = ""
        Me.CpbCountDown.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CpbCountDown.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CpbCountDown.SuperscriptText = ""
        Me.CpbCountDown.TabIndex = 7
        Me.CpbCountDown.Tag = ""
        Me.CpbCountDown.Text = "00:00:00"
        Me.CpbCountDown.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CpbCountDown.Value = 68
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnStart.Location = New System.Drawing.Point(216, 463)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(189, 32)
        Me.BtnStart.TabIndex = 8
        Me.BtnStart.Text = "Démarrer"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnStop.Location = New System.Drawing.Point(219, 539)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(189, 32)
        Me.BtnStop.TabIndex = 9
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnPause
        '
        Me.BtnPause.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnPause.Location = New System.Drawing.Point(219, 501)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(189, 32)
        Me.BtnPause.TabIndex = 10
        Me.BtnPause.Text = "Pause"
        Me.BtnPause.UseVisualStyleBackColor = True
        '
        'TimerCountDown
        '
        Me.TimerCountDown.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 584)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.CpbCountDown)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NupSecondes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NupMinutes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NupHours)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compte à rebours"
        CType(Me.NupHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupSecondes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NupHours As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents NupMinutes As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NupSecondes As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CpbCountDown As CircularProgressBar.CircularProgressBar
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents BtnPause As Button
    Friend WithEvents TimerCountDown As Timer
End Class
