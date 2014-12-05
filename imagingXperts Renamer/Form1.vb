Imports System
Imports System.IO

Public Class frmMain

    Private _arrFiles() As String
    Private _intCurrent As Integer

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim lngRC As Long
        lngRC = WritePrivateProfileString("General", "startpath", txtPath.Text, "appinfo.ini")
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
            GetAllFiles()
            GetNextFile()
        Else
            grpLocation.Enabled = True
            grpBox.Enabled = False
            sender.Text = "Start"
        End If
    End Sub
    Private Sub GetAllFiles()
        Dim dirF As New DirectoryInfo(txtPath.Text)
        Dim filArr As FileInfo() = dirF.GetFiles("*.pdf")
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
                web.Navigate(_arrFiles(_intCurrent))
            Else
                MessageBox.Show("No More Files", "imagingXperts LLC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnStart_Click(btnStart, New System.EventArgs)
            End If
        Else
            MessageBox.Show("The selected Directory not Exists", "imagingXperts LLC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Mover el archivo a la carpeta READY
        Dim strPath As String
        If txtFileName.Text.Trim.Length > 3 Then
            If chkCreate.Checked = True Then
                strPath = txtPath.Text & "\READY\" & txtPath.Text & "\"
            Else
                strPath = txtPath.Text & "\READY\"
            End If
        Else
            MessageBox.Show("The Patient name must be greater than 3 chars", "imagingXperts LLC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
