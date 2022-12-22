Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Public Class DMHS
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa, _Tb_GioiTinh, _Tb_TTLV, _Tb_TTHN As DataTable
    Private vTbTP, vTbQuan, vTbXa As DataView
    Dim fileData As Byte() = Nothing
    Private _Load_TP As Boolean = False
    '================Dung
    Private DsLuong As New DataSet
    Private TbLuong As New DataTable
    Private TbHLuong As New DataTable

    Private DsBH As New DataSet
    Private TbBH As New DataTable
    Private TbHBH As New DataTable

    Private DsGiadinh As New DataSet
    Private TbGiadinh As New DataTable
    Private TbHGiadinh As New DataTable

    Private DsHocTap As New DataSet
    Private TbHocTap As New DataTable
    Private TbHHocTap As New DataTable

    Private DsBangCap As New DataSet
    Private TbBangCap As New DataTable
    Private TbHBangCap As New DataTable

    Private DsCongtac As New DataSet
    Private TbCongtac As New DataTable
    Private TbHCongtac As New DataTable

    Private DsKhenThuong As New DataSet
    Private TbKhenThuong As New DataTable
    Private TbHKhenThuong As New DataTable

    Private DsKyLuat As New DataSet
    Private TbKyLuat As New DataTable
    Private TbHKyLuat As New DataTable

    Private DsDoanDang As New DataSet
    Private TbDoanDang As New DataTable
    Private TbHDoanDang As New DataTable

    Private DsDmkh As New DataSet
    Private TbDmkh As New DataTable
    Private TbHDmkh As New DataTable
    '================End Dung
    Private Sub FDMHS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()
        'V_LoadTinh_Quan_Xa()
        V_LoadToCombox()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_HS, TxtNh_HS1, TxtNh_HS2, TxtNh_HS3, TxtNh_HS4, TxtNh_HS5)
        _Load_TP = True
        V_DownLoadImage()
        TxtMa_HS.Focus()
        V_AddhanderMaster()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Image"
    Private Sub V_SelectImage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim OpenStatus As OpenFileDialog = CyberSupport.GetOpenFileDialog(False, "Image Files |(*.bmp;*.jpg;*.jpeg;*.GIF;*.png)")
        If (OpenStatus.ShowDialog = DialogResult.OK) Then
            Dim file As String
            For Each file In OpenStatus.FileNames
                'lay ra duoi mo rong vd: .doc or .pdf
                Dim file_Type As String = System.IO.Path.GetExtension(file)
                Dim file_Name As String = System.IO.Path.GetFileNameWithoutExtension(file)
                Dim Fullfile_Name As String = file
                Dim info As New FileInfo(file)
                Dim file_Size As Long = info.Length
                fileData = CyberSupport.ReadFileToBytes(Fullfile_Name)
                Try
                    'PictureImage.BackgroundImage = CyberSupport.ReadByteToImage(fileData)
                    PictureImage.Image = CyberSupport.ReadByteToImage(fileData)
                Catch ex As Exception
                End Try
            Next
        End If
    End Sub
    Public Function ReadFileDatabaseToFile(ByVal Appconn As SqlConnection, ByVal _Tb_Name As String, ByVal _Key As String, ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                            Optional ByVal _Field As String = "File_Bit", Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing) As Byte()
        Dim _Return As Byte() = Nothing
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", "SELECT TOP 1 [" & _Field.Trim & "] FROM dbo.[" & _Tb_Name.Trim & "] WHERE " & _Key.Trim & "#" & _Ma_Dvcs & "#" & _User_name)
        If _DsTmp.Tables.Count < 0 Then Return Nothing
        If _DsTmp.Tables(0).Rows.Count < 1 Then Return Nothing
        If Not _DsTmp.Tables(0).Columns.Contains(_Field.Trim) Then Return Nothing Else _Field = _DsTmp.Tables(0).Columns(_Field.Trim).ColumnName

        Dim File_bit As Object
        Try
            File_bit = _DsTmp.Tables(0).Rows(0).Item(_Field)
            _Return = DirectCast(File_bit, Byte())
        Catch ex As Exception
        End Try
        ReadFileDatabaseToFile = _Return
    End Function
    Private Sub V_LoadImage()
        Dim DsImage As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRGetImageHS", TxtMa_HS.Text & "#" & M_Ma_Dvcs & M_User_Name)
    End Sub
#End Region
#Region "LoadTinh_Quan_Xa"
    Private Sub V_LoadTinh_Quan_Xa()
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetTPQuanXa", M_Ma_Dvcs + "#" + M_User_Name)
        TbTP = DsTb.Tables(0).Copy
        TbQuan = DsTb.Tables(1).Copy
        TbXa = DsTb.Tables(2).Copy

        vTbTP = New DataView(TbTP)
        vTbQuan = New DataView(TbQuan)
        vTbXa = New DataView(TbXa)

        CyberFill.V_FillComBoxDefaul(Me.CmbMa_TP, vTbTP, "Ma_TP", "Ten_TP", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa")
    End Sub
    Private Function GetTab(ByVal Tb_name As String, Optional ByVal Order As String = "1=1", Optional ByVal Key As String = "1=1") As DataTable
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetTable", Tb_name + "#" + Key + "#" + Order)
        GetTab = DsTb.Tables(0).Copy
    End Function
    Private Sub V_Ma_TP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_TP(False)
        V_Ma_Quan(False)
    End Sub
    Private Sub V_Ma_Quan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_Quan(False)
    End Sub
    Private Sub V_Ma_xa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_Xa(False)
    End Sub
    Private Sub V_Ma_TP(ByVal Load As Boolean)
        If Load Then
            CmbMa_TP.SelectedValue = TxtMa_TP.Text.Trim
        Else
            TxtMa_TP.Text = CmbMa_TP.SelectedValue.ToString.Trim
        End If
        vTbQuan.RowFilter = "Ma_Tp = '" & TxtMa_TP.Text.Trim & "'"
    End Sub
    Private Sub V_Ma_Quan(ByVal Load As Boolean)
        If Load Then
            CmbMa_Quan.SelectedValue = TxtMa_Quan.Text.Trim
        Else
            TxtMa_Quan.Text = CmbMa_Quan.SelectedValue.ToString.Trim
        End If
        vTbXa.RowFilter = "Ma_Quan = '" & TxtMa_Quan.Text.Trim() & "'"
    End Sub
    Private Sub V_Ma_Xa(ByVal Load As Boolean)
        If Load Then
            CmbMa_Xa.SelectedValue = TxtMA_Xa.Text.Trim
        Else
            TxtMA_Xa.Text = CmbMa_Xa.SelectedValue.ToString.Trim
        End If
    End Sub
#End Region
#Region "LoadToCombox"
    Private Sub V_LoadToCombox()
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetTPQuanXa", M_Ma_Dvcs + "#" + M_User_Name)
        TbTP = DsTb.Tables(0).Copy
        TbQuan = DsTb.Tables(1).Copy
        TbXa = DsTb.Tables(2).Copy

        vTbTP = New DataView(TbTP)
        vTbQuan = New DataView(TbQuan)
        vTbXa = New DataView(TbXa)

        CyberFill.V_FillComBoxDefaul(Me.CmbMa_TP, vTbTP, "Ma_TP", "Ten_TP", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa")
        DsTb = Nothing
        _Tb_GioiTinh = CyberSmodb.OpenTable(Appconn, DsTb, "CRDmGioiTinh", "1", CyberSmlib)
        _Tb_TTLV = CyberSmodb.OpenTable(Appconn, DsTb, "CRDmTTLV", "1", CyberSmlib)
        _Tb_TTHN = CyberSmodb.OpenTable(Appconn, DsTb, "CRDmTTHN", "1", CyberSmlib)

        CyberFill.V_FillComBoxDefaul(Me.CmbGioi_tinh, _Tb_GioiTinh, "Ma", "Ten", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(Me.CmbTT_LV, _Tb_TTLV, "Ma", "Ten", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(Me.CbbTT_HN, _Tb_TTHN, "Ma", "Ten", "Ngam_Dinh")

    End Sub
#End Region
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtNgay_sinh.Value = Now.Date()
            TxtNgay_CMND.Value = Now.Date()
            TxtNgay_TV.Value = Now.Date()
            TxtNgay_LV.Value = Now.Date()
            'TxtNgay_Nghi_Viec.Value = Now.Date()
        End If

        If TxtNh_HS1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHs", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_HS1.Text.Trim + "')", CyberSmlib)
        If TxtNh_HS2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHs", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_HS2.Text.Trim + "')", CyberSmlib)
        If TxtNh_HS3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHs", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_HS3.Text.Trim + "')", CyberSmlib)
        If TxtNh_HS4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHs", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_HS4.Text.Trim + "')", CyberSmlib)
        If TxtNh_HS5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHs", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_HS5.Text.Trim + "')", CyberSmlib)
        If TxtMa_BP.Text.Trim = "" Then TxtTen_BP.Text = "" Else TxtTen_BP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Bp", "DmBp", "(Ma_Bp = N'" + TxtMa_BP.Text.Trim + "')", CyberSmlib)

        If TxtMa_chucvu.Text.Trim = "" Then TxtTen_chucvu.Text = "" Else TxtTen_chucvu.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_ChucVu", "DmChucVu", "(Ma_ChucVu = N'" + TxtMa_chucvu.Text.Trim + "')", CyberSmlib)
        If TxtMa_cty.Text.Trim = "" Then TxtTen_cty.Text = "" Else TxtTen_cty.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Cty", "DmCty", "(Ma_Cty = N'" + TxtMa_cty.Text.Trim + "')", CyberSmlib)
        If TxtMa_ChucDanh.Text.Trim = "" Then TxtTen_ChucDanh.Text = "" Else TxtTen_ChucDanh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_ChucDanh", "DmChucDanh", "(Ma_ChucDanh = N'" + TxtMa_ChucDanh.Text.Trim + "')", CyberSmlib)

        '================Dung
        DsLuong = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetLuong", TxtMa_HS.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsBH = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetBH", TxtMa_HS.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsGiadinh = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetGiadinh", TxtMa_HS.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsHocTap = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetHocTap ", TxtMa_HS.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsCongtac = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetCongTac", TxtMa_HS.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsBangCap = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetBangCap", TxtMa_HS.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsKhenThuong = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetKhenThuong ", TxtMa_HS.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsKyLuat = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetKyLuat ", TxtMa_HS.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        DsDoanDang = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetDoanDang  ", TxtMa_HS.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)

        TbLuong = New DataTable
        TbHLuong = New DataTable
        TbLuong = DsLuong.Tables(0)
        TbHLuong = DsLuong.Tables(1)

        TbBH = New DataTable
        TbHBH = New DataTable
        TbBH = DsBH.Tables(0)
        TbHBH = DsBH.Tables(1)


        TbGiadinh = New DataTable
        TbHGiadinh = New DataTable
        TbGiadinh = DsGiadinh.Tables(0)
        TbHGiadinh = DsGiadinh.Tables(1)


        TbHocTap = New DataTable
        TbHHocTap = New DataTable
        TbHocTap = DsHocTap.Tables(0)
        TbHHocTap = DsHocTap.Tables(1)

        TbCongtac = New DataTable
        TbHCongtac = New DataTable
        TbCongtac = DsCongtac.Tables(0)
        TbHCongtac = DsCongtac.Tables(1)

        TbBangCap = New DataTable
        TbHBangCap = New DataTable
        TbBangCap = DsBangCap.Tables(0)
        TbHBangCap = DsBangCap.Tables(1)

        TbKhenThuong = New DataTable
        TbHKhenThuong = New DataTable
        TbKhenThuong = DsKhenThuong.Tables(0)
        TbHKhenThuong = DsKhenThuong.Tables(1)

        TbKyLuat = New DataTable
        TbHKyLuat = New DataTable
        TbKyLuat = DsKyLuat.Tables(0)
        TbHKyLuat = DsKyLuat.Tables(1)

        TbDoanDang = New DataTable
        TbHDoanDang = New DataTable
        TbDoanDang = DsDoanDang.Tables(0)
        TbHDoanDang = DsDoanDang.Tables(1)

        '--------------KienPV
        'TbDmkh = New DataTable
        'TbHDmkh = New DataTable
        'TbDmkh = DsDmkh.Tables(0)
        'TbHDmkh = DsDmkh.Tables(1)
        '================EndDung
    End Sub
    Private Sub V_AddhanderMaster()
        RemoveHandler CbbSelectImage.Click, AddressOf V_SelectImage
        AddHandler CbbSelectImage.Click, AddressOf V_SelectImage
        '------------------------------------------------------------------------------------------
        '---TInh thanh
        AddHandler CmbMa_TP.SelectedValueChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedValueChanged, AddressOf V_Ma_Quan_SelectedIndexChanged
        AddHandler CmbMa_Xa.SelectedValueChanged, AddressOf V_Ma_xa_SelectedIndexChanged
        '------------------------------------------------------------------------------------------
        RemoveHandler TxtMa_HS.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_HS.KeyPress, AddressOf TxtCodeError_KeyPress
        '--HS1
        RemoveHandler TxtNh_HS1.CyberValiting, AddressOf V_NH_HS1
        RemoveHandler TxtNh_HS1.CyberLeave, AddressOf L_NH_HS1
        AddHandler TxtNh_HS1.CyberValiting, AddressOf V_NH_HS1
        AddHandler TxtNh_HS1.CyberLeave, AddressOf L_NH_HS1
        '--HS2
        RemoveHandler TxtNh_HS2.CyberValiting, AddressOf V_NH_HS2
        RemoveHandler TxtNh_HS2.CyberLeave, AddressOf L_NH_HS2
        AddHandler TxtNh_HS2.CyberValiting, AddressOf V_NH_HS2
        AddHandler TxtNh_HS2.CyberLeave, AddressOf L_NH_HS2
        '--HS3
        RemoveHandler TxtNh_HS3.CyberValiting, AddressOf V_NH_HS3
        RemoveHandler TxtNh_HS3.CyberLeave, AddressOf L_NH_HS3
        AddHandler TxtNh_HS3.CyberValiting, AddressOf V_NH_HS3
        AddHandler TxtNh_HS3.CyberLeave, AddressOf L_NH_HS3
        '--HS4
        RemoveHandler TxtNh_HS4.CyberValiting, AddressOf V_NH_HS4
        RemoveHandler TxtNh_HS4.CyberLeave, AddressOf L_NH_HS4
        AddHandler TxtNh_HS4.CyberValiting, AddressOf V_NH_HS4
        AddHandler TxtNh_HS4.CyberLeave, AddressOf L_NH_HS4
        '--HS5
        RemoveHandler TxtNh_HS5.CyberValiting, AddressOf V_NH_HS5
        RemoveHandler TxtNh_HS5.CyberLeave, AddressOf L_NH_HS5
        AddHandler TxtNh_HS5.CyberValiting, AddressOf V_NH_HS5
        AddHandler TxtNh_HS5.CyberLeave, AddressOf L_NH_HS5


        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP

        AddHandler TxtMa_cty.CyberValiting, AddressOf V_Ma_cty
        AddHandler TxtMa_cty.CyberLeave, AddressOf L_Ma_cty

        AddHandler TxtMa_chucvu.CyberValiting, AddressOf V_Ma_chucvu
        AddHandler TxtMa_chucvu.CyberLeave, AddressOf L_Ma_chucvu
        '
        AddHandler TxtMa_ChucDanh.CyberValiting, AddressOf V_Ma_chucdanh
        AddHandler TxtMa_ChucDanh.CyberLeave, AddressOf L_Ma_chucdanh
        '==================button
        'ButtCong_Tac
        AddHandler ButtLuong.Click, AddressOf V_Luong
        AddHandler ButtBao_hiem.Click, AddressOf V_BH
        AddHandler ButtGia_Dinh.Click, AddressOf V_Giadinh
        AddHandler ButtHoc_Tap.Click, AddressOf V_HocTap
        AddHandler ButtCong_Tac.Click, AddressOf V_Cong_Tac
        AddHandler Buttbang_Cap.Click, AddressOf V_bang_Cap
        AddHandler ButtKhen_thuong.Click, AddressOf V_KhenThuong
        AddHandler ButtKy_Luat.Click, AddressOf V_KyLuat
        AddHandler ButtDoan_Dang.Click, AddressOf V_DoanDang
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "DownLoad And Attach Image"
    Private Sub V_DownLoadImage()
        PictureImage.Image = Nothing
        If Me.Mode = "S" Then
            Try
                'PictureImage.BackgroundImage = CyberSupport.ReadByteToImage(ReadFileDatabaseToFile(Appconn, "DmHsImage", "Ma_Hs =N'" + TxtMa_HS.Text.Trim + "'", M_Ma_Dvcs, M_User_Name, "File_Bit", CyberSmlib))
                PictureImage.Image = CyberSupport.ReadByteToImage(ReadFileDatabaseToFile(Appconn, "DmHsImage", "Ma_Hs =N'" + TxtMa_HS.Text.Trim + "'", M_Ma_Dvcs, M_User_Name, "File_Bit", CyberSmlib))
            Catch ex As Exception
            End Try
        Else
            'PictureImage.BackgroundImage = Nothing
            PictureImage.Image = Nothing
        End If
    End Sub
    Private Sub V_SaveImage()
        Dim _ma_HsOld As String = ""
        If Me.Mode = "S" Then
            _ma_HsOld = Me.DrOld.Item("Ma_Hs").ToString.Trim
            CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", "DELETE FROM dbo.DmHsImage WHERE ma_Hs =N'" + _ma_HsOld + "'#" & M_Ma_Dvcs & "#" & M_User_Name)
        End If
        CyberSupport.V_ImageToDataBase(Me, "CP_CRSaveImage", Me.PictureImage, M_Ma_Dvcs, M_User_Name, "DmHsImage", Me.Appconn, CyberSmodb, CyberSmlib)
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_HS1"
    Private Sub V_NH_HS1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHS", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_HS1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HS1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HS1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HS2"
    Private Sub V_NH_HS2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHS", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_HS2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HS2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HS2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HS3"
    Private Sub V_NH_HS3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHS", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_HS3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HS3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HS3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HS4"
    Private Sub V_NH_HS4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHS", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_HS4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HS4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HS4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_HS5"
    Private Sub V_NH_HS5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHS", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_HS5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HS5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HS5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP.Text = ""
            TxtTen_BP.Text = ""
        End If
    End Sub
    Private Sub V_Ma_cty(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_cty", "Dmcty", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_cty(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_cty.Text = DrReturn.Item("Ma_cty")
            TxtTen_cty.Text = DrReturn.Item("Ten_cty")
        Else
            TxtMa_cty.Text = ""
            TxtTen_cty.Text = ""
        End If
    End Sub
    Private Sub V_Ma_chucvu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_chucvu", "Dmchucvu", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_chucvu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_chucvu.Text = DrReturn.Item("Ma_chucvu")
            TxtTen_chucvu.Text = DrReturn.Item("Ten_chucvu")
        Else
            TxtMa_chucvu.Text = ""
            TxtTen_chucvu.Text = ""
        End If
    End Sub
    Private Sub V_Ma_chucdanh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_chucdanh", "Dmchucdanh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_chucdanh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ChucDanh.Text = DrReturn.Item("Ma_chucdanh")
            TxtTen_ChucDanh.Text = DrReturn.Item("Ten_chucdanh")
            ChkIs_DV_CVDV.Checked = DrReturn.Item("Is_DV_CVDV")
            ChkIs_DV_Dieu_phoi.Checked = DrReturn.Item("Is_DV_Dieu_phoi")
            ChkIs_DV_KTV_SCC.Checked = DrReturn.Item("Is_DV_KTV_SCC")
            ChkIs_DV_KTV_SDS.Checked = DrReturn.Item("Is_DV_KTV_SDS")

            ChkIs_KD_TP.Checked = DrReturn.Item("Is_KD_TP")
            ChkIs_KD_TVBH.Checked = DrReturn.Item("Is_KD_TVBH")
            ChkIs_Kd_Admin.Checked = DrReturn.Item("Is_Kd_Admin")
        Else
            TxtMa_ChucDanh.Text = ""
            TxtTen_ChucDanh.Text = ""
        End If
    End Sub
#End Region
#Region "Click button"
    Private Sub V_Luong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsLuong, "", TbLuong)
    End Sub
    Private Sub V_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsBH, "", TbBH)
    End Sub
    Private Sub V_Giadinh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsGiadinh, "", TbGiadinh)
    End Sub
    Private Sub V_HocTap(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsHocTap, "", TbHocTap)
    End Sub
    Private Sub V_Cong_Tac(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsCongtac, "", TbCongtac)
    End Sub
    Private Sub V_bang_Cap(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsBangCap, "", TbBangCap)
    End Sub
    Private Sub V_KhenThuong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsKhenThuong, "", TbKhenThuong)
    End Sub
    Private Sub V_KyLuat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsKyLuat, "", TbKyLuat)
    End Sub
    Private Sub V_DoanDang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadFromAndUpdatData(DsDoanDang, "", TbDoanDang)
    End Sub
    Private Sub V_LoadFromAndUpdatData(ByVal _DsHs As DataSet, ByVal TableName As String, ByVal TbDetail As DataTable)
        Dim Frm As New FrmDmHs
        Frm.V_InVao(Appconn, M_Para, oSysvar, _DsHs, TableName)
        Frm.ShowDialog()
        If Frm.iOkSave = False Then Exit Sub
        TbDetail.Clear()
        CyberSmodb.SQLTbToTb(Frm.Dt_DetailTmp, TbDetail)
        For iRow As Integer = 0 To TbDetail.Rows.Count - 1
            TbDetail.Rows(iRow)("Ma_Hs") = TxtMa_HS.Text.Trim
            TbDetail.Rows(iRow)("Stt_rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            TbDetail.Rows(iRow)("ma_Dvcs") = M_Ma_Dvcs
        Next
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_HS.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        Dim _ma_HsOld As String = TxtMa_HS.Text
        UpdateMa_HS(TbLuong, TxtMa_HS.Text)
        UpdateMa_HS(TbBH, TxtMa_HS.Text)
        UpdateMa_HS(TbGiadinh, TxtMa_HS.Text)
        UpdateMa_HS(TbHocTap, TxtMa_HS.Text)
        UpdateMa_HS(TbBangCap, TxtMa_HS.Text)
        UpdateMa_HS(TbCongtac, TxtMa_HS.Text)
        UpdateMa_HS(TbKhenThuong, TxtMa_HS.Text)
        UpdateMa_HS(TbKyLuat, TxtMa_HS.Text)
        UpdateMa_HS(TbDoanDang, TxtMa_HS.Text)

        '============= Save 
        'If Me.Mode = "S" Then
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbLuong, "DMHS_Luong", Me.Mode, "Ma_Hs = N'" + _ma_HsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbBH, "DMHS_BH", Me.Mode, "Ma_Hs = N'" + _ma_HsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbGiadinh, "DMHS_Giadinh", Me.Mode, "Ma_Hs = N'" + _ma_HsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbHocTap, "DMHS_HocTap ", Me.Mode, "Ma_Hs = N'" + _ma_HsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbBangCap, "DMHS_BANGCAP", Me.Mode, "Ma_Hs = N'" + _ma_HsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbCongtac, "DMHS_CongTac", Me.Mode, "Ma_Hs = N'" + _ma_HsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbKhenThuong, "DMHS_KhenThuong ", Me.Mode, "Ma_Hs = N'" + _ma_HsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbKyLuat, "DMHS_KyLuat ", Me.Mode, "Ma_Hs = N'" + _ma_HsOld.Trim + "'")
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, TbDoanDang, "DMHS_DoanDang  ", Me.Mode, "Ma_Hs = N'" + _ma_HsOld.Trim + "'")
        DsDmkh = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_HrGetDmkh  ", TxtMa_HS.Text.Trim & "#" & TxtTen_HS.Text.Trim & "#" & TxtDia_chi.Text.Trim & "#" & Mode.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        'End If
        '=============== End

        V_SaveImage()
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub

    Private Sub UpdateMa_HS(ByRef _Tb As DataTable, ByVal _Ma_HS As String)
        If _Tb Is Nothing Then Exit Sub
        If Not _Tb.Columns.Contains("MA_HS") Then Exit Sub

        For i As Integer = 0 To _Tb.Rows.Count - 1
            _Tb.Rows(i).BeginEdit()
            _Tb.Rows(i).Item("Ma_HS") = _Ma_HS
            _Tb.Rows(i).EndEdit()
        Next
        _Tb.AcceptChanges()
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
