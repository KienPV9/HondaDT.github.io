Imports System.Drawing
Imports System.Windows.Forms
Public Class CDKHTN
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang, DtNam As DataTable
    Dim Dt_head, Dt_Master, Dt_Dmct As DataTable
    Dim Dv_head, Dv_Master, Dv_Dmct As DataView
    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys
    Dim DtTmp As DataTable
    Private Sub FABTPBTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_LoadDatabase("1")
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        CyberFill.V_FillVoucher(MasterGRV, Me.Lan, Dv_head, Dv_Master, DrDmct)
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen

        V_AddHandler()
        Me.Text = Me.Para(11).Trim
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHandler()
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        RemoveHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        'RemoveHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        'AddHandler ButtOK.Click, AddressOf V_Nhan

        RemoveHandler CmdSelectAll.Click, AddressOf V_SelectAll
        RemoveHandler CmdRemoveAll.Click, AddressOf V_RemoveAll

        ''-Ma_hs_c
        RemoveHandler Txtma_hs_c.CyberValiting, AddressOf V_Ma_hs_c
        RemoveHandler Txtma_hs_c.CyberLeave, AddressOf L_Ma_hs_c
        AddHandler Txtma_hs_c.CyberValiting, AddressOf V_Ma_hs_c
        AddHandler Txtma_hs_c.CyberLeave, AddressOf L_Ma_hs_c
        ''-Ma_tp
        RemoveHandler TxtMa_tp.CyberValiting, AddressOf V_Ma_tp
        RemoveHandler TxtMa_tp.CyberLeave, AddressOf L_Ma_tp
        AddHandler TxtMa_tp.CyberValiting, AddressOf V_Ma_tp
        AddHandler TxtMa_tp.CyberLeave, AddressOf L_Ma_tp
        ''-Ma_quan
        RemoveHandler TxtMa_quan.CyberValiting, AddressOf V_Ma_quan
        RemoveHandler TxtMa_quan.CyberLeave, AddressOf L_Ma_quan
        AddHandler TxtMa_quan.CyberValiting, AddressOf V_Ma_quan
        AddHandler TxtMa_quan.CyberLeave, AddressOf L_Ma_quan
        ''-Ma_xa
        RemoveHandler TxtMa_xa.CyberValiting, AddressOf V_Ma_xa
        RemoveHandler TxtMa_xa.CyberLeave, AddressOf L_Ma_xa
        AddHandler TxtMa_xa.CyberValiting, AddressOf V_Ma_xa
        AddHandler TxtMa_xa.CyberLeave, AddressOf L_Ma_xa
        ''-Ma_hs_n
        RemoveHandler TxtMa_hs_n.CyberValiting, AddressOf V_Ma_hs_n
        RemoveHandler TxtMa_hs_n.CyberLeave, AddressOf L_Ma_hs_n
        AddHandler TxtMa_hs_n.CyberValiting, AddressOf V_Ma_hs_n
        AddHandler TxtMa_hs_n.CyberLeave, AddressOf L_Ma_hs_n

        AddHandler CmdSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmdRemoveAll.Click, AddressOf V_RemoveAll
     
    End Sub

    Private Sub V_Load()
    End Sub
#Region "Vali --- Ma_hs_c"
    Private Sub V_Ma_hs_c(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_hs_c.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "USER_NAME", "USERINFO", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_hs_c(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_hs_c.Text = "" Then
            TxtTen_hs_c.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_hs_c.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            Txtma_hs_c.Text = DrReturn.Item("USER_NAME")
            TxtTen_hs_c.Text = DrReturn.Item("COMMENT")
        Else
            TxtMa_hs_c.Text = ""
            TxtTen_hs_c.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_tp"
    Private Sub V_Ma_tp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_tp.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_tp", "dmtp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_tp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Txtma_tp.Text = "" Then
            TxtTen_tp.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_tp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_tp.Text = DrReturn.Item("ma_tp")
            TxtTen_tp.Text = DrReturn.Item("Ten_tp")
        Else
            Txtma_tp.Text = ""
            TxtTen_tp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_quan"
    Private Sub V_Ma_quan(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_quan.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_quan", "Dmquan", "ma_tp = N'" & TxtMa_tp.Text.Trim & "'", "1=1")
    End Sub
    Private Sub L_Ma_quan(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_quan.Text = "" Then
            TxtTen_quan.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_quan.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_quan.Text = DrReturn.Item("ma_quan")
            TxtTen_quan.Text = DrReturn.Item("Ten_quan")
        Else
            TxtMa_quan.Text = ""
            TxtTen_quan.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_xa"
    Private Sub V_Ma_xa(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_xa.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_xa", "Dmxa", "ma_quan = N'" & TxtMa_quan.Text.Trim() & "'", "1=1")
    End Sub
    Private Sub L_Ma_xa(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_xa.Text = "" Then
            TxtTen_xa.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_xa.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_xa.Text = DrReturn.Item("ma_xa")
            TxtTen_xa.Text = DrReturn.Item("Ten_xa")
        Else
            TxtMa_xa.Text = ""
            TxtTen_xa.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_hs_N"
    Private Sub V_Ma_hs_n(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_hs_n.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "USER_NAME", "USERINFO", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_hs_n(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_hs_n.Text = "" Then
            TxtTen_hs_n.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_hs_n.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_hs_n.Text = DrReturn.Item("USER_NAME")
            TxtTen_hs_n.Text = DrReturn.Item("COMMENT")
        Else
            TxtMa_hs_n.Text = ""
            TxtTen_hs_n.Text = ""
        End If
    End Sub
#End Region
    Private Sub V_LoadDatabase(ByVal Status)
        Dim DsTmp As DataSet

        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOADCDKHTN", Status & "#" & Txtma_hs_c.Text.Trim & "#" & TxtMa_tp.Text.Trim & "#" & TxtMa_quan.Text.Trim & "#" & TxtMa_xa.Text.Trim & "#" & TxtLoai_kh.Text.Trim & "#" & txtDT1.Text.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        CyberSmodb.SetNotNullTable(DsTmp.Tables(0))
        If Status = "1" Then

            Dt_Master = DsTmp.Tables(0).Copy
            'Dt_Dmct = DsTmp.Tables(1).Copy
            Dt_head = DsTmp.Tables(1).Copy

            Dv_Master = New DataView(Dt_Master)
            'Dv_Dmct = New DataView(Dt_Dmct)
            Dv_head = New DataView(Dt_head)
            'DrDmct = Dt_Dmct.Rows(0)
        Else
            Dim nCount As Integer = Dt_Master.Rows.Count - 1
            For i As Integer = nCount To 0 Step -1
                Dt_Master.Rows(i).Delete()

            Next
            Dt_Master.AcceptChanges()
            For i = 0 To DsTmp.Tables(0).Rows.Count - 1
                Dt_Master.ImportRow(DsTmp.Tables(0).Rows(i))
            Next
            Dt_Master.AcceptChanges()
        End If
    End Sub
   
    Private Sub V_Loaddata()
        Dim Ds As DataSet
        Ds = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOADCDKHTN", "0" & "#" & Txtma_hs_c.Text.Trim & "#" & TxtMa_tp.Text.Trim & "#" & TxtMa_quan.Text.Trim & "#" & TxtMa_xa.Text.Trim & "#" & TxtLoai_kh.Text.Trim & "#" & txtDT1.Text.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)


      
        CyberSmodb.SetNotNullTable(Ds.Tables(0))

        For i As Integer = 0 To Ds.Tables(0).Rows.Count - 1
            If Ds.Tables(0).Rows.Count <= 0 Then
                Ds.Dispose()
                Exit Sub
            End If
        Next
        'End If
        For i As Integer = 0 To Ds.Tables(0).Rows.Count - 1
            Ds.Tables(0).Rows(i).EndEdit()
            Ds.Tables(0).Rows(i).EndEdit()
        Next

        Ds.Tables(0).AcceptChanges()
        Dim dt As DataTable = Ds.Tables(0)
        Dt_Master.Clear()
        CyberSmodb.SQLTbToTb(dt, Dt_Master)
        Ds.Dispose()
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Return
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chuyển đổi", "Create"), AddressOf V_Nhan, Shortcut.F4, My.Resources.apply_16x16, True, False))
       

        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
#Region "Valid"
#End Region
#Region "Select - Unselect"
  
#End Region
    Private Sub V_Nhan()

        If Txtma_hs_c.Text.Trim = "" Then
            MsgBox(" Chưa nhập thông tin người chuyển đổi")
            Exit Sub
        End If
        If TxtMa_hs_n.Text.Trim = "" Then
            MsgBox("Chưa nhập thông tin người nhận chuyển đổi")
            Exit Sub
        End If

        'If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, Me.Lan)
        '--Xoa truoc khi tao
        'If DtTmp.Rows(i).Item("Tag") Then
        '    Dim _DsCreate As DataSet = Nothing
        '    For i As Integer = 0 To Dt_Master.Rows.Count - 1
        '        _DsCreate = Nothing
        '        Dim _strField As String = ""
        '        Dim _strValue As String = ""
        '        CyberSmodb.GetValueData(Dt_Master.Rows(i), _strField, _strValue)
        '        _DsCreate = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CDDVKHTN", Txtma_hs_c.Text.Trim & "#" & TxtMa_hs_n.Text.Trim & "#" & DtTmp.Rows(i).Item("Id_Kh").ToString.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        '    Next
        '    If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

        '    If Not _DsCreate Is Nothing Then CyberSupport.V_MsgChk(_DsCreate.Tables(0), Me.Sysvar, Me.Lan)
        '    Me.Tag = ""
        '    V_LoadDatabase("1")
        'End If

        Dim dsChk As New DataSet
        Dim nCount As Integer
 
        Dim i As Integer
        For i = 0 To Dt_Master.Rows.Count - 1

            If Dt_Master.Rows(i)("Tag") Then
                dsChk = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CDDVKHTN", Txtma_hs_c.Text.Trim & "#" & TxtMa_hs_n.Text.Trim & "#" & Dt_Master.Rows(i).Item("Id_Kh").ToString.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
                nCount = dsChk.Tables.Count - 1

                If dsChk.Tables(nCount).Rows(0).Item("Status").ToString.Trim = "Y" Then
                    Dt_Master.Rows(i).BeginEdit()
                    Dt_Master.Rows(i).Item("Tag") = False

                    Dt_Master.Rows(i).EndEdit()
                    Dt_Master.AcceptChanges()

                Else
                    Dt_Master.Rows(i).BeginEdit()
                    Dt_Master.Rows(i).EndEdit()
                    Dt_Master.AcceptChanges()
                End If
                MsgBox(dsChk.Tables(nCount).Rows(0).Item("Note").ToString.Trim)
            End If

        Next
        Me.Master.Refresh()
        V_LoadDatabase("0")
        'Me.Close()
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub

    Private Sub CmdLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoadData.Click
        V_Loaddata()
    End Sub

  
    Private Sub ButtOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtOK.Click
        V_Nhan()
    End Sub
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = True
            Dt_Master.Rows(i).EndEdit()
            Dt_Master.AcceptChanges()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = False
            Dt_Master.Rows(i).EndEdit()
            Dt_Master.AcceptChanges()
        Next
    End Sub
End Class
