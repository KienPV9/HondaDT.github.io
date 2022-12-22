Public Class BELapKHGX_KeHoach
    Public Property Dr() As DataRow
        Get
            Dr = M_Dr
        End Get
        Set(ByVal Value As DataRow)
            M_Dr = Value
        End Set
    End Property
    Public Property Drv() As DataRowView
        Get
            Drv = M_Drv
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv = Value
        End Set
    End Property
    Public Property Dt() As DataTable
        Get
            Dt = M_Dt
        End Get
        Set(ByVal Value As DataTable)
            M_Dt = Value
        End Set
    End Property
    Dim M_Dr As DataRow
    Dim M_Drv As DataRowView
    Dim M_Dt As DataTable
    Public M_Thang1 As String = ""
    Public M_Thang2 As String = ""
    Public M_Nam1 As String = ""
    Public M_Nam2 As String = ""
    Public M_Loai As String = ""
    Public M_Dt_Return As DataTable

    Private Sub CP_BELapKHGX_KeHoach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Tang_Qua()

        V_Load()

        V_AddHandler()
        Me.Text = "Kế hoạch PDS, Lắp NTPK, Xuất hóa đơn, Giao Xe"
        AddHandler ButtOK.Click, AddressOf V_Nhan
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub

    Private Sub V_Load()
        Dim _Strpara As String = "0#" & M_Loai.ToString.Trim & "#" & M_Thang1.ToString.Trim & "#" & M_Nam1.ToString.Trim & "#" & M_Thang2.ToString.Trim & "#" & M_Nam2.ToString.Trim & "#" & M_Drv.Item("Stt_Rec").ToString.Trim & "#" & M_Drv.Item("Stt_Rec0").ToString.Trim
        _Strpara = _Strpara & "#"
        _Strpara = _Strpara & "#"
        _Strpara = _Strpara & "#"
        _Strpara = _Strpara & "#"
        _Strpara = _Strpara & "#"
        _Strpara = _Strpara & "#" & M_Ma_Dvcs
        _Strpara = _Strpara & "#" & M_User_Name
        Dim _Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BELapKHGX_Load", _Strpara)
        Dim _Dr As DataRow = _Dstmp.Tables(0).Rows(0)
        CyberSmodb.SetValueTObj(Me, _Dr)
        _Dstmp.Dispose()
    End Sub
    Private Sub V_Tang_Qua()
        '--- Quà tặng
        Dim dtQua_tang As New DataTable
        dtQua_tang.Columns.Add("Qua_Tang")
        dtQua_tang.Columns.Add("Ten")
        dtQua_tang.Columns.Add("Ten2")
        dtQua_tang.Columns.Add("Default")

        dtQua_tang.Rows.Add("01", "Không", "Non-souvernir", "01")
        dtQua_tang.Rows.Add("02", "Hoa", "Flower", "01")
        dtQua_tang.Rows.Add("03", "Sổ da", "Leather NoteBook", "01")
        dtQua_tang.Rows.Add("04", "Ô", "Umbrella", "01")
        dtQua_tang.Rows.Add("05", "Gối cổ", "Neck Pillow", "01")
        dtQua_tang.Rows.Add("06", "Khác", "Other", "01")
        CyberFill.V_FillComBoxDefaul(CbbQua_tang, dtQua_tang, "Qua_Tang", IIf(Me.Lan = "V", "Ten", "Ten2"), "Default")

        '--- Quà tặng SN
        Dim dtQua_tang_SN As New DataTable
        dtQua_tang_SN.Columns.Add("TT_HoSo")
        dtQua_tang_SN.Columns.Add("Ten")
        dtQua_tang_SN.Columns.Add("Ten2")
        dtQua_tang_SN.Columns.Add("Default")

        dtQua_tang_SN.Rows.Add("CNHS", "CNHS", "Non-gift", "01")
        dtQua_tang_SN.Rows.Add("DGHS", "DGHS", "Towels", "01")
        dtQua_tang_SN.Rows.Add("HS", "HS", "HS", "01")
        dtQua_tang_SN.Rows.Add("...", "Khác", "Other", "01")
        CyberFill.V_FillComBoxDefaul(CbbTT_HoSo, dtQua_tang_SN, "TT_HoSo", IIf(Me.Lan = "V", "Ten", "Ten2"), "Default")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ''  Dim _Dt As DataTable = Drv.DataView.Table.Clone()
        Dim _Dt As DataTable
        Dim Dstmp1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.BELapKHGX WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        _Dt = Dstmp1.Tables(0).Copy
        Dstmp1.Dispose()

        Dim _DrClone As DataRow = _Dt.NewRow
        _DrClone.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrClone)
        CyberSmodb.AddValueToRow(_DrClone, Me)
        If _Dt.Columns.Contains("Stt_Rec") Then _DrClone.Item("Stt_Rec") = TxtStt_Rec.Text
        If _Dt.Columns.Contains("Stt_Rec0") Then _DrClone.Item("Stt_Rec0") = TxtStt_Rec0.Text
        _DrClone.EndEdit()
        _Dt.Rows.Add(_DrClone)
        _Dt.AcceptChanges()
        Dim _XML As String = CyberSmodb.V_ConvertDataToXML(_Dt)
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BELapKHGX_SAVE", TxtStt_Rec.Text + "#" + TxtStt_Rec0.Text + "#" + _XML & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub
        Me.Save_OK = True
        M_Dt_Return = DsTmp.Tables(1).Copy
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_Nhan_Luu(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim strField As String = ""
        Dim strValue As String = ""
        CyberSmodb.GetValueControler(Me, strField, strValue)

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BELapKHGX_SAVE", strField & "#" & strValue & "#" & Drv()("Stt_Rec").ToString.Trim & "#" & Drv()("Stt_Rec0").ToString.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub

        M_Dt_Return = DsTmp.Tables(1).Copy
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore

        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        AddHandler TxtGio_PDS.Leave, AddressOf V_Gio_PDS
        AddHandler TxtGio_PK.Leave, AddressOf V_Gio_PK
        AddHandler TxtGio_HD.Leave, AddressOf V_Gio_HD
        AddHandler TxtGio_Giao.Leave, AddressOf V_Gio_Giao
        AddHandler TxtGio_Tang_Qua.Leave, AddressOf V_Gio_Tang_Qua
        AddHandler TxtGio_DK.Leave, AddressOf V_Gio_DK

    End Sub
#End Region
    Private Sub V_Gio_PK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGio_PK.Text = CyberVoucher.V_GetTG(TxtGio_PK.Text, 0)
    End Sub
    Private Sub V_Gio_PDS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGio_PDS.Text = CyberVoucher.V_GetTG(TxtGio_PDS.Text, 0)
    End Sub
    Private Sub V_Gio_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGio_HD.Text = CyberVoucher.V_GetTG(TxtGio_HD.Text, 0)
    End Sub
    Private Sub V_Gio_Giao(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGio_Giao.Text = CyberVoucher.V_GetTG(TxtGio_Giao.Text, 0)
    End Sub
    Private Sub V_Gio_Tang_Qua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGio_Tang_Qua.Text = CyberVoucher.V_GetTG(TxtGio_Tang_Qua.Text, 0)
    End Sub
    Private Sub V_Gio_DK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGio_DK.Text = CyberVoucher.V_GetTG(TxtGio_DK.Text, 0)
    End Sub
End Class
