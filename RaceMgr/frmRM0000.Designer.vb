<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRM0000
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRM0000))
        Me.grpCommand = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnResultsMgr = New System.Windows.Forms.Button()
        Me.btnRaceMgr = New System.Windows.Forms.Button()
        Me.btnRunnerMgr = New System.Windows.Forms.Button()
        Me.btnTeamMgr = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.grpCommand.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommand
        '
        Me.grpCommand.BackColor = System.Drawing.Color.SteelBlue
        Me.grpCommand.Controls.Add(Me.btnExit)
        Me.grpCommand.Controls.Add(Me.btnResultsMgr)
        Me.grpCommand.Controls.Add(Me.btnRaceMgr)
        Me.grpCommand.Controls.Add(Me.btnRunnerMgr)
        Me.grpCommand.Controls.Add(Me.btnTeamMgr)
        Me.grpCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCommand.ForeColor = System.Drawing.Color.White
        Me.grpCommand.Location = New System.Drawing.Point(9, 248)
        Me.grpCommand.Margin = New System.Windows.Forms.Padding(2)
        Me.grpCommand.Name = "grpCommand"
        Me.grpCommand.Padding = New System.Windows.Forms.Padding(2)
        Me.grpCommand.Size = New System.Drawing.Size(560, 56)
        Me.grpCommand.TabIndex = 0
        Me.grpCommand.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(439, 17)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnResultsMgr
        '
        Me.btnResultsMgr.Enabled = False
        Me.btnResultsMgr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResultsMgr.Location = New System.Drawing.Point(312, 16)
        Me.btnResultsMgr.Margin = New System.Windows.Forms.Padding(2)
        Me.btnResultsMgr.Name = "btnResultsMgr"
        Me.btnResultsMgr.Size = New System.Drawing.Size(102, 28)
        Me.btnResultsMgr.TabIndex = 4
        Me.btnResultsMgr.Text = "4-Results Mgr"
        Me.btnResultsMgr.UseVisualStyleBackColor = True
        '
        'btnRaceMgr
        '
        Me.btnRaceMgr.Enabled = False
        Me.btnRaceMgr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRaceMgr.Location = New System.Drawing.Point(212, 16)
        Me.btnRaceMgr.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRaceMgr.Name = "btnRaceMgr"
        Me.btnRaceMgr.Size = New System.Drawing.Size(102, 28)
        Me.btnRaceMgr.TabIndex = 3
        Me.btnRaceMgr.Text = "3-Race Mgr"
        Me.btnRaceMgr.UseVisualStyleBackColor = True
        '
        'btnRunnerMgr
        '
        Me.btnRunnerMgr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRunnerMgr.Location = New System.Drawing.Point(112, 16)
        Me.btnRunnerMgr.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRunnerMgr.Name = "btnRunnerMgr"
        Me.btnRunnerMgr.Size = New System.Drawing.Size(102, 28)
        Me.btnRunnerMgr.TabIndex = 2
        Me.btnRunnerMgr.Text = "2-Runner Mgr"
        Me.btnRunnerMgr.UseVisualStyleBackColor = True
        '
        'btnTeamMgr
        '
        Me.btnTeamMgr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTeamMgr.Location = New System.Drawing.Point(13, 16)
        Me.btnTeamMgr.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTeamMgr.Name = "btnTeamMgr"
        Me.btnTeamMgr.Size = New System.Drawing.Size(102, 28)
        Me.btnTeamMgr.TabIndex = 1
        Me.btnTeamMgr.Text = "1-Team Mgr"
        Me.btnTeamMgr.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, -213)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(526, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.race_still
        Me.PictureBox2.Location = New System.Drawing.Point(9, -2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(560, 248)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.txtFilePath)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(339, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 49)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Location - Full Path Location"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(13, 16)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(206, 20)
        Me.txtFilePath.TabIndex = 0
        Me.txtFilePath.Text = "C:\Bob\RosterLoad.txt"
        '
        'frmRM0000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 312)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpCommand)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRM0000"
        Me.Text = "Race Manager - 0000 - Home - Devin Brite | B.D."
        Me.grpCommand.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCommand As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnResultsMgr As System.Windows.Forms.Button
    Friend WithEvents btnRaceMgr As System.Windows.Forms.Button
    Friend WithEvents btnRunnerMgr As System.Windows.Forms.Button
    Friend WithEvents btnTeamMgr As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox

End Class
