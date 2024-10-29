<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.staticList = New System.Windows.Forms.DataGridView()
        Me.Machine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hostName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtNWError = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnLeaseClear = New System.Windows.Forms.Button()
        Me.btnLeaseDefault = New System.Windows.Forms.Button()
        Me.cmbUnknown = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtMaxLease = New System.Windows.Forms.TextBox()
        Me.txtDefaultLease = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClearDNS = New System.Windows.Forms.Button()
        Me.btnDomainExport = New System.Windows.Forms.Button()
        Me.btnDomainImport = New System.Windows.Forms.Button()
        Me.lstDNS = New System.Windows.Forms.DataGridView()
        Me.DNSs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDomainName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRoutersClear = New System.Windows.Forms.Button()
        Me.btnRoutersExport = New System.Windows.Forms.Button()
        Me.btnRoutersImport = New System.Windows.Forms.Button()
        Me.lstRouters = New System.Windows.Forms.DataGridView()
        Me.Routers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBroadcast = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSubnet = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbIPnum = New System.Windows.Forms.ComboBox()
        Me.btnAutoDetect = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRangeB = New System.Windows.Forms.TextBox()
        Me.txtRangeA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAreaSubnet = New System.Windows.Forms.TextBox()
        Me.txtAreaNetwork = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtWPAD = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtServiceError = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnClearWINSDD = New System.Windows.Forms.Button()
        Me.btnExportWINSDD = New System.Windows.Forms.Button()
        Me.btnImportWINSDD = New System.Windows.Forms.Button()
        Me.btnClearWINS = New System.Windows.Forms.Button()
        Me.btnExportWINS = New System.Windows.Forms.Button()
        Me.btnImportWINS = New System.Windows.Forms.Button()
        Me.cmbWINSNodeType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstWINSDD = New System.Windows.Forms.DataGridView()
        Me.winsDD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lstWINS = New System.Windows.Forms.DataGridView()
        Me.wins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClearNTP = New System.Windows.Forms.Button()
        Me.btnExportNTP = New System.Windows.Forms.Button()
        Me.btnImportNTP = New System.Windows.Forms.Button()
        Me.btnJSC = New System.Windows.Forms.Button()
        Me.cmbTimeOffset = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstNTP = New System.Windows.Forms.DataGridView()
        Me.NTP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmbCharCode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbNewLine = New System.Windows.Forms.ComboBox()
        Me.cmbTab = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMachinesOnly = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.sfdExport = New System.Windows.Forms.SaveFileDialog()
        Me.ofdImport = New System.Windows.Forms.OpenFileDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnGen = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.staticList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.lstDNS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.lstRouters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.lstWINSDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstWINS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.lstNTP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(0, 276)
        Me.txtRes.Multiline = True
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRes.Size = New System.Drawing.Size(595, 96)
        Me.txtRes.TabIndex = 1
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "CSVファイル(*.csv)|*.csv|テキストファイル(*.txt)|*.txt|TSVファイル(*.tsv)|*.tsv|SSVファイル(*.ssv)|*." &
    "ssv"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "CSV ファイル|*.csv;*.txt|TSV ファイル|*.tsv;*.txt|SSV ファイル|*.ssv;*.txt"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(794, 269)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.btnExport)
        Me.TabPage1.Controls.Add(Me.txtError)
        Me.TabPage1.Controls.Add(Me.btnImport)
        Me.TabPage1.Controls.Add(Me.staticList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(786, 243)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Machines"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(750, 214)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(30, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.save_icon
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(640, 184)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(89, 46)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(604, 55)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.ReadOnly = True
        Me.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtError.Size = New System.Drawing.Size(176, 117)
        Me.txtError.TabIndex = 2
        '
        'btnImport
        '
        Me.btnImport.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.open_icon
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.Location = New System.Drawing.Point(640, 3)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(89, 46)
        Me.btnImport.TabIndex = 1
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'staticList
        '
        Me.staticList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.staticList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Machine, Me.MAC, Me.IP, Me.hostName})
        Me.staticList.Location = New System.Drawing.Point(3, 3)
        Me.staticList.Name = "staticList"
        Me.staticList.RowTemplate.Height = 21
        Me.staticList.Size = New System.Drawing.Size(595, 237)
        Me.staticList.TabIndex = 0
        '
        'Machine
        '
        Me.Machine.HeaderText = "Machine"
        Me.Machine.MaxInputLength = 32
        Me.Machine.Name = "Machine"
        '
        'MAC
        '
        Me.MAC.HeaderText = "MACアドレス"
        Me.MAC.MaxInputLength = 17
        Me.MAC.Name = "MAC"
        Me.MAC.Width = 200
        '
        'IP
        '
        Me.IP.HeaderText = "IPアドレス"
        Me.IP.MaxInputLength = 15
        Me.IP.Name = "IP"
        Me.IP.Width = 150
        '
        'hostName
        '
        Me.hostName.HeaderText = "ホスト名"
        Me.hostName.Name = "hostName"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtNWError)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(786, 243)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Network"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtNWError
        '
        Me.txtNWError.Location = New System.Drawing.Point(586, 158)
        Me.txtNWError.Multiline = True
        Me.txtNWError.Name = "txtNWError"
        Me.txtNWError.ReadOnly = True
        Me.txtNWError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNWError.Size = New System.Drawing.Size(188, 79)
        Me.txtNWError.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnLeaseClear)
        Me.GroupBox4.Controls.Add(Me.btnLeaseDefault)
        Me.GroupBox4.Controls.Add(Me.cmbUnknown)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtMaxLease)
        Me.GroupBox4.Controls.Add(Me.txtDefaultLease)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(586, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(194, 144)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Configures"
        '
        'btnLeaseClear
        '
        Me.btnLeaseClear.Location = New System.Drawing.Point(113, 69)
        Me.btnLeaseClear.Name = "btnLeaseClear"
        Me.btnLeaseClear.Size = New System.Drawing.Size(57, 23)
        Me.btnLeaseClear.TabIndex = 5
        Me.btnLeaseClear.Text = "Clear"
        Me.btnLeaseClear.UseVisualStyleBackColor = True
        '
        'btnLeaseDefault
        '
        Me.btnLeaseDefault.Location = New System.Drawing.Point(50, 69)
        Me.btnLeaseDefault.Name = "btnLeaseDefault"
        Me.btnLeaseDefault.Size = New System.Drawing.Size(57, 23)
        Me.btnLeaseDefault.TabIndex = 4
        Me.btnLeaseDefault.Text = "Default"
        Me.btnLeaseDefault.UseVisualStyleBackColor = True
        '
        'cmbUnknown
        '
        Me.cmbUnknown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnknown.FormattingEnabled = True
        Me.cmbUnknown.Items.AddRange(New Object() {"", "Allow", "Deny"})
        Me.cmbUnknown.Location = New System.Drawing.Point(102, 111)
        Me.cmbUnknown.Name = "cmbUnknown"
        Me.cmbUnknown.Size = New System.Drawing.Size(86, 20)
        Me.cmbUnknown.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 12)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Unknown Clients"
        '
        'txtMaxLease
        '
        Me.txtMaxLease.Location = New System.Drawing.Point(113, 43)
        Me.txtMaxLease.Name = "txtMaxLease"
        Me.txtMaxLease.Size = New System.Drawing.Size(75, 19)
        Me.txtMaxLease.TabIndex = 3
        Me.txtMaxLease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDefaultLease
        '
        Me.txtDefaultLease.Location = New System.Drawing.Point(113, 18)
        Me.txtDefaultLease.Name = "txtDefaultLease"
        Me.txtDefaultLease.Size = New System.Drawing.Size(75, 19)
        Me.txtDefaultLease.TabIndex = 1
        Me.txtDefaultLease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 44)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 12)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "max-lease-time"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 12)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "default-lease-time"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClearDNS)
        Me.GroupBox2.Controls.Add(Me.btnDomainExport)
        Me.GroupBox2.Controls.Add(Me.btnDomainImport)
        Me.GroupBox2.Controls.Add(Me.lstDNS)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtDomainName)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(181, 203)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Domain"
        '
        'btnClearDNS
        '
        Me.btnClearDNS.Location = New System.Drawing.Point(148, 141)
        Me.btnClearDNS.Name = "btnClearDNS"
        Me.btnClearDNS.Size = New System.Drawing.Size(27, 23)
        Me.btnClearDNS.TabIndex = 3
        Me.btnClearDNS.Text = "C"
        Me.btnClearDNS.UseVisualStyleBackColor = True
        '
        'btnDomainExport
        '
        Me.btnDomainExport.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.save_icon
        Me.btnDomainExport.Location = New System.Drawing.Point(94, 141)
        Me.btnDomainExport.Name = "btnDomainExport"
        Me.btnDomainExport.Size = New System.Drawing.Size(29, 23)
        Me.btnDomainExport.TabIndex = 2
        Me.btnDomainExport.UseVisualStyleBackColor = True
        '
        'btnDomainImport
        '
        Me.btnDomainImport.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.open_icon
        Me.btnDomainImport.Location = New System.Drawing.Point(59, 141)
        Me.btnDomainImport.Name = "btnDomainImport"
        Me.btnDomainImport.Size = New System.Drawing.Size(29, 23)
        Me.btnDomainImport.TabIndex = 1
        Me.btnDomainImport.UseVisualStyleBackColor = True
        '
        'lstDNS
        '
        Me.lstDNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstDNS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNSs})
        Me.lstDNS.Location = New System.Drawing.Point(9, 18)
        Me.lstDNS.Name = "lstDNS"
        Me.lstDNS.RowHeadersWidth = 25
        Me.lstDNS.RowTemplate.Height = 21
        Me.lstDNS.Size = New System.Drawing.Size(166, 117)
        Me.lstDNS.TabIndex = 0
        '
        'DNSs
        '
        Me.DNSs.HeaderText = "DNS Servers"
        Me.DNSs.Name = "DNSs"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 174)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 12)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Domain"
        '
        'txtDomainName
        '
        Me.txtDomainName.Location = New System.Drawing.Point(57, 171)
        Me.txtDomainName.Name = "txtDomainName"
        Me.txtDomainName.Size = New System.Drawing.Size(107, 19)
        Me.txtDomainName.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRoutersClear)
        Me.GroupBox1.Controls.Add(Me.btnRoutersExport)
        Me.GroupBox1.Controls.Add(Me.btnRoutersImport)
        Me.GroupBox1.Controls.Add(Me.lstRouters)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBroadcast)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSubnet)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cmbIPnum)
        Me.GroupBox1.Controls.Add(Me.btnAutoDetect)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtRangeB)
        Me.GroupBox1.Controls.Add(Me.txtRangeA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAreaSubnet)
        Me.GroupBox1.Controls.Add(Me.txtAreaNetwork)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Common Settings"
        '
        'btnRoutersClear
        '
        Me.btnRoutersClear.Location = New System.Drawing.Point(352, 199)
        Me.btnRoutersClear.Name = "btnRoutersClear"
        Me.btnRoutersClear.Size = New System.Drawing.Size(27, 23)
        Me.btnRoutersClear.TabIndex = 18
        Me.btnRoutersClear.Text = "C"
        Me.btnRoutersClear.UseVisualStyleBackColor = True
        '
        'btnRoutersExport
        '
        Me.btnRoutersExport.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.save_icon
        Me.btnRoutersExport.Location = New System.Drawing.Point(303, 199)
        Me.btnRoutersExport.Name = "btnRoutersExport"
        Me.btnRoutersExport.Size = New System.Drawing.Size(29, 23)
        Me.btnRoutersExport.TabIndex = 17
        Me.btnRoutersExport.UseVisualStyleBackColor = True
        '
        'btnRoutersImport
        '
        Me.btnRoutersImport.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.open_icon
        Me.btnRoutersImport.Location = New System.Drawing.Point(268, 199)
        Me.btnRoutersImport.Name = "btnRoutersImport"
        Me.btnRoutersImport.Size = New System.Drawing.Size(29, 23)
        Me.btnRoutersImport.TabIndex = 16
        Me.btnRoutersImport.UseVisualStyleBackColor = True
        '
        'lstRouters
        '
        Me.lstRouters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstRouters.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Routers})
        Me.lstRouters.Location = New System.Drawing.Point(222, 85)
        Me.lstRouters.Name = "lstRouters"
        Me.lstRouters.RowHeadersWidth = 25
        Me.lstRouters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.lstRouters.RowTemplate.Height = 21
        Me.lstRouters.Size = New System.Drawing.Size(157, 109)
        Me.lstRouters.TabIndex = 15
        '
        'Routers
        '
        Me.Routers.HeaderText = "Routers"
        Me.Routers.MaxInputLength = 15
        Me.Routers.Name = "Routers"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 12)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Broadcast"
        '
        'txtBroadcast
        '
        Me.txtBroadcast.Location = New System.Drawing.Point(96, 175)
        Me.txtBroadcast.Name = "txtBroadcast"
        Me.txtBroadcast.Size = New System.Drawing.Size(107, 19)
        Me.txtBroadcast.TabIndex = 14
        Me.txtBroadcast.Text = "192.168.0.255"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 12)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Subnet"
        '
        'txtSubnet
        '
        Me.txtSubnet.Location = New System.Drawing.Point(96, 150)
        Me.txtSubnet.Name = "txtSubnet"
        Me.txtSubnet.Size = New System.Drawing.Size(107, 19)
        Me.txtSubnet.TabIndex = 12
        Me.txtSubnet.Text = "255.255.255.0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(34, 77)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 12)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "IP numeric"
        '
        'cmbIPnum
        '
        Me.cmbIPnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIPnum.FormattingEnabled = True
        Me.cmbIPnum.Items.AddRange(New Object() {"", "(max)", "6", "14", "30", "62", "126", "254", "510", "1022"})
        Me.cmbIPnum.Location = New System.Drawing.Point(96, 74)
        Me.cmbIPnum.Name = "cmbIPnum"
        Me.cmbIPnum.Size = New System.Drawing.Size(73, 20)
        Me.cmbIPnum.TabIndex = 6
        '
        'btnAutoDetect
        '
        Me.btnAutoDetect.Location = New System.Drawing.Point(184, 18)
        Me.btnAutoDetect.Name = "btnAutoDetect"
        Me.btnAutoDetect.Size = New System.Drawing.Size(91, 44)
        Me.btnAutoDetect.TabIndex = 4
        Me.btnAutoDetect.Text = "Auto Detect"
        Me.btnAutoDetect.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 12)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "IP Range (max)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "IP Range (min)"
        '
        'txtRangeB
        '
        Me.txtRangeB.Location = New System.Drawing.Point(96, 125)
        Me.txtRangeB.Name = "txtRangeB"
        Me.txtRangeB.Size = New System.Drawing.Size(107, 19)
        Me.txtRangeB.TabIndex = 10
        Me.txtRangeB.Text = "192.168.0.254"
        '
        'txtRangeA
        '
        Me.txtRangeA.Location = New System.Drawing.Point(96, 100)
        Me.txtRangeA.Name = "txtRangeA"
        Me.txtRangeA.Size = New System.Drawing.Size(107, 19)
        Me.txtRangeA.TabIndex = 8
        Me.txtRangeA.Text = "192.168.0.2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Subnet"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Network"
        '
        'txtAreaSubnet
        '
        Me.txtAreaSubnet.Location = New System.Drawing.Point(59, 43)
        Me.txtAreaSubnet.Name = "txtAreaSubnet"
        Me.txtAreaSubnet.Size = New System.Drawing.Size(107, 19)
        Me.txtAreaSubnet.TabIndex = 3
        Me.txtAreaSubnet.Text = "255.255.255.0"
        '
        'txtAreaNetwork
        '
        Me.txtAreaNetwork.Location = New System.Drawing.Point(59, 18)
        Me.txtAreaNetwork.Name = "txtAreaNetwork"
        Me.txtAreaNetwork.Size = New System.Drawing.Size(107, 19)
        Me.txtAreaNetwork.TabIndex = 1
        Me.txtAreaNetwork.Text = "192.168.0.0"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Controls.Add(Me.txtServiceError)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(786, 243)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Network Servies"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtWPAD)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Location = New System.Drawing.Point(236, 191)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(355, 49)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "WPAD"
        '
        'txtWPAD
        '
        Me.txtWPAD.Location = New System.Drawing.Point(78, 18)
        Me.txtWPAD.Name = "txtWPAD"
        Me.txtWPAD.Size = New System.Drawing.Size(262, 19)
        Me.txtWPAD.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 12)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "WPAD-URL"
        '
        'txtServiceError
        '
        Me.txtServiceError.Location = New System.Drawing.Point(597, 3)
        Me.txtServiceError.Multiline = True
        Me.txtServiceError.Name = "txtServiceError"
        Me.txtServiceError.ReadOnly = True
        Me.txtServiceError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtServiceError.Size = New System.Drawing.Size(186, 237)
        Me.txtServiceError.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnClearWINSDD)
        Me.GroupBox5.Controls.Add(Me.btnExportWINSDD)
        Me.GroupBox5.Controls.Add(Me.btnImportWINSDD)
        Me.GroupBox5.Controls.Add(Me.btnClearWINS)
        Me.GroupBox5.Controls.Add(Me.btnExportWINS)
        Me.GroupBox5.Controls.Add(Me.btnImportWINS)
        Me.GroupBox5.Controls.Add(Me.cmbWINSNodeType)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.lstWINSDD)
        Me.GroupBox5.Controls.Add(Me.lstWINS)
        Me.GroupBox5.Location = New System.Drawing.Point(236, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(355, 182)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "NetBIOS"
        '
        'btnClearWINSDD
        '
        Me.btnClearWINSDD.Location = New System.Drawing.Point(322, 122)
        Me.btnClearWINSDD.Name = "btnClearWINSDD"
        Me.btnClearWINSDD.Size = New System.Drawing.Size(27, 23)
        Me.btnClearWINSDD.TabIndex = 7
        Me.btnClearWINSDD.Text = "C"
        Me.btnClearWINSDD.UseVisualStyleBackColor = True
        '
        'btnExportWINSDD
        '
        Me.btnExportWINSDD.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.save_icon
        Me.btnExportWINSDD.Location = New System.Drawing.Point(259, 122)
        Me.btnExportWINSDD.Name = "btnExportWINSDD"
        Me.btnExportWINSDD.Size = New System.Drawing.Size(29, 23)
        Me.btnExportWINSDD.TabIndex = 6
        Me.btnExportWINSDD.UseVisualStyleBackColor = True
        '
        'btnImportWINSDD
        '
        Me.btnImportWINSDD.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.open_icon
        Me.btnImportWINSDD.Location = New System.Drawing.Point(224, 122)
        Me.btnImportWINSDD.Name = "btnImportWINSDD"
        Me.btnImportWINSDD.Size = New System.Drawing.Size(29, 23)
        Me.btnImportWINSDD.TabIndex = 5
        Me.btnImportWINSDD.UseVisualStyleBackColor = True
        '
        'btnClearWINS
        '
        Me.btnClearWINS.Location = New System.Drawing.Point(146, 122)
        Me.btnClearWINS.Name = "btnClearWINS"
        Me.btnClearWINS.Size = New System.Drawing.Size(27, 23)
        Me.btnClearWINS.TabIndex = 3
        Me.btnClearWINS.Text = "C"
        Me.btnClearWINS.UseVisualStyleBackColor = True
        '
        'btnExportWINS
        '
        Me.btnExportWINS.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.save_icon
        Me.btnExportWINS.Location = New System.Drawing.Point(83, 122)
        Me.btnExportWINS.Name = "btnExportWINS"
        Me.btnExportWINS.Size = New System.Drawing.Size(29, 23)
        Me.btnExportWINS.TabIndex = 2
        Me.btnExportWINS.UseVisualStyleBackColor = True
        '
        'btnImportWINS
        '
        Me.btnImportWINS.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.open_icon
        Me.btnImportWINS.Location = New System.Drawing.Point(48, 122)
        Me.btnImportWINS.Name = "btnImportWINS"
        Me.btnImportWINS.Size = New System.Drawing.Size(29, 23)
        Me.btnImportWINS.TabIndex = 1
        Me.btnImportWINS.UseVisualStyleBackColor = True
        '
        'cmbWINSNodeType
        '
        Me.cmbWINSNodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWINSNodeType.FormattingEnabled = True
        Me.cmbWINSNodeType.Items.AddRange(New Object() {"", "1 (B node, No-WINS)", "2 (P node, WINS-Only)", "4 (M node, Broadcast->WINS)", "8 (H node, WINS->Broadcast)"})
        Me.cmbWINSNodeType.Location = New System.Drawing.Point(116, 156)
        Me.cmbWINSNodeType.Name = "cmbWINSNodeType"
        Me.cmbWINSNodeType.Size = New System.Drawing.Size(165, 20)
        Me.cmbWINSNodeType.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 12)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "NetBIOS Node type"
        '
        'lstWINSDD
        '
        Me.lstWINSDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstWINSDD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.winsDD})
        Me.lstWINSDD.Location = New System.Drawing.Point(179, 18)
        Me.lstWINSDD.Name = "lstWINSDD"
        Me.lstWINSDD.RowTemplate.Height = 21
        Me.lstWINSDD.Size = New System.Drawing.Size(167, 98)
        Me.lstWINSDD.TabIndex = 4
        '
        'winsDD
        '
        Me.winsDD.HeaderText = "DD Servers"
        Me.winsDD.Name = "winsDD"
        '
        'lstWINS
        '
        Me.lstWINS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstWINS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.wins})
        Me.lstWINS.Location = New System.Drawing.Point(6, 18)
        Me.lstWINS.Name = "lstWINS"
        Me.lstWINS.RowTemplate.Height = 21
        Me.lstWINS.Size = New System.Drawing.Size(167, 98)
        Me.lstWINS.TabIndex = 0
        '
        'wins
        '
        Me.wins.HeaderText = "WINS Servers"
        Me.wins.Name = "wins"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClearNTP)
        Me.GroupBox3.Controls.Add(Me.btnExportNTP)
        Me.GroupBox3.Controls.Add(Me.btnImportNTP)
        Me.GroupBox3.Controls.Add(Me.btnJSC)
        Me.GroupBox3.Controls.Add(Me.cmbTimeOffset)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lstNTP)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 182)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NTP"
        '
        'btnClearNTP
        '
        Me.btnClearNTP.Location = New System.Drawing.Point(189, 122)
        Me.btnClearNTP.Name = "btnClearNTP"
        Me.btnClearNTP.Size = New System.Drawing.Size(27, 23)
        Me.btnClearNTP.TabIndex = 3
        Me.btnClearNTP.Text = "C"
        Me.btnClearNTP.UseVisualStyleBackColor = True
        '
        'btnExportNTP
        '
        Me.btnExportNTP.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.save_icon
        Me.btnExportNTP.Location = New System.Drawing.Point(98, 122)
        Me.btnExportNTP.Name = "btnExportNTP"
        Me.btnExportNTP.Size = New System.Drawing.Size(29, 23)
        Me.btnExportNTP.TabIndex = 2
        Me.btnExportNTP.UseVisualStyleBackColor = True
        '
        'btnImportNTP
        '
        Me.btnImportNTP.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.open_icon
        Me.btnImportNTP.Location = New System.Drawing.Point(63, 122)
        Me.btnImportNTP.Name = "btnImportNTP"
        Me.btnImportNTP.Size = New System.Drawing.Size(29, 23)
        Me.btnImportNTP.TabIndex = 1
        Me.btnImportNTP.UseVisualStyleBackColor = True
        '
        'btnJSC
        '
        Me.btnJSC.Location = New System.Drawing.Point(172, 156)
        Me.btnJSC.Name = "btnJSC"
        Me.btnJSC.Size = New System.Drawing.Size(44, 20)
        Me.btnJSC.TabIndex = 6
        Me.btnJSC.Text = "JSC"
        Me.btnJSC.UseVisualStyleBackColor = True
        '
        'cmbTimeOffset
        '
        Me.cmbTimeOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeOffset.FormattingEnabled = True
        Me.cmbTimeOffset.Items.AddRange(New Object() {"", "+14", "+13", "+12:45", "+12", "+11:30", "+11", "+10:30", "+9:30", "+9", "+8:45", "+8", "+7", "+6", "+5:45", "+5:30", "+5", "+4:30", "+4", "+3", "+2", "+1", "0", "-1", "-2", "-3", "-3:30", "-4", "-4:30", "-5", "-6", "-7", "-8", "-9", "-9:30", "-10", "-11", "-12"})
        Me.cmbTimeOffset.Location = New System.Drawing.Point(78, 156)
        Me.cmbTimeOffset.Name = "cmbTimeOffset"
        Me.cmbTimeOffset.Size = New System.Drawing.Size(88, 20)
        Me.cmbTimeOffset.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 12)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Time Offset"
        '
        'lstNTP
        '
        Me.lstNTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstNTP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NTP})
        Me.lstNTP.Location = New System.Drawing.Point(6, 18)
        Me.lstNTP.Name = "lstNTP"
        Me.lstNTP.RowHeadersWidth = 25
        Me.lstNTP.RowTemplate.Height = 21
        Me.lstNTP.Size = New System.Drawing.Size(210, 98)
        Me.lstNTP.TabIndex = 0
        '
        'NTP
        '
        Me.NTP.HeaderText = "NTP Servers"
        Me.NTP.Name = "NTP"
        Me.NTP.Width = 160
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmbCharCode)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.cmbNewLine)
        Me.TabPage3.Controls.Add(Me.cmbTab)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(786, 243)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Encode"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmbCharCode
        '
        Me.cmbCharCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCharCode.Enabled = False
        Me.cmbCharCode.FormattingEnabled = True
        Me.cmbCharCode.Items.AddRange(New Object() {"Shift-JIS", "UTF-8", "EUC-JP"})
        Me.cmbCharCode.Location = New System.Drawing.Point(65, 60)
        Me.cmbCharCode.Name = "cmbCharCode"
        Me.cmbCharCode.Size = New System.Drawing.Size(92, 20)
        Me.cmbCharCode.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "文字コード"
        '
        'cmbNewLine
        '
        Me.cmbNewLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewLine.FormattingEnabled = True
        Me.cmbNewLine.Items.AddRange(New Object() {"CR+LF (Win)", "LF (UNIX)", "CR (Old Mac)"})
        Me.cmbNewLine.Location = New System.Drawing.Point(65, 34)
        Me.cmbNewLine.Name = "cmbNewLine"
        Me.cmbNewLine.Size = New System.Drawing.Size(92, 20)
        Me.cmbNewLine.TabIndex = 3
        '
        'cmbTab
        '
        Me.cmbTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTab.FormattingEnabled = True
        Me.cmbTab.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbTab.Location = New System.Drawing.Point(65, 8)
        Me.cmbTab.Name = "cmbTab"
        Me.cmbTab.Size = New System.Drawing.Size(92, 20)
        Me.cmbTab.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "改行コード"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "タブ幅"
        '
        'chkMachinesOnly
        '
        Me.chkMachinesOnly.AutoSize = True
        Me.chkMachinesOnly.Checked = True
        Me.chkMachinesOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMachinesOnly.Location = New System.Drawing.Point(706, 296)
        Me.chkMachinesOnly.Name = "chkMachinesOnly"
        Me.chkMachinesOnly.Size = New System.Drawing.Size(97, 16)
        Me.chkMachinesOnly.TabIndex = 4
        Me.chkMachinesOnly.Text = "Machiens only"
        Me.chkMachinesOnly.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 12)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "WPAD"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 12)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "NTP"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 12)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "WINS"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(49, 66)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(107, 19)
        Me.TextBox14.TabIndex = 4
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(49, 41)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(107, 19)
        Me.TextBox13.TabIndex = 3
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(49, 16)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(107, 19)
        Me.TextBox12.TabIndex = 2
        '
        'sfdExport
        '
        Me.sfdExport.Filter = "対応形式(*.sidc;*.txt;*.lst)|*.sidc;*.txt;*.lst|SIDCファイル(*.sidc)|*.sidc|テキストファイル(*.tx" &
    "t)|*.txt|リストファイル(*.lst)|*.lst|すべてのファイル(*.*)|*.*"
        '
        'ofdImport
        '
        Me.ofdImport.Filter = "対応形式(*.sidc;*.txt;*.lst)|*.sidc;*.txt;*.lst|SIDCファイル(*.sidc)|*.sidc|テキストファイル(*.tx" &
    "t)|*.txt|リストファイル(*.lst)|*.lst|すべてのファイル(*.*)|*.*"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.save_icon
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(608, 327)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 36)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnGen
        '
        Me.btnGen.Image = Global.staticIPDHCPConfigure.My.Resources.Resources.generate_icon
        Me.btnGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGen.Location = New System.Drawing.Point(610, 285)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(90, 36)
        Me.btnGen.TabIndex = 2
        Me.btnGen.Text = "Gen"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 374)
        Me.Controls.Add(Me.chkMachinesOnly)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.txtRes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "staticIPDHCPConfigure"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.staticList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.lstDNS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.lstRouters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.lstWINSDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstWINS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.lstNTP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRes As System.Windows.Forms.TextBox
    Friend WithEvents btnGen As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtError As System.Windows.Forms.TextBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents staticList As System.Windows.Forms.DataGridView
    Friend WithEvents Machine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hostName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAreaSubnet As System.Windows.Forms.TextBox
    Friend WithEvents txtAreaNetwork As System.Windows.Forms.TextBox
    Friend WithEvents cmbCharCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNewLine As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTab As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRangeB As System.Windows.Forms.TextBox
    Friend WithEvents txtRangeA As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDomainName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaxLease As System.Windows.Forms.TextBox
    Friend WithEvents txtDefaultLease As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbUnknown As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chkMachinesOnly As System.Windows.Forms.CheckBox
    Friend WithEvents btnLeaseClear As System.Windows.Forms.Button
    Friend WithEvents btnLeaseDefault As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBroadcast As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSubnet As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbIPnum As System.Windows.Forms.ComboBox
    Friend WithEvents btnAutoDetect As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtWPAD As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents txtNWError As System.Windows.Forms.TextBox
    Friend WithEvents lstRouters As System.Windows.Forms.DataGridView
    Friend WithEvents lstDNS As System.Windows.Forms.DataGridView
    Friend WithEvents Routers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lstNTP As System.Windows.Forms.DataGridView
    Friend WithEvents NTP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtServiceError As System.Windows.Forms.TextBox
    Friend WithEvents DNSs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lstWINSDD As System.Windows.Forms.DataGridView
    Friend WithEvents lstWINS As System.Windows.Forms.DataGridView
    Friend WithEvents wins As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents winsDD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbWINSNodeType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnJSC As System.Windows.Forms.Button
    Friend WithEvents cmbTimeOffset As System.Windows.Forms.ComboBox
    Friend WithEvents sfdExport As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdImport As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnClearDNS As System.Windows.Forms.Button
    Friend WithEvents btnDomainExport As System.Windows.Forms.Button
    Friend WithEvents btnDomainImport As System.Windows.Forms.Button
    Friend WithEvents btnRoutersClear As System.Windows.Forms.Button
    Friend WithEvents btnRoutersExport As System.Windows.Forms.Button
    Friend WithEvents btnRoutersImport As System.Windows.Forms.Button
    Friend WithEvents btnClearWINSDD As System.Windows.Forms.Button
    Friend WithEvents btnExportWINSDD As System.Windows.Forms.Button
    Friend WithEvents btnImportWINSDD As System.Windows.Forms.Button
    Friend WithEvents btnClearWINS As System.Windows.Forms.Button
    Friend WithEvents btnExportWINS As System.Windows.Forms.Button
    Friend WithEvents btnImportWINS As System.Windows.Forms.Button
    Friend WithEvents btnClearNTP As System.Windows.Forms.Button
    Friend WithEvents btnExportNTP As System.Windows.Forms.Button
    Friend WithEvents btnImportNTP As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
