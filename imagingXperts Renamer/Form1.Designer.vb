<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.rdFolders = New System.Windows.Forms.RadioButton()
        Me.rdDocs = New System.Windows.Forms.RadioButton()
        Me.chkPutFilename = New System.Windows.Forms.CheckBox()
        Me.chkCreate = New System.Windows.Forms.CheckBox()
        Me.btnExam = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.fldB = New System.Windows.Forms.FolderBrowserDialog()
        Me.web = New System.Windows.Forms.WebBrowser()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnSaveF = New System.Windows.Forms.Button()
        Me.btnLoadF = New System.Windows.Forms.Button()
        Me.grpBox.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.btnSave)
        Me.grpBox.Controls.Add(Me.txtFileName)
        Me.grpBox.Enabled = False
        Me.grpBox.Location = New System.Drawing.Point(12, 235)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(245, 97)
        Me.grpBox.TabIndex = 4
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Names"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(150, 55)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 33)
        Me.btnSave.TabIndex = 5
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFileName.Location = New System.Drawing.Point(6, 29)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(233, 20)
        Me.txtFileName.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(162, 172)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(89, 33)
        Me.btnStart.TabIndex = 3
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.rdFolders)
        Me.grpLocation.Controls.Add(Me.rdDocs)
        Me.grpLocation.Controls.Add(Me.chkPutFilename)
        Me.grpLocation.Controls.Add(Me.chkCreate)
        Me.grpLocation.Controls.Add(Me.btnExam)
        Me.grpLocation.Controls.Add(Me.txtPath)
        Me.grpLocation.Location = New System.Drawing.Point(12, 12)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(245, 154)
        Me.grpLocation.TabIndex = 2
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Location"
        '
        'rdFolders
        '
        Me.rdFolders.AutoSize = True
        Me.rdFolders.Enabled = False
        Me.rdFolders.Location = New System.Drawing.Point(103, 106)
        Me.rdFolders.Name = "rdFolders"
        Me.rdFolders.Size = New System.Drawing.Size(59, 17)
        Me.rdFolders.TabIndex = 6
        Me.rdFolders.Text = "Folders"
        Me.rdFolders.UseVisualStyleBackColor = True
        '
        'rdDocs
        '
        Me.rdDocs.AutoSize = True
        Me.rdDocs.Checked = True
        Me.rdDocs.Enabled = False
        Me.rdDocs.Location = New System.Drawing.Point(6, 106)
        Me.rdDocs.Name = "rdDocs"
        Me.rdDocs.Size = New System.Drawing.Size(79, 17)
        Me.rdDocs.TabIndex = 5
        Me.rdDocs.TabStop = True
        Me.rdDocs.Text = "Documents"
        Me.rdDocs.UseVisualStyleBackColor = True
        '
        'chkPutFilename
        '
        Me.chkPutFilename.AutoSize = True
        Me.chkPutFilename.Location = New System.Drawing.Point(6, 131)
        Me.chkPutFilename.Name = "chkPutFilename"
        Me.chkPutFilename.Size = New System.Drawing.Size(119, 17)
        Me.chkPutFilename.TabIndex = 4
        Me.chkPutFilename.Text = "Filename as Default"
        Me.chkPutFilename.UseVisualStyleBackColor = True
        '
        'chkCreate
        '
        Me.chkCreate.AutoSize = True
        Me.chkCreate.Checked = True
        Me.chkCreate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCreate.Location = New System.Drawing.Point(6, 83)
        Me.chkCreate.Name = "chkCreate"
        Me.chkCreate.Size = New System.Drawing.Size(125, 17)
        Me.chkCreate.TabIndex = 2
        Me.chkCreate.Text = "Create Patient Folder"
        Me.chkCreate.UseVisualStyleBackColor = True
        '
        'btnExam
        '
        Me.btnExam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExam.Location = New System.Drawing.Point(150, 45)
        Me.btnExam.Name = "btnExam"
        Me.btnExam.Size = New System.Drawing.Size(89, 33)
        Me.btnExam.TabIndex = 1
        Me.btnExam.Text = "Browse"
        Me.btnExam.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Location = New System.Drawing.Point(6, 19)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(233, 20)
        Me.txtPath.TabIndex = 0
        '
        'web
        '
        Me.web.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.web.Location = New System.Drawing.Point(272, 0)
        Me.web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.web.Name = "web"
        Me.web.Size = New System.Drawing.Size(558, 662)
        Me.web.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(162, 360)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 33)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "Delete File"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(15, 213)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 7
        '
        'btnSaveF
        '
        Me.btnSaveF.Location = New System.Drawing.Point(162, 459)
        Me.btnSaveF.Name = "btnSaveF"
        Me.btnSaveF.Size = New System.Drawing.Size(89, 33)
        Me.btnSaveF.TabIndex = 8
        Me.btnSaveF.TabStop = False
        Me.btnSaveF.Text = "Save File"
        Me.btnSaveF.UseVisualStyleBackColor = True
        '
        'btnLoadF
        '
        Me.btnLoadF.Location = New System.Drawing.Point(67, 459)
        Me.btnLoadF.Name = "btnLoadF"
        Me.btnLoadF.Size = New System.Drawing.Size(89, 33)
        Me.btnLoadF.TabIndex = 9
        Me.btnLoadF.TabStop = False
        Me.btnLoadF.Text = "Load File"
        Me.btnLoadF.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 666)
        Me.Controls.Add(Me.btnLoadF)
        Me.Controls.Add(Me.btnSaveF)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.web)
        Me.Controls.Add(Me.grpBox)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grpLocation)
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.Text = "imagingXperts Renamer"
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBox As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents grpLocation As System.Windows.Forms.GroupBox
    Friend WithEvents chkCreate As System.Windows.Forms.CheckBox
    Friend WithEvents btnExam As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents fldB As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkPutFilename As System.Windows.Forms.CheckBox
    Friend WithEvents rdFolders As System.Windows.Forms.RadioButton
    Friend WithEvents rdDocs As System.Windows.Forms.RadioButton
    Friend WithEvents web As System.Windows.Forms.WebBrowser
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnSaveF As System.Windows.Forms.Button
    Friend WithEvents btnLoadF As System.Windows.Forms.Button

End Class
