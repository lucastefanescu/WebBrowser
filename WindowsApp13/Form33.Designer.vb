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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivateWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookmarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripNavigator = New System.Windows.Forms.ToolStrip()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnForward = New System.Windows.Forms.ToolStripButton()
        Me.txtUrl = New System.Windows.Forms.ToolStripTextBox()
        Me.btnReload = New System.Windows.Forms.ToolStripButton()
        Me.cmbSearchEngines = New System.Windows.Forms.ToolStripComboBox()
        Me.txtUrlSearchEngines = New System.Windows.Forms.ToolStripTextBox()
        Me.btnDownloads = New System.Windows.Forms.ToolStripButton()
        Me.BtnHome = New System.Windows.Forms.ToolStripButton()
        Me.btnVolumeDown = New System.Windows.Forms.ToolStripButton()
        Me.btnVolumeUp = New System.Windows.Forms.ToolStripButton()
        Me.lblDate = New System.Windows.Forms.ToolStripLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tmrdate = New System.Windows.Forms.Timer(Me.components)
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.lstUrl = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.toolstripNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.BookmarksToolStripMenuItem, Me.HistoryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1498, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.NewTabToolStripMenuItem, Me.CloseTabToolStripMenuItem, Me.PrivateWindowToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.ExitToolStripMenuItem, Me.toolStripSeparator2})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.NewWindowToolStripMenuItem.Text = "New &Window"
        '
        'NewTabToolStripMenuItem
        '
        Me.NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        Me.NewTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.NewTabToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.NewTabToolStripMenuItem.Text = "New &Tab"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.CloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'PrivateWindowToolStripMenuItem
        '
        Me.PrivateWindowToolStripMenuItem.Name = "PrivateWindowToolStripMenuItem"
        Me.PrivateWindowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PrivateWindowToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.PrivateWindowToolStripMenuItem.Text = "Pri&vate Window"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(227, 6)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(227, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(227, 6)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.ToolsToolStripMenuItem.Text = "&Advanced Options "
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'BookmarksToolStripMenuItem
        '
        Me.BookmarksToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem"
        Me.BookmarksToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.BookmarksToolStripMenuItem.Text = "&Bookmarks"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.HistoryToolStripMenuItem.Text = "&History"
        '
        'toolstripNavigator
        '
        Me.toolstripNavigator.BackColor = System.Drawing.Color.SkyBlue
        Me.toolstripNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnForward, Me.txtUrl, Me.btnReload, Me.cmbSearchEngines, Me.txtUrlSearchEngines, Me.btnDownloads, Me.BtnHome, Me.btnVolumeDown, Me.btnVolumeUp, Me.lblDate})
        Me.toolstripNavigator.Location = New System.Drawing.Point(0, 24)
        Me.toolstripNavigator.Name = "toolstripNavigator"
        Me.toolstripNavigator.Size = New System.Drawing.Size(1498, 33)
        Me.toolstripNavigator.TabIndex = 1
        Me.toolstripNavigator.Text = "ToolStrip1"
        '
        'btnBack
        '
        Me.btnBack.AutoSize = False
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.WindowsApp13.My.Resources.Resources.iconfinder_Back_32435
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 30)
        Me.btnBack.Text = "ToolStripButton1"
        '
        'btnForward
        '
        Me.btnForward.AutoSize = False
        Me.btnForward.BackColor = System.Drawing.Color.Transparent
        Me.btnForward.BackgroundImage = Global.WindowsApp13.My.Resources.Resources.iconfinder_Forward_32479
        Me.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnForward.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(50, 30)
        Me.btnForward.Text = "ToolStripButton2"
        '
        'txtUrl
        '
        Me.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUrl.AutoSize = False
        Me.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(500, 23)
        '
        'btnReload
        '
        Me.btnReload.AutoSize = False
        Me.btnReload.BackColor = System.Drawing.Color.Transparent
        Me.btnReload.BackgroundImage = Global.WindowsApp13.My.Resources.Resources.iconfinder_Refresh_32541
        Me.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReload.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(50, 30)
        Me.btnReload.Text = "ToolStripButton3"
        '
        'cmbSearchEngines
        '
        Me.cmbSearchEngines.AutoSize = False
        Me.cmbSearchEngines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchEngines.Margin = New System.Windows.Forms.Padding(30, 0, 1, 0)
        Me.cmbSearchEngines.Name = "cmbSearchEngines"
        Me.cmbSearchEngines.Size = New System.Drawing.Size(90, 23)
        '
        'txtUrlSearchEngines
        '
        Me.txtUrlSearchEngines.AutoSize = False
        Me.txtUrlSearchEngines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUrlSearchEngines.Margin = New System.Windows.Forms.Padding(8, 0, 1, 0)
        Me.txtUrlSearchEngines.Name = "txtUrlSearchEngines"
        Me.txtUrlSearchEngines.Size = New System.Drawing.Size(100, 23)
        '
        'btnDownloads
        '
        Me.btnDownloads.AutoSize = False
        Me.btnDownloads.BackColor = System.Drawing.Color.Transparent
        Me.btnDownloads.BackgroundImage = Global.WindowsApp13.My.Resources.Resources.iconfinder_Down_32460
        Me.btnDownloads.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDownloads.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDownloads.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDownloads.Margin = New System.Windows.Forms.Padding(30, 1, 0, 2)
        Me.btnDownloads.Name = "btnDownloads"
        Me.btnDownloads.Size = New System.Drawing.Size(50, 30)
        Me.btnDownloads.Text = "ToolStripButton5"
        '
        'BtnHome
        '
        Me.BtnHome.AutoSize = False
        Me.BtnHome.BackColor = System.Drawing.Color.Transparent
        Me.BtnHome.BackgroundImage = Global.WindowsApp13.My.Resources.Resources.iconfinder_Home_32491
        Me.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(50, 30)
        Me.BtnHome.Text = "ToolStripButton4"
        '
        'btnVolumeDown
        '
        Me.btnVolumeDown.AutoSize = False
        Me.btnVolumeDown.BackColor = System.Drawing.Color.Transparent
        Me.btnVolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolumeDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVolumeDown.Image = Global.WindowsApp13.My.Resources.Resources.iconfinder_volume_down_3671907
        Me.btnVolumeDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVolumeDown.Name = "btnVolumeDown"
        Me.btnVolumeDown.Size = New System.Drawing.Size(50, 30)
        Me.btnVolumeDown.Text = "ToolStripButton1"
        '
        'btnVolumeUp
        '
        Me.btnVolumeUp.AutoSize = False
        Me.btnVolumeUp.BackColor = System.Drawing.Color.Transparent
        Me.btnVolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolumeUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVolumeUp.Image = Global.WindowsApp13.My.Resources.Resources.iconfinder_volume_up_3671909
        Me.btnVolumeUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVolumeUp.Name = "btnVolumeUp"
        Me.btnVolumeUp.Size = New System.Drawing.Size(50, 30)
        Me.btnVolumeUp.Text = "ToolStripButton2"
        '
        'lblDate
        '
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 30)
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1498, 726)
        Me.TabControl1.TabIndex = 2
        '
        'tmrdate
        '
        Me.tmrdate.Enabled = True
        Me.tmrdate.Interval = 1
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.Location = New System.Drawing.Point(607, 0)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(120, 95)
        Me.lstName.TabIndex = 3
        '
        'lstUrl
        '
        Me.lstUrl.FormattingEnabled = True
        Me.lstUrl.Location = New System.Drawing.Point(723, 0)
        Me.lstUrl.Name = "lstUrl"
        Me.lstUrl.Size = New System.Drawing.Size(120, 95)
        Me.lstUrl.TabIndex = 4
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(840, 0)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 758)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1498, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 783)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.lstUrl)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.toolstripNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Escape"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.toolstripNavigator.ResumeLayout(False)
        Me.toolstripNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrivateWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookmarksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolstripNavigator As ToolStrip
    Friend WithEvents btnForward As ToolStripButton
    Friend WithEvents txtUrl As ToolStripTextBox
    Friend WithEvents btnReload As ToolStripButton
    Friend WithEvents cmbSearchEngines As ToolStripComboBox
    Friend WithEvents txtUrlSearchEngines As ToolStripTextBox
    Friend WithEvents btnDownloads As ToolStripButton
    Friend WithEvents BtnHome As ToolStripButton
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnVolumeDown As ToolStripButton
    Friend WithEvents btnVolumeUp As ToolStripButton
    Friend WithEvents lblDate As ToolStripLabel
    Friend WithEvents tmrdate As Timer
    Friend WithEvents CloseTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstName As ListBox
    Friend WithEvents lstUrl As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
