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
        Me.splitC = New System.Windows.Forms.SplitContainer()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.chkFoldorFiles = New System.Windows.Forms.CheckBox()
        Me.chkCreate = New System.Windows.Forms.CheckBox()
        Me.btnExam = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.web = New System.Windows.Forms.WebBrowser()
        Me.fldB = New System.Windows.Forms.FolderBrowserDialog()
        Me.chkPutFilename = New System.Windows.Forms.CheckBox()
        CType(Me.splitC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitC.Panel1.SuspendLayout()
        Me.splitC.Panel2.SuspendLayout()
        Me.splitC.SuspendLayout()
        Me.grpBox.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitC
        '
        Me.splitC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitC.Location = New System.Drawing.Point(0, 0)
        Me.splitC.Name = "splitC"
        '
        'splitC.Panel1
        '
        Me.splitC.Panel1.Controls.Add(Me.grpBox)
        Me.splitC.Panel1.Controls.Add(Me.btnStart)
        Me.splitC.Panel1.Controls.Add(Me.grpLocation)
        '
        'splitC.Panel2
        '
        Me.splitC.Panel2.Controls.Add(Me.web)
        Me.splitC.Size = New System.Drawing.Size(828, 666)
        Me.splitC.SplitterDistance = 268
        Me.splitC.TabIndex = 0
        '
        'grpBox
        '
        Me.grpBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBox.Controls.Add(Me.btnSave)
        Me.grpBox.Controls.Add(Me.txtFileName)
        Me.grpBox.Enabled = False
        Me.grpBox.Location = New System.Drawing.Point(12, 211)
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
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.Location = New System.Drawing.Point(6, 29)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(233, 20)
        Me.txtFileName.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(162, 172)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(89, 33)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'grpLocation
        '
        Me.grpLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLocation.Controls.Add(Me.chkPutFilename)
        Me.grpLocation.Controls.Add(Me.chkFoldorFiles)
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
        'chkFoldorFiles
        '
        Me.chkFoldorFiles.AutoSize = True
        Me.chkFoldorFiles.Checked = True
        Me.chkFoldorFiles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFoldorFiles.Location = New System.Drawing.Point(6, 106)
        Me.chkFoldorFiles.Name = "chkFoldorFiles"
        Me.chkFoldorFiles.Size = New System.Drawing.Size(99, 17)
        Me.chkFoldorFiles.TabIndex = 3
        Me.chkFoldorFiles.Text = "Are Documents"
        Me.chkFoldorFiles.UseVisualStyleBackColor = True
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
        Me.web.Dock = System.Windows.Forms.DockStyle.Fill
        Me.web.Location = New System.Drawing.Point(0, 0)
        Me.web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.web.Name = "web"
        Me.web.Size = New System.Drawing.Size(556, 666)
        Me.web.TabIndex = 0
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 666)
        Me.Controls.Add(Me.splitC)
        Me.Name = "frmMain"
        Me.Text = "imagingXperts Renamer"
        Me.splitC.Panel1.ResumeLayout(False)
        Me.splitC.Panel2.ResumeLayout(False)
        CType(Me.splitC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitC.ResumeLayout(False)
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splitC As System.Windows.Forms.SplitContainer
    Friend WithEvents web As System.Windows.Forms.WebBrowser
    Friend WithEvents grpBox As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents grpLocation As System.Windows.Forms.GroupBox
    Friend WithEvents chkFoldorFiles As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreate As System.Windows.Forms.CheckBox
    Friend WithEvents btnExam As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents fldB As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkPutFilename As System.Windows.Forms.CheckBox

End Class
