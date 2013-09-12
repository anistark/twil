<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WebsitePropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutTwilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.cmbsearch = New System.Windows.Forms.ComboBox
        Me.lblport = New System.Windows.Forms.Label
        Me.lblproxy = New System.Windows.Forms.Label
        Me.Txtport = New System.Windows.Forms.TextBox
        Me.Txtproxy = New System.Windows.Forms.TextBox
        Me.ButtonProxy = New System.Windows.Forms.Button
        Me.ButtonHome = New System.Windows.Forms.Button
        Me.ButtonStop = New System.Windows.Forms.Button
        Me.ButtonGo = New System.Windows.Forms.Button
        Me.Cmbaddress = New System.Windows.Forms.ComboBox
        Me.ButtonRefresh = New System.Windows.Forms.Button
        Me.ButtonForward = New System.Windows.Forms.Button
        Me.ButtonBack = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButtonAddTab = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonRemoveTab = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonHistory = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonPageSetup = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 661)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1238, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(107, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStausLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1238, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTabToolStripMenuItem, Me.RemoveTabToolStripMenuItem, Me.WebsitePropertiesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddTabToolStripMenuItem
        '
        Me.AddTabToolStripMenuItem.Name = "AddTabToolStripMenuItem"
        Me.AddTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.AddTabToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AddTabToolStripMenuItem.Text = "Add Tab"
        '
        'RemoveTabToolStripMenuItem
        '
        Me.RemoveTabToolStripMenuItem.Name = "RemoveTabToolStripMenuItem"
        Me.RemoveTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.RemoveTabToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.RemoveTabToolStripMenuItem.Text = "Remove Tab"
        '
        'WebsitePropertiesToolStripMenuItem
        '
        Me.WebsitePropertiesToolStripMenuItem.Name = "WebsitePropertiesToolStripMenuItem"
        Me.WebsitePropertiesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.WebsitePropertiesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.WebsitePropertiesToolStripMenuItem.Text = "Website Properties"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTwilToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutTwilToolStripMenuItem
        '
        Me.AboutTwilToolStripMenuItem.Name = "AboutTwilToolStripMenuItem"
        Me.AboutTwilToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutTwilToolStripMenuItem.Text = "About Twil"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(0, 98)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1238, 563)
        Me.TabControl1.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonSearch)
        Me.Panel1.Controls.Add(Me.cmbsearch)
        Me.Panel1.Controls.Add(Me.lblport)
        Me.Panel1.Controls.Add(Me.lblproxy)
        Me.Panel1.Controls.Add(Me.Txtport)
        Me.Panel1.Controls.Add(Me.Txtproxy)
        Me.Panel1.Controls.Add(Me.ButtonProxy)
        Me.Panel1.Controls.Add(Me.ButtonHome)
        Me.Panel1.Controls.Add(Me.ButtonStop)
        Me.Panel1.Controls.Add(Me.ButtonGo)
        Me.Panel1.Controls.Add(Me.Cmbaddress)
        Me.Panel1.Controls.Add(Me.ButtonRefresh)
        Me.Panel1.Controls.Add(Me.ButtonForward)
        Me.Panel1.Controls.Add(Me.ButtonBack)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1238, 46)
        Me.Panel1.TabIndex = 12
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Image = CType(resources.GetObject("ButtonSearch.Image"), System.Drawing.Image)
        Me.ButtonSearch.Location = New System.Drawing.Point(926, 8)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(30, 29)
        Me.ButtonSearch.TabIndex = 13
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'cmbsearch
        '
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Location = New System.Drawing.Point(777, 8)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(143, 21)
        Me.cmbsearch.TabIndex = 12
        '
        'lblport
        '
        Me.lblport.AutoSize = True
        Me.lblport.Location = New System.Drawing.Point(993, 28)
        Me.lblport.Name = "lblport"
        Me.lblport.Size = New System.Drawing.Size(26, 13)
        Me.lblport.TabIndex = 11
        Me.lblport.Text = "Port"
        '
        'lblproxy
        '
        Me.lblproxy.AutoSize = True
        Me.lblproxy.Location = New System.Drawing.Point(989, 8)
        Me.lblproxy.Name = "lblproxy"
        Me.lblproxy.Size = New System.Drawing.Size(33, 13)
        Me.lblproxy.TabIndex = 10
        Me.lblproxy.Text = "Proxy"
        '
        'Txtport
        '
        Me.Txtport.Location = New System.Drawing.Point(1038, 27)
        Me.Txtport.Name = "Txtport"
        Me.Txtport.Size = New System.Drawing.Size(134, 20)
        Me.Txtport.TabIndex = 9
        '
        'Txtproxy
        '
        Me.Txtproxy.Location = New System.Drawing.Point(1038, 4)
        Me.Txtproxy.Name = "Txtproxy"
        Me.Txtproxy.Size = New System.Drawing.Size(137, 20)
        Me.Txtproxy.TabIndex = 8
        '
        'ButtonProxy
        '
        Me.ButtonProxy.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonProxy.Location = New System.Drawing.Point(1181, 4)
        Me.ButtonProxy.Name = "ButtonProxy"
        Me.ButtonProxy.Size = New System.Drawing.Size(54, 39)
        Me.ButtonProxy.TabIndex = 7
        Me.ButtonProxy.Text = "Set Proxy"
        Me.ButtonProxy.UseVisualStyleBackColor = False
        '
        'ButtonHome
        '
        Me.ButtonHome.Image = CType(resources.GetObject("ButtonHome.Image"), System.Drawing.Image)
        Me.ButtonHome.Location = New System.Drawing.Point(194, 6)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(34, 34)
        Me.ButtonHome.TabIndex = 6
        Me.ButtonHome.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.Image = CType(resources.GetObject("ButtonStop.Image"), System.Drawing.Image)
        Me.ButtonStop.Location = New System.Drawing.Point(157, 4)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(31, 31)
        Me.ButtonStop.TabIndex = 5
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ButtonGo
        '
        Me.ButtonGo.Image = CType(resources.GetObject("ButtonGo.Image"), System.Drawing.Image)
        Me.ButtonGo.Location = New System.Drawing.Point(712, 4)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(44, 39)
        Me.ButtonGo.TabIndex = 4
        Me.ButtonGo.UseVisualStyleBackColor = True
        '
        'Cmbaddress
        '
        Me.Cmbaddress.FormattingEnabled = True
        Me.Cmbaddress.Location = New System.Drawing.Point(234, 13)
        Me.Cmbaddress.Name = "Cmbaddress"
        Me.Cmbaddress.Size = New System.Drawing.Size(472, 21)
        Me.Cmbaddress.TabIndex = 3
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Image = CType(resources.GetObject("ButtonRefresh.Image"), System.Drawing.Image)
        Me.ButtonRefresh.Location = New System.Drawing.Point(107, 4)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(44, 39)
        Me.ButtonRefresh.TabIndex = 2
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonForward
        '
        Me.ButtonForward.Image = CType(resources.GetObject("ButtonForward.Image"), System.Drawing.Image)
        Me.ButtonForward.Location = New System.Drawing.Point(60, 3)
        Me.ButtonForward.Name = "ButtonForward"
        Me.ButtonForward.Size = New System.Drawing.Size(41, 39)
        Me.ButtonForward.TabIndex = 1
        Me.ButtonForward.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.Image = CType(resources.GetObject("ButtonBack.Image"), System.Drawing.Image)
        Me.ButtonBack.Location = New System.Drawing.Point(13, 3)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(41, 40)
        Me.ButtonBack.TabIndex = 0
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonAddTab, Me.ToolStripButtonRemoveTab, Me.ToolStripSeparator1, Me.ToolStripButtonHistory, Me.ToolStripSeparator2, Me.ToolStripButtonPrint, Me.ToolStripButtonPrintPreview, Me.ToolStripButtonPageSetup})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 70)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1238, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonAddTab
        '
        Me.ToolStripButtonAddTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAddTab.Image = CType(resources.GetObject("ToolStripButtonAddTab.Image"), System.Drawing.Image)
        Me.ToolStripButtonAddTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAddTab.Name = "ToolStripButtonAddTab"
        Me.ToolStripButtonAddTab.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonAddTab.Text = "Add Tab"
        '
        'ToolStripButtonRemoveTab
        '
        Me.ToolStripButtonRemoveTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRemoveTab.Image = CType(resources.GetObject("ToolStripButtonRemoveTab.Image"), System.Drawing.Image)
        Me.ToolStripButtonRemoveTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRemoveTab.Name = "ToolStripButtonRemoveTab"
        Me.ToolStripButtonRemoveTab.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonRemoveTab.Text = "Remove Tab"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonHistory
        '
        Me.ToolStripButtonHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonHistory.Image = CType(resources.GetObject("ToolStripButtonHistory.Image"), System.Drawing.Image)
        Me.ToolStripButtonHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonHistory.Name = "ToolStripButtonHistory"
        Me.ToolStripButtonHistory.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonHistory.Text = "History"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonPrint
        '
        Me.ToolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPrint.Image = CType(resources.GetObject("ToolStripButtonPrint.Image"), System.Drawing.Image)
        Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
        Me.ToolStripButtonPrint.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPrint.Text = "Print"
        '
        'ToolStripButtonPrintPreview
        '
        Me.ToolStripButtonPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPrintPreview.Image = CType(resources.GetObject("ToolStripButtonPrintPreview.Image"), System.Drawing.Image)
        Me.ToolStripButtonPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPrintPreview.Name = "ToolStripButtonPrintPreview"
        Me.ToolStripButtonPrintPreview.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPrintPreview.Text = "Print Preview"
        '
        'ToolStripButtonPageSetup
        '
        Me.ToolStripButtonPageSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPageSetup.Image = CType(resources.GetObject("ToolStripButtonPageSetup.Image"), System.Drawing.Image)
        Me.ToolStripButtonPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPageSetup.Name = "ToolStripButtonPageSetup"
        Me.ToolStripButtonPageSetup.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPageSetup.Text = "Page Setup"
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1238, 683)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Twil Browser"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsitePropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTwilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonGo As System.Windows.Forms.Button
    Friend WithEvents Cmbaddress As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonForward As System.Windows.Forms.Button
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents ButtonHome As System.Windows.Forms.Button
    Friend WithEvents ButtonProxy As System.Windows.Forms.Button
    Friend WithEvents Txtproxy As System.Windows.Forms.TextBox
    Friend WithEvents lblport As System.Windows.Forms.Label
    Friend WithEvents lblproxy As System.Windows.Forms.Label
    Friend WithEvents Txtport As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonAddTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRemoveTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonPrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonPageSetup As System.Windows.Forms.ToolStripButton

End Class
