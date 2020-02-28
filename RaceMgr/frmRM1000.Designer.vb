<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRM1000
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
        Me.grpCommand = New System.Windows.Forms.GroupBox()
        Me.btnDeleteTeam = New System.Windows.Forms.Button()
        Me.btnAddTeam = New System.Windows.Forms.Button()
        Me.btnLoadTeam = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstTeam = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBoxFile = New System.Windows.Forms.GroupBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpAddTeam = New System.Windows.Forms.GroupBox()
        Me.txtAdLast = New System.Windows.Forms.TextBox()
        Me.txtCoachLast = New System.Windows.Forms.TextBox()
        Me.txtSchoolName = New System.Windows.Forms.TextBox()
        Me.txtAdFirst = New System.Windows.Forms.TextBox()
        Me.txtCoachFirst = New System.Windows.Forms.TextBox()
        Me.txtSchoolCode = New System.Windows.Forms.TextBox()
        Me.lblAdLast = New System.Windows.Forms.Label()
        Me.lblCoachLast = New System.Windows.Forms.Label()
        Me.lblSchoolName = New System.Windows.Forms.Label()
        Me.lblAdFirst = New System.Windows.Forms.Label()
        Me.lblCoachFirst = New System.Windows.Forms.Label()
        Me.lblSchoolCode = New System.Windows.Forms.Label()
        Me.btnCancelNewTeam = New System.Windows.Forms.Button()
        Me.btnRefreshNewTeam = New System.Windows.Forms.Button()
        Me.btnSaveNewTeam = New System.Windows.Forms.Button()
        Me.grpCommand.SuspendLayout()
        Me.grpBoxFile.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddTeam.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommand
        '
        Me.grpCommand.BackColor = System.Drawing.Color.SteelBlue
        Me.grpCommand.Controls.Add(Me.btnDeleteTeam)
        Me.grpCommand.Controls.Add(Me.btnAddTeam)
        Me.grpCommand.Controls.Add(Me.btnLoadTeam)
        Me.grpCommand.Controls.Add(Me.btnExit)
        Me.grpCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCommand.ForeColor = System.Drawing.Color.White
        Me.grpCommand.Location = New System.Drawing.Point(9, 285)
        Me.grpCommand.Margin = New System.Windows.Forms.Padding(2)
        Me.grpCommand.Name = "grpCommand"
        Me.grpCommand.Padding = New System.Windows.Forms.Padding(2)
        Me.grpCommand.Size = New System.Drawing.Size(560, 56)
        Me.grpCommand.TabIndex = 1
        Me.grpCommand.TabStop = False
        '
        'btnDeleteTeam
        '
        Me.btnDeleteTeam.Enabled = False
        Me.btnDeleteTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeleteTeam.Location = New System.Drawing.Point(218, 17)
        Me.btnDeleteTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteTeam.Name = "btnDeleteTeam"
        Me.btnDeleteTeam.Size = New System.Drawing.Size(102, 28)
        Me.btnDeleteTeam.TabIndex = 3
        Me.btnDeleteTeam.Text = "Delete Team"
        Me.btnDeleteTeam.UseVisualStyleBackColor = True
        '
        'btnAddTeam
        '
        Me.btnAddTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddTeam.Location = New System.Drawing.Point(118, 17)
        Me.btnAddTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddTeam.Name = "btnAddTeam"
        Me.btnAddTeam.Size = New System.Drawing.Size(102, 28)
        Me.btnAddTeam.TabIndex = 2
        Me.btnAddTeam.Text = "Add Team"
        Me.btnAddTeam.UseVisualStyleBackColor = True
        '
        'btnLoadTeam
        '
        Me.btnLoadTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoadTeam.Location = New System.Drawing.Point(17, 17)
        Me.btnLoadTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoadTeam.Name = "btnLoadTeam"
        Me.btnLoadTeam.Size = New System.Drawing.Size(102, 28)
        Me.btnLoadTeam.TabIndex = 1
        Me.btnLoadTeam.Text = "Load Teams"
        Me.btnLoadTeam.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(439, 17)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 28)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Return"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstTeam
        '
        Me.lstTeam.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTeam.FormattingEnabled = True
        Me.lstTeam.ItemHeight = 14
        Me.lstTeam.Location = New System.Drawing.Point(9, 20)
        Me.lstTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.lstTeam.Name = "lstTeam"
        Me.lstTeam.Size = New System.Drawing.Size(429, 116)
        Me.lstTeam.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "School Code | School Name | Coach F-Name | Coach L-Name | AD F-Name| AD L-Name"
        '
        'grpBoxFile
        '
        Me.grpBoxFile.BackColor = System.Drawing.Color.SteelBlue
        Me.grpBoxFile.Controls.Add(Me.txtFilePath)
        Me.grpBoxFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxFile.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.grpBoxFile.Location = New System.Drawing.Point(337, 231)
        Me.grpBoxFile.Name = "grpBoxFile"
        Me.grpBoxFile.Size = New System.Drawing.Size(230, 49)
        Me.grpBoxFile.TabIndex = 10
        Me.grpBoxFile.TabStop = False
        Me.grpBoxFile.Text = "Data Location - Full Path Location"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(13, 16)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(206, 20)
        Me.txtFilePath.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.corsa
        Me.PictureBox1.Location = New System.Drawing.Point(443, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'grpAddTeam
        '
        Me.grpAddTeam.BackColor = System.Drawing.Color.SteelBlue
        Me.grpAddTeam.Controls.Add(Me.txtAdLast)
        Me.grpAddTeam.Controls.Add(Me.txtCoachLast)
        Me.grpAddTeam.Controls.Add(Me.txtSchoolName)
        Me.grpAddTeam.Controls.Add(Me.txtAdFirst)
        Me.grpAddTeam.Controls.Add(Me.txtCoachFirst)
        Me.grpAddTeam.Controls.Add(Me.txtSchoolCode)
        Me.grpAddTeam.Controls.Add(Me.lblAdLast)
        Me.grpAddTeam.Controls.Add(Me.lblCoachLast)
        Me.grpAddTeam.Controls.Add(Me.lblSchoolName)
        Me.grpAddTeam.Controls.Add(Me.lblAdFirst)
        Me.grpAddTeam.Controls.Add(Me.lblCoachFirst)
        Me.grpAddTeam.Controls.Add(Me.lblSchoolCode)
        Me.grpAddTeam.Controls.Add(Me.btnCancelNewTeam)
        Me.grpAddTeam.Controls.Add(Me.btnRefreshNewTeam)
        Me.grpAddTeam.Controls.Add(Me.btnSaveNewTeam)
        Me.grpAddTeam.Enabled = False
        Me.grpAddTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddTeam.ForeColor = System.Drawing.Color.White
        Me.grpAddTeam.Location = New System.Drawing.Point(9, 140)
        Me.grpAddTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.grpAddTeam.Name = "grpAddTeam"
        Me.grpAddTeam.Padding = New System.Windows.Forms.Padding(2)
        Me.grpAddTeam.Size = New System.Drawing.Size(560, 140)
        Me.grpAddTeam.TabIndex = 5
        Me.grpAddTeam.TabStop = False
        Me.grpAddTeam.Text = "Add Team Information"
        Me.grpAddTeam.Visible = False
        '
        'txtAdLast
        '
        Me.txtAdLast.Location = New System.Drawing.Point(379, 73)
        Me.txtAdLast.Name = "txtAdLast"
        Me.txtAdLast.Size = New System.Drawing.Size(134, 19)
        Me.txtAdLast.TabIndex = 5
        '
        'txtCoachLast
        '
        Me.txtCoachLast.Location = New System.Drawing.Point(379, 44)
        Me.txtCoachLast.Name = "txtCoachLast"
        Me.txtCoachLast.Size = New System.Drawing.Size(134, 19)
        Me.txtCoachLast.TabIndex = 3
        '
        'txtSchoolName
        '
        Me.txtSchoolName.Location = New System.Drawing.Point(379, 15)
        Me.txtSchoolName.Name = "txtSchoolName"
        Me.txtSchoolName.Size = New System.Drawing.Size(134, 19)
        Me.txtSchoolName.TabIndex = 1
        '
        'txtAdFirst
        '
        Me.txtAdFirst.Location = New System.Drawing.Point(113, 73)
        Me.txtAdFirst.Name = "txtAdFirst"
        Me.txtAdFirst.Size = New System.Drawing.Size(143, 19)
        Me.txtAdFirst.TabIndex = 4
        '
        'txtCoachFirst
        '
        Me.txtCoachFirst.Location = New System.Drawing.Point(113, 44)
        Me.txtCoachFirst.Name = "txtCoachFirst"
        Me.txtCoachFirst.Size = New System.Drawing.Size(143, 19)
        Me.txtCoachFirst.TabIndex = 2
        '
        'txtSchoolCode
        '
        Me.txtSchoolCode.Location = New System.Drawing.Point(113, 15)
        Me.txtSchoolCode.Name = "txtSchoolCode"
        Me.txtSchoolCode.Size = New System.Drawing.Size(59, 19)
        Me.txtSchoolCode.TabIndex = 0
        '
        'lblAdLast
        '
        Me.lblAdLast.AutoSize = True
        Me.lblAdLast.Location = New System.Drawing.Point(283, 76)
        Me.lblAdLast.Name = "lblAdLast"
        Me.lblAdLast.Size = New System.Drawing.Size(71, 13)
        Me.lblAdLast.TabIndex = 9
        Me.lblAdLast.Text = "AD L-Name"
        '
        'lblCoachLast
        '
        Me.lblCoachLast.AutoSize = True
        Me.lblCoachLast.Location = New System.Drawing.Point(283, 47)
        Me.lblCoachLast.Name = "lblCoachLast"
        Me.lblCoachLast.Size = New System.Drawing.Size(90, 13)
        Me.lblCoachLast.TabIndex = 8
        Me.lblCoachLast.Text = "Coach L-Name"
        '
        'lblSchoolName
        '
        Me.lblSchoolName.AutoSize = True
        Me.lblSchoolName.Location = New System.Drawing.Point(283, 18)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.Size = New System.Drawing.Size(82, 13)
        Me.lblSchoolName.TabIndex = 7
        Me.lblSchoolName.Text = "School Name"
        '
        'lblAdFirst
        '
        Me.lblAdFirst.AutoSize = True
        Me.lblAdFirst.Location = New System.Drawing.Point(17, 76)
        Me.lblAdFirst.Name = "lblAdFirst"
        Me.lblAdFirst.Size = New System.Drawing.Size(71, 13)
        Me.lblAdFirst.TabIndex = 6
        Me.lblAdFirst.Text = "AD F-Name"
        '
        'lblCoachFirst
        '
        Me.lblCoachFirst.AutoSize = True
        Me.lblCoachFirst.Location = New System.Drawing.Point(17, 47)
        Me.lblCoachFirst.Name = "lblCoachFirst"
        Me.lblCoachFirst.Size = New System.Drawing.Size(90, 13)
        Me.lblCoachFirst.TabIndex = 5
        Me.lblCoachFirst.Text = "Coach F-Name"
        '
        'lblSchoolCode
        '
        Me.lblSchoolCode.AutoSize = True
        Me.lblSchoolCode.Location = New System.Drawing.Point(17, 18)
        Me.lblSchoolCode.Name = "lblSchoolCode"
        Me.lblSchoolCode.Size = New System.Drawing.Size(79, 13)
        Me.lblSchoolCode.TabIndex = 4
        Me.lblSchoolCode.Text = "School Code"
        '
        'btnCancelNewTeam
        '
        Me.btnCancelNewTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelNewTeam.Location = New System.Drawing.Point(445, 102)
        Me.btnCancelNewTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelNewTeam.Name = "btnCancelNewTeam"
        Me.btnCancelNewTeam.Size = New System.Drawing.Size(102, 28)
        Me.btnCancelNewTeam.TabIndex = 8
        Me.btnCancelNewTeam.Text = "&Cancel"
        Me.btnCancelNewTeam.UseVisualStyleBackColor = True
        '
        'btnRefreshNewTeam
        '
        Me.btnRefreshNewTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefreshNewTeam.Location = New System.Drawing.Point(341, 102)
        Me.btnRefreshNewTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefreshNewTeam.Name = "btnRefreshNewTeam"
        Me.btnRefreshNewTeam.Size = New System.Drawing.Size(102, 28)
        Me.btnRefreshNewTeam.TabIndex = 7
        Me.btnRefreshNewTeam.Text = "re&Fresh"
        Me.btnRefreshNewTeam.UseVisualStyleBackColor = True
        '
        'btnSaveNewTeam
        '
        Me.btnSaveNewTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSaveNewTeam.Location = New System.Drawing.Point(238, 102)
        Me.btnSaveNewTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveNewTeam.Name = "btnSaveNewTeam"
        Me.btnSaveNewTeam.Size = New System.Drawing.Size(102, 28)
        Me.btnSaveNewTeam.TabIndex = 6
        Me.btnSaveNewTeam.Text = "&Save"
        Me.btnSaveNewTeam.UseVisualStyleBackColor = True
        '
        'frmRM1000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 352)
        Me.Controls.Add(Me.grpAddTeam)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpBoxFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTeam)
        Me.Controls.Add(Me.grpCommand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRM1000"
        Me.Text = "Race Manager - 1000 - Team Management - Devin Brite | B.D."
        Me.grpCommand.ResumeLayout(False)
        Me.grpBoxFile.ResumeLayout(False)
        Me.grpBoxFile.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAddTeam.ResumeLayout(False)
        Me.grpAddTeam.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCommand As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDeleteTeam As System.Windows.Forms.Button
    Friend WithEvents btnAddTeam As System.Windows.Forms.Button
    Friend WithEvents btnLoadTeam As System.Windows.Forms.Button
    Friend WithEvents lstTeam As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpBoxFile As System.Windows.Forms.GroupBox
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grpAddTeam As GroupBox
    Friend WithEvents btnCancelNewTeam As Button
    Friend WithEvents btnRefreshNewTeam As Button
    Friend WithEvents btnSaveNewTeam As Button
    Friend WithEvents txtAdLast As TextBox
    Friend WithEvents txtCoachLast As TextBox
    Friend WithEvents txtSchoolName As TextBox
    Friend WithEvents txtAdFirst As TextBox
    Friend WithEvents txtCoachFirst As TextBox
    Friend WithEvents txtSchoolCode As TextBox
    Friend WithEvents lblAdLast As Label
    Friend WithEvents lblCoachLast As Label
    Friend WithEvents lblSchoolName As Label
    Friend WithEvents lblAdFirst As Label
    Friend WithEvents lblCoachFirst As Label
    Friend WithEvents lblSchoolCode As Label
End Class
