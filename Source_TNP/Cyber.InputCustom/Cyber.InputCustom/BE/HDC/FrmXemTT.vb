Public Class FrmXemTT
#Region "Get or Set Property----------------------"
    Public Property Stt_rec() As String
        Get
            Return M_Stt_rec
        End Get
        Set(ByVal value As String)
            M_Stt_rec = value
        End Set
    End Property
    Public Property Ma_Ct() As String
        Get
            Return M_Ma_Ct
        End Get
        Set(ByVal value As String)
            M_Ma_Ct = value
        End Set
    End Property
    Public Property Mode() As String
        Get
            Return M_Mode
        End Get
        Set(ByVal value As String)
            M_Mode = value
        End Set
    End Property
    Public Property Ma_KH() As String
        Get
            Return M_Ma_KH
        End Get
        Set(ByVal value As String)
            M_Ma_KH = value
        End Set
    End Property
    Public Property Ma_GD() As String
        Get
            Return M_Ma_GD
        End Get
        Set(ByVal value As String)
            M_Ma_GD = value
        End Set
    End Property
    Public Property Master_Return() As DataTable
        Get
            Master_Return = M_Master_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Master_Return = Value
        End Set
    End Property
    Public Property _Ds_LoolUp() As DataSet
        Get
            _Ds_LoolUp = DsLookup
        End Get
        Set(ByVal Value As DataSet)
            DsLookup = Value
        End Set
    End Property
#End Region
#Region "Bien----------------------"
    Dim M_Stt_rec As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Mode As String = "M"
    Dim M_Ma_KH As String = ""
    Dim M_Ma_GD As String = "1"

    Dim DsLookup As New DataSet
    Dim Dt_Master, Dt_head As New DataTable
    Dim Dv_Master, Dv_head As New DataView

    Dim EditMasterTag As New Cyber.Fill.CyberColumnGridView
    Dim M_Master_Return, Dt_Post As DataTable

    Dim DrReturn As DataRow
#End Region
    Private Sub FrmXemTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        'Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT Ma_Post,MAX(Ten_Post) as Ten_Post,MAX(Ten_Post2) as Ten_Post2,'0' as Ngam_Dinh FROM dbo.DmPost WHERE Ma_Ct =N'PT1' OR Ma_Ct =N'BC1' AND Ma_Post > N'1' GROUP BY Ma_Post ORDER BY Ma_Post#" + M_Ma_Dvcs + "#" + M_User_Name)
        'Dt_Post = Dstmp.Tables(0).Copy
        'Dstmp.Dispose()
        'For i As Integer = 0 To Dt_Post.Rows.Count - 1
        '    Dt_Post.Rows(i).BeginEdit()
        '    If Dt_Post.Rows(i).Item("Ma_Post").ToString.Trim = "9" Then Dt_Post.Rows(i).Item("Ngam_Dinh") = "1" Else Dt_Post.Rows(i).Item("Ngam_Dinh") = "0"
        '    Dt_Post.Rows(i).EndEdit()
        'Next

        V_Load()
        V_GetColumn()
        V_AddHander()

        Dim FixCol As Integer = 4
        If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_GetColumn()
        EditMasterTag.GetColumn(MasterGRV, "tag")
    End Sub
    Private Sub V_AddHander()
        'V_Menu(DetailGRVRo_Master, AddressOf V_EditVoucherRo)
        CyberFill.V_GridviewRowCellStyle(MasterGRV)
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdXem_TT.Click, AddressOf V_LocRo
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        AddHandler TxtMa_mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_mau.CyberLeave, AddressOf L_Ma_Mau
    End Sub

#Region "Valid "
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "Is_KD = 1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        ' If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn("Ma_Kx").ToString.Trim
            TxtTen_Kx.Text = DrReturn("Ten_Kx").ToString.Trim
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_mau.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauKx", "1=1", "Ma_kx ='" + TxtMa_Kx.Text.ToString.Trim + "'")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_mau.Text = "" Then
            TxtTen_mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_mau.Text = DrReturn("Ma_mau").ToString.Trim
            TxtTen_mau.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_mau", "Dmmauxe", "Ma_mau = N'" + TxtMa_mau.Text.Trim + "'", CyberSmlib)

        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Load - "
    Private Sub V_EditVoucherRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, MasterGRV)
    End Sub
    Private Sub V_Load()
        TxtThang.Text = Month(Now.Date)
        TxtNam.Text = Year(Now.Date)
        'TxtMa_Kx.Text = M_Ma_KH
        'TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_KH", "DmKH", "Ma_KH = N'" + TxtMa_Kx.Text + "'", CyberSmlib)
        V_LoadDatabase("1")
    End Sub
    Private Sub V_LoadDatabase(ByVal Status As String)
 
        Dim DsTT_Xe As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXemChiTieu", Status & "#" & TxtThang.Text & "#" & TxtNam.Text & "#" + TxtMa_Kx.Text & "#" & TxtMa_mau.Text + "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTT_Xe.Tables(0), Me.Sysvar, Me.Lan) Then
            DsTT_Xe.Dispose()
            Exit Sub
        End If
        For i = 0 To DsTT_Xe.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTT_Xe.Tables(i))
        Next
        If Status = "1" Then
            Dt_Master = DsTT_Xe.Tables(1)
            Dt_head = DsTT_Xe.Tables(2)
            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_head)
            V_FillDataToGridview(MasterGRV, M_LAN, Dv_head, Dv_Master)
        Else
            Dt_Master.Clear()
            CyberSmodb.SQLTbToTb(DsTT_Xe.Tables(1), Dt_Master)
            Dt_Master.AcceptChanges()
        End If
    End Sub
    Private Sub V_FillDataToGridview(ByRef GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
#End Region
#Region "Tinh toan"
#End Region
    Private Sub V_LocRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("0")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore

        Dim _Master_Return As DataTable = Dt_Master.Clone
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex

        If iRow >= 0 Then
            _Master_Return.ImportRow(Dt_Master.Rows(iRow))
        End If

        Me.Master_Return = _Master_Return
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
