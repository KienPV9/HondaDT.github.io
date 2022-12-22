Imports System.Windows.Forms
Public Class CRQLKHTN_Mua
    Dim M_Ds As New DataSet
    Dim M_TableName As String
    Public drOld, drNew As DataRow
    Public M_mode As String
    Private tbKX, tbKhmua, tbhttt, tbmau As DataTable
    Public iOkSave As Boolean = False
    Public Sub V_InVao(ByVal AppCon As SqlClient.SqlConnection, ByVal M_para As String(), ByVal osysvar As Collection, ByVal _drOld As DataRow, ByVal _drNew As DataRow, ByVal TableName As String, ByVal _M_mode As String)
        AppConn = AppCon
        Para = M_para
        Sysvar = osysvar
        drOld = _drOld
        drNew = _drNew
        M_mode = _M_mode
        M_TableName = TableName
    End Sub
    Private Sub CRQLKHTN_Mua_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Getdefault()
        CreateTabe()
        V_LoadMa_Kx()
        V_LoadMa_Mau()
        V_LoadMa_KHMUA()
        V_LoadMa_HTTT()
        If M_mode = "S" Then CyberSmodb.SetValueTObj(Me, drOld) Else TxtNgay_Gx.Value = Now.Date
        V_Addhandler()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "LoadtoComb"
    Private Sub V_LoadMa_Kx()
        Dim DsTbkx As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQLKHTNLoadTable", "Ma_Kx#" & M_Ma_Dvcs & "#" & M_User_Name)
        tbKX = DsTbkx.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Kx, tbKX, "Ma_Kx", "Ten_Kx")
    End Sub
    Private Sub V_LoadMa_Mau()
        Dim DsTbma_mau As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQLKHTNLoadTable", "Ma_Mau#" & M_Ma_Dvcs & "#" & M_User_Name)
        tbmau = DsTbma_mau.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Mau, tbmau, "Ma_Mau", "Ten_Mau")
    End Sub
    Private Sub V_LoadMa_KHMUA()
        Dim DsTbkhmua As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQLKHTNLoadTable", "Ma_KHMUA##" & M_User_Name)
        tbKhmua = DsTbkhmua.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_KHMUA, tbKhmua, "Ma_KHMUA", "Ten_KHMUA")
    End Sub
    Private Sub V_LoadMa_HTTT()

        Dim DsTbhttt As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQLKHTNLoadTable", "Ma_HTTT##" & M_User_Name)
        tbhttt = DsTbhttt.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.Cmbma_HTTT, tbhttt, "Ma_HTTT", "Ten_HTTT")
    End Sub
    Private Sub CreateTabe()
        Dim DtKQ_Mua As New DataTable
        DtKQ_Mua.Columns.Add("Loai_kq")
        DtKQ_Mua.Columns.Add("Ten")
        DtKQ_Mua.Columns.Add("Default")

        DtKQ_Mua.Rows.Add("1", IIf(M_LAN = "V", "Nghi ngờ chất vấn", ""), "1")
        DtKQ_Mua.Rows.Add("2", IIf(M_LAN = "V", "Tìm hiểu đánh giá", ""), "0")
        DtKQ_Mua.Rows.Add("3", IIf(M_LAN = "V", "Thưởng thức/ an tâm tình nguyện", ""), "0")
        DtKQ_Mua.Rows.Add("4", IIf(M_LAN = "V", "Lặp lại sự đánh giá", ""), "0")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_TT, DtKQ_Mua, "Loai_kq", "Ten")
    End Sub
#End Region
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
    Private Sub V_Addhandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Close
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
        TxtTen_Kx.Text = CmbMa_Kx.Text
        txtten_Mau.Text = CmbMa_Mau.Text

        txtTen_HTTT.Text = Cmbma_HTTT.Text
        txtTen_KhMua.Text = CmbMa_KHMUA.Text


        CyberSmodb.AddValueToRow(drNew, Me)
        Me.Close()
    End Sub
End Class