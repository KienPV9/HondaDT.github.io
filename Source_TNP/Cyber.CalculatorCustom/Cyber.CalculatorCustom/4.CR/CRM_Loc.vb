Public Class CRM_Loc
    Public Property Add_Title() As String
        Get
            Add_Title = M_Add_Title
        End Get
        Set(ByVal Value As String)
            M_Add_Title = Value
        End Set
    End Property
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim M_Add_Title As String = ""
    Dim Dt_Loai, Dt_Ngay_D, Dt_TTCS As DataTable
    Dim Dv_Loai, Dv_Ngay_D, Dv_TTCS As DataView
    Private Sub CRM_Xem_Loc_CS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date
        TxtNgay_Ct1.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtNgay_Ct1)
        TxtNgay_Ct2.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtNgay_Ct2)
        V_GetData()

        V_AddHander()
        If M_Add_Title <> "" Then Me.Text = M_Add_Title & Me.Text
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_GetData()        
        Dim _Loai As String = Me.Para(M_VT_PARA + 2).ToString.Trim
        Dim _Ma_Loai As String = Me.Para(M_VT_PARA + 3).ToString.Trim

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMQLLLLoad_Filter", _Loai + "#" + _Ma_Loai + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If DsTmp.Tables.Count >= 1 Then Dt_Loai = DsTmp.Tables(0).Copy
        If DsTmp.Tables.Count >= 2 Then Dt_Ngay_D = DsTmp.Tables(1).Copy
        If DsTmp.Tables.Count >= 3 Then Dt_TTCS = DsTmp.Tables(2).Copy

        If Not Dt_Loai Is Nothing Then If Dt_Loai.Rows.Count = 0 Then Dt_Loai = Nothing
        If Not Dt_Ngay_D Is Nothing Then If Dt_Ngay_D.Rows.Count = 0 Then Dt_Ngay_D = Nothing
        If Not Dt_TTCS Is Nothing Then If Dt_TTCS.Rows.Count = 0 Then Dt_TTCS = Nothing

        If Not Dt_Loai Is Nothing Then Dv_Loai = New DataView(Dt_Loai)
        If Not Dt_Ngay_D Is Nothing Then Dv_Ngay_D = New DataView(Dt_Ngay_D)
        If Not Dt_TTCS Is Nothing Then Dv_TTCS = New DataView(Dt_TTCS)

        'Hình thức CS
        If Not Dv_Loai Is Nothing Then
            CyberFill.V_FillComBoxDefaul(CmbMa_Loai, Dv_Loai, "Ma_Loai", If(M_LAN = "V", "Ten_Loai", "Ten_Loai2"), "Ngam_Dinh")
            CmbMa_Loai.Visible = True
            LabMa_Loai.Visible = True
        Else
            CmbMa_Loai.Visible = False
            LabMa_Loai.Visible = False
        End If

        'Mã ngày CS
        If Not Dv_Ngay_D Is Nothing Then
            CyberFill.V_FillComBoxDefaul(CmbMa_Ngay, Dv_Ngay_D, "Ma_Ngay", If(M_LAN = "V", "Ten_Ngay", "Ten_Ngay2"), "Ngam_Dinh")
            CmbMa_Ngay.Visible = True
            LabMa_Ngay.Visible = True
        Else
            CmbMa_Ngay.Visible = False
            LabMa_Ngay.Visible = False
        End If
        V_Ma_Loai(New System.Object, New System.EventArgs)

        'Tình trạng CS
        If Not Dv_TTCS Is Nothing Then
            CyberFill.V_FillComBoxDefaul(CmbTT_CS, Dv_TTCS, "Ma_TTCS", If(M_LAN = "V", "Ten_TTCS", "Ten_TTCS2"), "Ngam_Dinh")
            CmbTT_CS.Visible = True
            LabTT_CS.Visible = True
        Else
            CmbTT_CS.Visible = False
            LabTT_CS.Visible = False
        End If
    End Sub
    Private Sub V_Ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Dv_Loai Is Nothing Then Return
        If Dv_Ngay_D Is Nothing Then Return
        Dim _Ma_Loai As String = CyberSmodb.GetvalueFromCombox(CmbMa_Loai).ToString.Trim
        Dim _StrFilter As String = "1=1"
        If Not _Ma_Loai = "" Then
            _StrFilter = " Ma_Loai = '' OR Ma_Loai = '" + _Ma_Loai + "'"
        End If
        Try
            Dv_Ngay_D.RowFilter = _StrFilter
        Catch ex As Exception

        End Try
    End Sub
    Private Sub V_AddHander()
        'Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        'Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        'Ma_Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        'Ma_ChienDich
        AddHandler TxtMa_ChienDich.CyberValiting, AddressOf V_Ma_ChienDich
        AddHandler TxtMa_ChienDich.CyberLeave, AddressOf L_Ma_ChienDich

        AddHandler CmbMa_Loai.SelectedIndexChanged, AddressOf V_Ma_Loai
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
#Region "Valid"
#Region "Valid --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hs.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Mau.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
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
    End Sub
#End Region
#Region "Valid --- Ma_ChienDich"
    Private Sub V_Ma_ChienDich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_ChienDich.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_ChienDich", "DmChienDich", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ChienDich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_ChienDich.Text = "" Then
            TxtTen_ChienDich.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_ChienDich.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ChienDich.Text = DrReturn.Item("Ma_ChienDich")
            TxtTen_ChienDich.Text = DrReturn.Item("Ten_ChienDich")
        Else
            TxtMa_ChienDich.Text = ""
            TxtTen_ChienDich.Text = ""
        End If
    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _Ngay_Ct1 As Date = TxtNgay_Ct1.Value
        Dim _Ngay_Ct2 As Date = TxtNgay_Ct2.Value
        Dim _Loai As String = ""
        Dim _Ma_TTCS As String = ""
        Dim _Ma_Loai As String = ""
        Dim _Ma_Ngay As String = ""

        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)
        Try
            _Loai = Me.Para(M_VT_PARA + 2).ToString.Trim.ToUpper()
        Catch ex As Exception

        End Try

        _Ma_TTCS = CyberSmodb.GetvalueFromCombox(CmbTT_CS)
        _Ma_Loai = CyberSmodb.GetvalueFromCombox(CmbMa_Loai)
        _Ma_Ngay = CyberSmodb.GetvalueFromCombox(CmbMa_Ngay)

        Dim M_strParameterStore As String = _Loai & "#" & _Ma_Loai.Trim & "#" & _Ma_Ngay & "#" & _Ma_TTCS & "#" & _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd")
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Mau.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_ChienDich.Text
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name

        Me.Key_Sub1 = TxtNgay_Ct1.Text.ToString.Trim
        Me.Key_Sub2 = TxtNgay_Ct2.Text.ToString.Trim
        Me.Key_Sub3 = _Loai
        Me.Key_Sub4 = _Ma_Loai
        Me.Key_Sub5 = _Ma_Ngay

        Me.Tag = M_strParameterStore
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
