Imports System.Windows.Forms
Public Class CRQLTN_Xem
#Region "AddProperty"
    Public Property _Title() As String
        Get
            _Title = M_Title
        End Get
        Set(ByVal Value As String)
            M_Title = Value
        End Set
    End Property

#End Region
    Dim M_Title As String = ""
    Dim M_Ds As New DataSet
    Dim M_TableName As String
    Public Dt_DetailTmp, Dt_Head As DataTable
    Dim Dv_DetailTmp, Dv_Head As DataView
    Dim M_Mode As String = "M"
    Public Sub V_InVao(ByVal AppCon As SqlClient.SqlConnection, ByVal M_para As String(), ByVal osysvar As Collection, ByVal _ds As DataSet, ByVal TableName As String, ByVal _Mode As String)
        AppConn = AppCon
        Para = M_para
        Sysvar = osysvar
        M_Ds = _ds
        M_Mode = _Mode
        M_TableName = TableName
    End Sub
    Private Sub FrmCRQL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Getdefault()
        V_loadData()
        V_MainSystem()
        V_Addhandler()
        If Not _Title.Trim = "" Then Me.Text = _Title
        Me.Save_OK = False
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
        Dim mnItemsMail As New ContextMenu
        Dim mnItemsManl As New ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF3 As New MenuItem("Sửa", AddressOf V_ShortUpdateItem, Keys.F3)

        Dim mnItemsF7 As New MenuItem("In lái thử", AddressOf V_In_Lai_Thu, Keys.F7)
        Dim mnItemsF12 As New MenuItem("Sửa mẫu lái thử", AddressOf V_Sua_Lai_Thu, Keys.F12)

        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)

        Dim mnItemsSave As New MenuItem("Lưu dữ liệu", AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)

        Dim mnItemsExit As New MenuItem("Quay ra", AddressOf V_Close, Shortcut.None)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF3)
        If M_TableName.ToString.ToUpper.Trim = "CRQLKHTN_LT".ToString.ToUpper.Trim Then mnItemsMail.MenuItems.Add(mnItemsF7)
        If M_TableName.ToString.ToUpper.Trim = "CRQLKHTN_LT".ToString.ToUpper.Trim Then mnItemsMail.MenuItems.Add(mnItemsF12)

        mnItemsMail.MenuItems.Add(mnItemsF8)
        mnItemsMail.MenuItems.Add(mnItemsSave)
        mnItemsMail.MenuItems.Add(mnItemsExit)

        MasterGRV.GridControl.ContextMenu = mnItemsMail

        mnItemsManl.MenuItems.Add(mnItemsSave)
        Me.ContextMenu = mnItemsManl
    End Sub
    Private Sub V_In_Lai_Thu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub

        '---
        Dim _Ma_In As String = ""
        Dim _Loai_in As String = "1"
        Dim _Id_kh As String = Dv_DetailTmp.Item(iRow).Item("Id_kh").ToString.Trim
        Dim _Id_Item As String = Dv_DetailTmp.Item(iRow).Item("Id_Item").ToString.Trim

        Dim CyberVoucher As New Cyber.Voucher.Sys
        Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQLKH_PRINT", _Id_kh & "#" & _Id_Item & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        Dim _Report_Name As String = DsPrint.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim
        Dim _Title As String = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        Dim CyberPrint As New Cyber.Print.Sys
        CyberPrint.CyberPrintReport(AppConn, _Loai_in, _Report_Name, DsPrint, "", "", Me.Sysvar, Me.Para, "", False, "", Me.Lan, True, True)
        DsPrint.Dispose()
    End Sub
    Private Sub V_Sua_Lai_Thu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        '---
        Dim _Ma_In As String = ""
        Dim _Loai_in As String = "3"
        Dim _Id_kh As String = Dv_DetailTmp.Item(iRow).Item("Id_kh").ToString.Trim
        Dim _Id_Item As String = Dv_DetailTmp.Item(iRow).Item("Id_Item").ToString.Trim

        Dim CyberVoucher As New Cyber.Voucher.Sys
        Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQLKH_PRINT", _Id_kh & "#" & _Id_Item & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        Dim _Report_Name As String = DsPrint.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim
        Dim _Title As String = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        Dim CyberPrint As New Cyber.Print.Sys
        CyberPrint.CyberPrintReport(AppConn, _Loai_in, _Report_Name, DsPrint, "", "", Me.Sysvar, Me.Para, "", False, "", Me.Lan, True, True)
        DsPrint.Dispose()
    End Sub

    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = MasterGRV.FocusedRowHandle
        V_AddItem(iRow)
        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(MasterGRV, iRow, 0)
    End Sub

    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        Dim DrOld, drNew As DataRow
        Dim iOk As Boolean = False
        If iRow >= 0 Then DrOld = Dt_DetailTmp.Rows(iRow) Else DrOld = Nothing

        drNew = Dt_DetailTmp.NewRow
        CyberSmodb.SetValueBlankRow(drNew)

        Select Case M_TableName
            Case "CRQLKHTN_DL"
                Dim Frm As New CRQLKHTN_DL
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "M")
                Frm.ShowDialog()
                iOk = Frm.iOkSave
            Case "CRQLKHTN_GD"
                Dim Frm As New CRQLKHTN_GD
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "M")
                Frm.ShowDialog()
                iOk = Frm.iOkSave
            Case "CRQLKHTN_Mua"
                Dim Frm As New CRQLKHTN_Mua
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "M")
                Frm.ShowDialog()
                iOk = Frm.iOkSave

            Case "CRQLKHTN_Ban"
                Dim Frm As New CRQLKHTN_Ban
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "M")
                Frm.ShowDialog()
                iOk = Frm.iOkSave

            Case "CRQLKHTN_LT"
                Dim Frm As New CRQLKHTN_LaiThu
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "M")
                Frm.ShowDialog()
                iOk = Frm.iOkSave

        End Select

        If iOk = False Then Exit Sub
        '===========================
        Dt_DetailTmp.Rows.Add(drNew)
        CarrOn(Dt_DetailTmp.Rows(Dt_DetailTmp.Rows.Count - 1))

        UpdateList()
    End Sub
    '----------SỬA
    Private Sub V_ShortUpdateItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = MasterGRV.FocusedRowHandle
        V_UpdateItem(iRow)
        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(MasterGRV, iRow, 0)
    End Sub
    Private Sub V_UpdateItem(Optional ByVal iRow As Integer = -1)
        Dim DrOld, drNew As DataRow
        Dim iOk As Boolean = False
        If iRow >= 0 Then DrOld = Dt_DetailTmp.Rows(iRow) Else DrOld = Nothing

        drNew = DrOld
        Select Case M_TableName
            Case "CRQLKHTN_DL"
                Dim Frm As New CRQLKHTN_DL
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "S")
                Frm.ShowDialog()
                iOk = Frm.iOkSave
            Case "CRQLKHTN_GD"
                Dim Frm As New CRQLKHTN_GD
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "S")
                Frm.ShowDialog()
                iOk = Frm.iOkSave
            Case "CRQLKHTN_Mua"
                Dim Frm As New CRQLKHTN_Mua
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "S")
                Frm.ShowDialog()
                iOk = Frm.iOkSave
            Case "CRQLKHTN_Ban"
                Dim Frm As New CRQLKHTN_Ban
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "S")
                Frm.ShowDialog()
                iOk = Frm.iOkSave
            Case "CRQLKHTN_LT"
                Dim Frm As New CRQLKHTN_LaiThu
                Frm.ShowInTaskbar = False
                Frm.V_InVao(AppConn, Para, Sysvar, DrOld, drNew, M_TableName, "S")
                Frm.ShowDialog()
                iOk = Frm.iOkSave
        End Select
        If iOk = False Then Exit Sub
        '===========================
        ' drNew = DrOld
        'CarrOn(Dt_DetailTmp.Rows(Dt_DetailTmp.Rows.Count - 1))

        UpdateList()
    End Sub
    '------------END SỬA
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
        Me.Save_OK = False
        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Me.Close()
    End Sub
End Class