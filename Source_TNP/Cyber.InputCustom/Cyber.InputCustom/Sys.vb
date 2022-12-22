Imports System.Data.SqlClient
Public Class Sys
    Public Function Initvao(ByVal M_Para As String()) As Boolean
        Dim CyberPw As New Cyber.InputCustomPW.Sys
        If CyberPw.Initvao(M_Para) Then
            Return True
            Exit Function
        End If
        '------------------------------------------------------------------------------------
        Dim CyberSmlib As New Cyber.SmLib.Sys
        Dim CyberSmodb As New Cyber.Smodb.Sys
        Dim CyberFill As New Cyber.Fill.Sys
        Dim CyberSupport As New Cyber.Support.Sys
        Dim CyberLoading As New Cyber.Loading.Loading
        Dim CyberFrom As New Cyber.From.Sys
        '------------------------------------------------------------------------------------
        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        Dim M_User_Name As String = M_Para(6).Trim
        Dim M_LAN As String = M_Para(13).Trim
        Dim M_Ma_Dvcs As String = M_Para(14).Trim
        Dim M_Ma_GD As String = M_Para(M_VT_PARA + 1).Trim
        Dim M_Ma_CT As String = M_Para(M_VT_PARA + 2).Trim
        Dim M_Stt_Rec As String = M_Para(M_Para.Length - 1).Trim

        '------------------------------------------------------------------------------------
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(M_LAN)
        Dim Frm As Cyber.From.Frmvoucher = Nothing
        M_Ma_CT = M_Ma_CT.Trim.ToUpper
        'Select Case M_Ma_CT.Trim.ToUpper
        '    Case "PC1", "BN1"
        '        Frm = New PC1
        '    Case "PT1", "BC1"
        '        Frm = New PT1
        '    Case "DM1", "DM1", "DM3", "DM4", "DM5", "DM5", "DM7", "DM8", "DM9"
        '        Frm = New DM1
        '    Case Else
        '        Frm = pGettype(M_Ma_CT)
        'End Select
        Frm = pGettype(M_Ma_CT)
        If Frm Is Nothing Then
            If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
            Return False
        End If

        '------------------------------------------------------------------------------------
        Dim Appconn As SqlConnection = CyberSmlib.GetConn()
        Dim oSysvar As Collection = CyberSmlib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
        '------------------------------------------------------------------------------------
        Dim DrDmct As DataRow = CyberSmodb.SQLGetRow(Appconn, "DMCT", "Ma_CT =N'" + M_Ma_CT.Trim + "'", CyberSmlib)
        Dim M_DsHead As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HeadVoucher", M_Ma_CT.Trim + "#" + M_User_Name)
        Dim M_strFilter As String = "1###" + M_Stt_Rec + "#19000101#19000101#0#9#" + M_Ma_CT.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim M_DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_Filter" + M_Ma_CT.Trim, M_strFilter)
        For i As Integer = 0 To M_DsData.Tables.Count - 1
            CyberSmodb.SetNotNullTable(M_DsData.Tables(i))
        Next
        Dim M_DsLooKup As New DataSet
        '------------------------------------------------------------------------------------
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        '------------------------------------------------------------------------------------
        '---Head
        '------------------------------------------------------------------------------------
        Dim nCount As Integer = M_DsData.Tables(1).Rows.Count
        'If nCount > 1 Then M_Stt_Rec = CyberFrom.V_ViewVoucher(Appconn, oSysvar, M_LAN, M_Para, DrDmct, M_DsData, M_DsHead, M_DsLooKup, Nothing, Nothing, M_Stt_Rec, M_strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
        If nCount > 1 Then
            If M_Ma_CT = "HDK" Or M_Ma_CT = "HDP" Or M_Ma_CT = "HDM" Then
                M_Stt_Rec = CyberFrom.V_ViewVoucher2(Appconn, oSysvar, M_LAN, M_Para, DrDmct, M_DsData, M_DsHead, M_DsLooKup, Nothing, Nothing, Nothing, M_Stt_Rec, M_strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
            Else
                M_Stt_Rec = CyberFrom.V_ViewVoucher(Appconn, oSysvar, M_LAN, M_Para, DrDmct, M_DsData, M_DsHead, M_DsLooKup, Nothing, Nothing, M_Stt_Rec, M_strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
            End If
        End If

        If nCount = 1 Then M_Stt_Rec = M_DsData.Tables(1).Rows(0).Item("Stt_Rec")
        If nCount <= 0 Then M_Stt_Rec = ""
        ''------------------------------------------------------------------------------------
        ''---GK
        'If M_Ma_CT = "PK1" Then Frm = New PK1
        ' ''If M_Ma_CT = "PK2" Then Frm = New PK2
        ' ''---CA
        'If M_Ma_CT = "PT1" Then Frm = New PT1
        'If M_Ma_CT = "BC1" Then Frm = New PT1

        'If M_Ma_CT = "PC1" Then Frm = New PC1
        'If M_Ma_CT = "BN1" Then Frm = New PC1
        ''SO
        'If M_Ma_CT = "HDA" Then Frm = New HDA
        'If M_Ma_CT = "HD1" Then Frm = New HD1
        'If M_Ma_CT = "PNF" Then Frm = New PNF
        ''PO
        'If M_Ma_CT = "PNA" Then Frm = New PNA
        'If M_Ma_CT = "PNB" Then Frm = New PNB
        'If M_Ma_CT = "PNC" Then Frm = New PNC
        'If M_Ma_CT = "PN1" Then Frm = New PN1
        'If M_Ma_CT = "PN2" Then Frm = New PN2
        'If M_Ma_CT = "PXF" Then Frm = New PXF
        'If M_Ma_CT = "PNG" Then Frm = New PNG
        ''----IN
        'If M_Ma_CT = "PXD" Then Frm = New PXD
        'If M_Ma_CT = "PND" Then Frm = New PND
        'If M_Ma_CT = "PXE" Then Frm = New PXE
        ''----IM
        'If M_Ma_CT = "PXI" Then Frm = New PXI
        'If M_Ma_CT = "PNI" Then Frm = New PNI
        'If M_Ma_CT = "PNT" Then Frm = New PNT
        'If M_Ma_CT = "PXU" Then Frm = New PXU
        '------------------------------------------------------------------------------------
        'If M_Ma_CT = "HDH" Then Frm = New HDH
        'If M_Ma_CT = "HDL" Then Frm = New HDL
        'If M_Ma_CT = "PXL" Then Frm = New PXL
        'If M_Ma_CT = "HDB" Then Frm = New HDB
        '------------------------------------------------------------------------------------
        'If M_Ma_CT = "POD" Then Frm = New POD
        'If M_Ma_CT = "PNK" Then Frm = New PNK
        '------------------------------------------------------------------------------------San xuat
        'If M_Ma_CT = "KH1" Or M_Ma_CT = "KH2" Or M_Ma_CT = "KH3" Or M_Ma_CT = "KH4" Or M_Ma_CT = "KH5" Or M_Ma_CT = "KH6" Or M_Ma_CT = "KH7" Or M_Ma_CT = "KH8" Or M_Ma_CT = "KH9" Then Frm = New KH1
        'If M_Ma_CT = "DM1" Or M_Ma_CT = "DM2" Or M_Ma_CT = "DM3" Or M_Ma_CT = "DM4" Or M_Ma_CT = "DM5" Then Frm = New DM1
        '------------------------------------------------------------------------------------
        'If M_Ma_CT = "KH1" Then Frm = New KH1
        'If M_Ma_CT = "KH3" Then Frm = New KH3
        'If M_Ma_CT = "KH4" Then Frm = New KH4
        'If M_Ma_CT = "KH6" Then Frm = New KH6
        'If M_Ma_CT = "KH9" Then Frm = New KH9
        '------------------------------------------------------------------------------------
        Frm.strFilter = M_strFilter
        Frm.DrDmct = DrDmct
        Frm.SysVar = oSysvar
        Frm.Lan = M_LAN
        Frm.Stt_Rec = M_Stt_Rec
        Frm.Para = M_Para
        Frm.AppConn = Appconn
        Frm.DsData = M_DsData
        Frm.DsHead = M_DsHead
        Frm.DsLookup = M_DsLooKup
        Frm.ShowDialog()
        Return True
    End Function
    
    Public Function GetFormPrintVoucher(ByVal M_ma_CT) As Cyber.From.FrmPrintVoucher
        Dim _Return As Cyber.From.FrmPrintVoucher = Nothing
        'If M_ma_CT.ToString.ToUpper = "PT1" Then _Return = New FrmPrintVoucher
        'If M_ma_CT.ToString.ToUpper = "HDK" Then _Return = New FrmPrintVoucherHDK
        Dim CyberInput As New Cyber.Input.Sys
        _Return = CyberInput.GetFormPrintVoucher(M_ma_CT)
        'If _Return Is Nothing Then
        '    If M_ma_CT.ToString.ToUpper = "HDK" Then _Return = New Cyber.Input.FrmPrintVoucherHDK
        'End If

        'If M_ma_CT.ToString.ToUpper = "HDS" Then _Return = New FrmPrintVoucherHDS
        Return _Return
    End Function


    Public Function GetFormFilterVoucher(ByVal M_ma_CT) As Cyber.From.FrmFilterVoucher
        Dim _Return As Cyber.From.FrmFilterVoucher = Nothing
        ' If M_ma_CT.ToString.ToUpper = "PT1" Then _Return = New Filter_PT1
        GetFormFilterVoucher = _Return
    End Function
    Public Function GetDia_Chi(ByVal _Ma_kh As String, ByVal _Dia_Chi As String, ByVal _Ma_Ct As String, ByVal _Mode As String, ByVal _App As SqlConnection, ByVal CyberSmlib As Cyber.SmLib.Sys, ByVal CyberSmodb As Cyber.Smodb.Sys) As String
        Dim _Return As String = ""
        If _Dia_Chi.Trim = "" Then
            _Return = CyberSmodb.SQLGetvalue(_App, "Dia_Chi", "Dmkh", "Ma_Kh = N'" + _Ma_kh.Trim.Replace("'", "").Replace("#", "") + "'", CyberSmlib)
            If _Return = "" Then _Return = _Dia_Chi
        Else
            _Return = _Dia_Chi
        End If
        GetDia_Chi = _Return
    End Function
    Public Function V_Thanh_Toan_HD(ByVal _App As SqlConnection, ByRef _Dt As DataTable, ByVal _Mode As String, ByVal _Ma_KH As String, ByVal _Ngay_Ct As Date, ByVal _Stt_Rec As String, ByVal _Ma_Ct As String, ByVal _Ma_NT As String, ByVal _Ma_Dvcs As String, ByVal _user_Name As String, Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing) As Boolean
        Dim _Return As Boolean = True
        If _Mode.Trim <> "M" Then Return False
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        Dim DsThanh_Toan As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_GetDetailArApTTPB", _Mode + "#" + _Ma_KH.Trim + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + _Stt_Rec + "#" + _Ma_Ct + "#" + _Ma_NT + "#" + _Ma_Dvcs + "#" + _user_Name)
        If DsThanh_Toan.Tables.Count < 1 Then Return False
        CyberSmodb.SetNotNullTable(DsThanh_Toan.Tables(0))
        _Dt.Clear()
        CyberSmodb.SQLTbToTb(DsThanh_Toan.Tables(0), _Dt)
        DsThanh_Toan.Dispose()
        V_Thanh_Toan_HD = _Return
    End Function
    Public Function SysGetNo(ByVal _App As SqlConnection, ByVal osysvar As Collection, ByVal _Mode As String, ByRef _SO As String, ByVal _Stt_Rec As String, ByVal _Ngay_Ct As Date, ByVal _Ngay_Lct As Date, ByVal _Ma_GD As String, ByVal _Ma_Ct As String, ByVal _Ma_Dvcs As String, ByVal _User_Name As String) As Boolean
        Dim _Return As Boolean = True
        Dim CyberSmlib As New Cyber.SmLib.Sys
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_SysGetNo", _Mode & "#" & _SO & "#" & _Stt_Rec & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & _Ngay_Lct.ToString("yyyyMMdd") & "#" & _Ma_GD & "#" & _Ma_Ct & "#" & _Ma_Dvcs & "#" & _User_Name)
        If _DsTmp.Tables.Count < 2 Then Return False
        If _DsTmp.Tables(0).Rows.Count < 1 Then Return False
        If _DsTmp.Tables(1).Rows.Count < 1 Then Return False
        Dim _Status As String = ""
        Dim _Msg As String = ""
        Dim _Note As String = ""
        Dim _M_SO As String = ""

        If _DsTmp.Tables(0).Columns.Contains("Status") Then _Status = _DsTmp.Tables(0).Rows(0).Item("Status").ToString.Trim
        If _DsTmp.Tables(0).Columns.Contains("Msg") Then _Msg = _DsTmp.Tables(0).Rows(0).Item("Msg").ToString.Trim
        If _DsTmp.Tables(0).Columns.Contains("Note") Then _Note = _DsTmp.Tables(0).Rows(0).Item("Note").ToString.Trim
        If _DsTmp.Tables(1).Columns.Contains("M_SO") Then _M_SO = _DsTmp.Tables(1).Rows(0).Item("M_SO").ToString.Trim
        If _Status = "N" Then _Return = False
        If _Msg = "Y" Then MsgBox(_Note, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, osysvar("M_CYBER_VER"))
        If _Return And _M_SO <> "" Then _SO = _M_SO
        Return _Return
    End Function
    Private Function pGettype(ByVal ClassName As String) As Object
        Dim class_type As Type = Nothing
        Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        For Each ctrtype As Type In myAssembly.GetExportedTypes
            If ctrtype.Name.Trim.ToString.ToUpper = ClassName.Trim.ToUpper Then
                class_type = ctrtype
                Exit For
            End If
        Next
        If class_type Is Nothing Then Return class_type
        Return Activator.CreateInstance(class_type)
    End Function
    '=============================================================BH
    Public Function V_GetHDBFromPXL(ByVal _App As SqlConnection, ByVal _CyberSmlib As Cyber.SmLib.Sys, ByVal _Loai As String, ByVal _Px As String, ByVal _Ngay_Ct1 As String, ByVal _Ngay_Ct2 As String, ByVal _lenh_So As String, ByVal _Ma_kh As String, ByVal _Stt_Rec As String, ByVal _Ma_Ct As String, ByVal _Ma_Dvcs As String, ByVal _User_Name As String) As DataSet
        V_GetHDBFromPXL = _CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_GetHDBFromPXL", _Loai & "#" & _Px & "#" & _Ngay_Ct1 & "#" & _Ngay_Ct2 & "#" & _lenh_So & "#" & _Ma_kh & "#" & _Stt_Rec & "#" & _Ma_Ct & "#" & _Ma_Dvcs & "#" & _User_Name)
    End Function
    '=============================================================DO
    Public Function V_GetPNKFromPOD(ByVal _App As SqlConnection, ByVal _CyberSmlib As Cyber.SmLib.Sys, ByVal _Loai As String, ByVal _Ngay_Ct1 As String, ByVal _Ngay_Ct2 As String, ByVal _lenh_Po As String, ByVal _Ma_kh As String, ByVal _Stt_Rec As String, ByVal _Ma_Ct As String, ByVal _Ma_Dvcs As String, ByVal _User_Name As String) As DataSet
        V_GetPNKFromPOD = _CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_GetPNKFromPOD", _Loai & "#" & _Ngay_Ct1 & "#" & _Ngay_Ct2 & "#" & _lenh_Po & "#" & _Ma_kh & "#" & _Stt_Rec & "#" & _Ma_Ct & "#" & _Ma_Dvcs & "#" & _User_Name)
    End Function
    Public Function V_GetPNOFromPOD(ByVal _App As SqlConnection, ByVal _CyberSmlib As Cyber.SmLib.Sys, ByVal _Loai As String, ByVal _Ngay_Ct1 As String, ByVal _Ngay_Ct2 As String, ByVal _lenh_Po As String, ByVal _Ma_kh As String, ByVal _Stt_Rec As String, ByVal _Ma_Ct As String, ByVal _Ma_Dvcs As String, ByVal _User_Name As String) As DataSet
        V_GetPNOFromPOD = _CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_GetPNOFromPOD", _Loai & "#" & _Ngay_Ct1 & "#" & _Ngay_Ct2 & "#" & _lenh_Po & "#" & _Ma_kh & "#" & _Stt_Rec & "#" & _Ma_Ct & "#" & _Ma_Dvcs & "#" & _User_Name)
    End Function
    Public Function V_GetPNMFromPNO(ByVal _App As SqlConnection, ByVal _CyberSmlib As Cyber.SmLib.Sys, ByVal _Loai As String, ByVal _Ngay_Ct1 As String, ByVal _Ngay_Ct2 As String, ByVal _lenh_Po As String, ByVal _Ma_kh As String, ByVal _Stt_Rec As String, ByVal _Ma_Ct As String, ByVal _Ma_Dvcs As String, ByVal _User_Name As String) As DataSet
        V_GetPNMFromPNO = _CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_GetPNMFromPNO", _Loai & "#" & _Ngay_Ct1 & "#" & _Ngay_Ct2 & "#" & _lenh_Po & "#" & _Ma_kh & "#" & _Stt_Rec & "#" & _Ma_Ct & "#" & _Ma_Dvcs & "#" & _User_Name)
    End Function
    '=============================================================RO/
    '=============================================================QV
    Public Sub V_Tinh_Sl_Ve(ByVal _App As SqlConnection, ByVal _Dv_Detail As DataView, ByVal _iRow As Integer, ByVal _Dt As Date, ByVal _Ma_Ct As String,
                            ByVal _Mode As String, ByVal _Ma_Dvcs As String, ByVal _User_Name As String, Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing)
        If _iRow < 0 Then Exit Sub
        If _Dv_Detail.Count < _iRow + 1 Then Exit Sub
        If Not (_Mode.Trim.ToUpper = "M" Or _Mode.Trim.ToUpper = "S") Then Exit Sub

        If Not _Dv_Detail.Table.Columns.Contains("Seri_Dau") Then Exit Sub
        If Not _Dv_Detail.Table.Columns.Contains("Seri_Cuoi") Then Exit Sub
        If Not _Dv_Detail.Table.Columns.Contains("So_Luong") Then Exit Sub
        If Not _Dv_Detail.Table.Columns.Contains("Ma_Ve") Then Exit Sub

        '----------------------------------------------------------------------------------
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        Dim _Seri_Dau As String = _Dv_Detail.Item(_iRow).Item("Seri_Dau").ToString.Trim.Replace(" ", "").Replace(",", ".")
        Dim _Seri_Cuoi As String = _Dv_Detail.Item(_iRow).Item("Seri_Cuoi").ToString.Trim.Replace(" ", "").Replace(",", ".")
        Dim _So_Luong As String = _Dv_Detail.Item(_iRow).Item("So_Luong").ToString.Trim.Replace(" ", "").Replace(",", ".")
        Dim _Ma_Ve As String = _Dv_Detail.Item(_iRow).Item("Ma_Ve").ToString.Trim
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_QVGetSLVe", _Dt.ToString("yyyyMMdd") & "#" & _Seri_Dau & "#" & _Seri_Cuoi & "#" & _So_Luong & "#" & _Ma_Ct & "#" & _Mode & "#" & _Ma_Ve & "#" & _Ma_Dvcs & "#" & _User_Name)
        If _DsTmp.Tables.Count < 1 Then Exit Sub
        If _DsTmp.Tables(0).Rows.Count < 1 Then Exit Sub

        _Dv_Detail.BeginInit()
        If _DsTmp.Tables(0).Columns.Contains("So_Luong") Then _Dv_Detail.Item(_iRow).Item("So_Luong") = _DsTmp.Tables(0).Rows(0).Item("So_Luong")
        If _DsTmp.Tables(0).Columns.Contains("Seri_Dau") Then _Dv_Detail.Item(_iRow).Item("Seri_Dau") = _DsTmp.Tables(0).Rows(0).Item("Seri_Dau")
        If _DsTmp.Tables(0).Columns.Contains("Seri_Cuoi") Then _Dv_Detail.Item(_iRow).Item("Seri_Cuoi") = _DsTmp.Tables(0).Rows(0).Item("Seri_Cuoi")

        If _DsTmp.Tables(0).Columns.Contains("Gia_NT") And _Dv_Detail.Table.Columns.Contains("Gia_NT") Then _Dv_Detail.Item(_iRow).Item("Gia_NT") = _DsTmp.Tables(0).Rows(0).Item("Gia_NT")
        If _DsTmp.Tables(0).Columns.Contains("Tien_NT") And _Dv_Detail.Table.Columns.Contains("Tien_NT") Then _Dv_Detail.Item(_iRow).Item("Tien_NT") = _DsTmp.Tables(0).Rows(0).Item("Tien_NT")

        _Dv_Detail.EndInit()
    End Sub
    'hieulv 29-12-2021
    Public Shared Function V_GetSo_DN(_Ma_Ct As String, _Ma_GD As String, _Mode As String, _Ngay_Ct As Date, _So_DN As String, _Ma_Dvcs As String) As String
        Dim So_DN_return As String = _So_DN.Trim
        If Len(_So_DN) > 5 Then
            Return So_DN_return
            Exit Function
        End If
        '
        So_DN_return = Right("000000" + _So_DN, 5)
        If _Ma_Ct = "PDC" Then
            So_DN_return = _Ma_Dvcs.Trim + ".CC" + Right(Year(_Ngay_Ct).ToString.Trim, 2) + So_DN_return
        End If

        If _Ma_Ct = "PDN" Then
            So_DN_return = _Ma_Dvcs.Trim + ".VT" + Right(Year(_Ngay_Ct).ToString.Trim, 2) + So_DN_return
        End If
        Return So_DN_return
    End Function
End Class
