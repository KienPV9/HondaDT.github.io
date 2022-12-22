Imports System.Data.SqlClient
Imports System.IO
Public Class DCD
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_Cp_Name As String
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
    Dim filepath As String
    Dim Dt_Master1, Dt_Head1, Dt_Tab1 As DataTable
    Dim Dv_Master1, Dv_Head1 As DataView
    Dim Dt_DetailCv, Dt_DetailCvTmp As New DataTable
    Dim Dv_DetailCv, Dv_DetailCvTmp As New DataView
    Dim Dt_DetailTTX, Dt_DetailTTXTmp As New DataTable
    Dim Dv_DetailTTX, Dv_DetailTTXTmp As New DataView
#End Region
#Region "Khai bao bien Paramater----------------------"
    Dim M_Ma_THue, M_Mau_BC As String
#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys

#End Region
#Region "Columns Edit"
    Dim EditMa_xe, EditLoai_Xe, EditMa_KX, EditTen_Kx, EditMa_Mau, EditTen_Mau, EditSo_Khung, EditSo_May, EditLoai_Dong_Co, EditSo_Dong_Co As New Cyber.Fill.CyberColumnGridView
    Dim EditDai_Ly_Ban, EditXuat_Xuong, EditGhi_Chu, EditMa_CV, EditTen_CV, EditMa_CTCV, EditTen_CTCV As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_VT, EditPart_no, EditTen_Vt, EditDvt, EditSo_Luong, EditMa_Kho, EditMa_Vitri As New Cyber.Fill.CyberColumnGridView
#End Region
#Region "Khai bao bien Private"
    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
#End Region
    Private Sub SVB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()

        If DrDmct.Table.Columns.Contains("NonVAT") Then ChkNonVAT.Visible = (DrDmct.Item("NonVAT").ToString.Trim = "1")
        If DrDmct.Table.Columns.Contains("CaptionNonVAT") Then If DrDmct.Item("CaptionNonVAT").ToString.Trim <> "" Then ChkNonVAT.Text = DrDmct.Item("CaptionNonVAT").ToString.Trim
        V_GetColumn()
        V_AddHandler()
        V_Databing()
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_MainSystem()
        V_MainSystemCv()
        V_MainSystemTTX()
        CmdNew.Select()
    End Sub
#Region "Load And Set And Default"
    Private Sub V_Load()
        V_Getdefault()
        '---------------------
        ' Vật tư
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        ' Công việc
        Dt_DetailCv = M_DsData.Tables(2)
        Dt_DetailCvTmp = Dt_DetailCv.Clone
        ' Thông tin xe
        Dt_DetailTTX = M_DsData.Tables(3)
        Dt_DetailTTXTmp = Dt_DetailTTX.Clone
        ' Ph
        Dt_Master = M_DsData.Tables(1)
        ' Ph
        Dv_Master = New DataView(Dt_Master)

        ' Vật tư
        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        ' Công việc
        Dv_DetailCv = New DataView(Dt_DetailCv)
        Dv_DetailCvTmp = New DataView(Dt_DetailCvTmp)
        ' Thông tin xe
        Dv_DetailTTX = New DataView(Dt_DetailTTX)
        Dv_DetailTTXTmp = New DataView(Dt_DetailTTXTmp)
        '========= FillData to Gridview Vt
        DetailVt.DataSource = Dv_DetailTmp
        Me.DetailGRVVt.GridControl = Me.DetailVt
        CyberFill.V_FillVoucher(DetailGRVVt, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)
        '========= FillData to Gridview Cv
        DetailCv.DataSource = Dv_DetailCvTmp
        Me.DetailGRVCv.GridControl = Me.DetailCv
        CyberFill.V_FillVoucher(DetailGRVCv, M_LAN, New DataView(M_DsHead.Tables(2)), Dv_DetailCvTmp, Me.DrDmct)

        '========= FillData to Gridview TTX
        DetailTTX.DataSource = Dv_DetailTTXTmp
        Me.DetailGRVTTX.GridControl = Me.DetailTTX
        CyberFill.V_FillVoucher(DetailGRVTTX, M_LAN, New DataView(M_DsHead.Tables(3)), Dv_DetailTTXTmp, Me.DrDmct)



        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        ' M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, Dslookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
        'V_LoadNam()
    End Sub
    'Private Sub V_LoadNam()
    '    Dim tbNam, tbthang As DataTable
    '    Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadNam", M_Ma_Dvcs & "#" & M_User_Name)
    '    tbNam = DsTmp.Tables(0).Copy
    '    CyberFill.V_FillComBoxValue(Me.cmbNam, tbNam, "Ma_nam", "Ten_nam", "")
    '    tbthang = DsTmp.Tables(1).Copy
    '    CyberFill.V_FillComBoxValue(Me.cmdthang, tbthang, "Ma_thang", "Ten_thang", "")
    '    cmbNam.Text = Year(Now.Date)
    '    cmdthang.Text = Month(Now.Date)
    'End Sub



    Private Sub V_Getdefault()
        M_strFilter = Me.strFilter
        M_DrDmct = Me.DrDmct
        M_Ph = M_DrDmct.Item("M_Ph").ToString.Trim
        M_Ct = M_DrDmct.Item("M_Ct").ToString.Trim
        osysvar = Me.SysVar
        M_Stt_Rec = Me.Stt_Rec
        M_LAN = Me.Lan
        M_Para = Me.Para
        AppConn = Me.AppConn
        M_DsData = Me.DsData
        M_DsHead = Me.DsHead
        M_DsLookUp = Me.DsLookup
        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        K_Tmp = M_Para(1).Trim
        K_System = M_Para(2).Trim
        K_Repo = M_Para(3).Trim
        K_Repo_Nt = M_Para(4).Trim
        M_CYBER_VER = M_Para(5).Trim
        M_User_Name = M_Para(6).Trim
        M_Comment = M_Para(7).Trim
        M_is_Admin = CType(M_Para(8), Boolean)
        M_User_ID = M_Para(9).Trim
        M_Menu_ID0 = M_Para(10).Trim
        M_Bar = M_Para(11).Trim
        M_Bar2 = M_Para(12).Trim
        M_LAN = M_Para(13).Trim
        M_Ma_Dvcs = M_Para(14).Trim
        '---------------------------------------------------------------------------------------------'
        M_Ma_GD = M_Para(M_VT_PARA + 1).Trim
        M_Ma_CT = M_Para(M_VT_PARA + 2).Trim
        'M_Mau_BC = M_Para(M_VT_PARA + 4).Trim
        '---------------------------------------------------------------------------------------------'
        M_Ma_Post = CyberSupport.V_GetMaxPost(AppConn, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        '---
        M_Ma_Nt = DrDmct.Item("Ma_Nt").ToString.Trim
        M_Dien_Giai = DrDmct.Item("Dien_Giai").ToString.Trim

        DtPost = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmPost", "Ma_Post", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), M_Ma_Post)
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)

        V_LoadDefault()
    End Sub
    Private Sub V_SetProperty()
        Me.Stt_Rec = M_Stt_Rec
        '---
        Dim FixCol As Integer = -1
        FixCol = DrDmct.Item("ColFrozen_master")
        If FixCol < DetailGRVVt.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRVVt.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRVVt.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRVVt.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown

        If FixCol < DetailGRVCv.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRVCv.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRVCv.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRVCv.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown

        If FixCol < DetailGRVTTX.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRVTTX.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRVTTX.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRVTTX.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown



    End Sub
    Private Sub V_GetColumn()
        EditMa_xe.GetColumn(DetailGRVTTX, "Ma_xe")
        EditLoai_Xe.GetColumn(DetailGRVTTX, "Loai_Xe")
        EditMa_KX.GetColumn(DetailGRVTTX, "Ma_KX")
        EditTen_Kx.GetColumn(DetailGRVTTX, "Ten_KX")
        EditMa_Mau.GetColumn(DetailGRVTTX, "Ma_Mau")
        EditTen_Mau.GetColumn(DetailGRVTTX, "Ten_Mau")
        EditSo_Khung.GetColumn(DetailGRVTTX, "So_Khung")
        EditSo_May.GetColumn(DetailGRVTTX, "So_May")
        EditLoai_Dong_Co.GetColumn(DetailGRVTTX, "Loai_Dong_Co")
        EditSo_Dong_Co.GetColumn(DetailGRVTTX, "So_Dong_Co")
        EditDai_Ly_Ban.GetColumn(DetailGRVTTX, "Dai_Ly_Ban")
        EditXuat_Xuong.GetColumn(DetailGRVTTX, "Xuat_Xuong")
        EditGhi_Chu.GetColumn(DetailGRVTTX, "Ghi_Chu")

        EditMa_CV.GetColumn(DetailGRVCv, "Ma_CV")
        EditTen_CV.GetColumn(DetailGRVCv, "Ten_CV")
        EditMa_CTCV.GetColumn(DetailGRVCv, "Ma_CTCV")
        EditTen_CTCV.GetColumn(DetailGRVCv, "Ten_CTCV")

        EditMa_VT.GetColumn(DetailGRVVt, "Ma_VT")
        EditPart_no.GetColumn(DetailGRVVt, "Part_no")
        EditTen_Vt.GetColumn(DetailGRVVt, "Ten_Vt")
        EditDvt.GetColumn(DetailGRVVt, "Dvt")
        EditSo_Luong.GetColumn(DetailGRVVt, "So_Luong")
        EditMa_Kho.GetColumn(DetailGRVVt, "Ma_Kho")
        EditMa_Vitri.GetColumn(DetailGRVVt, "Ma_Vitri")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        'TxtTieu_De.Focus()
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        V_AddHandler_System()
        V_AddHandler_Master()
        V_AddHandler_Detail()
    End Sub
    Private Sub V_AddHandler_System()
        AddHandler Me.KeyDown, AddressOf FrmMain_KeyDown
        '---
        AddHandler CmdSave.Click, AddressOf V_Save
        AddHandler CmdNew.Click, AddressOf V_New
        AddHandler CmdEdit.Click, AddressOf V_Edit
        AddHandler CmdDelete.Click, AddressOf V_Delete
        AddHandler CmdCancel.Click, AddressOf V_Cancel
        AddHandler CmdPrint.Click, AddressOf V_Print
        AddHandler CmdView.Click, AddressOf V_View
        AddHandler CmdSearch.Click, AddressOf V_Search
        AddHandler CmdExit.Click, AddressOf V_Exit
        AddHandler CmdImport.Click, AddressOf V_Import
        AddHandler CmdCopy.Click, AddressOf V_Copy
        '---
        AddHandler DetailGRVVt.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRVVt.KeyDown, AddressOf MasterGRV_KeyDown
        '---
        AddHandler DetailGRVCv.PopupMenuShowing, AddressOf MasterGRVCv_PopupMenuShowing
        AddHandler DetailGRVCv.KeyDown, AddressOf MasterGRVCv_KeyDown

        '-----
        AddHandler DetailGRVTTX.PopupMenuShowing, AddressOf MasterGRVTTX_PopupMenuShowing
        AddHandler DetailGRVTTX.KeyDown, AddressOf MasterGRVTTX_KeyDown
        '-----------------------------------
        AddHandler DetailGRVVt.RowCellStyle, AddressOf DetailGRVVT_RowCellStyle
        AddHandler DetailGRVCv.RowCellStyle, AddressOf DetailGRVCV_RowCellStyle
        AddHandler DetailGRVTTX.RowCellStyle, AddressOf DetailGRVTTX_RowCellStyle
        '---

        '---
        AddHandler CbbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtMa_Quyen.Leave, AddressOf L_Ma_Quyen
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler TxtSo_Ct.Enter, AddressOf V_So_Ct
        'AddHandler ChkUntil_Rep.CheckedChanged, AddressOf V_Until_Rep
        AddHandler TxtMa_hs.CyberValiting, AddressOf V_Ma_hs_H
        AddHandler TxtMa_hs.CyberLeave, AddressOf L_Ma_hs_H
        'AddHandler CmdOK.Click, AddressOf V_loadNV
        '----------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_AddHandler_Detail()
        '---Add On
        EditLoai_Xe.V_ActiLookUpColumn(AddressOf V_Loai_Xe, AddressOf L_Loai_Xe)
        ' EditMa_KX.V_ActiLookUpColumn(AddressOf V_Ma_Kx, AddressOf L_Ma_KX)
        EditMa_Mau.V_ActiLookUpColumn(AddressOf V_Ma_Mau, AddressOf L_Ma_Mau)

        EditMa_VT.V_ActiLookUpColumn(AddressOf V_Ma_VT, AddressOf L_Ma_VT)
        EditMa_CV.V_ActiLookUpColumn(AddressOf V_Ma_CV, AddressOf L_Ma_CV)
        EditMa_CTCV.V_ActiLookUpColumn(AddressOf V_Ma_CTCV, AddressOf L_Ma_CTCV)

        EditMa_xe.V_ActiLookUpColumn(AddressOf V_Ma_xe, AddressOf L_Ma_xe)
    End Sub
#Region "Loai_Xe"
    Private Sub V_Loai_Xe(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_NH", "DmNhKX", "1=1", "1=1")
    End Sub
    Private Sub L_Loai_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVTTX.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Loai_Xe") = ""
            Exit Sub
        End If
        drvCurren("Loai_Xe") = DrReturn("Ma_Nh")
        DetailGRVTTX.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_KX"

    Private Sub V_Ma_xe(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_xe", "Dmxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVTTX.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_xe") = ""
            Exit Sub
        End If
        drvCurren("Ma_xe") = DrReturn("Ma_xe")
        drvCurren("so_khung") = DrReturn("so_khung")
        drvCurren("so_may") = DrReturn("so_may")
        drvCurren("ten_kh") = DrReturn("ten_kh")
        drvCurren("Ma_kx") = DrReturn("MA_KX")
        DetailGRVTTX.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVTTX.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Mau") = ""
            drvCurren("Ten_Mau") = ""
            Exit Sub
        End If
        drvCurren("Ma_Mau") = DrReturn("Ma_Mau")
        drvCurren("Ten_Mau") = DrReturn("Ten_Mau")
        DetailGRVTTX.UpdateCurrentRow()
    End Sub
#End Region

#Region "Ma_VT"

    Private Sub V_Ma_VT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_VT", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVVt.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_VT") = ""
            drvCurren("Ten_VT") = ""
            drvCurren("DVT") = ""
            Exit Sub
        End If

        drvCurren("Ma_VT") = DrReturn("Ma_VT")
        drvCurren("Ten_VT") = DrReturn("Ten_VT")
        drvCurren("Ma_kho_i") = DrReturn("Ma_kho")
        drvCurren("DVT") = DrReturn("DVT")
        DetailGRVVt.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_CV"
    Private Sub V_Ma_CV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_CV", "Dmcv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVCv.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_CV") = ""
            drvCurren("Ten_CV") = ""
            Exit Sub
        End If
        drvCurren("Ma_CV") = DrReturn("Ma_CV")
        drvCurren("Ten_CV3") = DrReturn("Ten_CV")
        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region
#Region "Ma_CTCV"
    Private Sub V_Ma_CTCV(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_CTCV", "DmCTCV", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CTCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVCv.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_CTCV") = ""
            drvCurren("Ten_CTCV") = ""
            Exit Sub
        End If
        drvCurren("Ma_CTCV") = DrReturn("Ma_CTCV")
        drvCurren("Ten_CTCV") = DrReturn("Ten_CTCV")
        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region

#End Region
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRVVT_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVVt, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub DetailGRVCV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVCv, Dt_DetailCvTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub DetailGRVTTX_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVTTX, Dt_DetailTTXTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Protected Overrides Sub V_Databing()
        Dim i As Integer
        Dim Drv As DataRowView
        Drv = Nothing

        For i = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim = M_Stt_Rec.Trim Then
                Drv = Dv_Master.Item(i)
                Exit For
            End If
        Next
        CyberSmodb.SetValueTObj(Me, Drv)
        '------------------------------------
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        '------------------------------------
        Dt_DetailCvTmp.Clear()
        Dt_DetailCvTmp.AcceptChanges()
        For i = 0 To Dt_DetailCv.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailCvTmp.ImportRow(Dt_DetailCv.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next

        Dt_DetailTTXTmp.Clear()
        Dt_DetailTTXTmp.AcceptChanges()
        For i = 0 To Dt_DetailTTX.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTTXTmp.ImportRow(Dt_DetailTTX.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        UpdateList()


        'V_VisibleUntil_Rep()

    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then

            DetailGRVVt.OptionsBehavior.ReadOnly = False
            DetailGRVCv.OptionsBehavior.ReadOnly = False
            DetailGRVTTX.OptionsBehavior.ReadOnly = False


            DetailGRVVt.OptionsBehavior.Editable = True
            DetailGRVCv.OptionsBehavior.Editable = True

            DetailGRVTTX.OptionsBehavior.Editable = True


            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then TxtSo_Ct.ReadOnly = True Else TxtSo_Ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRVVt.OptionsBehavior.ReadOnly = True
            DetailGRVCv.OptionsBehavior.ReadOnly = True
            DetailGRVTTX.OptionsBehavior.ReadOnly = False

            DetailGRVVt.OptionsBehavior.Editable = False
            DetailGRVCv.OptionsBehavior.Editable = False
            DetailGRVTTX.OptionsBehavior.Editable = True

        End If

        If M_Mode = "S" Then CbbMa_GD.Enabled = False
        If M_Mode = "M" Then CbbMa_GD.Enabled = True
        CyberFill.SetFoCusGRV(DetailGRVVt, M_Mode)
        CyberFill.SetFoCusGRV(DetailGRVCv, M_Mode)
        CyberFill.SetFoCusGRV(DetailGRVTTX, M_Mode)
        SetTxt()

    End Sub
    Private Sub V_GetDateVoucher(ByVal _Mode As String, ByRef _Ngay_Ct As Date, ByRef _Ngay_LCT As Date)
        Dim _DtReturn As DataTable = CyberSupport.V_GetDateVoucher(_Mode, _Ngay_Ct, _Ngay_LCT, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        If _DtReturn Is Nothing Then Exit Sub Else If _DtReturn.Rows.Count <= 0 Then Exit Sub
        If Not _DtReturn.Columns.Contains("Status") Then Exit Sub
        If _DtReturn.Rows(0).Item("Status").ToString.Trim = "N" Then Exit Sub
        If Not DrDmct.Item("M_Ngay_LCt").ToString.Trim = "1" Then TxtNgay_LCt.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        If DrDmct.Item("M_Ngay_Ct").ToString.Trim = "1" Then TxtNgay_Ct.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        _Ngay_Ct = TxtNgay_Ct.Value
        _Ngay_LCT = TxtNgay_Ct.Value
    End Sub
    Private Sub V_GetNoVoucherAuto()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" And TxtSo_Ct.Text.Trim <> "" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucherAuto(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub

#Region "Valid - Master"
#Region "Valid --- DMQuyen"
    Private Sub L_Ma_Quyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Quyen.Text = "" Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, M_DsLookUp, TxtMa_Quyen.Text, "ma_Quyen", "DmQuyen", DrReturn, "1=1", "1=1", "1")
        If DrReturn Is Nothing Then TxtMa_Quyen.Text = "" Else TxtMa_Quyen.Text = DrReturn.Item("ma_Quyen")
    End Sub
#End Region
#End Region
#Region "Valid --- Ma_BP_H"
    Private Sub V_Ma_hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_hs.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_hs", "Dmhs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_hs.Text = "" Then
            TxtTen_hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_hs.Text = DrReturn.Item("Ma_hs")
            TxtTen_hs.Text = DrReturn.Item("Ten_hs")
        Else
            TxtMa_hs.Text = ""
            TxtTen_hs.Text = ""
        End If
    End Sub
#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub UpdateList()

    End Sub



    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'Dim iRow As Integer = -1
        'iRow = DetailGRV.GetFocusedDataSourceRowIndex
        'If iRow < 0 Then Exit Sub
        'DetailGRV.PostEditor()
        'Dim drvCurren As DataRowView
        'drvCurren = DetailGRV.GetFocusedRow
        'CyberSupport.V_UpdateGRV(DetailGRV)
        UpdateList()
    End Sub
#End Region

#Region "Valid - Detail - Core"

#End Region
#Region "Valid - Detail - Add On"

#End Region
#End Region
#Region "Ngay ct, ngay lap chung tu,so chung tu"
    Private Sub V_Ngay_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_So_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not TxtSo_Ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        TxtSo_Ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, TxtSo_Ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Until_Rep(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        'V_VisibleUntil_Rep()
    End Sub

#End Region
#Region "Mainform"
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu

        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItem, Keys.F8)


        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)

        Me.ContextMenu = mnItemsMail
    End Sub

    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVVt.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVVt.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, AppConn, DetailGRVVt) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_MainSystemCv()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItemCv, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItemCv, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVCv.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRVCv_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()

            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItemCv, Nothing, True, False))

            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItemCv, Nothing, True, False))

            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If

    End Sub
    Private Sub V_ShortAddItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        V_AddItemCv(iRow)
        iRow = Dv_DetailCvTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailCvTmp, AppConn, DetailGRVCv) Then Exit Sub
        Dv_DetailCvTmp.Delete(iRow)
        Dv_DetailCvTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub MasterGRVCv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItemCv(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemCv(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        Dim TbHeader As New DataTable
        vTbAdd = Dv_DetailCvTmp
        TbHeader = M_DsHead.Tables(2)
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing
        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), New DataView(TbHeader))
        CarrOnCv(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailCvTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOnCv(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#Region "Main"
    Private Sub V_MainSystemTTX()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItemTTX, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItemTTX, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVTTX.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRVTTX_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()


            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItemTTX, Nothing, True, False))

            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItemTTX, Nothing, True, False))

            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If

    End Sub
    Private Sub V_ShortAddItemTTX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVTTX.FocusedRowHandle
        V_AddItemTTX(iRow)
        iRow = Dv_DetailTTXTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVTTX, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemTTX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVTTX.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTTXTmp, AppConn, DetailGRVTTX) Then Exit Sub
        Dv_DetailTTXTmp.Delete(iRow)
        Dv_DetailTTXTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub MasterGRVTTX_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItemTTX(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemTTX(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        Dim TbHeader As New DataTable
        vTbAdd = Dv_DetailTTXTmp
        TbHeader = M_DsHead.Tables(3)
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing
        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), New DataView(TbHeader))
        CarrOnCv(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailTTXTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVTTX, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOnTTX(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region
    Private Sub FrmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If M_Mode.Trim = "X" Then If e.KeyValue = 27 Then V_Exit(sender, e)
        If M_Mode.Trim = "X" Then
            Select Case e.KeyValue
                Case 33 'Pageup
                    V_Prev(sender, e)
                Case 34 'PageDown
                    V_NEXT(sender, e)
                Case 35 'End
                    V_Bottom(sender, e)
                Case 36 'Home
                    V_Top(sender, e)
            End Select
        End If
    End Sub
    Private Function ChkRightsVoucher(ByVal _Mode As String) As Boolean
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        ChkRightsVoucher = CyberSupport.ChkRightsVoucher(_Dt, _Mode, _Ma_Post, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, M_LAN, AppConn, osysvar, CyberSmlib)
    End Function
#End Region
#Region "Button"
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)


        DetailGRVVt.PostEditor()
        DetailGRVCv.PostEditor()
        DetailGRVTTX.PostEditor()
        Dv_DetailTmp.Table.AcceptChanges()
        Dv_DetailCvTmp.Table.AcceptChanges()
        Dv_DetailTTXTmp.Table.AcceptChanges()
        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        '----------------------------------------------------------------------------------------------------------------------
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailCvTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailTTXTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, TxtSo_Ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
        '----------------------------------------------------------------------------------------------------------------------
        Dim DrMasterOld As DataRow
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            DrMasterOld = CyberSmodb.V_CopyDataRow(drMaster)

            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        '---------------------------------------------------
        Dim DsSave As DataSet
        If Not CyberSmodb.V_SysCheckSaveVoucher(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailCvTmp, Dt_DetailTTXTmp}, {M_Ct, M_Ph, "DMCHIENDICHCV", "DMCHIENDICHSK"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, CbbMa_GD.SelectedValue, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport, DsSave) Then
            If M_Mode = "S" And Not DrMasterOld Is Nothing Then CyberSmodb.V_UpdateRowtoRow(DrMasterOld, Dt_Master, CrrRow)
            Return
        End If
        '---------------------------------------------------
        '---Update Head
        If DsSave.Tables.Count >= 2 Then
            If DsSave.Tables(1).Rows.Count > 0 Then
                CyberSmodb.SetValueTObj_1(Me, DsSave.Tables(1).Rows(0)) '----Chi set Những trường có dữ liệu
                CyberSmodb.AddValueToRow(drMaster, Me)
                drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
                drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
                drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
            End If
        End If
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '---Update Chi tiet
        If DsSave.Tables.Count >= 3 Then
            For iRow As Integer = 0 To DsSave.Tables(2).Rows.Count - 1
                Try
                    CyberSmodb.V_UpdateRowtoRow(DsSave.Tables(2).Rows(iRow), Dt_DetailTmp, iRow)
                Catch ex As Exception
                End Try
            Next
        End If
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        Dt_Detail.Load(Dt_DetailTmp.CreateDataReader)
        '----------------------------------------------------------------------------------------------------------------------
        '--- Save Dien_Giai

        'Public Function SQLExcuteStoreProcedureFile(ByVal Appconn As SqlConnection, ByVal Cp_Name As String, ByVal SqlParameter As Dictionary(Of String, Object)) As Object
        '    Return cyberAppConnect.SQLExcuteStoreProcedureFile(Appconn, Cp_Name, SqlParameter)
        'End Function
        '----------------------------------------------------------------------------------------------------------------------
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("L")
        CyberSmlib.FlushMemorySave()
    End Sub



    Private Function ChkVsave() As Boolean
        Dim iRow, nCount As Integer
        nCount = Dt_DetailTmp.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailTmp.Rows(iRow).Item("Ma_VT").ToString.Trim = "" Then
                Dt_DetailTmp.Rows(iRow).Delete()
                Dt_DetailTmp.AcceptChanges()
            End If
        Next
        nCount = Dt_DetailCvTmp.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailCvTmp.Rows(iRow).Item("Ma_Cv").ToString.Trim = "" Then
                Dt_DetailCvTmp.Rows(iRow).Delete()
                Dt_DetailCvTmp.AcceptChanges()
            End If
        Next
        UpdateList()
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec.Trim
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT.Trim
            Dt_DetailTmp.Rows(iRow).Item("Ma_Chiendich") = TxtMa_chiendich.Text

            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1) 'Smvoucherlib.Sys.ClsVoucher.GetStt_Rec0(iRow + 1)
        Next
        Dt_DetailTmp.AcceptChanges()
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec.Trim
            Dt_DetailCvTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT.Trim
            Dt_DetailCvTmp.Rows(iRow).Item("Ma_Chiendich") = TxtMa_chiendich.Text

            Dt_DetailCvTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value

            If Dt_DetailCvTmp.Columns.Contains("MA_HS_I") Then If Not TxtMa_hs.Text.Trim = "" Then Dt_DetailCvTmp.Rows(iRow).Item("MA_HS_I") = TxtMa_hs.Text.Trim

            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1) 'Smvoucherlib.Sys.ClsVoucher.GetStt_Rec0(iRow + 1)
        Next
        Dt_DetailCvTmp.AcceptChanges()
        '---------------------------------------------------------------------------------

        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTTXTmp.Rows.Count - 1
            Dt_DetailTTXTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec.Trim
            Dt_DetailTTXTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT.Trim
            Dt_DetailTTXTmp.Rows(iRow).Item("ma_chienDich") = TxtMa_chiendich.Text

            Dt_DetailTTXTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value

            If Dt_DetailTTXTmp.Columns.Contains("MA_HS_I") Then If Not TxtMa_hs.Text.Trim = "" Then Dt_DetailTTXTmp.Rows(iRow).Item("MA_HS_I") = TxtMa_hs.Text.Trim

            Dt_DetailTTXTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1) 'Smvoucherlib.Sys.ClsVoucher.GetStt_Rec0(iRow + 1)
        Next
        Dt_DetailTTXTmp.AcceptChanges()
        '---------------------------------------------------------------------------------

        UpdateList()
        ChkVsave = True
    End Function
    Private Function Add2Database() As Boolean
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailTTX, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCv.ImportRow(Dt_DetailCvTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailTTXTmp.Rows.Count - 1
            Dt_DetailTTX.ImportRow(Dt_DetailTTXTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailCvTmp, Dt_DetailTTXTmp}, {M_Ct, M_Ph, "DMCHIENDICHCV", "DMCHIENDICHSK"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)

        ''---Save: History
        'CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: TO SQL

        'CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        ''V_CyberSaveToSQL()

        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTGT40", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")

        '' CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        ''CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTGT40", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: Post
        'CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Function
    Private Sub Add2Database_Luu()
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(TxtSo_Ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailTTX, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCv.ImportRow(Dt_DetailCvTmp.Rows(i))
        Next
        For i As Integer = 0 To Dt_DetailTTXTmp.Rows.Count - 1
            Dt_DetailTTX.ImportRow(Dt_DetailTTXTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        '---Save: History
        CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '-----------------------------------------------------------------------------------------------------
        '---Save: TO SQL

        CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        'V_CyberSaveToSQL()

        CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "DMChiendichCV", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "DMChiendichSK", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")

        ' CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailCvTmp, "CTGT40", M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        '-----------------------------------------------------------------------------------------------------
        '---Save: Post
        CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Copy(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("C") Then Exit Sub
        M_Stt_RecOld = M_Stt_Rec
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)
        Dim M_So_Bg As String = ""
        Dim Frm As Cyber.From.FrmCopy
        Frm = New FrmCopy
        Frm.Para = M_Para
        Frm.Lan = M_LAN
        Frm.Sysvar = osysvar
        Frm.DrDmct = Me.DrDmct
        Frm.So_CT = ""
        Frm.Ngay_CT = Now.Date
        Frm.Ngay_LCT = Now.Date
        Frm.SysApp = AppConn
        Frm.Ma_Dvcs = TxtMa_Dvcs.Text
        Frm.Stt_Rec = M_Stt_Rec
        Frm.ShowDialog()
        If Not Frm.Ok_Copy Then
            M_Stt_Rec = M_Stt_RecOld
            Exit Sub
        End If

        Dim _Ngay_Ct_Copy As Date = Frm.TxtNgay_Ct.Value
        Dim _Ngay_LCt_Copy As Date = Frm.TxtNgay_LCt.Value
        Dim _So_Ct_Copy As String = Frm.txtSo_ct.Text
        Dim _Ma_Quyen_Copy As String = Frm.TxtMa_Quyen.Text
        '------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        '------------------------------------------------------------------

        '------------------------------------------------------------------
        For iRow = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCvTmp.Rows(iRow).BeginEdit()
            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailCvTmp.Rows(iRow).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailCvTmp.Rows(iRow).EndEdit()
        Next

        For iRow = 0 To Dt_DetailTTXTmp.Rows.Count - 1
            Dt_DetailTTXTmp.Rows(iRow).BeginEdit()
            Dt_DetailTTXTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTTXTmp.Rows(iRow).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailTTXTmp.Rows(iRow).EndEdit()
        Next

        TxtMa_chiendich.Text = ""

        TxtStt_Rec.Text = M_Stt_Rec
        TxtNgay_Ct.Value = _Ngay_Ct_Copy
        TxtNgay_LCt.Value = _Ngay_LCt_Copy
        TxtMa_Quyen.Text = _Ma_Quyen_Copy.Trim
        TxtSo_Ct.Text = _So_Ct_Copy.Trim

        'TxtGio_BD.Text = Strings.Right("00" + Now.Hour.ToString.Trim, 2) + Strings.Right("00" + Now.Minute.ToString.Trim, 2)
        'TxtGio_KT.Text = Strings.Right("00" + Now.AddHours(2).Hour.ToString.Trim, 2) + Strings.Right("00" + Now.Minute.ToString.Trim, 2)
        'TxtGio_HenKT.Text = Strings.Right("00" + Now.AddHours(2).Hour.ToString.Trim, 2) + Strings.Right("00" + Now.AddMinutes(15).Minute.ToString.Trim, 2)

        'TxtNgay_KT.Value = Now.Date
        'TxtNgay_NT.Value = Now.Date

        M_Mode = "M"
        V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_New(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec

        If Not ChkRightsVoucher("M") Then Exit Sub
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)

        M_Mode = "M"

        V_Databing()
        '--------------
        TxtStt_Rec.Text = M_Stt_Rec
        TxtMa_Dvcs.Text = M_Ma_Dvcs

        '--------------
        V_New()
        V_GetMaBP()

        '-----------------------
        '-----------------
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
        CyberSmodb.SetValueFromCombox(CbbMa_TTCP_H, M_Ma_TTCP_H)
    End Sub
    Private Sub V_New()
        If Dt_DetailTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailTmp.NewRow()
            DrCurren = Dt_DetailTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)

            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailTmp.Rows.Add(DrCurren)
            Dt_DetailTmp.AcceptChanges()
        End If

        '----

        If Dt_DetailCvTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailCvTmp.NewRow()
            DrCurren = Dt_DetailCvTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)

            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailCvTmp.Rows.Add(DrCurren)
            Dt_DetailCvTmp.AcceptChanges()
        End If
        '----
        If Dt_DetailTTXTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailTTXTmp.NewRow()
            DrCurren = Dt_DetailTTXTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)

            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"

            Dt_DetailTTXTmp.Rows.Add(DrCurren)
            Dt_DetailTTXTmp.AcceptChanges()
        End If
    End Sub
    Private Sub V_GetMaBP()
        Dim dsTMp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetBpHs", M_User_Name)
        If dsTMp.Tables.Count < 1 Then
            dsTMp.Dispose()
            Exit Sub
        End If
        If dsTMp.Tables(0).Rows.Count < 1 Then
            dsTMp.Dispose()
            Exit Sub
        End If
        If dsTMp.Tables(0).Columns.Contains("Ma_Hs_H") Then If TxtMa_hs.Text.Trim = "" Then TxtMa_hs.Text = dsTMp.Tables(0).Rows(0).Item("Ma_HS_H")
        If dsTMp.Tables(0).Columns.Contains("Ten_Hs_H") Then If TxtTen_hs.Text.Trim = "" Then TxtTen_hs.Text = dsTMp.Tables(0).Rows(0).Item("Ten_Hs_H")

        If dsTMp.Tables(0).Columns.Contains("Ngay_Server") Then If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.Value = dsTMp.Tables(0).Rows(0).Item("Ngay_Server")
        If dsTMp.Tables(0).Columns.Contains("Ngay_Server") Then If DrDmct.Item("M_Ngay_Lct").ToString.Trim = "0" Then TxtNgay_LCt.Value = dsTMp.Tables(0).Rows(0).Item("Ngay_Server")
        dsTMp.Dispose()
    End Sub
    Private Sub V_Edit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("S") Then Exit Sub
        M_Mode = "S"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("S")
    End Sub
    Private Sub V_Delete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("D") Then Exit Sub
        Dim iMasterRow As Integer = -1
        For iRow As Integer = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                iMasterRow = iRow
                Exit For
            End If
        Next
        If Not CyberSupport.V_DeleteVoucher(AppConn, osysvar, M_LAN, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub
        CyberSupport.V_DeleteTableVoucher(Dt_Master, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_Detail, M_Stt_Rec)

        M_Count = Dt_Master.Rows.Count

        If M_Count < 0 Then iMasterRow = -1
        If iMasterRow >= M_Count Then iMasterRow = M_Count - 1

        If iMasterRow >= 0 Then M_Stt_Rec = Dv_Master.Item(iMasterRow).Item("Stt_Rec").ToString.Trim Else M_Stt_Rec = ""

        M_Mode = "X"
        V_Databing()

        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("D")
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkRightsVoucher("P") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        CyberVoucher.V_PrintVocuher(AppConn, osysvar, Nothing, M_Stt_Rec, _Dt, _Ma_Post, M_LAN, M_Para, DrDmct, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub
    Private Sub V_Cancel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_Rec = M_Stt_RecOld
        V_Databing()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("X")
    End Sub
    Private Sub V_View(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = "X"
        If M_Stt_Rec = "" Then Exit Sub
        M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)
        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberVoucher.V_FilterVocuher(AppConn, osysvar, Me.DsLookup, M_LAN, M_Para, DrDmct, M_strFilter, M_Ma_CT, M_Ma_Dvcs, M_User_Name) Then Exit Sub
        Dim DsRefresh As DataSet = CyberSupport.V_FilterData(AppConn, M_strFilter, CyberSmlib, CyberSmodb, DsData)
        If Not CyberSupport.MsgFilterData(DsRefresh.Tables(1), M_LAN, osysvar) Then Exit Sub

        If DsRefresh.Tables(1).Rows.Count = 1 Then M_Stt_Rec = DsRefresh.Tables(1).Rows(0).Item("Stt_Rec")
        If DsRefresh.Tables(1).Rows.Count > 1 Then M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, Me.DsData, Me.DsHead, Me.DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)

        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberSupport.V_ExitVoucher(osysvar, M_LAN) Then Exit Sub
        Me.Close()
    End Sub
#End Region
#Region "Add Or Detete Item"
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = DetailGRVVt.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailGRVVt.RowCount - 1
        Dim iRowRowFocus As Integer = DetailGRVVt.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailGRVVt.VisibleColumns.IndexOf(DetailGRVVt.FocusedColumn)
        Dim iRowOld As Integer = DetailGRVVt.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailTmp.Item(iRow) Else DrvOld = Nothing
        Dv_DetailTmp.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(1)))
        CarrOn(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        UpdateList()

        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVVt, iRow, 0)

    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region
#Region "Sms - Import"
    Private Sub V_Import(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable


        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRVTTX, Dt_DetailTTXTmp, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        Dt_DetailTTXTmp.Clear()
        Dt_DetailTTXTmp.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailTTXTmp.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailTTXTmp.AcceptChanges()
    End Sub
    Private Sub SetTxt()
        'txtTen_HS.Enabled = False
        TxtT_he_so.ReadOnly = True
        TxtT_tien_KPI.ReadOnly = True
    End Sub
#End Region
#Region "TTCP Default and New/Save _TTCP"
    Dim M_Is_Visible_TTCP As Boolean = False
    Dim DtTTCP As DataTable
    Dim M_Ma_TTCP_H As String = ""



    Dim M_Ten_TTCP_H As String = ""
    Dim M_Ten_TTCP2_H As String = ""

    Dim M_Ma_TTLN_H As String = ""
    Dim M_Ten_TTLN_H As String = ""
    Dim M_Ten_TTLN2_H As String = ""


    Dim M_Ma_HS_H As String = ""
    Dim M_Ten_HS_H As String = ""
    Dim M_Ten_HS2_H As String = ""

    Dim M_Ma_BP_H As String = ""
    Dim M_Ten_BP_H As String = ""
    Dim M_Ten_BP2_H As String = ""
    Private Sub V_LoadDefault()
        If DrDmct.Table.Columns.Contains("Is_Visible_TTCP") Then M_Is_Visible_TTCP = (DrDmct.Item("Is_Visible_TTCP").ToString.Trim = "1")
        LabMa_TTCP_H.Visible = M_Is_Visible_TTCP
        CbbMa_TTCP_H.Visible = M_Is_Visible_TTCP

        If M_Is_Visible_TTCP And DrDmct.Table.Columns.Contains("CaptionTTCP") Then If DrDmct.Item("CaptionTTCP").ToString.Trim <> "" Then LabMa_TTCP_H.Text = DrDmct.Item("CaptionTTCP").ToString.Trim

        If M_Is_Visible_TTCP Then
            Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetDefaultVoucher", M_Ma_CT.Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

            If DsTmp.Tables.Count = 0 Then
                M_Is_Visible_TTCP = False
                DsTmp.Dispose()
                Return
            End If

            If DsTmp.Tables(0).Columns.Contains("Ma_TTCP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP_H") Then M_Ten_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP2_H") Then M_Ten_TTCP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_TTLN_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN_H") Then M_Ten_TTLN_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN2_H") Then M_Ten_TTLN2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_HS_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS_H") Then M_Ten_HS_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS2_H") Then M_Ten_HS2_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_BP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP_H") Then M_Ten_BP_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP2_H") Then M_Ten_BP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP2_H").ToString.Trim

            If DsTmp.Tables.Count > 1 Then
                DtTTCP = DsTmp.Tables(1).Copy
                CyberFill.V_FillComBoxValue(Me.CbbMa_TTCP_H, DtTTCP, "Ma_TTCP", If(M_LAN = "V", "Ten_TTCP", "Ten_TTCP2"), M_Ma_TTCP_H)
            Else
                M_Is_Visible_TTCP = False
            End If

            DsTmp.Dispose()
        End If
    End Sub
#End Region
End Class


