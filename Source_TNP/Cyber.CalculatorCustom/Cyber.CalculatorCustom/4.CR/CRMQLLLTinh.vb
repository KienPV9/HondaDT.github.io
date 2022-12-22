Public Class CRMQLLLTinh
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
    Dim _Loai, _Ma_Loai As String
    Dim Dt_Loai, Dt_Ma_Loai As DataTable
    Dim Dv_Loai, Dv_Ma_Loai As DataView

    Private Sub CRMQLLLTinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date


        TxtNgay_Ct1.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtNgay_Ct1)
        TxtNgay_Ct2.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtNgay_Ct2)

        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CbbLoai.SelectedIndexChanged, AddressOf V_Loai

        If M_Add_Title <> "" Then Me.Text = M_Add_Title & Me.Text

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        'AddHandler TxtCrmMa_Loai.CyberValiting, AddressOf V_CrmMa_Loai
        'AddHandler TxtCrmMa_Loai.CyberLeave, AddressOf L_CrmMa_Loai

        Dim M_VT_PARA As Integer = CType(Para(0).Trim, Integer)
        _Loai = Me.Para(M_VT_PARA + 2).ToString.Trim
        _Ma_Loai = Me.Para(M_VT_PARA + 3).ToString.Trim

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMQLLLTinh_Load", _Loai + "#" + _Ma_Loai + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dt_Loai = DsTmp.Tables(0).Copy
        Dt_Ma_Loai = DsTmp.Tables(1).Copy

        Dv_Loai = New DataView(Dt_Loai)
        Dv_Ma_Loai = New DataView(Dt_Ma_Loai)

        CyberFill.V_FillComBoxDefaul(CbbLoai, Dv_Loai, "Loai", IIf(M_LAN = "V", "Ten_Loai", "Ten_Loai2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_Loai, Dv_Ma_Loai, "Ma_Loai", IIf(M_LAN = "V", "Ten_Loai", "Ten_Loai2"), "Ngam_Dinh")
        V_Loai(New System.Object, New System.EventArgs)
        'Default
        TxtNgay_Ct1.Value = Date.Now
        TxtNgay_Ct2.Value = Date.Now
    End Sub
#Region "Vali --- CrmMa_Loai"
    Private Sub V_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Loai_Filter As String = CyberSmodb.GetvalueFromCombox(CbbLoai)
        Dim _KeyFilter As String = "1=1"
        If Dt_Ma_Loai.Columns.Contains("Loai") And _Loai_Filter.Trim <> "" Then
            _KeyFilter = "Loai = '" + _Loai_Filter + "' OR Loai = ''"
        End If
        Try
            Dv_Ma_Loai.RowFilter = _KeyFilter
        Catch ex As Exception

        End Try
    End Sub
    'Private Sub V_CrmMa_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim _Loai1 As String = CyberSmodb.GetvalueFromCombox(CbbLoai)
    '    Dim _keyClient As String = "1=1"
    '    Dim _keySQL As String = "1=1"
    '    If Not _Loai.Trim = "" Then _keySQL = _keySQL + " AND CRMLoai = N'" + _Loai.Trim + "'"
    '    If Not _Ma_Loai.Trim = "" Then _keySQL = _keySQL + " AND CRMMa_Loai = N'" + _Ma_Loai.Trim + "'"

    '    If Not _Loai1.Trim = "" Then _keyClient = "CRMLoai = '" + _Loai1.Trim + "'"
    '    TxtCrmMa_Loai.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "CrmMa_Loai", "CRMDMLOAI", _keySQL, _keyClient)

    'End Sub
    'Private Sub L_CrmMa_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TxtCrmMa_Loai.Text = "" Then
    '        TxtCrmTen_Loai.Text = ""
    '        Exit Sub
    '    End If
    '    DrReturn = TxtCrmMa_Loai.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtCrmMa_Loai.Text = DrReturn.Item("CrmMa_Loai")
    '        TxtCrmTen_Loai.Text = DrReturn.Item("CrmTen_Loai")
    '    Else
    '        TxtCrmMa_Loai.Text = ""
    '        TxtCrmTen_Loai.Text = ""
    '    End If
    'End Sub
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _Ngay_Ct1 As Date = TxtNgay_Ct1.Value
        Dim _Ngay_Ct2 As Date = TxtNgay_Ct2.Value

        Dim _Loai As String = CyberSmodb.GetvalueFromCombox(CbbLoai)
        Dim _Ma_Loai As String = CyberSmodb.GetvalueFromCombox(CbbMa_Loai)

        Dim M_strParameterStore As String = _Loai & "#" & _Ma_Loai & "#" & _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd")
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub

  
End Class
