Imports System.Windows.Forms
Imports System.Drawing

Public Class CRQLTN_Xem_KQ
#Region "AddProperty"
    Public Property _Title() As String
        Get
            _Title = M_Title
        End Get
        Set(ByVal Value As String)
            M_Title = Value
        End Set
    End Property
    Public Property _Loai() As String
        Get
            _Loai = M_Loai
        End Get
        Set(ByVal Value As String)
            M_Loai = Value
        End Set
    End Property
    Public Property _ID_KH() As String
        Get
            _ID_KH = M_ID_KH
        End Get
        Set(ByVal Value As String)
            M_ID_KH = Value
        End Set
    End Property
#End Region
    Dim M_Title As String = ""
    Dim M_ID_KH As String
    Dim M_Loai As String = "SC"
    Dim Dt_Master, Dt_Head As DataTable
    Dim DV_Master, Dv_Head As DataView
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub CRQLTN_Xem_KQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_loadData()
        V_MainSystem()
        V_Addhandler()
        If Not _Title.Trim = "" Then Me.Text = _Title
        Me.Save_OK = False
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_loadData()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRQL_VIEW_" + _Loai.Trim, _ID_KH + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        Dt_Master = DsTmp.Tables(0).Copy
        Dt_Head = DsTmp.Tables(1).Copy

        DV_Master = New DataView(Dt_Master)
        Dv_Head = New DataView(Dt_Head)
        DsTmp.Dispose()

        Master.DataSource = DV_Master

        'CyberFill.V_FillVoucher(MasterGRV, M_LAN, Dv_Head, DV_Master)
        CyberFill.V_FillReports(MasterGRV, M_LAN, Dv_Head, DV_Master)
    End Sub
    Private Sub V_Addhandler()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Close
        RemoveHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Close
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

    End Sub
    Private Sub V_MainSystem()
        Dim mnItemsMail As New ContextMenu
        Dim mnItemsManl As New ContextMenu
        Dim mnItemsF5 As New MenuItem("Làm tươi dữ liệu", AddressOf V_F5, Keys.F5)
        'Dim mnItemsF3 As New MenuItem("Sửa", AddressOf V_ShortUpdateItem, Keys.F3)
        'Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)
        'Dim mnItemsSave As New MenuItem("Lưu dữ liệu", AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)

        mnItemsMail.MenuItems.Add(mnItemsF5)
        'mnItemsMail.MenuItems.Add(mnItemsF3)
        'mnItemsMail.MenuItems.Add(mnItemsF8)
        'mnItemsMail.MenuItems.Add(mnItemsSave)
        MasterGRV.GridControl.ContextMenu = mnItemsMail

        'mnItemsManl.MenuItems.Add(mnItemsSave)
        Me.ContextMenu = mnItemsManl
    End Sub
    Private Sub V_F5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_loadData()
    End Sub
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
End Class