Imports System.Windows.Forms
Public Class CRQLKHTN_GD
    Dim M_Ds As New DataSet
    Dim M_TableName As String
    Public drOld, drNew As DataRow
    Public M_mode As String
    Private tbPTLH, tbhttt As DataTable
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
    Private Sub CRQLKHTN_GD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If M_mode = "S" Then CyberSmodb.SetValueTObj(Me, drOld) Else TxtDate2.Value = Now.Date
        V_Getdefault()
        CreateTabe()
        V_loadData()
        V_LoadMa_PTLH()
        V_AddhanderMaster()
        V_Addhandler()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "LoadtoComb"

    Private Sub V_LoadMa_PTLH()
        Dim DsTbGT As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQLKHTNLoadTable", "Ma_PTLH#" & M_Ma_Dvcs & "#" & M_User_Name)
        tbPTLH = DsTbGT.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_HT, tbPTLH, "Ma_PTLH", "TEN_PTLH", TxtMa_HT.Text)
        TxtMa_HT.Text = CmbMa_HT.SelectedIndex
        If M_mode = "M" Then
            CyberFill.V_FillComBoxDefaul(Me.CmbMa_HT, tbPTLH, "Ma_PTLH", "TEN_PTLH")
        End If
    End Sub

    Private Sub CreateTabe()
        Dim DtKQ_GD As New DataTable

        DtKQ_GD.Columns.Add("Loai_kq", GetType(String))
        DtKQ_GD.Columns.Add("Ten", GetType(String))
        DtKQ_GD.Columns.Add("Default", GetType(String))
        DtKQ_GD.Rows.Add("1", IIf(M_LAN = "V", "Rất tốt", ""), "1")
        DtKQ_GD.Rows.Add("2", IIf(M_LAN = "V", "Tốt", ""), "0")
        DtKQ_GD.Rows.Add("3", IIf(M_LAN = "V", "Bình thường", ""), "0")
        DtKQ_GD.Rows.Add("4", IIf(M_LAN = "V", "Chưa có kết quả", ""), "0")
        CyberFill.V_FillComBoxValue(Me.CmbMa_TT, DtKQ_GD, "Loai_kq", "Ten", TxtMa_TT.Text)
        TxtMa_TT.Text = CmbMa_TT.SelectedIndex
        If M_mode = "M" Then
            CyberFill.V_FillComBoxDefaul(Me.CmbMa_TT, DtKQ_GD, "Loai_kq", "Ten")
        End If
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
    Private Sub V_loadData()

    End Sub

    Protected Sub V_AddhanderMaster()
        AddHandler CmbMa_TT.SelectedValueChanged, AddressOf V_Ma_TT_SelectedIndexChanged
    End Sub
    Private Sub V_Ma_TT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_TT(False)
    End Sub
    Private Sub V_Ma_TT(ByVal Load As Boolean)
        If Load Then
            CmbMa_TT.SelectedValue = TxtMa_TT.Text.Trim
        Else
            TxtMa_TT.Text = CmbMa_TT.SelectedValue.ToString.Trim
        End If

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
        TxtTen_HT.Text = CmbMa_HT.Text
        

        CyberSmodb.AddValueToRow(drNew, Me)
        Me.Close()
    End Sub
End Class