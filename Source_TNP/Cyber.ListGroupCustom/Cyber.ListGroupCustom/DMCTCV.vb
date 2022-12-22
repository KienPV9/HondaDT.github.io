Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DMCTCV
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet

    Dim DT_DetailCTCVTmp, Dt_HeadCV, Dt_DmCt As DataTable
    Dim Dv_DetailCtCVTmp, Dv_HeadCV, Dv_DmCt As DataView
    Dim EditMa_KX, EditNh_KX1, EditNh_KX2, EditNh_KX3, EditNh_KX4, EditNh_KX5, EditTen_KX, EditGio_TC, EditGia_CV, EditMa_Khoang, EditTen_Khoang, EditPt1, EditTien_PT1, EditPt2, EditTien_PT2 As New Cyber.Fill.CyberColumnGridView
    Dim M_Ma_CT As String = "HDK"
    Dim M_Ma_TT As String = "C"
    Dim Lan As String = "V"
    Dim Ma_CtCvOld, Ma_DvcsOld As String

    Private Sub FDMTD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_ctcv.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterDmCTCVKX", TxtMa_ctcv.Text.Trim + "#" + Me.Mode.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        DT_DetailCTCVTmp = DsTmp.Tables(0).Copy
        Dt_HeadCV = DsTmp.Tables(1).Copy
        Dt_DmCt = DsTmp.Tables(2).Copy

        Dv_DetailCtCVTmp = New DataView(DT_DetailCTCVTmp)
        Dv_HeadCV = New DataView(Dt_HeadCV)
        Dv_DmCt = New DataView(Dt_DmCt)

        '========= FillData to Gridview Cv
        DetailCv.DataSource = Dv_DetailCtCVTmp
        Me.DetailGRVCv.GridControl = Me.DetailCv
        CyberFill.V_FillVoucher(DetailGRVCv, M_LAN, Dv_HeadCV, Dv_DetailCtCVTmp, Dt_DmCt.Rows(0))
        V_GetColumn()
        V_MainSystem()
        V_AddHandDetail()
        '--------------------------------------------------------------------------------------------

        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

        If Me.Mode = "M" Then TxtMa_thue.Text = "10"

        If TxtNh_ctCv1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCtCV", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_ctCv1.Text.Trim + "')", CyberSmlib)
        If TxtNh_ctCv2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCtCV", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_ctCv2.Text.Trim + "')", CyberSmlib)
        If TxtNh_ctCv3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCtCV", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_ctCv3.Text.Trim + "')", CyberSmlib)
        If TxtNh_ctCv4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCtCV", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_ctCv4.Text.Trim + "')", CyberSmlib)
        If TxtNh_ctCv5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCtCV", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_ctCv5.Text.Trim + "')", CyberSmlib)

        TxtTen_CV.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_CV", "DmCV", "(Ma_CV = N'" + TxtMa_CV.Text.Trim + "')", CyberSmlib)

        LabThue_suat.Text = CyberSmodb.SQLGetvalue(Appconn, "Thue_suat", "Dmthue", "(Ma_Thue = N'" + TxtMa_thue.Text.Trim + "')", CyberSmlib)
        TxtTen_HS.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_HS", "Dmhs", "(Ma_HS = N'" + TxtMa_HS.Text.Trim + "')", CyberSmlib)
        TxtTen_Tk_DT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "Dmtk0", "(TK0 = N'" + TxtTk_dt.Text.Trim + "')", CyberSmlib)
        TxtTen_TT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TT", "Dmtt", "(MA_TT = N'" + TxtMa_TT.Text.Trim + "')", CyberSmlib)
        TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kx", "DmKx", "(Ma_Kx = N'" + TxtMa_Kx.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kx1.Text.Trim = "" Then TxtTen_Nh_Kx1.Text = "" Else TxtTen_Nh_Kx1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKX", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Kx1.Text.Trim + "')", CyberSmlib)

        If Mode = "M" Then
            Ma_CtCvOld = ""
            Ma_DvcsOld = ""
        Else
            Ma_CtCvOld = TxtMa_ctcv.Text.Trim
            Ma_DvcsOld = TxtMa_Dvcs.Text.Trim
        End If
    End Sub
    Private Sub V_GetColumn()
        EditMa_KX.GetColumn(Me.DetailGRVCv, "Ma_KX")
        EditNh_KX1.GetColumn(Me.DetailGRVCv, "Nh_KX1")
        EditNh_KX2.GetColumn(Me.DetailGRVCv, "Nh_Kx2")
        EditNh_KX3.GetColumn(Me.DetailGRVCv, "Nh_Kx3")
        EditNh_KX4.GetColumn(Me.DetailGRVCv, "Nh_Kx4")
        EditNh_KX5.GetColumn(Me.DetailGRVCv, "Nh_Kx5")

        EditTen_KX.GetColumn(Me.DetailGRVCv, "Ten_KX")
        EditGio_TC.GetColumn(Me.DetailGRVCv, "Gio_TC")
        EditGia_CV.GetColumn(Me.DetailGRVCv, "Gia_CV")
        EditMa_Khoang.GetColumn(Me.DetailGRVCv, "Ma_Khoang")
        EditPt1.GetColumn(Me.DetailGRVCv, "PT1")
        EditTien_PT1.GetColumn(Me.DetailGRVCv, "Tien_PT1")
        EditPt2.GetColumn(Me.DetailGRVCv, "PT2")
        EditTien_PT2.GetColumn(Me.DetailGRVCv, "Tien_PT2")
    End Sub
    Private Sub V_MainSystem()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsManl As New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVCv.GridControl.ContextMenu = mnItemsMail
        Me.ContextMenu = mnItemsManl
    End Sub
    Private Sub V_AddHandDetail()
        EditMa_KX.V_ActiLookUpColumn(AddressOf V_Ma_KX1, AddressOf L_Ma_KX1)

        EditNh_KX1.V_ActiLookUpColumn(AddressOf V_Nh_Kx11, AddressOf L_Nh_Kx11)
        EditNh_KX2.V_ActiLookUpColumn(AddressOf V_Nh_Kx12, AddressOf L_Nh_Kx12)
        EditNh_KX3.V_ActiLookUpColumn(AddressOf V_Nh_Kx13, AddressOf L_Nh_Kx13)
        EditNh_KX4.V_ActiLookUpColumn(AddressOf V_Nh_Kx14, AddressOf L_Nh_Kx14)
        EditNh_KX5.V_ActiLookUpColumn(AddressOf V_Nh_Kx15, AddressOf L_Nh_Kx15)

        EditMa_Khoang.V_ActiLookUpColumn(AddressOf V_Ma_Khoang_I, AddressOf L_Ma_Khoang_I)

        If Not EditGio_TC.Column Is Nothing Then AddHandler EditGio_TC.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditGia_CV.Column Is Nothing Then AddHandler EditGia_CV.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        If Not EditPt1.Column Is Nothing Then AddHandler EditPt1.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditTien_PT1.Column Is Nothing Then AddHandler EditTien_PT1.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        If Not EditPt2.Column Is Nothing Then AddHandler EditPt2.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditTien_PT2.Column Is Nothing Then AddHandler EditTien_PT2.EditColumn.Leave, AddressOf V_Tinh_ToanCV

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_ctcv.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_ctcv.KeyPress, AddressOf TxtCodeError_KeyPress


        '--Nh_CTCV1
        RemoveHandler TxtNh_ctCv1.CyberValiting, AddressOf V_Nh_CtCv1
        RemoveHandler TxtNh_ctCv1.CyberLeave, AddressOf L_Nh_CtCv1
        AddHandler TxtNh_ctCv1.CyberValiting, AddressOf V_Nh_CtCv1
        AddHandler TxtNh_ctCv1.CyberLeave, AddressOf L_Nh_CtCv1
        '--Nh_CTCV2
        RemoveHandler TxtNh_ctCv2.CyberValiting, AddressOf V_Nh_CtCv2
        RemoveHandler TxtNh_ctCv2.CyberLeave, AddressOf L_Nh_CtCv2
        AddHandler TxtNh_ctCv2.CyberValiting, AddressOf V_Nh_CtCv2
        AddHandler TxtNh_ctCv2.CyberLeave, AddressOf L_Nh_CtCv2
        '--Nh_CTCV3
        RemoveHandler TxtNh_ctCv3.CyberValiting, AddressOf V_Nh_CtCv3
        RemoveHandler TxtNh_ctCv3.CyberLeave, AddressOf L_Nh_CtCv3
        AddHandler TxtNh_ctCv3.CyberValiting, AddressOf V_Nh_CtCv3
        AddHandler TxtNh_ctCv3.CyberLeave, AddressOf L_Nh_CtCv3
        '--Nh_CTCV4
        RemoveHandler TxtNh_ctCv4.CyberValiting, AddressOf V_Nh_CtCv4
        RemoveHandler TxtNh_ctCv4.CyberLeave, AddressOf L_Nh_CtCv4
        AddHandler TxtNh_ctCv4.CyberValiting, AddressOf V_Nh_CtCv4
        AddHandler TxtNh_ctCv4.CyberLeave, AddressOf L_Nh_CtCv4
        '--Nh_CTCV5
        RemoveHandler TxtNh_ctCv5.CyberValiting, AddressOf V_Nh_CtCv5
        RemoveHandler TxtNh_ctCv5.CyberLeave, AddressOf L_Nh_CtCv5
        AddHandler TxtNh_ctCv5.CyberValiting, AddressOf V_Nh_CtCv5
        AddHandler TxtNh_ctCv5.CyberLeave, AddressOf L_Nh_CtCv5

        AddHandler TxtMa_thue.CyberValiting, AddressOf V_Ma_Thue
        AddHandler TxtMa_thue.CyberLeave, AddressOf L_Ma_thue


        '--Ma_CV
        AddHandler TxtMa_CV.CyberValiting, AddressOf V_Ma_Cv
        AddHandler TxtMa_CV.CyberLeave, AddressOf L_Ma_Cv

        '--Ma_KX
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx

        '--Nh_KX1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_Kx1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_Kx1

        '--Ma_TT
        AddHandler TxtMa_TT.CyberValiting, AddressOf V_Ma_TT
        AddHandler TxtMa_TT.CyberLeave, AddressOf L_Ma_TT

        '--Tk_dt
        AddHandler TxtTk_dt.CyberValiting, AddressOf V_Tk_Dt
        AddHandler TxtTk_dt.CyberLeave, AddressOf L_Dt_DT
        '--Ma_Khoang

        AddHandler Txtma_Khoang.CyberValiting, AddressOf V_Ma_khoang
        AddHandler Txtma_Khoang.CyberLeave, AddressOf L_Ma_Khoang

        '--Ma_Hs
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS
        AddHandler TxtGia_CV.Leave, AddressOf L_Tinh_Toan
        AddHandler TxtGio_TC.Leave, AddressOf L_Tinh_Toan
        AddHandler TxtTien_CV.Leave, AddressOf L_Tinh_Toan

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Vali --- Ma_kx_Grid"
    Private Sub V_Ma_KX1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kx", "DMKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCtCVTmp.Item(iRow)("Ma_kx") = ""
            Dv_DetailCtCVTmp.Item(iRow).Item("Ten_kx") = ""

            Dv_DetailCtCVTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_KX As String = "", _Ten_KX As String = ""

        _Ma_KX = DrReturn("Ma_kx").ToString.Trim
        _Ten_KX = DrReturn("Ten_kx").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCtCVTmp.Item(iRow).Item("Ma_kx") = _Ma_KX
        Dv_DetailCtCVTmp.Item(iRow).Item("Ten_kx") = _Ten_KX

        Dv_DetailCtCVTmp.Item(iRow).EndEdit()

        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region
#Region "Valid --- Nh_kx_Grid"
    Private Sub V_Nh_KX11(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DMNhKX", "1=1", "Loai_NH='1'")
    End Sub
    Private Sub L_Nh_KX11(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCtCVTmp.Item(iRow)("Nh_kx1") = ""
            If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx1") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx1") = ""

            Dv_DetailCtCVTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_Nh As String = "", _Ten_Nh As String = ""

        _Ma_Nh = DrReturn("Ma_Nh").ToString.Trim
        _Ten_Nh = DrReturn("Ten_Nh").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCtCVTmp.Item(iRow).Item("Nh_kx1") = _Ma_Nh
        If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx1") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx1") = _Ten_Nh

        Dv_DetailCtCVTmp.Item(iRow).EndEdit()

        DetailGRVCv.UpdateCurrentRow()
    End Sub

    Private Sub V_Nh_KX12(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DMNhKX", "1=1", "Loai_NH='2'")
    End Sub
    Private Sub L_Nh_KX12(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCtCVTmp.Item(iRow)("Nh_kx2") = ""
            If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx2") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx2") = ""

            Dv_DetailCtCVTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_Nh As String = "", _Ten_Nh As String = ""

        _Ma_Nh = DrReturn("Ma_Nh").ToString.Trim
        _Ten_Nh = DrReturn("Ten_Nh").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCtCVTmp.Item(iRow).Item("Nh_kx2") = _Ma_Nh
        If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx2") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx2") = _Ten_Nh

        Dv_DetailCtCVTmp.Item(iRow).EndEdit()

        DetailGRVCv.UpdateCurrentRow()
    End Sub

    Private Sub V_Nh_KX13(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DMNhKX", "1=1", "Loai_NH='3'")
    End Sub
    Private Sub L_Nh_KX13(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCtCVTmp.Item(iRow)("Nh_kx3") = ""
            If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx3") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx3") = ""

            Dv_DetailCtCVTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_Nh As String = "", _Ten_Nh As String = ""

        _Ma_Nh = DrReturn("Ma_Nh").ToString.Trim
        _Ten_Nh = DrReturn("Ten_Nh").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCtCVTmp.Item(iRow).Item("Nh_kx3") = _Ma_Nh
        If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx3") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx3") = _Ten_Nh

        Dv_DetailCtCVTmp.Item(iRow).EndEdit()

        DetailGRVCv.UpdateCurrentRow()
    End Sub

    Private Sub V_Nh_KX14(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DMNhKX", "1=1", "Loai_NH='4'")
    End Sub
    Private Sub L_Nh_KX14(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCtCVTmp.Item(iRow)("Nh_kx4") = ""
            If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx4") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx4") = ""

            Dv_DetailCtCVTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_Nh As String = "", _Ten_Nh As String = ""

        _Ma_Nh = DrReturn("Ma_Nh").ToString.Trim
        _Ten_Nh = DrReturn("Ten_Nh").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCtCVTmp.Item(iRow).Item("Nh_kx4") = _Ma_Nh
        If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx4") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx4") = _Ten_Nh

        Dv_DetailCtCVTmp.Item(iRow).EndEdit()

        DetailGRVCv.UpdateCurrentRow()
    End Sub
    Private Sub V_Nh_KX15(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DMNhKX", "1=1", "Loai_NH='5'")
    End Sub
    Private Sub L_Nh_KX15(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCtCVTmp.Item(iRow)("Nh_kx5") = ""
            If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx5") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx5") = ""

            Dv_DetailCtCVTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_Nh As String = "", _Ten_Nh As String = ""

        _Ma_Nh = DrReturn("Ma_Nh").ToString.Trim
        _Ten_Nh = DrReturn("Ten_Nh").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCtCVTmp.Item(iRow).Item("Nh_kx5") = _Ma_Nh
        If DT_DetailCTCVTmp.Columns.Contains("Ten_Nh_Kx5") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_Nh_Kx5") = _Ten_Nh

        Dv_DetailCtCVTmp.Item(iRow).EndEdit()

        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region
#Region "Vali --- Ma_khoang"
    Private Sub V_Ma_Khoang_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_khoang", "DMKHOANG", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Khoang_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCtCVTmp.Item(iRow)("Ma_khoang") = ""
            If Dv_DetailCtCVTmp.Table.Columns.Contains("Ten_khoang") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_khoang") = ""
            Dv_DetailCtCVTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_Khoang As String = "", _Ten_Khoang As String = ""
        _Ma_Khoang = DrReturn("Ma_khoang").ToString.Trim
        _Ten_Khoang = DrReturn("Ten_khoang").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCtCVTmp.Item(iRow).Item("Ma_khoang") = _Ma_Khoang
        If Dv_DetailCtCVTmp.Table.Columns.Contains("Ten_khoang") Then Dv_DetailCtCVTmp.Item(iRow).Item("Ten_khoang") = _Ten_Khoang
        Dv_DetailCtCVTmp.Item(iRow).EndEdit()
        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region
#Region "Tinh toan"
    Private Sub V_Tinh_ToanCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DT_DetailCTCVTmp.AcceptChanges()
        Tinh_TienCV(iRow)
    End Sub
    Private Sub Tinh_TienCV(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        '-----------------------------------------------------------
        If Dv_DetailCtCVTmp.Table.Columns.Contains("Gia_CV") And Dv_DetailCtCVTmp.Table.Columns.Contains("Gio_TC") And Dv_DetailCtCVTmp.Table.Columns.Contains("Tien_CV") Then
            If Dv_DetailCtCVTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCtCVTmp.Item(iRow).Item("Gio_TC") <> 0 Then
                Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
                Dv_DetailCtCVTmp.Item(iRow).Item("Tien_CV") = CyberSupport.V_Round(Dv_DetailCtCVTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCtCVTmp.Item(iRow).Item("Gio_TC"), 0)
                Dv_DetailCtCVTmp.Item(iRow).EndEdit()
            End If
        End If
        '-----------------------------------------------------------
        Dv_DetailCtCVTmp.Item(iRow).BeginEdit()
        If Dv_DetailCtCVTmp.Table.Columns.Contains("Pt1") And Dv_DetailCtCVTmp.Table.Columns.Contains("Tien_CV") Then
            Dim _Tien_PT1 As Decimal = CyberSupport.V_Round(Dv_DetailCtCVTmp.Item(iRow).Item("Pt1") * Dv_DetailCtCVTmp.Item(iRow).Item("Tien_CV") / 100, 0)
            If _Tien_PT1 <> 0 Then Dv_DetailCtCVTmp.Item(iRow).Item("Tien_PT1") = _Tien_PT1
        End If
        If Dv_DetailCtCVTmp.Table.Columns.Contains("Pt2") And Dv_DetailCtCVTmp.Table.Columns.Contains("Tien_CV") Then
            Dim _Tien_PT2 As Decimal = CyberSupport.V_Round(Dv_DetailCtCVTmp.Item(iRow).Item("Pt2") * Dv_DetailCtCVTmp.Item(iRow).Item("Tien_CV") / 100, 0)
            If _Tien_PT2 <> 0 Then Dv_DetailCtCVTmp.Item(iRow).Item("Tien_PT2") = _Tien_PT2
        End If
        Dv_DetailCtCVTmp.Item(iRow).EndEdit()
        '-----------------------------------------------------------
        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region
#Region "GRV----"
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        vTbAdd = Dv_DetailCtCVTmp
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing

        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), Dv_HeadCV)
        CarrOn(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailCtCVTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)

    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailCtCVTmp, Appconn) Then Exit Sub
        Dv_DetailCtCVTmp.Delete(iRow)
        Dv_DetailCtCVTmp.Table.AcceptChanges()

    End Sub
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region
#Region "Valid"
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtGia_CV.Double * TxtGio_TC.Double <> 0 Then TxtTien_CV.Double = CyberSupport.V_Round(TxtGia_CV.Double * TxtGio_TC.Double, 0)
    End Sub
    Private Sub V_Ma_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_thue", "DMthue", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If TxtMa_thue.Text = "" Then
            txtThue_suat.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_thue.Text = DrReturn.Item("Ma_thue")
            txtThue_suat.Text = DrReturn.Item("Thue_suat")
        Else
            TxtMa_thue.Text = ""
            txtThue_suat.Text = ""
        End If
    End Sub
#Region "Vali --- Ma_Cv"
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Cv", "DMCv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_CV.Text = "" Then
            TxtTen_CV.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CV.Text = DrReturn.Item("Ma_Cv")
            TxtTen_CV.Text = DrReturn.Item("Ten_Cv")
        Else
            TxtMa_CV.Text = ""
            TxtTen_CV.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kx", "DMKx", "1=1", "1=1")
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
#Region "Vali --- Nh_Kx1"
    Private Sub V_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If TxtNh_Kx1.Text = "" Then
            TxtTen_Nh_Kx1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            TxtTen_Nh_Kx1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TT"
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TT", "DMTT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TT.Text = "" Then
            TxtTen_TT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TT.Text = DrReturn.Item("Ma_TT")
            TxtTen_TT.Text = DrReturn.Item("Ten_TT")
        Else
            TxtMa_TT.Text = ""
            TxtTen_TT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_DT"
    Private Sub V_Tk_Dt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Dt_DT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_dt.Text = "" Then
            TxtTen_Tk_DT.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_dt.Text = DrReturn.Item("tk0")
            TxtTen_Tk_DT.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTk_dt.Text = ""
            TxtTen_Tk_DT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Khoang"
    Private Sub V_Ma_khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_khoang", "Dmkhoang", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TxtTk_dt.Text = "" Then
        '    TxtTen_Tk0.Text = ""
        '    Exit Sub
        'End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_Khoang.Text = DrReturn.Item("ma_khoang")
            Txtten_Khoang.Text = DrReturn.Item("Ten_khoang")
        Else
            TxtTk_dt.Text = ""
            TxtTen_Tk_DT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "DMHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_HS.Text = "" Then
            TxtTen_HS.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_HS")
            TxtTen_HS.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HS.Text = ""
            TxtTen_HS.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Vali --- Nh_CtCv1"
    Private Sub V_Nh_CtCv1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_ctCv1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCtCv", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_CtCv1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_ctCv1.GetRowsSelectData(True)
        If TxtNh_ctCv1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_ctCv1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ctCv1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CtCv2"
    Private Sub V_Nh_CtCv2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_ctCv2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCtCv", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_CtCv2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_ctCv2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ctCv2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ctCv2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ctCv2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CtCv3"
    Private Sub V_Nh_CtCv3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_ctCv3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCtCv", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_CtCv3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not DrReturn Is Nothing Then TxtNh_ctCv3.Text = DrReturn.Item("Ma_Nh")
        If TxtNh_ctCv3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ctCv3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ctCv3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ctCv3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CtCv4"
    Private Sub V_Nh_CtCv4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_ctCv4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCtCv", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_CtCv4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_ctCv4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ctCv4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ctCv4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ctCv4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CtCv5"
    Private Sub V_Nh_CtCv5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_ctCv5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCtCv", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_CtCv5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_ctCv5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ctCv5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ctCv5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ctCv5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_ctcv.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub


        Dim nCount As Integer = 0
        nCount = Dv_DetailCtCVTmp.Count - 1
        For i = nCount To 0 Step -1
            If Dv_DetailCtCVTmp.Item(i).Item("Ma_Kx").ToString.Trim = "" And Dv_DetailCtCVTmp.Item(i).Item("Nh_Kx1").ToString.Trim = "" And Dv_DetailCtCVTmp.Item(i).Item("Nh_Kx2").ToString.Trim = "" And Dv_DetailCtCVTmp.Item(i).Item("Nh_Kx3").ToString.Trim = "" And Dv_DetailCtCVTmp.Item(i).Item("Nh_Kx4").ToString.Trim = "" And Dv_DetailCtCVTmp.Item(i).Item("Nh_Kx5").ToString.Trim = "" Then
                Dv_DetailCtCVTmp.Item(i).Delete()
            End If

        Next
        DT_DetailCTCVTmp.AcceptChanges()

        For i = 0 To Dv_DetailCtCVTmp.Count - 1
            Dv_DetailCtCVTmp.Item(i).BeginEdit()

            Dv_DetailCtCVTmp.Item(i).Item("Ma_CtCv") = TxtMa_ctcv.Text.Trim
            If DT_DetailCTCVTmp.Columns.Contains("Ma_Dvcs") Then Dv_DetailCtCVTmp.Item(i).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim

            Dv_DetailCtCVTmp.Item(i).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(i + 1)
            Dv_DetailCtCVTmp.Item(i).EndEdit()
        Next
        DT_DetailCTCVTmp.AcceptChanges()
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, DT_DetailCTCVTmp, "DMCTCVKX", Mode, "Ma_ctCv = N'" + Ma_CtCvOld.Trim + "'")

        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
