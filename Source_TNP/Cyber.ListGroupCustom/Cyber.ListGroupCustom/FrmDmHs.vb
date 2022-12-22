Imports System.Windows.Forms
Public Class FrmDmHs
    Dim M_Ds As New DataSet
    Dim M_TableName As String
    Public Dt_DetailTmp, Dt_Head As DataTable
    Dim Dv_DetailTmp, Dv_Head As DataView
    Public iOkSave As Boolean = False
    Public Sub V_InVao(ByVal AppCon As SqlClient.SqlConnection, ByVal M_para As String(), ByVal osysvar As Collection, ByVal _ds As DataSet, ByVal TableName As String)
        AppConn = AppCon
        Para = M_para
        Sysvar = osysvar
        M_Ds = _ds
        M_TableName = TableName
    End Sub
    Private Sub FrmDmHs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Getdefault()
        V_loadData()
        V_MainSystem()
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
    Private Sub V_loadData()

        Dt_DetailTmp = M_Ds.Tables(0).Copy
        Dt_Head = M_Ds.Tables(1).Copy

        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        Dv_Head = New DataView(Dt_Head)

        CyberFill.V_FillVoucher(MasterGRV, M_LAN, Dv_Head, Dv_DetailTmp)
    End Sub

    Private Sub V_Addhandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Close
    End Sub
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsManl As New ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)
        Dim mnItemsSave As New MenuItem("Lưu dữ liệu", AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        mnItemsMail.MenuItems.Add(mnItemsSave)
        MasterGRV.GridControl.ContextMenu = mnItemsMail

        mnItemsManl.MenuItems.Add(mnItemsSave)
        Me.ContextMenu = mnItemsManl
    End Sub
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = MasterGRV.FocusedRowHandle
        V_AddItem(iRow)
        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(MasterGRV, iRow, 0)
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        Dim DrvOld As DataRowView

        If iRow > 0 Then DrvOld = Dv_DetailTmp.Item(iRow) Else DrvOld = Nothing

        Dv_DetailTmp.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1), New DataView(Dt_Head))
        CarrOn(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        UpdateList()
    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
        If DvNew Is Nothing Then Return
        Dim _FieldName As String = ""
        For i As Integer = 0 To DvNew.Table.Columns.Count - 1
            _FieldName = DvNew.Table.Columns(i).ColumnName

            If Not DvNew.Table.Columns(_FieldName).DataType.Name.Trim.ToUpper = "DATETIME".Trim.ToUpper Then Continue For
            If IsDBNull(DvNew(_FieldName)) Then
                DvNew.Item(_FieldName) = Now.Date
                Continue For
            End If
            Dim _Dt As Date = DvNew(_FieldName)
            If _Dt.ToString("yyyyMMdd") = "19000101" Then
                DvNew.Item(_FieldName) = Now.Date
            End If
        Next
    End Sub
    Private Sub UpdateList()

    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = MasterGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(Sysvar, M_LAN, "", iRow, Dv_DetailTmp, AppConn) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
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
        Me.Close()
    End Sub
End Class
