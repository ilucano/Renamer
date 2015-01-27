Imports System
Imports System.IO

Public Class frmMain

    Private _arrFiles() As String
    Private _intCurrent As Integer
    Private _autocomplete As New AutoCompleteStringCollection()
    Private strExt As String

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim lngRC As Long
        lngRC = WritePrivateProfileString("General", "startpath", txtPath.Text, "appinfo.ini")
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                txtFileName.Text = "No Patient"
                btnSave_Click(btnSave, New System.EventArgs)
            Case Keys.F4
                txtFileName.Text = "Verify Name"
                btnSave_Click(btnSave, New System.EventArgs)
            Case Keys.F1
                txtFileName.SelectAll()
            Case Else
                txtFileName.Focus()
        End Select
    End Sub
    Private Sub frmMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim rcl As Integer
        Dim strWork As String

        strWork = New String(Chr(0), 200)

        'Pongo el Output
        rcl = GetPrivateProfileString("General", "startpath", "C:\", strWork, 200, "appinfo.ini")
        If rcl > 0 Then
            txtPath.Text = strWork.Substring(0, rcl)
        Else
            txtPath.Text = "C:\"
        End If
        LoadAutoComplete()
    End Sub
    Private Sub LoadAutoComplete()
        Dim dirF As New DirectoryInfo(txtPath.Text & "\READY\")
        Dim filArr As DirectoryInfo() = dirF.GetDirectories()
        Dim fri As DirectoryInfo

        For Each fri In filArr
            _autocomplete.Add(fri.Name)
        Next fri

        With txtFileName
            .AutoCompleteCustomSource = _autocomplete
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .Location = New Point(20, 20)
            .Width = 240
            .Visible = True
        End With

    End Sub
    Private Sub btnExam_Click(sender As Object, e As EventArgs) Handles btnExam.Click
        fldB.SelectedPath = txtPath.Text
        If fldB.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtPath.Text = fldB.SelectedPath
        End If
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If sender.Text = "Start" Then
            grpLocation.Enabled = False
            grpBox.Enabled = True
            sender.Text = "Stop"
            Me.AcceptButton = btnSave
            GetAllFiles()
            GetNextFile()
            Application.DoEvents()
            lblStatus.Text = "File " & _intCurrent & " of " & (_arrFiles.Count - 1)
            txtFileName.Focus()
        Else
            grpLocation.Enabled = True
            grpBox.Enabled = False
            Me.AcceptButton = btnStart
            sender.Text = "Start"
        End If
    End Sub
    Private Sub GetAllFiles()
        Dim dirF As New DirectoryInfo(txtPath.Text)
        Dim filArr As FileInfo() = dirF.GetFiles("*" & strExt)
        Dim fri As FileInfo
        Dim _int As Integer

        ReDim _arrFiles(filArr.Count - 1)
        For Each fri In filArr
            _arrFiles(_int) = fri.FullName
            _int += 1
        Next fri
    End Sub
    Private Sub GetNextFile()
        txtFileName.Text = ""
        If My.Computer.FileSystem.DirectoryExists(txtPath.Text) Then
            If _intCurrent <= (_arrFiles.Count - 1) Then
                If chkPutFilename.Checked = True Then
                    txtFileName.Text = IO.Path.GetFileNameWithoutExtension(_arrFiles(_intCurrent))
                End If
                'pdfV.LoadFile(_arrFiles(_intCurrent))
                web.Navigate(_arrFiles(_intCurrent))
                lblStatus.Text = "File " & _intCurrent & " of " & (_arrFiles.Count - 1)
            Else
                MessageBox.Show("No More Files", "imagingXperts LLC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnStart_Click(btnStart, New System.EventArgs)
            End If
        Else
            MessageBox.Show("The selected Directory not Exists", "imagingXperts LLC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strNewName As String

        strNewName = StrConv(txtFileName.Text, VbStrConv.ProperCase).Trim
        ' Mover el archivo a la carpeta READY
        Dim strPath As String
        If strNewName.Length > 3 Then
            If chkCreate.Checked = True Then
                strPath = txtPath.Text & "\READY\" & strNewName & "\"
            Else
                strPath = txtPath.Text & "\READY\"
            End If

            ' Si no existe el directorio lo creo
            If Not My.Computer.FileSystem.DirectoryExists(strPath) = True Then
                My.Computer.FileSystem.CreateDirectory(strPath)
            End If

            ' Si ya hay un archivo Igual le agrego un nro
            If My.Computer.FileSystem.FileExists(strPath & strNewName & strExt) = True Then
                Dim intCnt As Integer = 1
                Do Until Not (My.Computer.FileSystem.FileExists(strPath & strNewName & " " & intCnt & strExt))
                    intCnt += 1
                Loop
                My.Computer.FileSystem.MoveFile(_arrFiles(_intCurrent), strPath & strNewName & " " & intCnt & strExt, False)
            Else
                My.Computer.FileSystem.MoveFile(_arrFiles(_intCurrent), strPath & strNewName & ".pdf", False)
            End If
            _autocomplete.Add(strNewName)
            _intCurrent += 1
            GetNextFile()
            Application.DoEvents()
            txtFileName.Focus()
        Else
            MessageBox.Show("The Patient name must be greater than 3 chars", "imagingXperts LLC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtFileName_LostFocus(sender As Object, e As EventArgs) Handles txtFileName.LostFocus
        Dim currentTextBox As TextBox = DirectCast(sender, TextBox)
        'Set the text of the generic textbox to Proper Case
        currentTextBox.Text = StrConv(currentTextBox.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub pdfV_GotFocus(sender As Object, e As EventArgs)
        txtFileName.Focus()
    End Sub

    Private Sub web_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles web.DocumentCompleted
        txtFileName.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure to delete file?", "imagingXperts LLC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            If My.Computer.FileSystem.FileExists(_arrFiles(_intCurrent)) = True Then
                My.Computer.FileSystem.DeleteFile(_arrFiles(_intCurrent))
            End If
            _intCurrent += 1
            GetNextFile()
            Application.DoEvents()
        End If
        txtFileName.Focus()
    End Sub

    Private Sub web_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles web.PreviewKeyDown
        Select Case e.KeyCode
            Case Keys.F5
                txtFileName.Text = "No Patient"
                btnSave_Click(btnSave, New System.EventArgs)
            Case Keys.F4
                txtFileName.Text = "Verify Name"
                btnSave_Click(btnSave, New System.EventArgs)
            Case Keys.F1
                txtFileName.SelectAll()
            Case Else
                txtFileName.Focus()
        End Select
    End Sub

    Private Sub btnLoadF_Click(sender As Object, e As EventArgs) Handles btnLoadF.Click
        If My.Computer.FileSystem.FileExists(txtPath.Text & "\listado.txt") Then
            Dim objReader As New System.IO.StreamReader(txtPath.Text & "\listado.txt")

            Do While objReader.Peek() <> -1
                _autocomplete.Add(objReader.ReadLine())
            Loop

        End If
    End Sub

    Private Sub btnSaveF_Click(sender As Object, e As EventArgs) Handles btnSaveF.Click
        If My.Computer.FileSystem.FileExists(txtPath.Text & "\listado.txt") Then
            If MessageBox.Show("Are you sure to overwrite this file?", "imagingXperts LLC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                SaveAutocomplete()
            End If
        Else
            SaveAutocomplete()
        End If
    End Sub
    Public Sub SaveAutocomplete()
        Dim objWriter As New System.IO.StreamWriter(txtPath.Text & "\listado.txt", False)

        For Each obj In _autocomplete
            objWriter.WriteLine(obj.ToString)
        Next
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.SelectedText = "PDF" Then
            strExt = ".pdf"
        Else
            strExt = ".tif"
        End If
    End Sub
End Class
