Imports System.IO

Public Class Main
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        clbList.Items.Clear()
        btnGet.Enabled = False
        btnRemove.Enabled = False
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            tbxDirectory.Text = FolderBrowserDialog1.SelectedPath
        Else
            Exit Sub
        End If
        If tbxDirectory.Text <> "" Then btnGet.Enabled = True
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        Cursor = Cursors.WaitCursor
        DirSearch(tbxDirectory.Text)
        If clbList.Items.Count = 0 Then
            MsgBox("No Items Found", vbOKOnly, "Item Search")
        End If
        Cursor = Cursors.Default
        If clbList.Items.Count > 0 Then btnRemove.Enabled = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For Each item In clbList.CheckedItems
            'MsgBox(Path.Combine(tbxDirectory.Text, item))
            File.Delete(tbxDirectory.Text & "\" & item)
        Next
        Do While clbList.CheckedItems.Count > 0
            clbList.Items.Remove(clbList.CheckedItems(0))
        Loop
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub


    Sub DirSearch(ByVal sDir As String)
        Dim objDir As String
        Dim objFile As String
        Dim arrTypes(7) As String

        arrTypes(0) = "*-behindthescenes.mkv"
        arrTypes(1) = "*-deleted.mkv"
        arrTypes(2) = "*-featurette.mkv"
        arrTypes(3) = "*-interview.mkv"
        arrTypes(4) = "*-scene.mkv"
        arrTypes(5) = "*-Short.mkv"
        arrTypes(6) = "*-trailer.mkv"
        arrTypes(7) = "*-other.mkv"

        Try
            For Each objDir In Directory.GetDirectories(sDir)
                For i = 0 To UBound(arrTypes)
                    For Each objFile In Directory.GetFiles(objDir, arrTypes(i))
                        clbList.Items.Add(Mid(objFile, Len(sDir) + 2))
                    Next
                    DirSearch(objDir)
                Next
            Next
        Catch excpt As System.Exception
            Debug.WriteLine(excpt.Message)
        End Try
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        For i As Integer = 0 To clbList.Items.Count - 1
            clbList.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub ClearSelectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSelectionsToolStripMenuItem.Click
        For i As Integer = 0 To clbList.Items.Count - 1
            clbList.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnGet.Enabled = False
        btnRemove.Enabled = False
    End Sub
End Class
