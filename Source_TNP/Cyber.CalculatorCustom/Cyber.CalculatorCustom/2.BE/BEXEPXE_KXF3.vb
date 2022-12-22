Public Class BEXEPXE_KXF3
    Public Property Drv() As DataRowView
        Get
            Drv = M_Drv
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv = Value
        End Set
    End Property
    Public Property Dr() As DataRow
        Get
            Dr = M_Dr
        End Get
        Set(ByVal Value As DataRow)
            M_Dr = Value
        End Set
    End Property
    Dim M_Drv As DataRowView
    Dim M_Dr As DataRow
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub BEXEPXE_KXF3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler TxtMa_CSBH.CyberValiting, AddressOf V_Ma_CSBH
        AddHandler TxtMa_CSBH.CyberLeave, AddressOf L_Ma_CSBH

        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_kx

        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau

        AddHandler TxtTIEN_NT.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtCK.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtT_TT_NT.Leave, AddressOf V_Tinh_Toan

        AddHandler TxtKM_BH.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtMOI_GIOI.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtKM_PK.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtKM_KHAC.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtT_KM.Leave, AddressOf V_Tinh_Toan

        AddHandler TxtBH_BB.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtPK_BB.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtKhac_BB.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtT_BB.Leave, AddressOf V_Tinh_Toan


        AddHandler TxtGT1.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtGT2.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtGT3.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtGT4.Leave, AddressOf V_Tinh_Toan
        UpdateList()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, Dr)
        Me.Text = "Điều chỉnh xe cho hợp đồng"
        If Dr.Table.Columns.Contains("Ong_Ba") Then
            Dim _Ong_Ba As String = Dr.Item("Ong_Ba").ToString
            Me.Text = Me.Text + " [ " + _Ong_Ba + " ]"
        End If

        If Dr.Table.Columns.Contains("Ma_HD_I") Then
            Dim _Ma_HD_I As String = Dr.Item("Ma_HD_I").ToString
            Me.Text = Me.Text + ":  Hợp đồng số [ " + _Ma_HD_I + " ]"
        End If

        TxtTen_CSBH.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CSBH", "DmCSBH", "Ma_CSBH = N'" + TxtMa_CSBH.Text + "'", CyberSmlib)

    End Sub
    Sub V_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateList()

    End Sub
    Sub UpdateList()
        TxtT_TT_NT.Double = TxtTIEN_NT.Double - TxtCK.Double
        TxtT_TT.Double = TxtT_TT_NT.Double

        TxtT_KM.Double = TxtMOI_GIOI.Double + TxtKm_BH.Double + +TxtKM_PK.Double + TxtKM_KHAC.Double
        TxtT_BB.Double = TxtBH_BB.Double + TxtPK_BB.Double + +TxtKhac_BB.Double

        If (TxtGT1.Double + TxtGT2.Double + TxtGT3.Double + TxtGT4.Double) <> TxtT_TT_NT.Double Then
            TxtGT2.Double = TxtT_TT_NT.Double - TxtGT1.Double
            TxtGT3.Double = 0
            TxtGT4.Double = 0
        End If


    End Sub
#Region "Vali --- Ma_CSBH"
    Private Sub V_Ma_CSBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_CSBH.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_CSBH", "DmCSBH", "1=1", "1=1")

    End Sub
    Private Sub L_Ma_CSBH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_CSBH.Text = "" Then
            Txtten_CSBH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CSBH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CSBH.Text = DrReturn.Item("Ma_CSBH")
            If DrReturn.Table.Columns.Contains("Ten_CSBH") Then TxtTen_CSBH.Text = DrReturn.Item("Ten_CSBH") Else TxtTen_CSBH.Text = ""
            V_SetPriceXeSales()
        Else
            TxtMa_CSBH.Text = ""
            Txtten_CSBH.Text = ""
        End If

    End Sub
    Private Sub V_SetPriceXeSales()

        Dim _strF As String = ""
        Dim _strV As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value

        Dim Stt_Rec As String = Dr.Item("Stt_Rec")
        Dim Stt_Rec0 As String = Dr.Item("Stt_Rec0")
        Dim Ma_Ct As String = Dr.Item("Stt_Rec")

        CyberSmodb.GetValueControler(Me, _strF, _strV, "Ten_Kx,Ten_mau,Ten_CSBH")
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetPriceXeSalesCSBH", Stt_Rec + "#" + Ma_Ct + "#" + "S" + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + _strF + "#" + _strV + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name)

        If Dstmp.Tables.Count <= 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Not Dstmp.Tables(0).Columns.Contains("Status") Then
            Dstmp.Dispose()
            Return
        End If

        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Sysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables.Count <= 1 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(1).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(1).Columns.Contains("Ma_Kx") Then TxtMa_Kx.Text = Dstmp.Tables(1).Rows(0).Item("Ma_Kx").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_Kx") Then Txtten_Kx.Text = Dstmp.Tables(1).Rows(0).Item("Ten_Kx").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ma_Mau") Then TxtMa_Mau.Text = Dstmp.Tables(1).Rows(0).Item("Ma_Mau").ToString.Trim
        If Dstmp.Tables(1).Columns.Contains("Ten_Mau") Then TxtTen_Mau.Text = Dstmp.Tables(1).Rows(0).Item("Ten_Mau").ToString.Trim

        If Dstmp.Tables(1).Columns.Contains("TIEN_NT") Then TxtTIEN_NT.Text = Dstmp.Tables(1).Rows(0).Item("TIEN_NT")
        If Dstmp.Tables(1).Columns.Contains("CK") Then TxtCK.Text = Dstmp.Tables(1).Rows(0).Item("CK")
        If Dstmp.Tables(1).Columns.Contains("Moi_Gioi") Then TxtMOI_GIOI.Text = Dstmp.Tables(1).Rows(0).Item("Moi_Gioi")

        If Dstmp.Tables(1).Columns.Contains("KM_PK") Then TxtKM_PK.Text = Dstmp.Tables(1).Rows(0).Item("KM_PK")
        If Dstmp.Tables(1).Columns.Contains("KM_BH") Then TxtKm_BH.Text = Dstmp.Tables(1).Rows(0).Item("KM_BH")
        If Dstmp.Tables(1).Columns.Contains("KM_khac") Then TxtKM_KHAC.Text = Dstmp.Tables(1).Rows(0).Item("KM_khac")

        If Dstmp.Tables(1).Columns.Contains("PK_BB") Then TxtPK_BB.Text = Dstmp.Tables(1).Rows(0).Item("PK_BB")
        If Dstmp.Tables(1).Columns.Contains("BH_BB") Then TxtBH_BB.Text = Dstmp.Tables(1).Rows(0).Item("BH_BB")
        If Dstmp.Tables(1).Columns.Contains("Khac_BB") Then TxtKhac_BB.Text = Dstmp.Tables(1).Rows(0).Item("Khac_BB")

        If Dstmp.Tables(1).Columns.Contains("GT1") Then TxtGT1.Text = Dstmp.Tables(1).Rows(0).Item("GT1")
        If Dstmp.Tables(1).Columns.Contains("GT2") Then TxtGT2.Text = Dstmp.Tables(1).Rows(0).Item("GT2")
        If Dstmp.Tables(1).Columns.Contains("GT3") Then TxtGT3.Text = Dstmp.Tables(1).Rows(0).Item("GT3")
        If Dstmp.Tables(1).Columns.Contains("GT4") Then TxtGT4.Text = Dstmp.Tables(1).Rows(0).Item("GT4")


        Dstmp.Dispose()
        UpdateList()
    End Sub
#End Region
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            Txtten_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_kx")
            Txtten_Kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_Kx.Text = ""
            Txtten_Kx.Text = ""
        End If
        V_SetPriceXeSales()
    End Sub
#End Region
#Region "Vali --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtMa_Mau.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauKx", "1=1", "1=1")
        ''    TxtMa_mau.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_mau", "Dmmauxe", "1=1", "1=1")
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        'CyberSupport.V_Lookup("Ma_mau", "Dmmauxe", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)

        Dim _Ma_Kx As String = TxtMa_Kx.Text
        Dim iRow As Integer = -1
        Dim _FilterClient As String = "1=1"
        If Not _Ma_Kx = "" Then _FilterClient = " Ma_KX = '" + _Ma_Kx + "'"
        'CyberSupport.V_Lookup("Ma_mau", "DmmauKx", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
        ''CyberSupport.V_Lookup("Ma_mau", "DmmauKx", "1=1", _FilterClient, M_Mode, M_Ma_CT, M_LAN, M_Para, oSysvar, Appconn, DsLookup, sender)
        TxtMa_Mau.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_mau", "DmmauKx", "1=1", _FilterClient)

    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Mau.Text = "" Then
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")

        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If
        V_SetPriceXeSales()
    End Sub
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strField As String = ""
        Dim strValue As String = ""
        UpdateList()
        CyberSmodb.GetValueControler(Me, strField, strValue, "Ten_KX,Ten_MAU,Ten_CSBH")

        Dim Stt_Rec As String = Dr.Item("Stt_Rec")
        Dim Stt_Rec0 As String = Dr.Item("Stt_Rec0")

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXeSAVE_KX", Stt_Rec & "#" & Stt_Rec0 & "#" & strField & "#" & strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan) Then
            DsTmp.Dispose()
            CyberSmlib.FlushMemorySave()
            Me.Save_OK = False
            Exit Sub
        End If
        Dim _Dt As DataTable = DsTmp.Tables(DsTmp.Tables.Count - 1).Copy
        If _Dt.Rows.Count = 0 Then
            DsTmp.Dispose()
            CyberSmlib.FlushMemorySave()
            Me.Save_OK = False
            Me.Close()
            Exit Sub
        End If

        Me.Dr = _Dt.Rows(0)
        Me.Drv = New DataView(_Dt).Item(0)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
