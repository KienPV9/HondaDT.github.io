Imports System.Windows.Forms
Public Class CRQLKHTN_DL
    Dim M_Ds As New DataSet
    Dim M_TableName As String
    Public drOld, drNew As DataRow
    Public M_mode As String
    Private tbKX, tbmau As DataTable
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
    Private Sub CRQLKHTN_DL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If M_mode = "S" Then CyberSmodb.SetValueTObj(Me, drOld)
        If M_mode = "M" Then TxtNgay_Hen.Value = Now.Date
        If M_mode = "M" Then TxtGio_hen.Text = CyberVoucher.V_GetTG("", 0)
        If M_mode = "M" Then TxtNgay_Goi.Value = Now.Date.AddDays(3)
        If M_mode = "M" Then TxtGio_Goi.Text = CyberVoucher.V_GetTG("", 0)
        V_Getdefault()
        V_Addhandler()
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
    Private Sub V_Addhandler()
        AddHandler TxtGio_hen.Leave, AddressOf V_Gio_Hen
        AddHandler TxtGio_Goi.Leave, AddressOf V_Gio_Goi

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Close
    End Sub
    Private Sub V_Gio_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGio_hen.Text = CyberVoucher.V_GetTG(TxtGio_hen.Text, 0)
    End Sub
    Private Sub V_Gio_Goi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGio_Goi.Text = CyberVoucher.V_GetTG(TxtGio_Goi.Text, 0)
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
        CyberSmodb.AddValueToRow(drNew, Me)
        Me.Close()
    End Sub
End Class