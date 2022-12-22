Public Class DMCC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private _Load_TP As Boolean = False
    Private Sub FDMCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTabe()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Cc, TxtNh_CC1, TxtNh_CC2, TxtNh_CC3, TxtNh_CC4, TxtNh_CC5)
        TxtMa_Cc.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If TxtNh_CC1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCC", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_CC1.Text.Trim + "')", CyberSmlib)
        If TxtNh_CC2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCC", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_CC2.Text.Trim + "')", CyberSmlib)
        If TxtNh_CC3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCC", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_CC3.Text.Trim + "')", CyberSmlib)
        If TxtNh_CC4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCC", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_CC4.Text.Trim + "')", CyberSmlib)
        If TxtNh_CC5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCC", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_CC5.Text.Trim + "')", CyberSmlib)

        If TxtMa_Kho.Text.Trim = "" Then TxtTen_KHO.Text = "" Else TxtTen_KHO.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmlib)
        If Not TxtTk_Cc.Text.Trim = "" Then TxtTen_Tk_cc.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Cc.Text.Trim + "')", CyberSmlib)
        If Not txtTk_CL_Cc.Text.Trim = "" Then TxtTen_Tk_Cl.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + txtTk_CL_Cc.Text.Trim + "')", CyberSmlib)
        If Not txtTk_TT.Text.Trim = "" Then txtTen_Tk_TT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + txtTk_TT.Text.Trim + "')", CyberSmlib)
        If Not TxtTk_Cp.Text.Trim = "" Then TxtTen_tk_cp.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Cp.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            CmbCc_Ton_kho.SelectedValue = "1"
            CmbGia_Ton.SelectedValue = "1"
            CmbSua_Tk_Cc.SelectedValue = "0"
        End If
        If CmbCc_Ton_kho.Text.Trim = "" Then CmbCc_Ton_kho.SelectedValue = "1"
        If CmbGia_Ton.Text.Trim = "" Then CmbGia_Ton.SelectedValue = "1"
        If CmbSua_Tk_Cc.Text.Trim = "" Then CmbSua_Tk_Cc.SelectedValue = "0"
        If Me.Mode = "M" Then CbbLoai_Pb.SelectedValue = "2"

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_Cc.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Cc.KeyPress, AddressOf TxtCodeError_KeyPress

        '--CC1
        RemoveHandler TxtNh_CC1.CyberValiting, AddressOf V_NH_CC1
        RemoveHandler TxtNh_CC1.CyberLeave, AddressOf L_NH_CC1
        AddHandler TxtNh_CC1.CyberValiting, AddressOf V_NH_CC1
        AddHandler TxtNh_CC1.CyberLeave, AddressOf L_NH_CC1
        '--CC2
        RemoveHandler TxtNh_CC2.CyberValiting, AddressOf V_NH_CC2
        RemoveHandler TxtNh_CC2.CyberLeave, AddressOf L_NH_CC2
        AddHandler TxtNh_CC2.CyberValiting, AddressOf V_NH_CC2
        AddHandler TxtNh_CC2.CyberLeave, AddressOf L_NH_CC2
        '--CC3
        RemoveHandler TxtNh_CC3.CyberValiting, AddressOf V_NH_CC3
        RemoveHandler TxtNh_CC3.CyberLeave, AddressOf L_NH_CC3
        AddHandler TxtNh_CC3.CyberValiting, AddressOf V_NH_CC3
        AddHandler TxtNh_CC3.CyberLeave, AddressOf L_NH_CC3
        '--CC4
        RemoveHandler TxtNh_CC4.CyberValiting, AddressOf V_NH_CC4
        RemoveHandler TxtNh_CC4.CyberLeave, AddressOf L_NH_CC4
        AddHandler TxtNh_CC4.CyberValiting, AddressOf V_NH_CC4
        AddHandler TxtNh_CC4.CyberLeave, AddressOf L_NH_CC4
        '--CC5
        RemoveHandler TxtNh_CC5.CyberValiting, AddressOf V_NH_CC5
        RemoveHandler TxtNh_CC5.CyberLeave, AddressOf L_NH_CC5
        AddHandler TxtNh_CC5.CyberValiting, AddressOf V_NH_CC5
        AddHandler TxtNh_CC5.CyberLeave, AddressOf L_NH_CC5
        '-- Ma Kho
        RemoveHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        RemoveHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        '--TK_CC
        RemoveHandler TxtTk_Cc.CyberValiting, AddressOf V_Tk_CC
        RemoveHandler TxtTk_Cc.CyberLeave, AddressOf L_Tk_CC
        AddHandler TxtTk_Cc.CyberValiting, AddressOf V_Tk_CC
        AddHandler TxtTk_Cc.CyberLeave, AddressOf L_Tk_CC

        '--TK_CL_Cc
        RemoveHandler txtTk_CL_Cc.CyberValiting, AddressOf V_TK_CL_CC
        RemoveHandler txtTk_CL_Cc.CyberLeave, AddressOf L_TK_CL_CC
        AddHandler txtTk_CL_Cc.CyberValiting, AddressOf V_TK_CL_CC
        AddHandler txtTk_CL_Cc.CyberLeave, AddressOf L_TK_CL_CC

        '--TK_CL_Cc
        RemoveHandler txtTk_TT.CyberValiting, AddressOf V_TK_TT
        RemoveHandler txtTk_TT.CyberLeave, AddressOf L_TK_TT
        AddHandler txtTk_TT.CyberValiting, AddressOf V_TK_TT
        AddHandler txtTk_TT.CyberLeave, AddressOf L_TK_TT

        '--TK_CL_CP
        RemoveHandler TxtTk_Cp.CyberValiting, AddressOf V_TK_CP
        RemoveHandler TxtTk_Cp.CyberLeave, AddressOf L_TK_CP
        AddHandler TxtTk_Cp.CyberValiting, AddressOf V_TK_CP
        AddHandler TxtTk_Cp.CyberLeave, AddressOf L_TK_CP
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub CreateTabe()
        Dim DtTon_kho As New DataTable
        Dim DtGia_Ton As New DataTable
        Dim DtTSua_Tk_Cc As New DataTable

        DtTon_kho.Columns.Add("Vt_Ton_kho", GetType(String))
        DtTon_kho.Columns.Add("Ten", GetType(String))
        DtTon_kho.Rows.Add("1", IIf(M_LAN = "V", "Theo dõi tồn kho", "Inventory"))
        DtTon_kho.Rows.Add("0", IIf(M_LAN = "V", "Không theo dõi tồn kho", "No inventory"))
        CyberFill.V_FillComBoxDefaul(Me.CmbCc_Ton_kho, DtTon_kho, "Vt_Ton_kho", "Ten")
        '---
        DtGia_Ton.Columns.Add("Gia_Ton", GetType(String))
        DtGia_Ton.Columns.Add("Ten", GetType(String))
        DtGia_Ton.Rows.Add("1", IIf(M_LAN = "V", "Tính theo phương pháp giá bình quân", "Average price"))
        DtGia_Ton.Rows.Add("2", IIf(M_LAN = "V", "Tính theo phương pháp giá đích danh", "First in first out price - FIFO"))
        DtGia_Ton.Rows.Add("3", IIf(M_LAN = "V", "Tính theo phương pháp giá nhập trước xuất trước", "Average price"))
        DtGia_Ton.Rows.Add("4", IIf(M_LAN = "V", "Tính theo phương pháp giá bình quân ngày", "Average daily price"))
        CyberFill.V_FillComBoxDefaul(Me.CmbGia_Ton, DtGia_Ton, "Gia_Ton", "Ten")
        '---
        DtTSua_Tk_Cc.Columns.Add("Sua_Tk_Cc", GetType(String))
        DtTSua_Tk_Cc.Columns.Add("Ten", GetType(String))
        DtTSua_Tk_Cc.Rows.Add("1", IIf(M_LAN = "V", "Được sửa tài khoản tồn kho", "Account is correct warehouse"))
        DtTSua_Tk_Cc.Rows.Add("0", IIf(M_LAN = "V", "Không được sửa tài khoản tồn kho", "Account is not correct warehouse"))
        CyberFill.V_FillComBoxDefaul(Me.CmbSua_Tk_Cc, DtTSua_Tk_Cc, "Sua_Tk_Cc", "Ten")

        Dim DtloaiBP As New DataTable
        DtloaiBP.Columns.Add("Loai_Pb", GetType(String))
        DtloaiBP.Columns.Add("Ten", GetType(String))
        DtloaiBP.Rows.Add("1", IIf(M_LAN = "V", "Tính phân bổ theo ngày", "Level 1"))
        DtloaiBP.Rows.Add("2", IIf(M_LAN = "V", "Tính phân bổ theo tháng", "Level 2"))
        CyberFill.V_FillComBoxDefaul(Me.CbbLoai_Pb, DtloaiBP, "Loai_Pb", "Ten")

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_CC1"
    Private Sub V_NH_CC1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CC1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCC", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_CC1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CC1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CC1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CC1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_CC2"
    Private Sub V_NH_CC2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CC2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCC", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_CC2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CC2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CC2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CC2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_CC3"
    Private Sub V_NH_CC3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CC3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCC", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_CC3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CC3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CC3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CC3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_CC4"
    Private Sub V_NH_CC4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CC4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCC", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_CC4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CC4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CC4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CC4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_CC5"
    Private Sub V_NH_CC5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CC5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCC", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_CC5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CC5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CC5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CC5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kho"
    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kho.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_KHO.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_KHO.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CC"
    Private Sub V_Tk_CC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Cc.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk_Cc.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Cc.Text = DrReturn.Item("TK")
            TxtTen_Tk_cc.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Cc.Text = ""
            TxtTen_Tk_cc.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CL_CC"
    Private Sub V_TK_CL_CC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtTk_CL_Cc.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK_CL_CC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = txtTk_CL_Cc.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            txtTk_CL_Cc.Text = DrReturn.Item("TK")
            TxtTen_Tk_Cl.Text = DrReturn.Item("Ten_TK")
        Else
            txtTk_CL_Cc.Text = ""
            TxtTen_Tk_Cl.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_TT"
    Private Sub V_TK_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtTk_TT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = txtTk_TT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            txtTk_TT.Text = DrReturn.Item("TK")
            txtTen_Tk_TT.Text = DrReturn.Item("Ten_TK")
        Else
            txtTk_TT.Text = ""
            txtTen_Tk_TT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK_CP"
    Private Sub V_TK_CP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Cp.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK_CP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk_Cp.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Cp.Text = DrReturn.Item("TK")
            TxtTen_tk_cp.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Cp.Text = ""
            TxtTen_tk_cp.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Cc.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
