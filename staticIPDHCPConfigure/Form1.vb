Imports System.Text.RegularExpressions  ' 正規表現の有効化

Public Class Form1

    ''' <summary>
    ''' 初期動作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbTab.SelectedIndex = 3
        cmbCharCode.SelectedIndex = 1   ' いじれないよ
        cmbNewLine.SelectedIndex = 0

        lstRouters.Rows.Add("192.168.0.1")
    End Sub

    ''' <summary>
    ''' 生成ボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGen.Click
        txtError.Text = ""
        txtNWError.Text = ""
        txtServiceError.Text = ""

        ' タブ文字生成
        Dim tabStr As String = ""
        Dim biasStr As String = ""
        Dim longTabStr As String
        For i As Integer = cmbTab.SelectedIndex To 1 Step -1
            tabStr &= " "
        Next i

        If chkMachinesOnly.Checked Then
            longTabStr = tabStr
        Else
            biasStr = tabStr
            longTabStr = tabStr & tabStr
        End If


        ' 改行文字の指定
        Dim newLine As String
        If (cmbNewLine.SelectedIndex = 0) Then
            newLine = vbCrLf
        ElseIf (cmbNewLine.SelectedIndex = 1) Then
            newLine = vbLf
        Else
            newLine = vbCr
        End If

        Dim size As Integer ' 行数
        Dim res As String = ""  ' 生成

        If Not chkMachinesOnly.Checked Then
            If Not isIP(txtAreaNetwork.Text) Then
                txtNWError.Text &= "Strange Area Network" & vbCrLf
                Exit Sub
            End If
            If Not isIP(txtAreaSubnet.Text) Then
                txtNWError.Text &= "Strange Area Subnet-Mask" & vbCrLf
                Exit Sub
            End If
            ' エリア
            res = "subnet " & txtAreaNetwork.Text & " netmask " & txtAreaSubnet.Text & " {" & newLine

            ' IP Range
            Dim strangeRange As Integer = 0
            If Not isIP(txtRangeA.Text) Then
                txtNWError.Text &= "Strange RangeA" & vbCrLf
                strangeRange = 1
            End If
            If Not isIP(txtRangeB.Text) Then
                txtNWError.Text &= "Strange RangeB" & vbCr
                strangeRange += 2
            End If
            If (strangeRange = 0) Then
                res &= tabStr & "range " & txtRangeA.Text & " " & txtRangeB.Text & ";" & newLine
            ElseIf (strangeRange = 1) Then
                res &= tabStr & "range " & txtRangeB.Text & ";" & newLine
            ElseIf (strangeRange = 2) Then
                res &= tabStr & "range " & txtRangeA.Text & ";" & newLine
            End If

            ' サブネット
            If isIP(txtSubnet.Text) Then
                res &= tabStr & "option subnet-mask " & txtSubnet.Text & ";" & newLine
            Else
                txtNWError.Text &= "Strange Subnet-mask" & newLine
            End If

            ' ブロードキャスト
            If isIP(txtBroadcast.Text) Then
                res &= tabStr & "option broadcast-address " & txtBroadcast.Text & ";" & newLine
            Else
                txtNWError.Text &= "Strange Broadcast Address" & newLine
            End If

            ' ルーター (ゲートウェイ)
            Dim routersError As String = ""
            Dim addRouters As String = createIPLists(lstRouters, "Routers", routersError)
            If (addRouters.Length > 0) Then
                res &= tabStr & "option routers " & addRouters & ";" & newLine
            End If
            txtNWError.Text &= routersError


            res &= newLine

            ' DNS Server
            Dim dnsErrors As String = ""
            Dim addDNS As String = createIPDomainLists(lstDNS, "DNS Servers", dnsErrors)
            If (addDNS.Length > 0) Then
                res &= tabStr & "option domain-name-servers " & addDNS & ";" & newLine
            End If
            txtNWError.Text &= dnsErrors

            ' Domain name
            If (txtDomainName.Text.Length > 0) Then
                res &= tabStr & "option domain-name """ & txtDomainName.Text & """;" & newLine
            End If

            res &= newLine

            ' default-lease
            If (IsNumeric(txtDefaultLease.Text)) Then
                res &= tabStr & "default-lease-time " & txtDefaultLease.Text & ";" & newLine
            ElseIf (txtDefaultLease.Text.Length > 0) Then
                txtNWError.Text &= "Strange Defalt-Lease Time value" & vbCrLf
            End If
            ' max-lease
            If (IsNumeric(txtMaxLease.Text)) Then
                res &= tabStr & "max-lease-time " & txtMaxLease.Text & ";" & newLine
            ElseIf (txtMaxLease.Text.Length > 0) Then
                txtNWError.Text &= "Strange Max-Lease Time value" & vbCrLf
            End If

            ' unknown-clients
            If (cmbUnknown.SelectedIndex > 0) Then
                res &= tabStr & cmbUnknown.SelectedItem.ToString.ToLower & " unknown-clients;" & newLine
            End If

            res &= newLine

            ' NTP
            Dim ntpErrors As String = ""
            Dim addNTP As String = createIPDomainLists(lstNTP, "NTP Servers", ntpErrors)
            If (addNTP.Length > 0) Then
                res &= tabStr & "option ntp-servers " & addNTP & ";" & newLine
            End If
            txtServiceError.Text &= ntpErrors
            ' NTP Time Offset
            If (cmbTimeOffset.SelectedIndex > 0) Then
                res &= tabStr & "option time-offset " & encodeUTCOffset(cmbTimeOffset.SelectedItem) & ";" & newLine
            End If

            ' NetBIOS (WINS)
            Dim winsErrors As String = ""
            Dim addWINS As String = createIPDomainLists(lstWINS, "WINS Servers", winsErrors)
            If (addWINS.Length > 0) Then
                res &= tabStr & "option netbios-name-servers " & addWINS & ";" & newLine
            End If
            txtServiceError.Text &= winsErrors
            ' NetBIOS (WINS-DD)
            Dim winsDDErrors As String = ""
            Dim addWINSDD As String = createIPDomainLists(lstWINSDD, "WINS DD Servers", winsDDErrors)
            If (addWINSDD.Length > 0) Then
                res &= tabStr & "option netbios-dd-server " & addWINSDD & ";" & newLine
            End If
            txtServiceError.Text &= winsDDErrors
            ' NetBIOS (node-type)
            If (cmbWINSNodeType.SelectedIndex > 0) Then
                res &= tabStr & "option netbios-node-type " & (2 ^ (cmbWINSNodeType.SelectedIndex - 1)) & ";" & newLine
            End If

            ' WPAD
            Dim wpadURL As String = txtWPAD.Text.Trim
            If (wpadURL.Length > 0) Then
                res &= tabStr & "option wpad code 252 = text;" & newLine & tabStr & "option wpad """ & wpadURL & """;" & newLine
            End If
        End If

        With staticList
            If (.Rows(.RowCount - 1).IsNewRow) Then
                size = .RowCount - 2
            Else
                size = .RowCount - 1
            End If

            'res = ""
            For i As Integer = 0 To size
                Dim str As String = biasStr & "host " ' 個別生成対象
                Dim t As String ' 試験用文字列

                ' マシーン名
                If (.Item(0, i).Value Is Nothing) Then
                    str &= "machine" & (i + 1)
                Else
                    t = .Item(0, i).Value.ToString.Trim
                    If (t.Length = 0) Then
                        str &= "machine" & (i + 1)
                    Else
                        str &= t
                    End If
                End If

                str &= " {" & newLine

                ' MAC アドレス
                If (.Item(1, i).Value Is Nothing) Then
                    txtError.Text &= "Strange MAC Line: " & (i + 1)
                    Continue For
                ElseIf (isMAC(.Item(1, i).Value.ToString)) Then
                    str &= longTabStr & "hardware ethernet " & .Item(1, i).Value.ToString.Trim & ";" & newLine
                Else
                    txtError.Text &= "Strange MAC Line: " & (i + 1)
                    Continue For
                End If

                ' IP アドレス
                If (.Item(2, i).Value Is Nothing) Then
                    txtError.Text &= "Strange IP Address Line: " & (i + 1)
                    Continue For
                ElseIf (isIP(.Item(2, i).Value.ToString.Trim)) Then
                    str &= longTabStr & "fixed-address " & .Item(2, i).Value.ToString.Trim & ";" & newLine
                Else
                    txtError.Text &= "Strange IP Address Line: " & (i + 1)
                    Continue For
                End If

                ' ホスト名
                If (.Item(3, i).Value IsNot Nothing) Then
                    str &= longTabStr & "option host-name " & .Item(3, i).Value.ToString.Trim & ";" & newLine
                End If
                str &= biasStr & "}" & newLine

                res &= str
            Next i
        End With

        ' とじる
        If Not chkMachinesOnly.Checked Then
            res &= "}" & newLine
        End If

        txtRes.Text = res
    End Sub

    ''' <summary>
    ''' 生成テキストがダブルクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtRes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRes.DoubleClick
        txtRes.SelectAll()
    End Sub

    ''' <summary>
    ''' 保存ボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (txtRes.Text.Length > 0) Then
            If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Try
                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, txtRes.Text, False)
                Catch ex As Exception
                    MsgBox("Write fail!")
                End Try
            End If
        Else
            MsgBox("生成ファイル対象が空です。")
        End If
    End Sub


    ' ##########################################
    '   Machines Tab
    ' ##########################################

    ''' <summary>
    ''' Import ボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        clearDialog(OpenFileDialog1)

        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Try
                txtError.Text = ""
                Dim f As String = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName, System.Text.Encoding.Default)

                ' ファイルのパース
                Dim lists() As String = f.Split(vbCrLf)
                Dim size As Integer = lists.Length

                ' 区切りの指定
                Dim sep As String = ","
                If (OpenFileDialog1.FilterIndex = 1) Then
                    sep = ","
                ElseIf (OpenFileDialog1.FilterIndex = 2) Then
                    sep = vbTab
                ElseIf (OpenFileDialog1.FilterIndex = 3) Then
                    sep = " "
                End If

                With staticList
                    .Rows.Clear()
                    For i As Integer = 0 To size - 1
                        Dim tmp() As String = lists(i).Split(sep)
                        If (tmp.Length < 3) Then
                            txtError.Text = "Strange Format Line: " & (i + 1)
                            Continue For
                        Else
                            .Rows.Add(tmp)
                        End If
                    Next i
                End With

            Catch ex As Exception
                MsgBox("fail open!")
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Export が押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        clearDialog(SaveFileDialog1)

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sep As String = ","     ' 区切り文字
            With SaveFileDialog1
                If .FilterIndex = 2 Then
                    sep = vbTab
                ElseIf .FilterIndex = 3 Then
                    sep = " "
                End If
            End With
            Try
                With staticList
                    Dim size As Integer = IIf(.Rows(.Rows.Count - 1).IsNewRow, .Rows.Count - 2, .Rows.Count - 1)

                    Dim out As String = ""
                    For i As Integer = 0 To size Step 1
                        Dim tstr As String = ""
                        For j As Integer = 0 To 3 Step 1
                            If (.Item(j, i).Value Is Nothing) Then
                                tstr &= sep
                            Else
                                tstr &= .Item(j, i).Value.ToString & sep
                            End If
                        Next j
                        out &= tstr.Substring(0, tstr.Length - 1) & vbCrLf
                    Next i

                    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, out.TrimEnd, False)
                End With
            Catch ex As Exception
                txtError.Text = "Fail Export"
            End Try
        End If
    End Sub

    ''' <summary>
    ''' クリアが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        staticList.Rows.Clear()
    End Sub

    ' ##########################################
    '   Network Tab
    ' ##########################################

    ''' <summary>
    ''' leaseのデフォルトが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLeaseDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeaseDefault.Click
        txtDefaultLease.Text = "600"
        txtMaxLease.Text = "7200"
    End Sub

    ''' <summary>
    ''' leaseのクリアーが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLeaseClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeaseClear.Click
        txtDefaultLease.Text = ""
        txtMaxLease.Text = ""
    End Sub

    ''' <summary>
    ''' domainのインポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDomainImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDomainImport.Click
        Dim err As String = ""
        txtNWError.Text = ""

        clearDialog(ofdImport)

        If ofdImport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            importData(ofdImport.FileName, lstDNS, "DNS Servers", err)
            txtNWError.Text = err
        End If
    End Sub

    ''' <summary>
    ''' domainエクスポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDomainExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDomainExport.Click
        Dim err As String = ""
        txtNWError.Text = ""

        clearDialog(sfdExport)

        If sfdExport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                My.Computer.FileSystem.WriteAllText(sfdExport.FileName, createExportData(lstDNS, "DNS Servers"), False)
            Catch ex As Exception
                txtNWError.Text = "Export Error"
            End Try
        End If
    End Sub

    ''' <summary>
    ''' DNSのクリアー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClearDNS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearDNS.Click
        Dim size As Integer
        With lstDNS
            size = IIf(.Rows(.Rows.Count - 1).IsNewRow, .Rows.Count - 1, .Rows.Count)
        End With
        If size > 0 Then
            If (MessageBox.Show("Clear DNS Servers ?", "kakunin", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
                clearDataGridView(lstDNS)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Routersのインポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRoutersImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoutersImport.Click
        Dim err As String = ""
        txtNWError.Text = ""

        clearDialog(ofdImport)

        If ofdImport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            importData(ofdImport.FileName, lstRouters, "Routers", err)
            txtNWError.Text = err
        End If
    End Sub

    ''' <summary>
    ''' Routersのエクスポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRoutersExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoutersExport.Click
        Dim err As String = ""
        txtNWError.Text = ""

        clearDialog(sfdExport)

        If sfdExport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                My.Computer.FileSystem.WriteAllText(sfdExport.FileName, createExportData(lstRouters, "Routers"), False)
            Catch ex As Exception
                txtNWError.Text = "Export Error"
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Routersのクリアー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRoutersClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoutersClear.Click
        Dim size As Integer
        With lstRouters
            size = IIf(.Rows(.Rows.Count - 1).IsNewRow, .Rows.Count - 1, .Rows.Count)
        End With
        If (size > 0) Then
            If (MessageBox.Show("Clear Routers ?", "kakunin", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
                clearDataGridView(lstRouters)
            End If
        End If
    End Sub

    ''' <summary>
    ''' ネットワーク自動判定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAutoDetect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoDetect.Click
        Dim nw As UInteger = 0
        Dim subnet As UInteger = 0

        If Not chkAreaNewtwork_Subnetmask(nw, subnet) Then
            Exit Sub
        End If

        ' サブネット
        txtSubnet.Text = txtAreaSubnet.Text
        ' ブロードキャスト
        Dim broad As UInteger = nw Or (Not subnet)
        txtBroadcast.Text = ipIntToStr(broad)
        ' 範囲
        cmbIPnum.SelectedIndex = 0
        txtRangeA.Text = ipIntToStr(nw + 2)
        txtRangeB.Text = ipIntToStr(broad - 1)

        ' ゲートウェイ
        clearDataGridView(lstRouters)
        lstRouters.Rows.Add(ipIntToStr(nw + 1))
    End Sub

    ''' <summary>
    ''' IPnumの選択が変わった
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmbIPnum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIPnum.SelectedIndexChanged
        If cmbIPnum.SelectedIndex = 0 Then
            Exit Sub
        End If

        txtNWError.Text = ""
        Dim nw As UInteger = 0
        Dim subnet As UInteger = 0

        If Not chkAreaNewtwork_Subnetmask(nw, subnet) Then
            Exit Sub
        End If

        ' ブロードキャスト
        Dim broad As UInteger = nw Or (Not subnet)
        Dim hasIP As Integer = (broad - 1) - (nw + 2) + 1

        If cmbIPnum.SelectedIndex = 1 Then
            ' max
            txtRangeA.Text = ipIntToStr(nw + 2)
            txtRangeB.Text = ipIntToStr(broad - 1)
        Else
            ' 数が指定
            Dim needNum As Integer = Int(cmbIPnum.SelectedItem)
            If (needNum <= hasIP) Then
                txtRangeA.Text = ipIntToStr(nw + 2)
                txtRangeB.Text = ipIntToStr(nw + needNum + 2)
            Else
                txtNWError.Text = "too many IPs you need." & vbCrLf
                txtRangeA.Text = ipIntToStr(nw + 2)
                txtRangeB.Text = ipIntToStr(broad - 1)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Area Network と Area Subnet が正しく指定されているかチェック
    ''' </summary>
    ''' <param name="nw"></param>
    ''' <param name="subnet"></param>
    ''' <returns></returns>
    Private Function chkAreaNewtwork_Subnetmask(ByRef nw As UInteger, ByRef subnet As UInteger) As Boolean
        If Not (isIP(txtAreaNetwork.Text)) Then
            txtNWError.Text = "Strange Area Network" & vbCrLf
            Return False
        End If
        If Not (isIP(txtAreaSubnet.Text)) Then
            txtNWError.Text = "Strange Area Subnet" & vbCrLf
            Return False
        End If

        ' N/W とサブネットを用意
        nw = ipStrToInt(txtAreaNetwork.Text)
        subnet = ipStrToInt(txtAreaSubnet.Text)

        ' 正しい設定か判定
        If (nw And subnet) <> nw Then
            txtNWError.Text = "Invalid Area Network and Area Subnet" & vbCrLf
            Return False
        End If

        Return True
    End Function

    ' ##########################################
    '   Network Service Tab
    ' ##########################################

    ''' <summary>
    ''' JTC
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnJTC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJSC.Click
        cmbTimeOffset.SelectedIndex = 9
    End Sub

    ''' <summary>
    ''' NTPのクリアー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClearNTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearNTP.Click
        Dim size As Integer
        With lstNTP
            size = IIf(.Rows(.Rows.Count - 1).IsNewRow, .Rows.Count - 1, .Rows.Count)
        End With
        If (size > 0) Then
            If (MessageBox.Show("Clear NTP Servers ?", "kakunin", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
                clearDataGridView(lstNTP)
            End If
        End If
    End Sub

    ''' <summary>
    ''' NTPインポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnImportNTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportNTP.Click
        Dim err As String = ""
        txtServiceError.Text = ""

        clearDialog(ofdImport)

        If ofdImport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            importData(ofdImport.FileName, lstNTP, "NTP Servers", err)
            txtServiceError.Text = err
        End If
    End Sub

    ''' <summary>
    ''' NTPエクスポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExportNTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportNTP.Click
        Dim err As String = ""
        txtServiceError.Text = ""

        clearDialog(sfdExport)

        If sfdExport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                My.Computer.FileSystem.WriteAllText(sfdExport.FileName, createExportData(lstNTP, "NTP Servers"), False)
            Catch ex As Exception
                txtServiceError.Text = "Export Error"
            End Try
        End If
    End Sub

    ''' <summary>
    ''' WINSクリアー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClearWINS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearWINS.Click
        Dim size As Integer
        With lstWINS
            size = IIf(.Rows(.Rows.Count - 1).IsNewRow, .Rows.Count - 1, .Rows.Count)
        End With
        If (size > 0) Then
            If (MessageBox.Show("Clear WINS Servers ?", "kakunin", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
                clearDataGridView(lstWINS)
            End If
        End If
    End Sub

    ''' <summary>
    ''' WINSインポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnImportWINS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportWINS.Click
        Dim err As String = ""
        txtServiceError.Text = ""

        clearDialog(ofdImport)

        If ofdImport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            importData(ofdImport.FileName, lstWINS, "WINS Servers", err)
            txtServiceError.Text = err
        End If
    End Sub

    ''' <summary>
    ''' WINSエクスポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExportWINS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportWINS.Click
        Dim err As String = ""
        txtServiceError.Text = ""

        clearDialog(sfdExport)

        If sfdExport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                My.Computer.FileSystem.WriteAllText(sfdExport.FileName, createExportData(lstWINS, "WINS Servers"), False)
            Catch ex As Exception
                txtServiceError.Text = "Export Error"
            End Try
        End If
    End Sub

    ''' <summary>
    ''' WINSDDクリアー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClearWINSDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearWINSDD.Click
        Dim size As Integer
        With lstWINSDD
            size = IIf(.Rows(.Rows.Count - 1).IsNewRow, .Rows.Count - 1, .Rows.Count)
        End With
        If (size > 0) Then
            If (MessageBox.Show("Clear WINS-DD Servers ?", "kakunin", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
                clearDataGridView(lstWINSDD)
            End If
        End If
    End Sub

    ''' <summary>
    ''' WINSDDインポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnImportWINSDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportWINSDD.Click
        Dim err As String = ""
        txtServiceError.Text = ""

        clearDialog(ofdImport)

        If ofdImport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            importData(ofdImport.FileName, lstWINSDD, "WINS-DD Servers", err)
            txtServiceError.Text = err
        End If
    End Sub

    ''' <summary>
    ''' WINSDDエクスポート
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExportWINSDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportWINSDD.Click
        Dim err As String = ""
        txtServiceError.Text = ""

        clearDialog(sfdExport)

        If sfdExport.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                My.Computer.FileSystem.WriteAllText(sfdExport.FileName, createExportData(lstWINSDD, "WINS-DD Servers"), False)
            Catch ex As Exception
                txtServiceError.Text = "Export Error"
            End Try
        End If
    End Sub


    ' ##########################################
    '   プロシージャー
    ' ##########################################

    ''' <summary>
    ''' MAC アドレスか判定
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Function isMAC(ByVal str As String) As Boolean
        Dim ptn As String = "([0-9A-F]{2}:){5}[0-9A-F]{2}"
        Return Regex.IsMatch(str, ptn)
    End Function

    ''' <summary>
    ''' IP アドレスか判定
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Function isIP(ByVal str As String) As Boolean
        Dim strAry() As String = str.Split(".")
        If (strAry.Length <> 4) Then
            Return False
        Else
            For i As Integer = 0 To 3
                If (IsNumeric(strAry(i))) Then
                    Dim v As Integer = CInt(strAry(i))
                    If (v < 0 Or v > 255) Then
                        Return False
                    End If
                Else
                    Return False
                End If
            Next i
            Return True
        End If
    End Function

    ''' <summary>
    ''' IP アドレスの文字列を UInt に変換
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Function ipStrToInt(ByVal str As String) As UInteger
        Dim ary() As String = str.Split(".")
        Dim ip As UInteger = 0
        For i = 0 To 3 Step 1
            ip <<= 8
            ip = ip Or Convert.ToUInt32(ary(i))
        Next i
        Return ip
    End Function

    ''' <summary>
    ''' intのIPアドレスを文字列に変換
    ''' </summary>
    ''' <param name="v"></param>
    ''' <returns></returns>
    Function ipIntToStr(ByVal v As UInteger) As String
        Dim ip As String = ""
        Dim mask As UInteger = 255

        For i As Integer = 0 To 3
            ip = Convert.ToString(v And mask) & "." & ip
            v >>= 8
        Next i
        Return ip.Substring(0, ip.Length - 1)
    End Function

    ''' <summary>
    ''' DataGridView から IP アドレスの一覧を作る
    ''' </summary>
    ''' <param name="lst"></param>
    ''' <param name="dataName"></param>
    ''' <param name="err"></param>
    ''' <param name="col"></param>
    ''' <returns></returns>
    Private Function createIPLists(ByVal lst As DataGridView, ByVal dataName As String, Optional ByRef err As String = "", Optional ByVal col As Integer = 0) As String
        Dim ret As String = ""
        err = ""

        With lst
            Dim size As Integer = 0
            If .Rows(.Rows.Count - 1).IsNewRow Then
                size = .Rows.Count - 2
            Else
                size = .Rows.Count - 1
            End If

            If (size >= 0) Then
                For i As Integer = 0 To size Step 1
                    If (.Item(col, i).Value Is Nothing) Then
                        err &= "Empty " & dataName & " (line: " & (i + 1) & ")" & vbCrLf
                    ElseIf Not isIP(.Item(col, i).Value.ToString.Trim) Then
                        err &= "Strange " & dataName & " (line: " & (i + 1) & ")" & vbCrLf
                    Else
                        ret &= .Item(col, i).Value.ToString.Trim & ", "
                    End If
                Next i
            End If
        End With

        If (ret.Length > 0) Then
            Return ret.Substring(0, ret.Length - 2)
        Else
            Return ""
        End If
    End Function

    ''' <summary>
    ''' DataGridView から IP アドレスとドメインの一覧を作る
    ''' </summary>
    ''' <param name="lst"></param>
    ''' <param name="dataName"></param>
    ''' <param name="err"></param>
    ''' <param name="col"></param>
    ''' <returns></returns>
    Private Function createIPDomainLists(ByVal lst As DataGridView, ByVal dataName As String, Optional ByRef err As String = "", Optional ByVal col As Integer = 0) As String
        Dim ret As String = ""
        err = ""

        With lst
            Dim size As Integer = 0
            If .Rows(.Rows.Count - 1).IsNewRow Then
                size = .Rows.Count - 2
            Else
                size = .Rows.Count - 1
            End If

            If (size >= 0) Then
                For i As Integer = 0 To size Step 1
                    If (.Item(col, i).Value Is Nothing) Then
                        err &= "Empty " & dataName & " (line: " & (i + 1) & ")" & vbCrLf
                    Else
                        ret &= .Item(col, i).Value.ToString.Trim & ", "
                    End If
                Next i
            End If
        End With

        If (ret.Length > 0) Then
            Return ret.Substring(0, ret.Length - 2)
        Else
            Return ""
        End If
    End Function

    ''' <summary>
    ''' UTC からの差から、オフセット秒を算出する
    ''' </summary>
    ''' <param name="v"></param>
    ''' <returns></returns>
    Private Function encodeUTCOffset(ByVal v As String) As Integer
        Dim offsetValue As Integer = 0

        ' 0 以外
        If (v.Length > 1) Then
            Dim tmp As String() = v.Substring(1, v.Length - 1).Split(":")
            If (tmp.Length = 1) Then
                offsetValue = Int(tmp(0)) * 3600
            Else
                offsetValue = Int(tmp(0)) * 3600 + Int(tmp(1)) * 60
            End If

            ' 負の値
            If (v.Chars(0) = "-") Then
                offsetValue = -offsetValue
            End If
        End If
        Return offsetValue
    End Function

    ''' <summary>
    ''' 汎用 Export データの生成
    ''' </summary>
    ''' <param name="lst"></param>
    ''' <param name="dataType"></param>
    ''' <param name="col"></param>
    ''' <returns></returns>
    Private Function createExportData(ByVal lst As DataGridView, ByVal dataType As String, Optional ByVal col As Integer = 0) As String
        Dim ret As String = "1," & dataType & vbCrLf
        With lst
            Dim size As Integer = 0
            If .Rows(.Rows.Count - 1).IsNewRow Then
                size = .Rows.Count - 2
            Else
                size = .Rows.Count - 1
            End If

            For i As Integer = 0 To size Step 1
                If Not (.Item(col, i).Value Is Nothing) Then
                    ret &= .Item(col, i).Value.ToString.Trim & vbCrLf
                End If
            Next i
        End With
        Return ret.TrimEnd
    End Function

    ''' <summary>
    ''' 汎用 Import
    ''' </summary>
    ''' <param name="fn"></param>
    ''' <param name="lst"></param>
    ''' <param name="dataType"></param>
    ''' <param name="err"></param>
    ''' <param name="col"></param>
    ''' <returns></returns>
    Private Function importData(ByVal fn As String, ByVal lst As DataGridView, ByVal dataType As String, Optional ByRef err As String = "", Optional ByVal col As Integer = 0) As Boolean
        ' 初期化
        err = ""
        clearDataGridView(lst)

        ' 定義
        Dim fs As System.IO.FileStream = Nothing
        Dim sr As System.IO.StreamReader = Nothing

        Try
            fs = New System.IO.FileStream(fn, IO.FileMode.Open, IO.FileAccess.Read)
            sr = New System.IO.StreamReader(fs)

            Dim header As String = sr.ReadLine
            Dim headers() As String = header.Split(",")

            ' ただのリスト？
            If (headers.Length = 1) Then
                Return importDataV0(sr, lst, err, col)
            Else
                ' ヘッダーになっている

                ' バージョンチェック
                If (IsNumeric(headers(0))) Then
                    Dim ver As Integer = Int(headers(0))

                    If (String.Compare(headers(1), dataType) <> 0) Then
                        err &= "!Attention invalid data type ?" & vbCrLf
                    End If

                    If ver = 1 Then
                        Return importDataV1(sr, lst, err, col)
                    Else
                        err &= "Strange version imported file." & vbCrLf
                        Return False
                    End If
                Else
                    err &= "Strange file format imported file." & vbCrLf
                    Return False
                End If
            End If
        Catch ex As Exception
            err &= "Import Error. " & ex.Message & vbCrLf
            Return False
        End Try
    End Function

    ''' <summary>
    ''' 単なるリスト
    ''' </summary>
    ''' <param name="sr"></param>
    ''' <param name="lst"></param>
    ''' <param name="err"></param>
    ''' <param name="col"></param>
    ''' <returns></returns>
    Private Function importDataV0(ByVal sr As System.IO.StreamReader, ByVal lst As DataGridView, ByRef err As String, ByVal col As Integer) As Boolean
        If (sr Is Nothing) Then
            Return False
        Else
            Dim cnt As Integer = 0
            ' 1 行ずつ追加
            With lst
                Do While Not sr.EndOfStream
                    .Rows.Add()
                    .Item(col, cnt).Value = sr.ReadLine.Trim
                    cnt += 1
                Loop
            End With
            Return True
        End If
    End Function

    ''' <summary>
    ''' version.1 のファイルのインポート
    ''' </summary>
    ''' <param name="sr"></param>
    ''' <param name="lst"></param>
    ''' <param name="err"></param>
    ''' <param name="col"></param>
    ''' <returns></returns>
    Private Function importDataV1(ByVal sr As System.IO.StreamReader, ByVal lst As DataGridView, ByRef err As String, ByVal col As Integer) As Boolean
        If (sr Is Nothing) Then
            Return False
        Else
            ' 1 行ずつ追加
            Dim cnt As Integer = 0
            With lst
                Do While Not sr.EndOfStream
                    .Rows.Add()
                    .Item(col, cnt).Value = sr.ReadLine.Trim
                    cnt += 1
                Loop
            End With
            Return True
        End If
    End Function

    ''' <summary>
    ''' DataGridView を空にする
    ''' </summary>
    ''' <param name="d"></param>
    Private Sub clearDataGridView(ByVal d As DataGridView)
        Dim size As Integer = 0
        With d
            If .Rows(.Rows.Count - 1).IsNewRow Then
                size = .Rows.Count - 2
            Else
                size = .Rows.Count - 1
            End If
            If (size >= 0) Then
                For i As Integer = size To 0 Step -1
                    .Rows.RemoveAt(i)
                Next i
            End If
        End With
    End Sub

    ''' <summary>
    ''' SaveFileDialog, OpenFileDialog を初期化する
    ''' </summary>
    ''' <param name="d"></param>
    Private Sub clearDialog(ByVal d As FileDialog)
        If (TypeOf d Is SaveFileDialog) Or (TypeOf d Is OpenFileDialog) Then
            With d
                If (.FileName.Length > 0) Then
                    .InitialDirectory = System.IO.Path.GetDirectoryName(.FileName)
                    .FileName = ""
                End If
            End With
        End If
    End Sub
End Class
