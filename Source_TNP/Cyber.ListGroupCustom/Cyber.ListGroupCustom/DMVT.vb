Public Class DMVT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim Dt_Loai_VT As DataTable
    Private Sub FDMVT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        '----------------------------------------------------
        CreateTabe()
        '----------------------------------------------------
        V_Is_Loai_VT()
        '----------------------------------------------------
        V_Load()
        '----------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '----------------------------------------------------
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_VT, TxtNh_VT1, TxtNh_VT2, TxtNh_VT3, TxtNh_VT4, TxtNh_VT5)
        TxtMa_VT.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If TxtNh_VT1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_VT1.Text.Trim + "')", CyberSmlib)
        If TxtNh_VT2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_VT2.Text.Trim + "')", CyberSmlib)
        If TxtNh_VT3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_VT3.Text.Trim + "')", CyberSmlib)
        If Txtnh_4.Text.Trim = "" Then TxtTennh_4.Text = "" Else TxtTennh_4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '4' AND Ma_Nh = N'" + Txtnh_4.Text.Trim + "')", CyberSmlib)
        If TxtNh_VT5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVT", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_VT5.Text.Trim + "')", CyberSmlib)
        If Txtnh_kx2.Text.Trim = "" Then Txtten_nh.Text = "" Else Txtten_nh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhkx", "(Loai_Nh = '2' AND Ma_Nh = N'" + Txtnh_kx2.Text.Trim + "')", CyberSmlib)

        If TxtMa_Kh.Text.Trim = "" Then TxtTen_Kh.Text = "" Else TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kh", "dmkh", "(ma_kh = N'" + TxtMa_Kh.Text.Trim + "')", CyberSmlib)

        If TxtMa_Kho.Text.Trim = "" Then TxtTen_KHO.Text = "" Else TxtTen_KHO.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmlib)
        If TxtTk_VT.Text.Trim = "" Then TxtTen_Tk_VT.Text = "" Else TxtTen_Tk_VT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_VT.Text.Trim + "')", CyberSmlib)
        If TxtTk_GV.Text.Trim = "" Then TxtTen_TK_GV.Text = "" Else TxtTen_TK_GV.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_GV.Text.Trim + "')", CyberSmlib)
        If TxtTk_DT.Text.Trim = "" Then TxtTen_TK_DT.Text = "" Else TxtTen_TK_DT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_DT.Text.Trim + "')", CyberSmlib)

        If TxtTk_DT_NB.Text.Trim = "" Then TxtTen_TK_DT_NB.Text = "" Else TxtTen_TK_DT_NB.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_DT_NB.Text.Trim + "')", CyberSmlib)
        If TxtTk_TL.Text.Trim = "" Then TxtTen_TK_TL.Text = "" Else TxtTen_TK_TL.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_TL.Text.Trim + "')", CyberSmlib)
        If TxtTk_SPDD.Text.Trim = "" Then TxtTen_TK_SPDD.Text = "" Else TxtTen_TK_SPDD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_SPDD.Text.Trim + "')", CyberSmlib)
        If TxtTk_CL_VT.Text.Trim = "" Then TxtTen_TK_CL_VT.Text = "" Else TxtTen_TK_CL_VT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_CL_VT.Text.Trim + "')", CyberSmlib)
        If TxtTk_Ck.Text.Trim = "" Then TxtTen_TK_CK.Text = "" Else TxtTen_TK_CK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Ck.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Me.Mode = "M" Then CmbVt_Ton_kho.SelectedValue = "1"
        If Me.Mode = "M" Then CmbGia_Ton.SelectedValue = "3"
        If Me.Mode = "M" Then CmbSua_Tk_Vt.SelectedValue = "0"
        If Me.Mode = "M" Then
            Try
                If Not Dt_Loai_VT Is Nothing Then CbbLoai_VT.SelectedValue = M_Loai_VT
            Catch ex As Exception
            End Try
        End If
        If CmbVt_Ton_kho.Text.Trim = "" Then CmbVt_Ton_kho.SelectedValue = "1"
        If CmbGia_Ton.Text.Trim = "" Then CmbGia_Ton.SelectedValue = "1"
        If CmbSua_Tk_Vt.Text.Trim = "" Then CmbSua_Tk_Vt.SelectedValue = "0"
        If Me.Mode = "M" Then Txtma_Thue.Text = "10"
        TxtThue_Suat.Text = CyberSmodb.SQLGetvalue(Appconn, "Thue_suat", "Dmthue", "(Ma_Thue = N'" + Txtma_Thue.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_VT.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_VT.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Ma_KHO
        RemoveHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        RemoveHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        AddHandler Txtnh_kx2.CyberValiting, AddressOf V_Ma_nhkx2
        AddHandler Txtnh_kx2.CyberLeave, AddressOf L_Ma_nhkx2
        '--Ma_KH
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh

        '--Ma_VITRI
        RemoveHandler TxtMa_Vitri.CyberValiting, AddressOf V_Ma_Vitri
        RemoveHandler TxtMa_Vitri.CyberLeave, AddressOf L_Ma_Vitri
        AddHandler TxtMa_Vitri.CyberValiting, AddressOf V_Ma_Vitri
        AddHandler TxtMa_Vitri.CyberLeave, AddressOf L_Ma_Vitri
        '--Tk_VT
        RemoveHandler TxtTk_VT.CyberValiting, AddressOf V_Tk_VT
        RemoveHandler TxtTk_VT.CyberLeave, AddressOf L_Tk_VT
        AddHandler TxtTk_VT.CyberValiting, AddressOf V_Tk_VT
        AddHandler TxtTk_VT.CyberLeave, AddressOf L_Tk_VT
        '--Tk_GV
        RemoveHandler TxtTk_GV.CyberValiting, AddressOf V_Tk_GV
        RemoveHandler TxtTk_GV.CyberLeave, AddressOf L_Tk_GV
        AddHandler TxtTk_GV.CyberValiting, AddressOf V_Tk_GV
        AddHandler TxtTk_GV.CyberLeave, AddressOf L_Tk_GV
        '--Tk_DT
        RemoveHandler TxtTk_DT.CyberValiting, AddressOf V_Tk_DT
        RemoveHandler TxtTk_DT.CyberLeave, AddressOf L_Tk_DT
        AddHandler TxtTk_DT.CyberValiting, AddressOf V_Tk_DT
        AddHandler TxtTk_DT.CyberLeave, AddressOf L_Tk_DT
        '--Tk_DT_NB
        RemoveHandler TxtTk_DT_NB.CyberValiting, AddressOf V_Tk_DT_NB
        RemoveHandler TxtTk_DT_NB.CyberLeave, AddressOf L_Tk_DT_NB
        AddHandler TxtTk_DT_NB.CyberValiting, AddressOf V_Tk_DT_NB
        AddHandler TxtTk_DT_NB.CyberLeave, AddressOf L_Tk_DT_NB
        '--Tk_TL
        RemoveHandler TxtTk_TL.CyberValiting, AddressOf V_Tk_TL
        RemoveHandler TxtTk_TL.CyberLeave, AddressOf L_Tk_TL
        AddHandler TxtTk_TL.CyberValiting, AddressOf V_Tk_TL
        AddHandler TxtTk_TL.CyberLeave, AddressOf L_Tk_TL
        '--Tk_SPDD
        RemoveHandler TxtTk_SPDD.CyberValiting, AddressOf V_Tk_SPDD
        RemoveHandler TxtTk_SPDD.CyberLeave, AddressOf L_Tk_SPDD
        AddHandler TxtTk_SPDD.CyberValiting, AddressOf V_Tk_SPDD
        AddHandler TxtTk_SPDD.CyberLeave, AddressOf L_Tk_SPDD
        '--Tk_CL_VT
        RemoveHandler TxtTk_CL_VT.CyberValiting, AddressOf V_Tk_CL_VT
        RemoveHandler TxtTk_CL_VT.CyberLeave, AddressOf L_Tk_CL_VT
        AddHandler TxtTk_CL_VT.CyberValiting, AddressOf V_Tk_CL_VT
        AddHandler TxtTk_CL_VT.CyberLeave, AddressOf L_Tk_CL_VT
        '--Tk_CK
        RemoveHandler TxtTk_Ck.CyberValiting, AddressOf V_Tk_CK
        RemoveHandler TxtTk_Ck.CyberLeave, AddressOf L_Tk_CK
        AddHandler TxtTk_Ck.CyberValiting, AddressOf V_Tk_CK
        AddHandler TxtTk_Ck.CyberLeave, AddressOf L_Tk_CK
        '--Ma_Thue
        RemoveHandler Txtma_Thue.CyberValiting, AddressOf V_Ma_Thue
        RemoveHandler Txtma_Thue.CyberLeave, AddressOf L_Ma_Thue
        AddHandler Txtma_Thue.CyberValiting, AddressOf V_Ma_Thue
        AddHandler Txtma_Thue.CyberLeave, AddressOf L_Ma_Thue

        '--VT1
        RemoveHandler TxtNh_VT1.CyberValiting, AddressOf V_NH_VT1
        RemoveHandler TxtNh_VT1.CyberLeave, AddressOf L_NH_VT1
        AddHandler TxtNh_VT1.CyberValiting, AddressOf V_NH_VT1
        AddHandler TxtNh_VT1.CyberLeave, AddressOf L_NH_VT1
        '--VT2
        RemoveHandler TxtNh_VT2.CyberValiting, AddressOf V_NH_VT2
        RemoveHandler TxtNh_VT2.CyberLeave, AddressOf L_NH_VT2
        AddHandler TxtNh_VT2.CyberValiting, AddressOf V_NH_VT2
        AddHandler TxtNh_VT2.CyberLeave, AddressOf L_NH_VT2
        '--VT3
        RemoveHandler TxtNh_VT3.CyberValiting, AddressOf V_NH_VT3
        RemoveHandler TxtNh_VT3.CyberLeave, AddressOf L_NH_VT3
        AddHandler TxtNh_VT3.CyberValiting, AddressOf V_NH_VT3
        AddHandler TxtNh_VT3.CyberLeave, AddressOf L_NH_VT3
        '--VT4
        RemoveHandler Txtnh_4.CyberValiting, AddressOf V_NH_VT4
        RemoveHandler Txtnh_4.CyberLeave, AddressOf L_NH_VT4
        AddHandler Txtnh_4.CyberValiting, AddressOf V_NH_VT4
        AddHandler Txtnh_4.CyberLeave, AddressOf L_NH_VT4
        '--VT5
        RemoveHandler TxtNh_VT5.CyberValiting, AddressOf V_NH_VT5
        RemoveHandler TxtNh_VT5.CyberLeave, AddressOf L_NH_VT5
        AddHandler TxtNh_VT5.CyberValiting, AddressOf V_NH_VT5
        AddHandler TxtNh_VT5.CyberLeave, AddressOf L_NH_VT5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub CreateTabe()
        Dim DtTon_kho As New DataTable
        Dim DtGia_Ton As New DataTable
        Dim DtTSua_Tk_Vt As New DataTable

        DtTon_kho.Columns.Add("Vt_Ton_kho", GetType(String))
        DtTon_kho.Columns.Add("Ten", GetType(String))
        DtTon_kho.Rows.Add("1", IIf(M_LAN = "V", "Theo dõi tồn kho", "Inventory"))
        DtTon_kho.Rows.Add("0", IIf(M_LAN = "V", "Không theo dõi tồn kho", "No inventory"))
        CyberFill.V_FillComBoxDefaul(Me.CmbVt_Ton_kho, DtTon_kho, "Vt_Ton_kho", "Ten")
        '---
        DtGia_Ton.Columns.Add("Gia_Ton", GetType(String))
        DtGia_Ton.Columns.Add("Ten", GetType(String))
        DtGia_Ton.Rows.Add("1", IIf(M_LAN = "V", "Tính theo phương pháp giá bình quân", "Average price"))
        DtGia_Ton.Rows.Add("2", IIf(M_LAN = "V", "Tính theo phương pháp giá đích danh", "First in first out price - FIFO"))
        DtGia_Ton.Rows.Add("3", IIf(M_LAN = "V", "Tính theo phương pháp giá nhập trước xuất trước", "Average price"))
        DtGia_Ton.Rows.Add("4", IIf(M_LAN = "V", "Tính theo phương pháp giá bình quân ngày", "Average daily price"))
        CyberFill.V_FillComBoxDefaul(Me.CmbGia_Ton, DtGia_Ton, "Gia_Ton", "Ten")
        '---
        DtTSua_Tk_Vt.Columns.Add("Sua_Tk_Vt", GetType(String))
        DtTSua_Tk_Vt.Columns.Add("Ten", GetType(String))
        DtTSua_Tk_Vt.Rows.Add("1", IIf(M_LAN = "V", "Được sửa tài khoản tồn kho", "Account is correct warehouse"))
        DtTSua_Tk_Vt.Rows.Add("0", IIf(M_LAN = "V", "Không được sửa tài khoản tồn kho", "Account is not correct warehouse"))
        CyberFill.V_FillComBoxDefaul(Me.CmbSua_Tk_Vt, DtTSua_Tk_Vt, "Sua_Tk_Vt", "Ten")

    End Sub
    Dim M_Loai_VT As String = ""
    Private Sub V_Is_Loai_VT()
        CbbLoai_VT.Visible = False
        Dim Dstmp As New DataSet
        Try
            Dt_Loai_VT = CyberSmodb.OpenTableKey(Appconn, Dstmp, "DmLoaiVT", "Loai", "Acti = '1'", CyberSmlib)

        Catch ex As Exception

        End Try
        If Not Dt_Loai_VT Is Nothing Then
            If Dt_Loai_VT.Rows.Count > 0 Then
                CyberFill.V_FillComBoxDefaul(CbbLoai_VT, Dt_Loai_VT, "Loai", If(M_LAN = "V", "Ten_Loai", "Ten_Loai2"), "Ngam_Dinh")
                For i As Integer = 0 To Dt_Loai_VT.Rows.Count - 1
                    If Dt_Loai_VT.Rows(i).Item("Ngam_Dinh") = "1" Then
                        M_Loai_VT = Dt_Loai_VT.Rows(i).Item("Loai").ToString.Trim
                        Exit For
                    End If
                Next
            Else
                Dt_Loai_VT = Nothing
            End If
        End If
        If Not Dt_Loai_VT Is Nothing Then CbbLoai_VT.Visible = True Else CbbLoai_VT.Visible = False
        Dstmp.Dispose()
    End Sub
#End Region

#Region "Valid"
#Region "Vali --- Ma_Kho"
    Private Sub V_Ma_nhkx2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtnh_kx2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_nh", "Dmnhkx", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Ma_nhkx2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtnh_kx2.Text = "" Then
            Txtten_nh.Text = ""
            Exit Sub
        End If
        DrReturn = Txtnh_kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtnh_kx2.Text = DrReturn.Item("Ma_nh")
            Txtten_nh.Text = DrReturn.Item("Ten_nh")
        Else
            Txtnh_kx2.Text = ""
            Txtten_nh.Text = ""
        End If
    End Sub
    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kho.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kho.Text = "" Then
            TxtTen_KHO.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_KHO.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_KHO.Text = ""
        End If
    End Sub
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kh", "Dmkh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kh.Text = "" Then
            TxtTen_Kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Vtri"
    Private Sub V_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Vitri.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vitri", "DmVitri", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Vitri.Text = "" Then
            TxtTen_Vitri.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Vitri.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vitri.Text = DrReturn.Item("Ma_Vitri")
            TxtTen_Vitri.Text = DrReturn.Item("Ten_Vitri")
        Else
            TxtMa_Vitri.Text = ""
            TxtTen_Vitri.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_VT"
    Private Sub V_Tk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_VT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_VT.Text = "" Then
            TxtTen_Tk_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_VT.Text = DrReturn.Item("TK")
            TxtTen_Tk_VT.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_VT.Text = ""
            TxtTen_Tk_VT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_GV"
    Private Sub V_Tk_GV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_GV.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_GV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_GV.Text = "" Then
            TxtTen_TK_GV.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_GV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_GV.Text = DrReturn.Item("TK")
            TxtTen_TK_GV.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_GV.Text = ""
            TxtTen_TK_GV.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_DT"
    Private Sub V_Tk_DT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_DT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_DT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_DT.Text = "" Then
            TxtTen_TK_DT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_DT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_DT.Text = DrReturn.Item("TK")
            TxtTen_TK_DT.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_DT.Text = ""
            TxtTen_TK_DT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_DT_NB"
    Private Sub V_Tk_DT_NB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_DT_NB.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_DT_NB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_DT_NB.Text = "" Then
            TxtTen_TK_DT_NB.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_DT_NB.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_DT_NB.Text = DrReturn.Item("TK")
            TxtTen_TK_DT_NB.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_DT_NB.Text = ""
            TxtTen_TK_DT_NB.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_TL"
    Private Sub V_Tk_TL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_TL.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_TL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_TL.Text = "" Then
            TxtTen_TK_TL.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_TL.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_TL.Text = DrReturn.Item("TK")
            TxtTen_TK_TL.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_TL.Text = ""
            TxtTen_TK_TL.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_SPDD"
    Private Sub V_Tk_SPDD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_SPDD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_SPDD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_SPDD.Text = "" Then
            TxtTen_TK_SPDD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_SPDD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_SPDD.Text = DrReturn.Item("TK")
            TxtTen_TK_SPDD.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_SPDD.Text = ""
            TxtTen_TK_SPDD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CL_VT"
    Private Sub V_Tk_CL_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_CL_VT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CL_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_CL_VT.Text = "" Then
            TxtTen_TK_CL_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_CL_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_CL_VT.Text = DrReturn.Item("TK")
            TxtTen_TK_CL_VT.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_CL_VT.Text = ""
            TxtTen_TK_CL_VT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CK"
    Private Sub V_Tk_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Ck.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Ck.Text = "" Then
            TxtTen_TK_CK.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Ck.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Ck.Text = DrReturn.Item("TK")
            TxtTen_TK_CK.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Ck.Text = ""
            TxtTen_TK_CK.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Thue"
    Private Sub V_Ma_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_Thue.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_Thue", "Dmthue", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtma_Thue.Text = "" Then
            TxtThue_Suat.Text = 0
            Exit Sub
        End If
        DrReturn = Txtma_Thue.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_Thue.Text = DrReturn.Item("ma_Thue")
            TxtThue_Suat.Text = DrReturn.Item("Thue_suat")
        Else
            Txtma_Thue.Text = ""
            TxtThue_Suat.Text = 0
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT1"
    Private Sub V_UpdateTk(ByVal _Dr As DataRow)
        If _Dr Is Nothing Then Exit Sub
        'If _Dr.Table.Columns.Contains("MA_KHO") And TxtMa_Kho.Text.Trim = "" Then TxtMa_Kho.Text = _Dr.Item("MA_KHO").ToString.Trim
        'If _Dr.Table.Columns.Contains("TK_VT") And TxtTk_VT.Text.Trim = "" Then TxtTk_VT.Text = _Dr.Item("TK_VT").ToString.Trim
        'If _Dr.Table.Columns.Contains("TK_GV") And TxtTk_GV.Text.Trim = "" Then TxtTk_GV.Text = _Dr.Item("TK_GV").ToString.Trim
        'If _Dr.Table.Columns.Contains("TK_DT") And TxtTk_DT.Text.Trim = "" Then TxtTk_DT.Text = _Dr.Item("TK_DT").ToString.Trim
        'If _Dr.Table.Columns.Contains("TK_DT_NB") And TxtTk_DT_NB.Text.Trim = "" Then TxtTk_DT_NB.Text = _Dr.Item("TK_DT_NB").ToString.Trim
        'If _Dr.Table.Columns.Contains("TK_TL") And TxtTk_TL.Text.Trim = "" Then TxtTk_TL.Text = _Dr.Item("TK_TL").ToString.Trim
        'If _Dr.Table.Columns.Contains("TK_CL_VT") And TxtTk_CL_VT.Text.Trim = "" Then TxtTk_CL_VT.Text = _Dr.Item("TK_CL_VT").ToString.Trim
        'If _Dr.Table.Columns.Contains("TK_SPDD") And TxtTk_SPDD.Text.Trim = "" Then TxtTk_SPDD.Text = _Dr.Item("TK_SPDD").ToString.Trim
        'If _Dr.Table.Columns.Contains("TK_CK") And TxtTk_Ck.Text.Trim = "" Then TxtTk_Ck.Text = _Dr.Item("TK_CK").ToString.Trim

        If _Dr.Table.Columns.Contains("MA_KHO") Then If Not _Dr.Item("MA_KHO").ToString.Trim = "" Then TxtMa_Kho.Text = _Dr.Item("MA_KHO").ToString.Trim
        If _Dr.Table.Columns.Contains("TK_VT") Then If Not _Dr.Item("TK_VT").ToString.Trim = "" Then TxtTk_VT.Text = _Dr.Item("TK_VT").ToString.Trim
        If _Dr.Table.Columns.Contains("TK_GV") Then If Not _Dr.Item("TK_GV").ToString.Trim = "" Then TxtTk_GV.Text = _Dr.Item("TK_GV").ToString.Trim
        If _Dr.Table.Columns.Contains("TK_DT") Then If Not _Dr.Item("TK_DT").ToString.Trim = "" Then TxtTk_DT.Text = _Dr.Item("TK_DT").ToString.Trim
        If _Dr.Table.Columns.Contains("TK_DT_NB") Then If Not _Dr.Item("TK_DT_NB").ToString.Trim = "" Then TxtTk_DT_NB.Text = _Dr.Item("TK_DT_NB").ToString.Trim
        If _Dr.Table.Columns.Contains("TK_TL") Then If Not _Dr.Item("TK_TL").ToString.Trim = "" Then TxtTk_TL.Text = _Dr.Item("TK_TL").ToString.Trim
        If _Dr.Table.Columns.Contains("TK_CL_VT") Then If Not _Dr.Item("TK_CL_VT").ToString.Trim = "" Then TxtTk_CL_VT.Text = _Dr.Item("TK_CL_VT").ToString.Trim
        If _Dr.Table.Columns.Contains("TK_SPDD") Then If Not _Dr.Item("TK_SPDD").ToString.Trim = "" Then TxtTk_SPDD.Text = _Dr.Item("TK_SPDD").ToString.Trim
        If _Dr.Table.Columns.Contains("TK_CK") Then If Not _Dr.Item("TK_CK").ToString.Trim = "" Then TxtTk_Ck.Text = _Dr.Item("TK_CK").ToString.Trim

    End Sub
    Private Sub V_NH_VT1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_VT1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_VT1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_VT1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
            V_UpdateTk(DrReturn)
        Else
            TxtNh_VT1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT2"
    Private Sub V_NH_VT2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_VT2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_VT2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_VT2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
            V_UpdateTk(DrReturn)
        Else
            TxtNh_VT2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT3"
    Private Sub V_NH_VT3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_VT3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_VT3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_VT3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
            V_UpdateTk(DrReturn)
        Else
            TxtNh_VT3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT4"
    Private Sub V_NH_VT4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtnh_4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_VT4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtnh_4.Text = "" Then
            TxtTennh_4.Text = ""
            Exit Sub
        End If
        DrReturn = Txtnh_4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtnh_4.Text = DrReturn.Item("Ma_Nh")
            TxtTennh_4.Text = DrReturn.Item("Ten_Nh")
            V_UpdateTk(DrReturn)
        Else
            Txtnh_4.Text = ""
            TxtTennh_4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT5"
    Private Sub V_NH_VT5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_VT5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_VT5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_VT5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
            V_UpdateTk(DrReturn)
        Else
            TxtNh_VT5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
       Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_VT.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
        CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_UpdateDmVtAndDmGia2", "1" & "#" & Mode & "#" & TxtMa_VT.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
