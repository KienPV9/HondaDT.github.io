Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmUserName
    Dim Dt_DnCapTK_Sort, Dt_DnCapTK, Dt_DnCapTK_H, DtDvcs As DataTable
    Dim Dv_DnCapTK_Sort, Dv_DnCapTK, Dv_DnCapTK_H As DataView
    Dim Dt_DnCapMK_Sort, Dt_DnCapMK, Dt_DnCapMK_H As DataTable
    Dim Dv_DnCapMK_Sort, Dv_DnCapMK, Dv_DnCapMK_H As DataView
    Dim Dt_DnDongTK_Sort, Dt_DnDongTK, Dt_DnDongTK_H As DataTable
    Dim Dv_DnDongTK_Sort, Dv_DnDongTK, Dv_DnDongTK_H As DataView
    Dim CyberColor As New Cyber.Color.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub FrmUserName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_LoaddatabasesAll("1", "")
        V_AddHandler()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtNgay_Ct1.Value = Now.Date()
        TxtNgay_ct2.Value = Now.Date()
        '--------------------------------------------------------------------
        Dim DsUnits As New DataSet
        DsUnits = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysListUnits", M_Ma_Dvcs.Trim + "#" + M_User_Name)
        DtDvcs = DsUnits.Tables(0).Copy
        DsUnits.Dispose()
        '-----------------------------------------------------------------------
        Me.CyberFill.V_FillComBoxValue(Me.CbbMa_Dvcs, DtDvcs, "Ma_Dvcs", "Ten_Dvcs", M_Ma_Dvcs)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_LoaddatabasesAll(ByVal status As String, ByVal _Stt_rec As String)
        V_Loaddatabases_DNCapTK(status, _Stt_rec)
        V_Loaddatabases_DNCapMK(status, _Stt_rec)
        V_Loaddatabases_DNDongTK(status, _Stt_rec)
    End Sub
#Region "Cấp tài khoản"
    Private Sub V_Loaddatabases_DNCapTK(ByVal status As String, ByVal _Stt_rec As String)
        Dim strField As String = ""
        Dim strValue As String = ""
        Dim _strLoaitru As String = ""
        CyberSmodb.GetValueControler(Me, strField, strValue, _strLoaitru)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapTK", status + "#" + _Stt_rec + "#" + strField + "#" + strValue + "#" + CbbMa_Dvcs.SelectedValue.ToString.Trim + "#" + M_User_Name)

        If status = "1" Then
            Dt_DnCapTK_Sort = Dstmp.Tables(0).Copy
            Dt_DnCapTK = Dstmp.Tables(1).Copy
            Dt_DnCapTK_H = Dstmp.Tables(2).Copy

            Dv_DnCapTK = New DataView(Dt_DnCapTK)
            Dv_DnCapTK_H = New DataView(Dt_DnCapTK_H)

            CyberSupport.V_SetSortView(Dv_DnCapTK, Dt_DnCapTK_Sort)

            CyberFill.V_FillReports(Master_DNCapTKGRV, M_LAN, Dv_DnCapTK_H, Dv_DnCapTK)
            Master_DNCapTK.DataSource = Dv_DnCapTK

            Dim _ColFrozen As Integer = -1
            If Dt_DnCapTK_Sort.Columns.Contains("ColFrozen") Then If Dt_DnCapTK_Sort.Rows.Count > 0 Then _ColFrozen = Dt_DnCapTK_Sort.Rows(0).Item("ColFrozen")
            V_FixColumn_Master_DNCapTKGRV(_ColFrozen)
        Else
            If _Stt_rec.Trim = "" Then
                Dt_DnCapTK.Clear()
            Else
                Dim nCount As Integer = Dt_DnCapTK.Rows.Count - 1
                For i As Integer = nCount To 0 Step -1
                    If Not Dt_DnCapTK.Rows(i).Item("Stt_Rec").ToString.Trim.ToUpper = _Stt_rec.ToUpper.Trim Then Continue For
                    Dt_DnCapTK.Rows(i).Delete()
                Next
            End If
            Dt_DnCapTK.Load(Dstmp.Tables(0).CreateDataReader)
            Dt_DnCapTK.AcceptChanges()
        End If
        Dstmp.Dispose()
    End Sub
    Private Sub V_FixColumn_Master_DNCapTKGRV(ByVal _ColFrozen As Integer)
        If _ColFrozen < 0 Then Return
        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_DNCapTKGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_DNCapTKGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region
#Region "Cấp mật khẩu"
    Private Sub V_Loaddatabases_DNCapMK(ByVal status As String, ByVal _Stt_rec As String)
        Dim strField As String = ""
        Dim strValue As String = ""
        Dim _strLoaitru As String = ""
        CyberSmodb.GetValueControler(Me, strField, strValue, _strLoaitru)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapMK", status + "#" + _Stt_rec + "#" + strField + "#" + strValue + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        If status = "1" Then
            Dt_DnCapMK_Sort = Dstmp.Tables(0).Copy
            Dt_DnCapMK = Dstmp.Tables(1).Copy
            Dt_DnCapMK_H = Dstmp.Tables(2).Copy

            Dv_DnCapMK = New DataView(Dt_DnCapMK)
            Dv_DnCapMK_H = New DataView(Dt_DnCapMK_H)

            CyberSupport.V_SetSortView(Dv_DnCapMK, Dt_DnCapMK_Sort)

            CyberFill.V_FillReports(Master_DNCapMKGRV, M_LAN, Dv_DnCapMK_H, Dv_DnCapMK)
            Master_DNCapMK.DataSource = Dv_DnCapMK

            Dim _ColFrozen As Integer = -1
            If Dt_DnCapMK_Sort.Columns.Contains("ColFrozen") Then If Dt_DnCapMK_Sort.Rows.Count > 0 Then _ColFrozen = Dt_DnCapMK_Sort.Rows(0).Item("ColFrozen")
            V_FixColumn_Master_DNCapMKGRV(_ColFrozen)
        Else
            If _Stt_rec.Trim = "" Then
                Dt_DnCapMK.Clear()
            Else
                Dim nCount As Integer = Dt_DnCapMK.Rows.Count - 1
                For i As Integer = nCount To 0 Step -1
                    If Not Dt_DnCapMK.Rows(i).Item("Stt_Rec").ToString.Trim.ToUpper = _Stt_rec.ToUpper.Trim Then Continue For
                    Dt_DnCapMK.Rows(i).Delete()
                Next
            End If
            Dt_DnCapMK.Load(Dstmp.Tables(0).CreateDataReader)
            Dt_DnCapMK.AcceptChanges()
        End If
        Dstmp.Dispose()
    End Sub
    Private Sub V_FixColumn_Master_DNCapMKGRV(ByVal _ColFrozen As Integer)
        If _ColFrozen < 0 Then Return
        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_DNCapMKGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_DNCapMKGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region
#Region "Đóng tài khoản"
    Private Sub V_Loaddatabases_DNDongTK(ByVal status As String, ByVal _Stt_rec As String)
        Dim strField As String = ""
        Dim strValue As String = ""
        Dim _strLoaitru As String = ""
        CyberSmodb.GetValueControler(Me, strField, strValue, _strLoaitru)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNDongTK", status + "#" + _Stt_rec + "#" + strField + "#" + strValue + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        If status = "1" Then
            Dt_DnDongTK_Sort = Dstmp.Tables(0).Copy
            Dt_DnDongTK = Dstmp.Tables(1).Copy
            Dt_DnDongTK_H = Dstmp.Tables(2).Copy

            Dv_DnDongTK = New DataView(Dt_DnDongTK)
            Dv_DnDongTK_H = New DataView(Dt_DnDongTK_H)

            CyberSupport.V_SetSortView(Dv_DnDongTK, Dt_DnDongTK_Sort)

            CyberFill.V_FillReports(Master_DNDongTKGRV, M_LAN, Dv_DnDongTK_H, Dv_DnDongTK)
            Master_DNDongTK.DataSource = Dv_DnDongTK

            Dim _ColFrozen As Integer = -1
            If Dt_DnDongTK_Sort.Columns.Contains("ColFrozen") Then If Dt_DnDongTK_Sort.Rows.Count > 0 Then _ColFrozen = Dt_DnDongTK_Sort.Rows(0).Item("ColFrozen")
            V_FixColumn_Master_DNDongTKGRV(_ColFrozen)
        Else
            If _Stt_rec.Trim = "" Then
                Dt_DnDongTK.Clear()
            Else
                Dim nCount As Integer = Dt_DnDongTK.Rows.Count - 1
                For i As Integer = nCount To 0 Step -1
                    If Not Dt_DnDongTK.Rows(i).Item("Stt_Rec").ToString.Trim.ToUpper = _Stt_rec.ToUpper.Trim Then Continue For
                    Dt_DnDongTK.Rows(i).Delete()
                    Dt_DnDongTK.AcceptChanges()
                Next
            End If
            Dt_DnDongTK.Load(Dstmp.Tables(0).CreateDataReader)
        End If
        Dstmp.Dispose()
    End Sub
    Private Sub V_FixColumn_Master_DNDongTKGRV(ByVal _ColFrozen As Integer)
        If _ColFrozen < 0 Then Return
        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_DNDongTKGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_DNDongTKGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region
    Private Sub V_AddHandler()
        AddHandler TabUserName.DrawItem, AddressOf V_DrawItem
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler Master_DNCapTKGRV.PopupMenuShowing, AddressOf Master_DNCapTKGRV_PopupMenuShowing
        AddHandler Master_DNCapTKGRV.RowCellStyle, AddressOf Master_DNCapTKGRV_RowCellStyle
        AddHandler Master_DNCapMKGRV.PopupMenuShowing, AddressOf Master_DNCapMKGRV_PopupMenuShowing
        AddHandler Master_DNCapMKGRV.RowCellStyle, AddressOf Master_DNCapMKGRV_RowCellStyle
        AddHandler Master_DNDongTKGRV.PopupMenuShowing, AddressOf Master_DNDongTKGRV_PopupMenuShowing
        AddHandler Master_DNDongTKGRV.RowCellStyle, AddressOf Master_DNDongTKGRV_RowCellStyle
        AddHandler CmdSearch.Click, AddressOf V_Refresh_DnCapTK

        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
    End Sub
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim _filter As String = "1=1"
        If CbbMa_Dvcs.SelectedValue.ToString.Trim <> "" Then
            _filter = "Ma_Dvcs='" + CbbMa_Dvcs.SelectedValue.ToString.Trim + "'"
        End If
        TxtMa_Hs.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", _filter, "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "tao Moi tai khoan"
    Private Sub Master_DNCapTKGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle

        PopupMenu.ItemLinks.Clear()
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Tạo mới", "Create appointment schedule"), AddressOf V_Tao_DNCapTK, System.Windows.Forms.Shortcut.F4, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Sửa", "Create appointment schedule"), AddressOf V_Sua_DNCapTK, System.Windows.Forms.Shortcut.F3, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Xóa", "Create appointment schedule"), AddressOf V_Xoa_DNCapTK, System.Windows.Forms.Shortcut.F8, My.Resources.cancel_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Duyệt", "Create appointment schedule"), AddressOf V_Duyet_CapTK, System.Windows.Forms.Shortcut.F9, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Hủy duyệt", "Create appointment schedule"), AddressOf V_Huy_CapTK, System.Windows.Forms.Shortcut.F10, My.Resources.Xoa_BT_16x16, True, True), True).BeginGroup = False
        '
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Gửi email", "Create appointment schedule"), AddressOf V_Email_CapTK, System.Windows.Forms.Shortcut.F11, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        'PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_DnCapTK, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_DnCapTK, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub Master_DNCapTKGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_DNCapTKGRV, Dt_DnCapTK, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub V_Duyet_CapTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnCapTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapTK_UpdateMaPost", _Stt_Rec + "#9#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Return
        End If
        V_Loaddatabases_DNCapTK("0", _Stt_Rec)
    End Sub
    Private Sub V_Email_CapTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnCapTK.Item(iRow).Item("Stt_Rec").ToString.Trim

        CyberSupport.V_SendEmailVoucher(AppConn, Sysvar, Para, M_LAN, "1", "USR", _Stt_Rec, M_Ma_Dvcs, M_User_Name, True, False, False, True)

        V_Loaddatabases_DNCapTK("0", _Stt_Rec)
    End Sub
    Private Sub V_Huy_CapTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnCapTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapTK_UpdateMaPost", _Stt_Rec + "#0#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Return
        End If
        V_Loaddatabases_DNCapTK("0", _Stt_Rec)
    End Sub
    Private Sub V_Tao_DNCapTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapTKGRV.GetFocusedDataSourceRowIndex
        Dim _Stt_Rec As String = ""
        'If iRow >= 0 Then
        '    _Stt_Rec = Dv_DnCapTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        'End If
        V_DnCapTK(_Stt_Rec, "M")
    End Sub
    Private Sub V_Sua_DNCapTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnCapTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        V_DnCapTK(_Stt_Rec, "S")
    End Sub
    Private Sub V_DnCapTK(ByVal _Stt_Rec As String, ByVal _Mode As String)
        Dim Frm As New FrmUserName_DnCapTK
        '-----------------------------------------------------------
        Frm.Stt_Rec = _Stt_Rec
        Frm.Mode = _Mode
        '------------------------
        Frm.Lan = M_LAN
        Frm.Para = Me.Para
        Frm.Sysvar = Me.Sysvar
        Frm.AppConn = AppConn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()

        If Not Frm.Save_OK Then Return
        Dim _Rec As String = Frm.Tag.ToString

        V_Loaddatabases_DNCapTK("0", _Rec)

        CyberSmlib.FlushMemorySave()

    End Sub
    Private Sub V_Xoa_DNCapTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        If MsgBox("Bạn có muốn xóa đề nghị này không?", vbYesNo, M_CYBER_VER) = MsgBoxResult.No Then
            Return
        End If

        Dim _Stt_Rec As String = Dv_DnCapTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapTK_Delete", _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Return
        End If
        V_Loaddatabases_DNCapTK("0", _Stt_Rec)
    End Sub
    Private Sub V_ExportExcel_DnCapTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add("Đề Nghị cấp tài khoản", "Đề Nghị cấp tài khoản")
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_DNCapTKGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub V_Refresh_DnCapTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddatabases_DNCapTK("1", "")
        V_Loaddatabases_DNCapMK("1", "")
        V_Loaddatabases_DNDongTK("1", "")
    End Sub
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
#End Region
#Region "Cấp mật khẩu"
    Private Sub Master_DNCapMKGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle

        PopupMenu.ItemLinks.Clear()
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Tạo mới", "Create appointment schedule"), AddressOf V_Tao_DNCapMK, System.Windows.Forms.Shortcut.F4, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Sửa", "Create appointment schedule"), AddressOf V_Sua_DNCapMK, System.Windows.Forms.Shortcut.F3, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Xóa", "Create appointment schedule"), AddressOf V_Xoa_DNCapMK, System.Windows.Forms.Shortcut.F8, My.Resources.cancel_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Duyệt", "Create appointment schedule"), AddressOf V_Duyet_CapMK, System.Windows.Forms.Shortcut.F9, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Hủy duyệt", "Create appointment schedule"), AddressOf V_Huy_CapMK, System.Windows.Forms.Shortcut.F10, My.Resources.Xoa_BT_16x16, True, True), True).BeginGroup = False
        '
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Gửi email", "Create appointment schedule"), AddressOf V_Email_CapMK, System.Windows.Forms.Shortcut.F11, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        'PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_DnCapTK, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_DnCapMK, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub Master_DNCapMKGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_DNCapMKGRV, Dt_DnCapMK, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub V_Duyet_CapMK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapMKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnCapMK.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapMK_UpdateMaPost", _Stt_Rec + "#9#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Return
        End If
        V_Loaddatabases_DNCapMK("0", _Stt_Rec)
    End Sub
    Private Sub V_Email_CapMK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapMKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnCapMK.Item(iRow).Item("Stt_Rec").ToString.Trim

        CyberSupport.V_SendEmailVoucher(AppConn, Sysvar, Para, M_LAN, "1", "USP", _Stt_Rec, M_Ma_Dvcs, M_User_Name, True, False, False, True)

        V_Loaddatabases_DNCapMK("0", _Stt_Rec)
    End Sub
    Private Sub V_Huy_CapMK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapMKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnCapMK.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapMK_UpdateMaPost", _Stt_Rec + "#0#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Return
        End If
        V_Loaddatabases_DNCapMK("0", _Stt_Rec)
    End Sub
    Private Sub V_Xoa_DNCapMK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapMKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        If MsgBox("Bạn có muốn xóa đề nghị này không?", vbYesNo, M_CYBER_VER) = MsgBoxResult.No Then
            Return
        End If

        Dim _Stt_Rec As String = Dv_DnCapMK.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapMK_Delete", _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Return
        End If
        V_Loaddatabases_DNCapMK("0", _Stt_Rec)
    End Sub
    Private Sub V_Tao_DNCapMK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapMKGRV.GetFocusedDataSourceRowIndex
        Dim _Stt_Rec As String = ""
        'If iRow >= 0 Then
        '    _Stt_Rec = Dv_DnCapTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        'End If
        V_DnCapMK(_Stt_Rec, "M")
    End Sub
    Private Sub V_Sua_DNCapMK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNCapMKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnCapMK.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        V_DnCapMK(_Stt_Rec, "S")
    End Sub
    Private Sub V_DnCapMK(ByVal _Stt_Rec As String, ByVal _Mode As String)
        Dim Frm As New FrmUserName_DnCapMK
        '-----------------------------------------------------------
        Frm.Stt_Rec = _Stt_Rec
        Frm.Mode = _Mode
        '------------------------
        Frm.Lan = M_LAN
        Frm.Para = Me.Para
        Frm.Sysvar = Me.Sysvar
        Frm.AppConn = AppConn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()

        If Not Frm.Save_OK Then Return
        Dim _Rec As String = Frm.Tag.ToString

        V_Loaddatabases_DNCapMK("0", _Rec)

        CyberSmlib.FlushMemorySave()

    End Sub
    Private Sub V_Refresh_DnCapMK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddatabases_DNCapMK("1", "")
    End Sub
#End Region
#Region "Đóng tài khoản"
    Private Sub Master_DNDongTKGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle

        PopupMenu.ItemLinks.Clear()
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Tạo mới", "Create appointment schedule"), AddressOf V_Tao_DNDongTK, System.Windows.Forms.Shortcut.F4, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Sửa", "Create appointment schedule"), AddressOf V_Sua_DNDongTK, System.Windows.Forms.Shortcut.F3, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Xóa", "Create appointment schedule"), AddressOf V_Xoa_DNDongTK, System.Windows.Forms.Shortcut.F8, My.Resources.cancel_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Duyệt", "Create appointment schedule"), AddressOf V_Duyet_DongTK, System.Windows.Forms.Shortcut.F9, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Hủy duyệt", "Create appointment schedule"), AddressOf V_Huy_DongTK, System.Windows.Forms.Shortcut.F10, My.Resources.Xoa_BT_16x16, True, True), True).BeginGroup = False
        '
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Gửi email", "Create appointment schedule"), AddressOf V_Email_DongTK, System.Windows.Forms.Shortcut.F11, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        'PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_DnCapTK, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_DnDongTK, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub Master_DNDongTKGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_DNDongTKGRV, Dt_DnDongTK, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub V_Duyet_DongTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNDongTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnDongTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNDongTK_UpdateMaPost", _Stt_Rec + "#9#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Return
        End If
        V_Loaddatabases_DNDongTK("0", _Stt_Rec)
    End Sub
    Private Sub V_Email_DongTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNDongTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnDongTK.Item(iRow).Item("Stt_Rec").ToString.Trim

        CyberSupport.V_SendEmailVoucher(AppConn, Sysvar, Para, M_LAN, "1", "USD", _Stt_Rec, M_Ma_Dvcs, M_User_Name, True, False, False, True)

        V_Loaddatabases_DNDongTK("0", _Stt_Rec)
    End Sub
    Private Sub V_Huy_DongTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNDongTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnDongTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNDongTK_UpdateMaPost", _Stt_Rec + "#0#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Return
        End If
        V_Loaddatabases_DNDongTK("0", _Stt_Rec)
    End Sub
    Private Sub V_Xoa_DNDongTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNDongTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        If MsgBox("Bạn có muốn xóa đề nghị này không?", vbYesNo, M_CYBER_VER) = MsgBoxResult.No Then
            Return
        End If

        Dim _Stt_Rec As String = Dv_DnDongTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNDongTK_Delete", _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Return
        End If
        V_Loaddatabases_DNDongTK("0", _Stt_Rec)
    End Sub
    Private Sub V_Tao_DNDongTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNDongTKGRV.GetFocusedDataSourceRowIndex
        Dim _Stt_Rec As String = ""
        'If iRow >= 0 Then
        '    _Stt_Rec = Dv_DnCapTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        'End If
        V_DnDongTK(_Stt_Rec, "M")
    End Sub
    Private Sub V_Sua_DNDongTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_DNDongTKGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_DnDongTK.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        V_DnDongTK(_Stt_Rec, "S")
    End Sub
    Private Sub V_DnDongTK(ByVal _Stt_Rec As String, ByVal _Mode As String)
        Dim Frm As New FrmUserName_DnDongTK
        '-----------------------------------------------------------
        Frm.Stt_Rec = _Stt_Rec
        Frm.Mode = _Mode
        '------------------------
        Frm.Lan = M_LAN
        Frm.Para = Me.Para
        Frm.Sysvar = Me.Sysvar
        Frm.AppConn = AppConn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()

        If Not Frm.Save_OK Then Return
        Dim _Rec As String = Frm.Tag.ToString

        V_Loaddatabases_DNDongTK("0", _Rec)

        CyberSmlib.FlushMemorySave()

    End Sub
    Private Sub V_Refresh_DnDongTK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddatabases_DNDongTK("1", "")
    End Sub
#End Region
#Region "Boi mau Grd +Tag"
    Private Sub V_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        Dim SelectedTab As TabPage = sender.TabPages(e.Index)
        Dim HeaderRect As Rectangle = sender.GetTabRect(e.Index)
        Dim TextBrush As New SolidBrush(System.Drawing.Color.Black)
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        If Convert.ToBoolean(e.State And DrawItemState.Selected) Then
            Dim BoldFont As New Font(TabUserName.Font.Name, sender.Font.Size, FontStyle.Bold)
            e.Graphics.FillRectangle(New SolidBrush(System.Drawing.Color.OrangeRed), e.Bounds)
            TextBrush = New SolidBrush(System.Drawing.Color.White)
            e.Graphics.DrawString(SelectedTab.Text, BoldFont, TextBrush, HeaderRect, sf)

        Else
            e.Graphics.DrawString(SelectedTab.Text, e.Font, TextBrush, HeaderRect, sf)
        End If
        TextBrush.Dispose()
    End Sub
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
