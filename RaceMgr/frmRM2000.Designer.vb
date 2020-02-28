<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRM2000
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
        Me.btnDeleteRunner = New System.Windows.Forms.Button()
        Me.btnAddRunners = New System.Windows.Forms.Button()
        Me.btnLoadRunners = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBoxFile = New System.Windows.Forms.GroupBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpAddRunner = New System.Windows.Forms.GroupBox()
        Me.txtRunnerLname = New System.Windows.Forms.TextBox()
        Me.txtSchoolCode = New System.Windows.Forms.TextBox()
        Me.txtRunnerFname = New System.Windows.Forms.TextBox()
        Me.txtBib = New System.Windows.Forms.TextBox()
        Me.lblRunnerLname = New System.Windows.Forms.Label()
        Me.lblSchoolCode = New System.Windows.Forms.Label()
        Me.lblRunnerFname = New System.Windows.Forms.Label()
        Me.lblBib = New System.Windows.Forms.Label()
        Me.btnCancelNewRunner = New System.Windows.Forms.Button()
        Me.btnRefreshNewRunner = New System.Windows.Forms.Button()
        Me.btnSaveNewRunner = New System.Windows.Forms.Button()
        Me.grpCommand.SuspendLayout()
        Me.grpBoxFile.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddRunner.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommand
        '
        Me.grpCommand.BackColor = System.Drawing.Color.SteelBlue
        Me.grpCommand.Controls.Add(Me.btnDeleteRunner)
        Me.grpCommand.Controls.Add(Me.btnAddRunners)
        Me.grpCommand.Controls.Add(Me.btnLoadRunners)
        Me.grpCommand.Controls.Add(Me.btnExit)
        Me.grpCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCommand.ForeColor = System.Drawing.Color.White
        Me.grpCommand.Location = New System.Drawing.Point(11, 266)
        Me.grpCommand.Margin = New System.Windows.Forms.Padding(2)
        Me.grpCommand.Name = "grpCommand"
        Me.grpCommand.Padding = New System.Windows.Forms.Padding(2)
        Me.grpCommand.Size = New System.Drawing.Size(560, 56)
        Me.grpCommand.TabIndex = 2
        Me.grpCommand.TabStop = False
        '
        'btnDeleteRunner
        '
        Me.btnDeleteRunner.Enabled = False
        Me.btnDeleteRunner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeleteRunner.Location = New System.Drawing.Point(214, 17)
        Me.btnDeleteRunner.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteRunner.Name = "btnDeleteRunner"
        Me.btnDeleteRunner.Size = New System.Drawing.Size(102, 28)
        Me.btnDeleteRunner.TabIndex = 2
        Me.btnDeleteRunner.Text = "Del. Runners"
        Me.btnDeleteRunner.UseVisualStyleBackColor = True
        '
        'btnAddRunners
        '
        Me.btnAddRunners.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddRunners.Location = New System.Drawing.Point(114, 17)
        Me.btnAddRunners.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddRunners.Name = "btnAddRunners"
        Me.btnAddRunners.Size = New System.Drawing.Size(102, 28)
        Me.btnAddRunners.TabIndex = 1
        Me.btnAddRunners.Text = "Add Runners"
        Me.btnAddRunners.UseVisualStyleBackColor = True
        '
        'btnLoadRunners
        '
        Me.btnLoadRunners.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoadRunners.Location = New System.Drawing.Point(14, 17)
        Me.btnLoadRunners.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoadRunners.Name = "btnLoadRunners"
        Me.btnLoadRunners.Size = New System.Drawing.Size(102, 28)
        Me.btnLoadRunners.TabIndex = 0
        Me.btnLoadRunners.Text = "Load Runners"
        Me.btnLoadRunners.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(439, 17)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 28)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Return"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstPlayers
        '
        Me.lstPlayers.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.ItemHeight = 14
        Me.lstPlayers.Location = New System.Drawing.Point(11, 20)
        Me.lstPlayers.Margin = New System.Windows.Forms.Padding(2)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(430, 116)
        Me.lstPlayers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BIB # | School Code | Runner F-Name | Runner L-Name"
        '
        'grpBoxFile
        '
        Me.grpBoxFile.BackColor = System.Drawing.Color.SteelBlue
        Me.grpBoxFile.Controls.Add(Me.txtFilePath)
        Me.grpBoxFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxFile.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.grpBoxFile.Location = New System.Drawing.Point(342, 212)
        Me.grpBoxFile.Name = "grpBoxFile"
        Me.grpBoxFile.Size = New System.Drawing.Size(230, 49)
        Me.grpBoxFile.TabIndex = 1
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
        Me.PictureBox1.Location = New System.Drawing.Point(446, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'grpAddRunner
        '
        Me.grpAddRunner.BackColor = System.Drawing.Color.SteelBlue
        Me.grpAddRunner.Controls.Add(Me.txtRunnerLname)
        Me.grpAddRunner.Controls.Add(Me.txtSchoolCode)
        Me.grpAddRunner.Controls.Add(Me.txtRunnerFname)
        Me.grpAddRunner.Controls.Add(Me.txtBib)
        Me.grpAddRunner.Controls.Add(Me.lblRunnerLname)
        Me.grpAddRunner.Controls.Add(Me.lblSchoolCode)
        Me.grpAddRunner.Controls.Add(Me.lblRunnerFname)
        Me.grpAddRunner.Controls.Add(Me.lblBib)
        Me.grpAddRunner.Controls.Add(Me.btnCancelNewRunner)
        Me.grpAddRunner.Controls.Add(Me.btnRefreshNewRunner)
        Me.grpAddRunner.Controls.Add(Me.btnSaveNewRunner)
        Me.grpAddRunner.Enabled = False
        Me.grpAddRunner.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddRunner.ForeColor = System.Drawing.Color.White
        Me.grpAddRunner.Location = New System.Drawing.Point(11, 143)
        Me.grpAddRunner.Margin = New System.Windows.Forms.Padding(2)
        Me.grpAddRunner.Name = "grpAddRunner"
        Me.grpAddRunner.Padding = New System.Windows.Forms.Padding(2)
        Me.grpAddRunner.Size = New System.Drawing.Size(560, 119)
        Me.grpAddRunner.TabIndex = 1
        Me.grpAddRunner.TabStop = False
        Me.grpAddRunner.Text = "Add Runner Information"
        Me.grpAddRunner.Visible = False
        '
        'txtRunnerLname
        '
        Me.txtRunnerLname.Location = New System.Drawing.Point(373, 52)
        Me.txtRunnerLname.Name = "txtRunnerLname"
        Me.txtRunnerLname.Size = New System.Drawing.Size(134, 19)
        Me.txtRunnerLname.TabIndex = 3
        '
        'txtSchoolCode
        '
        Me.txtSchoolCode.Location = New System.Drawing.Point(373, 23)
        Me.txtSchoolCode.Name = "txtSchoolCode"
        Me.txtSchoolCode.Size = New System.Drawing.Size(64, 19)
        Me.txtSchoolCode.TabIndex = 1
        '
        'txtRunnerFname
        '
        Me.txtRunnerFname.Location = New System.Drawing.Point(107, 52)
        Me.txtRunnerFname.Name = "txtRunnerFname"
        Me.txtRunnerFname.Size = New System.Drawing.Size(143, 19)
        Me.txtRunnerFname.TabIndex = 2
        '
        'txtBib
        '
        Me.txtBib.Location = New System.Drawing.Point(107, 23)
        Me.txtBib.Name = "txtBib"
        Me.txtBib.Size = New System.Drawing.Size(64, 19)
        Me.txtBib.TabIndex = 0
        '
        'lblRunnerLname
        '
        Me.lblRunnerLname.AutoSize = True
        Me.lblRunnerLname.Location = New System.Drawing.Point(272, 55)
        Me.lblRunnerLname.Name = "lblRunnerLname"
        Me.lblRunnerLname.Size = New System.Drawing.Size(95, 13)
        Me.lblRunnerLname.TabIndex = 3
        Me.lblRunnerLname.Text = "Runner L-Name"
        '
        'lblSchoolCode
        '
        Me.lblSchoolCode.AutoSize = True
        Me.lblSchoolCode.Location = New System.Drawing.Point(288, 26)
        Me.lblSchoolCode.Name = "lblSchoolCode"
        Me.lblSchoolCode.Size = New System.Drawing.Size(79, 13)
        Me.lblSchoolCode.TabIndex = 1
        Me.lblSchoolCode.Text = "School Code"
        '
        'lblRunnerFname
        '
        Me.lblRunnerFname.AutoSize = True
        Me.lblRunnerFname.Location = New System.Drawing.Point(6, 55)
        Me.lblRunnerFname.Name = "lblRunnerFname"
        Me.lblRunnerFname.Size = New System.Drawing.Size(95, 13)
        Me.lblRunnerFname.TabIndex = 2
        Me.lblRunnerFname.Text = "Runner F-Name"
        '
        'lblBib
        '
        Me.lblBib.AutoSize = True
        Me.lblBib.Location = New System.Drawing.Point(62, 26)
        Me.lblBib.Name = "lblBib"
        Me.lblBib.Size = New System.Drawing.Size(39, 13)
        Me.lblBib.TabIndex = 0
        Me.lblBib.Text = "BIB #"
        '
        'btnCancelNewRunner
        '
        Me.btnCancelNewRunner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelNewRunner.Location = New System.Drawing.Point(439, 81)
        Me.btnCancelNewRunner.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelNewRunner.Name = "btnCancelNewRunner"
        Me.btnCancelNewRunner.Size = New System.Drawing.Size(102, 28)
        Me.btnCancelNewRunner.TabIndex = 6
        Me.btnCancelNewRunner.Text = "&Cancel"
        Me.btnCancelNewRunner.UseVisualStyleBackColor = True
        '
        'btnRefreshNewRunner
        '
        Me.btnRefreshNewRunner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefreshNewRunner.Location = New System.Drawing.Point(335, 81)
        Me.btnRefreshNewRunner.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefreshNewRunner.Name = "btnRefreshNewRunner"
        Me.btnRefreshNewRunner.Size = New System.Drawing.Size(102, 28)
        Me.btnRefreshNewRunner.TabIndex = 5
        Me.btnRefreshNewRunner.Text = "re&Fresh"
        Me.btnRefreshNewRunner.UseVisualStyleBackColor = True
        '
        'btnSaveNewRunner
        '
        Me.btnSaveNewRunner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSaveNewRunner.Location = New System.Drawing.Point(232, 81)
        Me.btnSaveNewRunner.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveNewRunner.Name = "btnSaveNewRunner"
        Me.btnSaveNewRunner.Size = New System.Drawing.Size(102, 28)
        Me.btnSaveNewRunner.TabIndex = 4
        Me.btnSaveNewRunner.Text = "&Save"
        Me.btnSaveNewRunner.UseVisualStyleBackColor = True
        '
        'frmRM2000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 333)
        Me.Controls.Add(Me.grpAddRunner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpBoxFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPlayers)
        Me.Controls.Add(Me.grpCommand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRM2000"
        Me.Text = "Race Manager - 2000 - Runner Management - Devin Brite | B.D."
        Me.grpCommand.ResumeLayout(False)
        Me.grpBoxFile.ResumeLayout(False)
        Me.grpBoxFile.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAddRunner.ResumeLayout(False)
        Me.grpAddRunner.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCommand As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAddRunners As System.Windows.Forms.Button
    Friend WithEvents btnLoadRunners As System.Windows.Forms.Button
    Friend WithEvents lstPlayers As System.Windows.Forms.ListBox
    Friend WithEvents btnDeleteRunner As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpBoxFile As System.Windows.Forms.GroupBox
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grpAddRunner As GroupBox
    Friend WithEvents txtRunnerLname As TextBox
    Friend WithEvents txtSchoolCode As TextBox
    Friend WithEvents txtRunnerFname As TextBox
    Friend WithEvents txtBib As TextBox
    Friend WithEvents lblRunnerLname As Label
    Friend WithEvents lblSchoolCode As Label
    Friend WithEvents lblRunnerFname As Label
    Friend WithEvents lblBib As Label
    Friend WithEvents btnCancelNewRunner As Button
    Friend WithEvents btnRefreshNewRunner As Button
    Friend WithEvents btnSaveNewRunner As Button
End Class
