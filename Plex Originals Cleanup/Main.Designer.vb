<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbxDirectory = New System.Windows.Forms.TextBox()
        Me.clbList = New System.Windows.Forms.CheckedListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSelectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(752, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MS_Application"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "FIle"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 281)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(131, 23)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select Starting Directory"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblDirectory
        '
        Me.lblDirectory.AutoSize = True
        Me.lblDirectory.Location = New System.Drawing.Point(13, 30)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(91, 13)
        Me.lblDirectory.TabIndex = 3
        Me.lblDirectory.Text = "Starting Directory:"
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(150, 282)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(75, 23)
        Me.btnGet.TabIndex = 4
        Me.btnGet.Text = "Get Items"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(232, 282)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(105, 23)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove Selected"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(344, 282)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbxDirectory
        '
        Me.tbxDirectory.Location = New System.Drawing.Point(110, 27)
        Me.tbxDirectory.Name = "tbxDirectory"
        Me.tbxDirectory.ReadOnly = True
        Me.tbxDirectory.Size = New System.Drawing.Size(630, 20)
        Me.tbxDirectory.TabIndex = 7
        '
        'clbList
        '
        Me.clbList.CheckOnClick = True
        Me.clbList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.clbList.FormattingEnabled = True
        Me.clbList.Location = New System.Drawing.Point(12, 53)
        Me.clbList.Name = "clbList"
        Me.clbList.Size = New System.Drawing.Size(728, 214)
        Me.clbList.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.ClearSelectionsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 48)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ClearSelectionsToolStripMenuItem
        '
        Me.ClearSelectionsToolStripMenuItem.Name = "ClearSelectionsToolStripMenuItem"
        Me.ClearSelectionsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ClearSelectionsToolStripMenuItem.Text = "Clear Selections"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 315)
        Me.Controls.Add(Me.clbList)
        Me.Controls.Add(Me.tbxDirectory)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.lblDirectory)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Plex Originals Cleanup"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblDirectory As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnGet As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbxDirectory As TextBox
    Friend WithEvents clbList As CheckedListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSelectionsToolStripMenuItem As ToolStripMenuItem
End Class
