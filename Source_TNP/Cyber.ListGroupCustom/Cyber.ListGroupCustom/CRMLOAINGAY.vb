Imports System.Data.SqlClient
Public Class CRMLOAINGAY
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim _DtPhanHe As DataTable
    Dim _DtLoai As DataTable
    Private Sub CRMDMLoai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        _DtPhanHe = CreateTablePhanHe()
        _DtLoai = CreateTableLoai()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_ngay.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Private Function CreateTablePhanHe() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma")
        _Return.Columns.Add("Ten")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("RO", "Đánh giá khách hàng sửa chữa", "1")
        _Return.Rows.Add("BE", "Đánh giá khách hàng bán xe", "0")
        CreateTablePhanHe = _Return
    End Function
    Private Function CreateTableLoai() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma")
        _Return.Columns.Add("Ten")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("CS", "CS", "1")
        _Return.Rows.Add("CR", "CR", "0")
        _Return.Rows.Add("CD", "CD", "0")
        CreateTableLoai = _Return
    End Function
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        TxtTen_loai.Text = CyberSmodb.SQLGetvalue(Appconn, "CrmTen_loai", "CRMDMLOAI", "(CrmMa_loai = N'" + TxtCrmMa_loai.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_ngay.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_ngay.KeyPress, AddressOf TxtCodeError_KeyPress
        '--BP1
        RemoveHandler TxtCrmMa_loai.CyberValiting, AddressOf V_Ma_loai
        RemoveHandler TxtCrmMa_loai.CyberLeave, AddressOf L_Ma_Loai
        AddHandler TxtCrmMa_loai.CyberValiting, AddressOf V_Ma_loai
        AddHandler TxtCrmMa_loai.CyberLeave, AddressOf L_Ma_Loai
        '--BP2
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Ch"
    Private Sub V_Ma_loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtCrmMa_loai.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Crmma_loai", "CRMDMLOAI", "1=1", "'1'='1'")
    End Sub
    Private Sub L_Ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtCrmMa_loai.GetRowsSelectData(True)
        If TxtCrmMa_loai.Text = "" Then
            TxtTen_loai.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtCrmMa_loai.Text = DrReturn.Item("Crmma_loai")
            TxtTen_loai.Text = DrReturn.Item("CrmTen_loai")
        Else
            TxtCrmMa_loai.Text = ""
            TxtTen_loai.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_ngay.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

End Class
