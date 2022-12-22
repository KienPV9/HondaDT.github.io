Public Class BEXEPXELOC
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
    Dim DtThang1, DtThang2, DtNam1, DtNam2 As DataTable
    Dim M_Add_Title As String = ""
    Private Sub BEXEPXELOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_kx
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        '--HD1
        AddHandler TxtNh_HD1.CyberValiting, AddressOf V_NH_HD1
        AddHandler TxtNh_HD1.CyberLeave, AddressOf L_NH_HD1
        '--HD2
        AddHandler TxtNh_HD2.CyberValiting, AddressOf V_NH_HD2
        AddHandler TxtNh_HD2.CyberLeave, AddressOf L_NH_HD2
        '--HD3
        AddHandler TxtNh_HD3.CyberValiting, AddressOf V_NH_HD3
        AddHandler TxtNh_HD3.CyberLeave, AddressOf L_NH_HD3
        If M_Add_Title <> "" Then Me.Text = M_Add_Title & Me.Text
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        DtThang1 = CreateTableMonth()
        DtThang2 = CreateTableMonth()
        DtNam1 = CreateTableYear()
        DtNam2 = DtNam1.Copy
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang1, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam1, DtNam1, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Thang2, DtThang2, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam2, DtNam2, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")

    End Sub
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next
        CreateTableMonth = _Return
    End Function
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        Dim _Default As String = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

            If Now.Date.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KX.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_KX.Text = "" Then
            TxtTen_KX.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_kx")
            TxtTen_KX.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_KX.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Mau"
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
#Region "Vali --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_KH.Text = "" Then
            TxtTen_KH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH.Text = DrReturn.Item("Ma_KH")
            TxtTen_KH.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_KH.Text = ""
            TxtTen_KH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HD.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_HD.Text = "" Then
            TxtTen_HD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HD1"
    Private Sub V_NH_HD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD1.V_LookUp(M_LAN, Me.Para, Me.Sysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_HD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_HD1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD1.Text = ""
            TxtTen_Nh_HD1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HD2"
    Private Sub V_NH_HD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD2.V_LookUp(M_LAN, Me.Para, Me.Sysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_HD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_HD2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD2.Text = ""
            TxtTen_Nh_HD2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HD3"
    Private Sub V_NH_HD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD3.V_LookUp(M_LAN, Me.Para, Me.Sysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_HD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_HD3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD3.Text = ""
            TxtTen_Nh_HD3.Text = ""
        End If
    End Sub
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Me.Thang1 = CbbM_Thang1.SelectedValue.ToString.Trim
        Me.Thang2 = CbbM_Thang2.SelectedValue.ToString.Trim
        Me.Nam = CbbM_Nam1.SelectedValue.ToString.Trim


        Me.Nam1 = CbbM_Nam1.SelectedValue.ToString.Trim
        Me.Nam2 = CbbM_Nam2.SelectedValue.ToString.Trim

        Dim _Nam1 As String = CbbM_Nam1.SelectedValue.ToString.Trim
        Dim _Nam2 As String = CbbM_Nam1.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = "1#0#" + Me.Thang1 & "#" & _Nam1 & "#" & Me.Thang2 & "#" & _Nam2

        M_strParameterStore = M_strParameterStore & "#" & ""
        M_strParameterStore = M_strParameterStore & "#" & ""
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Mau.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_HD1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_HD2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_HD3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Key_Sub1 = TxtMa_Kx.Text
        Me.Key_Sub2 = TxtMa_Mau.Text
        Me.Close()
    End Sub

    Private Sub CbbM_Nam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbbM_Nam1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
