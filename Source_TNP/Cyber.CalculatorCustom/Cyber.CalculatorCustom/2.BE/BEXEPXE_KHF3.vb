Public Class BEXEPXE_KHF3
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
    Dim TbTP, TbQuan, TbXa As New DataTable
    Public vTbTP, vTbQuan, vTbXa As DataView
    Dim M_Ma_TP_Ngam_Dinh As String = ""
    Dim M_Ma_Quan_Ngam_Dinh As String = ""
    Dim M_Ma_Xa_Ngam_Dinh As String = ""
    Dim M_Mode As String = "S"
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtPost, DtMaGD As DataTable
    Dim M_Ma_CT As String = "HDX"
    Dim M_Ma_GD As String = "4"
    Dim M_Ma_Post As String = "3"

    Dim M_Ma_HTLL_Ngam_Dinh As String = ""
    Dim M_Ma_MDSD_Ngam_Dinh As String = ""
    Dim M_Ma_HTMX_Ngam_Dinh As String = ""
    Dim M_Ma_DKGX_Ngam_Dinh As String = ""
    Dim M_Ky_HD_Ngam_Dinh As String = ""
    Dim M_Cv_Ky_HD_Ngam_Dinh As String = ""
    Dim M_Tk_Nh_Ngam_Dinh As String = ""
    Dim Dt_HTLL, Dt_MDSD, Dt_HTMX, Dt_DKGX, Dt_Ky_HD, Dt_TK_NH As DataTable
    Private Sub BEXEPXE_KHF3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_LoadDefaultHDX()

        V_Load()

        V_SetReadOnly()

        V_AddHandler_Master()
        Me.Text = "Sửa thông tin khách hàng"

        If Dr.Table.Columns.Contains("Ong_Ba") Then
            Dim _Ong_Ba As String = Dr.Item("Ong_Ba").ToString
            Me.Text = Me.Text + " [ " + _Ong_Ba + " ]"
        End If
        If Dr.Table.Columns.Contains("Ma_HD_H") Then
            Dim _Ma_HD_H As String = Dr.Item("Ma_HD_H").ToString
            Me.Text = Me.Text + ":  Hợp đồng số [ " + _Ma_HD_H + " ]"
        End If

        AddHandler ButtOK.Click, AddressOf V_Nhan
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
#Region "Load And Set And Default"
    Private Sub V_AddHandler_Master()
        AddHandler CmbMa_TP.SelectedIndexChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedIndexChanged, AddressOf V_Ma_quan_SelectedIndexChanged
        '--KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtTen_kh.Leave, AddressOf L_Ten_kh
        AddHandler TxtDia_Chi.Leave, AddressOf L_Dia_Chi
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtMa_SK.CyberValiting, AddressOf V_Ma_SK
        AddHandler TxtMa_SK.CyberLeave, AddressOf L_Ma_SK
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtMa_GPK.CyberValiting, AddressOf V_Ma_GPK
        AddHandler TxtMa_GPK.CyberLeave, AddressOf L_Ma_GPK
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtMa_LHKH.CyberValiting, AddressOf V_Ma_LHKH
        AddHandler TxtMa_LHKH.CyberLeave, AddressOf L_Ma_LHKH
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtMa_bp_H.CyberValiting, AddressOf V_Ma_Bp_H
        AddHandler TxtMa_bp_H.CyberLeave, AddressOf L_Ma_bp_H

        AddHandler TxtMa_HS_H.CyberValiting, AddressOf V_Ma_HS_H
        AddHandler TxtMa_HS_H.CyberLeave, AddressOf L_Ma_HS_H

        '----------------------------------------------------------------------------------------------------------
        'AddHandler TxtNh_HD1.CyberValiting, AddressOf V_Nh_HD1
        'AddHandler TxtNh_HD1.CyberLeave, AddressOf L_Nh_HD1
        'AddHandler TxtNh_HD2.CyberValiting, AddressOf V_Nh_HD2
        'AddHandler TxtNh_HD2.CyberLeave, AddressOf L_Nh_HD2
        'AddHandler TxtNh_HD3.CyberValiting, AddressOf V_Nh_HD3
        'AddHandler TxtNh_HD3.CyberLeave, AddressOf L_Nh_HD3
        '----------------------------------------------------------------------------------------------------------
        AddHandler TxtDT_LX.Leave, AddressOf L_DT_LX

        AddHandler TxtDien_Thoai.Leave, AddressOf L_Dien_Thoai
        AddHandler TxtFax.Leave, AddressOf L_Fax

        AddHandler txtOng_Ba.Leave, AddressOf L_Ong_Ba
        AddHandler TxtTen_kh.Leave, AddressOf L_Ten_kh


        AddHandler TxtTen_khVAT.Leave, AddressOf L_Ten_khVat
        AddHandler TxtDia_ChiVAT.Leave, AddressOf L_Dia_ChiVat

        AddHandler ChkTra_Thang.CheckedChanged, AddressOf V_Chk_Tra_Thang
        AddHandler ChkTra_Gop.CheckedChanged, AddressOf V_Chk_Tra_Gop
        AddHandler ChkTra_Thue_Mua.CheckedChanged, AddressOf V_Chk_Tra_Thue_Mua
        AddHandler ChkTra_Cham.CheckedChanged, AddressOf V_Chk_Tra_Cham
    End Sub
    Private Sub V_Load()
        DtPost = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmPost", "Ma_Post", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), M_Ma_Post)
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)
        CyberSmodb.SetValueTObj(Me, Dr)
    End Sub
    Private Sub V_LoadDefaultHDX()
        Dim DsTpQuanXa As New DataSet
        DsTpQuanXa = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDefaultHDX", M_Ma_CT.Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

        TbTP = DsTpQuanXa.Tables(0).Copy
        vTbTP = New DataView(TbTP)

        TbQuan = DsTpQuanXa.Tables(1).Copy
        vTbQuan = New DataView(TbQuan)

        TbXa = DsTpQuanXa.Tables(2).Copy
        vTbXa = New DataView(TbXa)

        Dt_HTLL = DsTpQuanXa.Tables(3).Copy
        Dt_Ky_HD = DsTpQuanXa.Tables(4).Copy

        Dt_MDSD = DsTpQuanXa.Tables(5).Copy
        Dt_HTMX = DsTpQuanXa.Tables(6).Copy
        Dt_DKGX = DsTpQuanXa.Tables(7).Copy

        '----Thangtv
        Dt_TK_NH = DsTpQuanXa.Tables(8).Copy
        DsTpQuanXa.Dispose()
        '--------------------------------------------------------------------------------------------
        '=========== FillCombox
        CyberFill.V_FillComBoxValue(CmbMa_TP, vTbTP, "ma_Tp", "Ten_Tp", "")
        CyberFill.V_FillComBoxValue(CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan", "")
        CyberFill.V_FillComBoxValue(CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa", "")
        '------------
        'CyberFill.V_FillComBoxDefaul(CmbVai_Tro, Dt_vai_tro, "Vai_Tro", "Ten", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_HTLL, Dt_HTLL, "MA_HTLL", "Ten_HTLL", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_MDSD, Dt_MDSD, "MA_MDSD", "Ten_MDSD", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_HTMX, Dt_HTMX, "MA_HTMX", "Ten_HTMX", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_DKGX, Dt_DKGX, "MA_DKGX", "Ten_DKGX", "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CmbKy_HD, Dt_Ky_HD, "MA_HS", "Ten_Hs", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbCv_Ky_KD, Dt_Ky_HD, "Chuc_Vu", "Chuc_Vu", "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CmbTk_nh, Dt_TK_NH, "TK_NH", "Ten_NH", "Ngam_Dinh")
        '--------------------------------------------------------------------------------------------
        If TbTP.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To TbTP.Rows.Count - 1
                If TbTP.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_TP_Ngam_Dinh = TbTP.Rows(i).Item("ma_TP").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If TbQuan.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To TbQuan.Rows.Count - 1
                If TbQuan.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_Quan_Ngam_Dinh = TbQuan.Rows(i).Item("ma_Quan").ToString.Trim
                    Exit For
                End If
            Next
        End If
        If TbXa.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To TbXa.Rows.Count - 1
                If TbXa.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_Xa_Ngam_Dinh = TbXa.Rows(i).Item("ma_Xa").ToString.Trim
                    Exit For
                End If
            Next
        End If


        If Dt_HTLL.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_HTLL.Rows.Count - 1
                If Dt_HTLL.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_HTLL_Ngam_Dinh = Dt_HTLL.Rows(i).Item("Ma_HTLL").ToString.Trim
                    Exit For
                End If
            Next
        End If

        If Dt_Ky_HD.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_Ky_HD.Rows.Count - 1
                If Dt_Ky_HD.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ky_HD_Ngam_Dinh = Dt_Ky_HD.Rows(i).Item("Ma_Hs").ToString.Trim
                    M_Cv_Ky_HD_Ngam_Dinh = Dt_Ky_HD.Rows(i).Item("Chuc_Vu").ToString.Trim
                    Exit For
                End If
            Next
        End If



        If Dt_MDSD.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_MDSD.Rows.Count - 1
                If Dt_MDSD.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_MDSD_Ngam_Dinh = Dt_MDSD.Rows(i).Item("Ma_MDSD").ToString.Trim
                    Exit For
                End If
            Next
        End If

        If Dt_HTMX.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_HTMX.Rows.Count - 1
                If Dt_HTMX.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_HTMX_Ngam_Dinh = Dt_HTMX.Rows(i).Item("Ma_HTMX").ToString.Trim
                    Exit For
                End If
            Next
        End If

        If Dt_DKGX.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_DKGX.Rows.Count - 1
                If Dt_DKGX.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_DKGX_Ngam_Dinh = Dt_DKGX.Rows(i).Item("Ma_DKGX").ToString.Trim
                    Exit For
                End If
            Next
        End If

        If Dt_TK_NH.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To Dt_TK_NH.Rows.Count - 1
                If Dt_TK_NH.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Tk_Nh_Ngam_Dinh = Dt_TK_NH.Rows(i).Item("Tk_Nh").ToString.Trim
                    Exit For
                End If
            Next
        End If
        '---------------------------------------------------------------------------------------------'
    End Sub
    Private Sub V_SetReadOnly()
        TxtMa_Hd_H.ReadOnly = True
        'TxtNh_HD1.ReadOnly = True
        'TxtNh_HD2.ReadOnly = True
        'TxtNh_HD3.ReadOnly = True
    End Sub
#End Region
#Region "Valid Master"
#Region "Valid Id/Ten_kh/Dia_Chi/Dien_Thoai/--- "
    Private Sub L_Fax(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        If TxtDien_Thoai.Text = "" Then TxtDien_Thoai.Text = TxtFax.Text
        If TxtDT_LX.Text = "" Then TxtDT_LX.Text = TxtFax.Text
    End Sub
    Private Sub L_Dien_Thoai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        If TxtDT_LX.Text = "" Then TxtDT_LX.Text = TxtDien_Thoai.Text
        If TxtDT_LH.Text = "" Then TxtDT_LH.Text = TxtDien_Thoai.Text
        If TxtFax.Text = "" Then TxtFax.Text = TxtDien_Thoai.Text
    End Sub
    Private Sub L_Ong_Ba(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        If txtOng_Ba.Text.Trim <> "" Then
            TxtTen_kh.Text = IIf(TxtTen_kh.Text.Trim <> "", TxtTen_kh.Text, txtOng_Ba.Text)
            TxtTen_khVAT.Text = IIf(TxtTen_khVAT.Text.Trim <> "", TxtTen_khVAT.Text, txtOng_Ba.Text)
        Else
            txtOng_Ba.Text = IIf(TxtTen_kh.Text.Trim <> "", TxtTen_kh.Text, txtOng_Ba.Text)
        End If
    End Sub
    Private Sub L_Ten_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub

        TxtTen_khVAT.Text = IIf(TxtTen_khVAT.Text.Trim <> "", TxtTen_khVAT.Text, TxtTen_kh.Text)
        txtOng_Ba.Text = IIf(txtOng_Ba.Text.Trim <> "", txtOng_Ba.Text, TxtTen_kh.Text)
        txtOng_Ba.Text = IIf(txtOng_Ba.Text.Trim <> "", txtOng_Ba.Text, TxtTen_khVAT.Text)
        TxtTen_kh_LH.Text = IIf(TxtTen_kh_LH.Text.Trim <> "", TxtTen_kh_LH.Text, TxtTen_kh.Text)
        TxtTen_kh_LH.Text = IIf(TxtTen_kh_LH.Text.Trim <> "", TxtTen_kh_LH.Text, TxtTen_khVAT.Text)
    End Sub
    Private Sub L_Dia_Chi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Kh.Text <> "" Then TxtDia_Chi.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kh", "DmKh", "Ma_Kh = N'" + TxtMa_Kh.Text + "'", CyberSmlib)

        TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim <> "", TxtDia_ChiVAT.Text, TxtDia_Chi.Text)
        TxtDC_LH.Text = IIf(TxtDC_LH.Text.Trim <> "", TxtDC_LH.Text, TxtDia_Chi.Text)
        TxtDC_LH.Text = IIf(TxtDC_LH.Text.Trim <> "", TxtDC_LH.Text, TxtDia_ChiVAT.Text)
    End Sub
    Private Sub L_Ten_khVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        TxtTen_kh.Text = IIf(TxtTen_kh.Text.Trim <> "", TxtTen_kh.Text, TxtTen_khVAT.Text)
        TxtTen_kh_LH.Text = IIf(TxtTen_kh_LH.Text.Trim <> "", TxtTen_kh_LH.Text, TxtTen_khVAT.Text)

    End Sub
    Private Sub L_Dia_ChiVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If
        TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim <> "", TxtDia_Chi.Text, TxtDia_ChiVAT.Text)
    End Sub
    Private Sub L_DT_LX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            Exit Sub
        End If

        If TxtDien_Thoai.Text = "" Then TxtDien_Thoai.Text = TxtDT_LX.Text
        If TxtFax.Text = "" Then TxtFax.Text = TxtDT_LX.Text

        If TxtDT_LH.Text = "" Then TxtDT_LH.Text = TxtDT_LX.Text
    End Sub
#End Region
#Region "Thành phố Quận xã"
    Private Sub V_Ma_TP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_TP()
    End Sub
    Private Sub V_Ma_quan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_Quan()
    End Sub
    Private Sub V_Ma_TP()
        vTbQuan.RowFilter = "Ma_TP = '" + CmbMa_TP.SelectedValue + "'"
        vTbXa.RowFilter = "Ma_Quan = '" + CmbMa_Quan.SelectedValue + "'"
    End Sub
    Private Sub V_Ma_Quan()
        vTbXa.RowFilter = "Ma_Quan = '" + CmbMa_Quan.SelectedValue + "'"
    End Sub
#End Region
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Kh.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_KH")
            TxtTen_kh.Text = DrReturn.Item("Ten_KH")
            TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim = "", DrReturn.Item("Dia_Chi"), TxtDia_Chi.Text)
            If txtOng_Ba.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Ong_Ba") Then txtOng_Ba.Text = DrReturn.Item("Ong_Ba")
            If txtOng_Ba.Text.Trim = "" Then If DrReturn.Table.Columns.Contains("Doi_Tac") Then txtOng_Ba.Text = DrReturn.Item("Doi_Tac")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_kh.Text = ""

        End If
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            TxtDia_Chi.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Sk"
    Private Sub V_Ma_SK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_SK", "DmSk", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_SK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_SK.Text = "" Then
            TxtTen_SK.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_SK.Text = DrReturn("Ma_Sk").ToString.Trim
            TxtTen_SK.Text = DrReturn("ten_sk").ToString.Trim
        Else
            TxtMa_SK.Text = ""
            TxtTen_SK.Text = ""
        End If

    End Sub
#End Region
#Region "Valid --- Ma_GPK"
    Private Sub V_Ma_GPK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_GPK", "DmGPK", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_GPK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_GPK.Text = "" Then
            TxtTen_GPK.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_GPK.Text = DrReturn("Ma_GPK").ToString.Trim
            TxtTen_GPK.Text = DrReturn("ten_GPK").ToString.Trim
        Else
            TxtMa_GPK.Text = ""
            TxtTen_GPK.Text = ""
        End If

    End Sub
#End Region
#Region "Valid --- Ma_LHKH"
    Private Sub V_Ma_LHKH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_LHKH", "DmLHKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LHKH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_LHKH.Text = "" Then
            TxtTen_LHKH.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHKH.Text = DrReturn("Ma_lhkh").ToString.Trim
            TxtTen_LHKH.Text = DrReturn("ten_lhkh").ToString.Trim
        Else
            TxtMa_LHKH.Text = ""
            TxtTen_LHKH.Text = ""
        End If

    End Sub
#End Region
#Region "Valid --- Ma_bp"
    Private Sub V_Ma_Bp_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_bp", "Dmbp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_bp_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_bp_H.Text = "" Then
            TxtTen_BP_H.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_bp_H.Text = DrReturn("Ma_bp").ToString.Trim
            TxtTen_BP_H.Text = DrReturn("ten_bp").ToString.Trim
        Else
            TxtMa_bp_H.Text = ""
            TxtTen_BP_H.Text = ""
        End If

    End Sub
#End Region
#Region "Valid --- Ma_HS_H"
    Private Sub V_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_HS_H.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_HS_H.Text = "" Then
            TxtTen_Hs_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HS_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS_H.Text = DrReturn.Item("Ma_HS")
            TxtTen_Hs_H.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HS_H.Text = ""
            TxtTen_Hs_H.Text = ""
        End If
    End Sub
#End Region
    '#Region "Valid --- Nh_hd1"
    '    Private Sub V_Nh_HD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_nh", "Dmnhhd", "1=1", "loai_nh='1'")
    '    End Sub
    '    Private Sub L_Nh_HD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '        If TxtNh_HD1.Text = "" Then
    '            TxtTen_Nh_HD1.Text = ""
    '            Exit Sub
    '        End If
    '        DrReturn = sender.GetRowsSelectData(True)
    '        If Not DrReturn Is Nothing Then
    '            TxtNh_HD1.Text = DrReturn("Ma_nh").ToString.Trim
    '            TxtTen_Nh_HD1.Text = DrReturn("ten_nh").ToString.Trim
    '        Else
    '            TxtNh_HD1.Text = ""
    '            TxtTen_Nh_HD1.Text = ""
    '        End If

    '    End Sub
    '#End Region
    '#Region "Valid --- Nh_hd2"
    '    Private Sub V_Nh_HD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_nh", "Dmnhhd", "1=1", "loai_nh='2'")
    '    End Sub
    '    Private Sub L_Nh_HD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '        If TxtNh_HD2.Text = "" Then
    '            TxtTen_Nh_HD2.Text = ""
    '            Exit Sub
    '        End If
    '        DrReturn = sender.GetRowsSelectData(True)
    '        If Not DrReturn Is Nothing Then
    '            TxtNh_HD2.Text = DrReturn("Ma_nh").ToString.Trim
    '            TxtTen_Nh_HD2.Text = DrReturn("ten_nh").ToString.Trim
    '        Else
    '            TxtNh_HD2.Text = ""
    '            TxtTen_Nh_HD2.Text = ""
    '        End If

    '    End Sub
    '#End Region
    '#Region "Valid --- Nh_hd3"
    '    Private Sub V_Nh_HD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_nh", "Dmnhhd", "1=1", "loai_nh='3'")
    '    End Sub
    '    Private Sub L_Nh_HD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    '        If TxtNh_HD3.Text = "" Then
    '            TxtTen_Nh_HD3.Text = ""
    '            Exit Sub
    '        End If
    '        DrReturn = sender.GetRowsSelectData(True)
    '        If Not DrReturn Is Nothing Then
    '            TxtNh_HD3.Text = DrReturn("Ma_nh").ToString.Trim
    '            TxtTen_Nh_HD3.Text = DrReturn("ten_nh").ToString.Trim
    '        Else
    '            TxtNh_HD3.Text = ""
    '            TxtTen_Nh_HD3.Text = ""
    '        End If

    '    End Sub
    '#End Region
#End Region
#Region "Tra thang/tra cham,.."
    Private Sub V_Chk_Tra_Thang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkTra_Thang.Checked = True Then
            ChkTra_Cham.Checked = False
            ChkTra_Gop.Checked = False
            ChkTra_Thue_Mua.Checked = False
        End If

    End Sub
    Private Sub V_Chk_Tra_Gop(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If ChkTra_Gop.Checked = True Then
            ChkTra_Cham.Checked = False
            ChkTra_Thang.Checked = False
            ChkTra_Thue_Mua.Checked = False
        End If

    End Sub
    Private Sub V_Chk_Tra_Thue_Mua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkTra_Thue_Mua.Checked = True Then
            ChkTra_Cham.Checked = False
            ChkTra_Gop.Checked = False
            ChkTra_Thang.Checked = False
        End If
    End Sub
    Private Sub V_Chk_Tra_Cham(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkTra_Cham.Checked = True Then
            ChkTra_Thang.Checked = False
            ChkTra_Gop.Checked = False
            ChkTra_Thue_Mua.Checked = False
        End If

    End Sub
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strField As String = ""
        Dim strValue As String = ""
        If Not ChkTra_Thang.Checked And Not ChkTra_Gop.Checked And Not ChkTra_Thue_Mua.Checked And Not ChkTra_Cham.Checked Then
            MsgBox("Bạn chưa chọn loại hình thanh toán", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return
        End If

        CyberSmodb.GetValueControler(Me, strField, strValue, "Ten_Bp_B,Ten_HS_H,TEN_LHKH,Ten_Nh_HD1,Ten_Nh_HD2,Ten_Nh_HD3,Ten_GPK,Ten_SK")

        Dim Stt_Rec As String = Dr.Item("Stt_Rec")

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXeSAVE_KH", Stt_Rec & "#" & strField & "#" & strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
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
