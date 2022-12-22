Imports System.Windows.Forms
Public Class CRQLKHTN_LaiThu
    Dim M_Ds As New DataSet
    Dim M_TableName As String
    Public drOld, drNew As DataRow
    Public M_mode As String
    Private tbPTLH, tbhttt As DataTable
    Public iOkSave As Boolean = False

    Dim tbGT As DataTable
    Dim tbDT As DataTable
    Dim tbKX As DataTable

    Public Sub V_InVao(ByVal AppCon As SqlClient.SqlConnection, ByVal M_para As String(), ByVal osysvar As Collection, ByVal _drOld As DataRow, ByVal _drNew As DataRow, ByVal TableName As String, ByVal _M_mode As String)
        AppConn = AppCon
        Para = M_para
        Sysvar = osysvar
        drOld = _drOld
        drNew = _drNew
        M_mode = _M_mode
        M_TableName = TableName
    End Sub
    Private Sub CRQLKHTN_LaiThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        V_Getdefault()
        TxtNgay_LT.Value = Now.Date
        TxtGio_BD.Text = CyberVoucher.V_GetTG("", 0)
        TxtGio_KT.Text = CyberVoucher.V_GetTG(TxtGio_BD.Text, 30)
        '-----------------------------------------------------
        V_LoadMa_GT()
        V_LoadMa_DTuoi()
        V_LoadMa_Kx()
        '-----------------------------------------------------
        CreateTabe()
        V_loadData()
        V_Addhandler()
        If M_mode = "S" Then CyberSmodb.SetValueTObj(Me, drOld)
        If M_mode = "M" Then
            TxtUser_Id.Text = M_User_ID
            V_GetNgay_Gio()
        End If

        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub

    Private Sub V_Getdefault()
        Dim M_VT_PARA As Integer = CType(Para(0).Trim, Integer)
        K_Tmp = Para(1).Trim
        K_System = Para(2).Trim
        K_Repo = Para(3).Trim
        K_Repo_Nt = Para(4).Trim
        M_CYBER_VER = Para(5).Trim
        M_User_Name = Para(6).Trim
        M_Comment = Para(7).Trim
        M_is_Admin = CType(Para(8), Boolean)
        M_User_ID = Para(9).Trim
        M_Menu_ID0 = Para(10).Trim
        M_Bar = Para(11).Trim
        M_Bar2 = Para(12).Trim
        M_LAN = Para(13).Trim
        M_Ma_Dvcs = Para(14).Trim
    End Sub
    Private Sub V_loadData()

    End Sub
    Private Sub V_LoadMa_GT()
        Dim DsTbGT As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_GT##" & M_User_Name)
        tbGT = DsTbGT.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_GT_LT, tbGT, "Ma_GT", "Ten_GT")
    End Sub
    Private Sub V_LoadMa_DTuoi()
        Dim DsTbDT As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_DTuoi##" & M_User_Name)
        tbDT = DsTbDT.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_DTuoi_LT, tbDT, "Ma_DTuoi", "Ten_DTuoi")
    End Sub
    Private Sub V_LoadMa_Kx()
        Dim DsTbkx As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CRQLKHTNLoadTable", "Ma_Kx##" & M_User_Name)
        tbKX = DsTbkx.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Kx_LT, tbKX, "Ma_Kx", "Ten_Kx")
    End Sub

    Private Sub CreateTabe()
        Dim DtKQ_LaiThu As New DataTable

        DtKQ_LaiThu.Columns.Add("Loai_kq", GetType(String))
        DtKQ_LaiThu.Columns.Add("Ten", GetType(String))
        DtKQ_LaiThu.Columns.Add("Default", GetType(String))
        DtKQ_LaiThu.Rows.Add("1", IIf(M_LAN = "V", "Thích lái", ""), "1")
        DtKQ_LaiThu.Rows.Add("2", IIf(M_LAN = "V", "Đang lưỡng lự", ""), "0")
        DtKQ_LaiThu.Rows.Add("3", IIf(M_LAN = "V", "Trải nghiệm xe khác", ""), "0")
        DtKQ_LaiThu.Rows.Add("4", IIf(M_LAN = "V", "Khác", ""), "0")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_TT, DtKQ_LaiThu, "Loai_kq", "Ten")

        'CyberFill.V_FillComBoxValue(Me.CmbMa_TT, DtKQ_LaiThu, "Loai_kq", "Ten", TxtMa_TT.Text)
        'TxtMa_TT.Text = CmbMa_TT.SelectedIndex
    End Sub

    Private Sub V_Addhandler()
        AddHandler TxtGio_BD.Leave, AddressOf V_Gio_BD
        AddHandler TxtGio_KT.Leave, AddressOf V_Gio_KT

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Close
    End Sub
    Private Sub V_Gio_BD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtGio_BD.Text = CyberVoucher.V_GetTG(TxtGio_BD.Text, 0)
    End Sub
    Private Sub V_Gio_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtGio_KT.Text = CyberVoucher.V_GetTG(TxtGio_KT.Text, 0)
    End Sub
    Private Sub V_GetNgay_Gio()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetCurrenDate", M_Ma_Dvcs + "#" + M_User_Name)
        TxtNgay_tao.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_HT")
        TxtGio_tao.Text = Dstmp.Tables(0).Rows(0).Item("Gio_HT")
        Dstmp.Dispose()
    End Sub

    Private Sub V_ShortSAVE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtOK.PerformClick()
    End Sub
    Private Sub V_Close(ByVal sender As System.Object, ByVal e As System.EventArgs)
        iOkSave = False
        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        iOkSave = True
        Txtten_TT.Text = CmbMa_TT.Text
        TxtTen_Kx.Text = CmbMa_Kx_LT.Text

        Txtten_GT.Text = CmbMa_GT_LT.Text
        txtTen_DTuoi.Text = CmbMa_DTuoi_LT.Text

        CyberSmodb.AddValueToRow(drNew, Me)
        Me.Close()
    End Sub
End Class