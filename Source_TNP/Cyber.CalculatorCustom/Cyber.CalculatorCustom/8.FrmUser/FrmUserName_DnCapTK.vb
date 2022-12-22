Public Class FrmUserName_DnCapTK
#Region "AddProperty"
    Dim M_Stt_Rec As String = "M"
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
        End Set
    End Property
    Dim M_Mode As String = "M"
    Public Property Mode() As String
        Get
            Mode = M_Mode
        End Get
        Set(ByVal Value As String)
            M_Mode = Value
        End Set
    End Property
#End Region
    Dim DtDvcs, DtPost, Dt_Dvcs, Dt_GroupInfo, Dt_Dvcs_H, Dt_GroupInfo_H As DataTable
    Dim Dv_Dvcs, Dv_GroupInfo, Dv_Dvcs_H, Dv_GroupInfo_H As DataView
    Dim DrReturn As DataRow
    Dim DsLookup, Ds As DataSet
    Private Sub FrmUserName_DnCapTK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Addhander()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        '--------------------------------------------------------------------
        Ds = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysListUnits", M_Ma_Dvcs.Trim + "#" + M_User_Name)
        DtDvcs = Ds.Tables(0)
        DtDvcs.Rows(0).Delete()
        DtDvcs.AcceptChanges()
        Me.CyberFill.V_FillComBoxValue(Me.CbbMa_Dvcs, DtDvcs, "Ma_Dvcs", "Ten_Dvcs", M_Ma_Dvcs)
        'add ma_post
        Dim _Return As New DataTable
        _Return.Columns.Add("ma_post")
        _Return.Columns.Add("ten_post")
        _Return.Columns.Add("ten_post2")
        _Return.Columns.Add("Default")
        _Return.Rows.Add("0", "Hủy đề nghị", "Cancel", "0")
        _Return.Rows.Add("3", "Lập đề nghị", "Create", "1")
        _Return.Rows.Add("9", "Duyệt đề nghị", "Approval", "0")
        DtPost = _Return
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), "3")
        '--------------------------------------------------------------------
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapTK_F3", M_Stt_Rec + "#" + M_Mode + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        CyberSmodb.SetValueTObj(Me, Dstmp.Tables(0).Rows(0))
        Dt_Dvcs = Dstmp.Tables(1).Copy
        Dt_Dvcs_H = Dstmp.Tables(2).Copy
        Dt_GroupInfo = Dstmp.Tables(3).Copy
        Dt_GroupInfo_H = Dstmp.Tables(4).Copy

        Dv_Dvcs = New DataView(Dt_Dvcs)
        Dv_Dvcs_H = New DataView(Dt_Dvcs_H)
        Dv_GroupInfo = New DataView(Dt_GroupInfo)
        Dv_GroupInfo_H = New DataView(Dt_GroupInfo_H)

        CyberFill.V_FillVoucher(Master_DvcsGRV, M_LAN, Dv_Dvcs_H, Dv_Dvcs)
        Master_Dvcs.DataSource = Dv_Dvcs

        CyberFill.V_FillVoucher(Master_GroupInfoGRV, M_LAN, Dv_GroupInfo_H, Dv_GroupInfo)
        Master_GroupInfo.DataSource = Dv_GroupInfo

        '----------------------------------------------------------------------
        'CyberSmodb.SetValueTObj(Me, Drv)
        If M_Mode = "M" Then
            TxtNgay_Ct.Value = Date.Now
            TxtCreatedDate.Value = Date.Now
            Me.Text = "Tạo mới đề nghị cấp tài khoản"
        Else
            Me.Text = "Sửa đề nghị cấp tài khoản"
        End If

        If M_Mode = "M" Then
            V_GetMaBP()
        End If
        TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Hs", "Dmhs", "Ma_hs = N'" + TxtMa_Hs.Text + "'", CyberSmlib)
        TxtTen_Hs_DN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Hs", "Dmhs", "Ma_hs = N'" + TxtMa_HS_DN.Text + "'", CyberSmlib)
        TxtTen_Bp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Bp", "Dmbp", "Ma_bp = N'" + TxtMa_Bp.Text + "'", CyberSmlib)
        '

        Dstmp.Dispose()
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
        If dsTMp.Tables(0).Columns.Contains("Ma_Hs_H") Then If TxtMa_HS_DN.Text.Trim = "" Then TxtMa_HS_DN.Text = dsTMp.Tables(0).Rows(0).Item("Ma_HS_H")
        If dsTMp.Tables(0).Columns.Contains("Ten_Hs_H") Then If TxtTen_Hs_DN.Text.Trim = "" Then TxtTen_Hs_DN.Text = dsTMp.Tables(0).Rows(0).Item("Ten_Hs_H")
        dsTMp.Dispose()
    End Sub
    Private Sub V_Addhander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        'Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        'Ma_Hs_Dn
        AddHandler TxtMa_HS_DN.CyberValiting, AddressOf V_Ma_Hs_DN
        AddHandler TxtMa_HS_DN.CyberLeave, AddressOf L_Ma_Hs_DN
        'Ma_Bp
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp
    End Sub
#Region "Valid"
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "Ma_Dvcs='" + CbbMa_Dvcs.SelectedValue.ToString.Trim + "'", "1=1")
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
#Region "Vali --- Ma_Hs_DN"
    Private Sub V_Ma_Hs_DN(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS_DN.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "Ma_Dvcs='" + CbbMa_Dvcs.SelectedValue.ToString.Trim + "'", "1=1")
    End Sub
    Private Sub L_Ma_Hs_DN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_HS_DN.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS_DN.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs_DN.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_HS_DN.Text = ""
            TxtTen_Hs_DN.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Bp", "DmBp", "Ma_Dvcs='" + CbbMa_Dvcs.SelectedValue.ToString.Trim + "'", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Bp.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_Bp")
            TxtTen_Bp.Text = DrReturn.Item("Ten_Bp")
        Else
            TxtMa_Bp.Text = ""
            TxtTen_Bp.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_strParameterStore As String = ""
        Me.Tag = M_Stt_Rec
        Dim _Str As String = "SELECT TOP 0 * FROM dbo.DmDNCapTK WHERE 1=0"
        Dim DsTmpstru As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", _Str)

        Dim DtMaster As DataTable = DsTmpstru.Tables(0).Copy
        Dim drMaster As DataRow = DtMaster.NewRow
        CyberSmodb.AddValueToRow(drMaster, Me)
        DtMaster.Rows.Add(drMaster)
        DtMaster.AcceptChanges()
        '
        Dim Dt_Dvcs_Save As DataTable = Dt_Dvcs.Clone
        Dim Dt_GroupInfo_Save As DataTable = Dt_GroupInfo.Clone
        '------------Lấy những đơn vị + Những Group được chọn
        Dim Drs_Dvcs As DataRow() = Dt_Dvcs.Select("tag = '1'")
        Dim Drs_GroupInfo As DataRow() = Dt_GroupInfo.Select("tag = '1'")
        For i As Integer = 0 To Drs_Dvcs.Length - 1
            Dt_Dvcs_Save.ImportRow(Drs_Dvcs(i))
        Next
        For i As Integer = 0 To Drs_GroupInfo.Length - 1
            Dt_GroupInfo_Save.ImportRow(Drs_GroupInfo(i))
        Next
        '------------

        Dim _Xml As String = CyberSmodb.V_ConvertDataToXML({"DmDNCapTK", "DmDNCapTK_Dvcs", "DmDNCapTK_Group"}, {DtMaster, Dt_Dvcs_Save, Dt_GroupInfo_Save})
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SmUserDNCapTK_Save", TxtStt_Rec.Text + "#" + M_Mode + "#" + _Xml + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            Me.Save_OK = False
            Me.Tag = ""
            Return
        Else
            Me.Save_OK = True
            Me.Tag = TxtStt_Rec.Text.Trim
        End If

        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
