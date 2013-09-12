Public Class Frmmain
    Dim int As Integer = 0

    Private Sub Loading(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        ToolStripProgressBar1.Maximum = e.MaximumProgress
        ToolStripProgressBar1.Value = e.CurrentProgress
    End Sub

    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        Cmbaddress.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
    End Sub

    Private Sub Frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim WebBrowser As New WebBrowser
        TabControl1.TabPages.Add("New Tab")
        WebBrowser.Name = "Twil Browser"
        WebBrowser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(WebBrowser)
        AddHandler WebBrowser.ProgressChanged, AddressOf Loading
        AddHandler WebBrowser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub

    Private Sub AddTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTabToolStripMenuItem.Click
        Dim WebBrowser As New WebBrowser
        TabControl1.TabPages.Add("New Tab")
        TabControl1.SelectTab(Int)
        WebBrowser.Name = "Twil Browser"
        WebBrowser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(WebBrowser)
        AddHandler WebBrowser.ProgressChanged, AddressOf Loading
        AddHandler WebBrowser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
        Cmbaddress.Text = ""
    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveTabToolStripMenuItem.Click
        If Not TabControl1.TabPages.Count = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            int = int - 1
        End If
    End Sub

    Private Sub WebsitePropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebsitePropertiesToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).StatusText
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub ButtonBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBack.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub ButtonForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonForward.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub ButtonGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGo.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(Cmbaddress.Text)
    End Sub

    Private Sub Cmbaddress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbaddress.SelectedIndexChanged
        ButtonGo.Focus()
    End Sub

    Private Sub ButtonStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStop.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Stop()
    End Sub

    Private Sub ButtonHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHome.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub

    Public Structure Struct_INTERNET_PROXY_INFO
        Public dwAccessType As Integer
        Public proxy As IntPtr
        Public proxyBypass As IntPtr
    End Structure
#Region "Proxy"

    ' The Windows API function that allows us to manipulate
    ' IE settings programmatically.
    Public Declare Auto Function InternetSetOption Lib "wininet.dll" _
    (ByVal hInternet As IntPtr, ByVal dwOption As Integer, ByVal lpBuffer As IntPtr, _
     ByVal lpdwBufferLength As Integer) As Boolean

    ' The function we will be using to set the proxy settings.
    Public Sub RefreshIESettings(ByVal strProxy As String)
        Const INTERNET_OPTION_PROXY As Integer = 38
        Const INTERNET_OPEN_TYPE_PROXY As Integer = 3
        Dim struct_IPI As Struct_INTERNET_PROXY_INFO

        ' Filling in structure
        struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY
        struct_IPI.proxy = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(strProxy)
        struct_IPI.proxyBypass = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi("local")

        ' Allocating memory
        Dim intptrStruct As IntPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Runtime.InteropServices.Marshal.SizeOf(struct_IPI))

        ' Converting structure to IntPtr
        System.Runtime.InteropServices.Marshal.StructureToPtr(struct_IPI, intptrStruct, True)
        Dim iReturn As Boolean = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, System.Runtime.InteropServices.Marshal.SizeOf(struct_IPI))
    End Sub

#End Region

    Public Sub ButtonProxy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProxy.Click
        RefreshIESettings(Txtproxy.Text + ":" + Txtport.Text)
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.co.uk/search?q=" & cmbsearch.Text)
    End Sub

    Private Sub ToolStripButtonAddTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAddTab.Click
        Dim WebBrowser As New WebBrowser
        TabControl1.TabPages.Add("New Tab")
        TabControl1.SelectTab(int)
        WebBrowser.Name = "Twil Browser"
        WebBrowser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(WebBrowser)
        AddHandler WebBrowser.ProgressChanged, AddressOf Loading
        AddHandler WebBrowser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
        Cmbaddress.Text = ""
    End Sub

    Private Sub ToolStripButtonRemoveTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonRemoveTab.Click
        If Not TabControl1.TabPages.Count = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            int = int - 1
        End If
    End Sub

    Private Sub ToolStripButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonPrint.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub

    Private Sub ToolStripButtonPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonPrintPreview.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub

    Private Sub ToolStripButtonPageSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonPageSetup.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub

    Private Sub AboutTwilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTwilToolStripMenuItem.Click
        AboutBox.Show()
    End Sub
End Class
