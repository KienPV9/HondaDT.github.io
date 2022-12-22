Public Class DMDGNV
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_LoadNam()
        CreateTable_MaLoai()
        V_Load()

        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Chitieu)
        TxtMa_Chitieu.Focus()

        V_Addhander()


        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtMa_Chitieu.Text.Trim = "" Then CmbMa_ND.Text = "" Else CmbMa_ND.SelectedValue = CyberSmodb.SQLGetvalue(Appconn, "Ma_ND", "DMDGNV", "(Ma_Chitieu = N'" + TxtMa_Chitieu.Text.Trim + "')", CyberSmlib)
        If TxtMa_Chitieu.Text.Trim = "" Then CmbMa_ND.Text = "" Else CmbMa_nhom.SelectedValue = CyberSmodb.SQLGetvalue(Appconn, "Ma_nhom", "DMDGNV", "(Ma_Chitieu = N'" + TxtMa_Chitieu.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

        If Me.Mode = "S" Then
            If CmbMa_ND.SelectedValue.Trim = "" Then TxtTen_ND.Text = "" Else TxtTen_ND.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_ND", "DmND", "(Ma_ND = N'" + CmbMa_ND.SelectedValue.Trim + "')", CyberSmlib)
        End If

    End Sub
    Private Sub V_LoadNam()
        Dim tbNam As DataTable
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_LoadNam", M_Ma_Dvcs & "#" & M_User_Name)
        tbNam = DsTmp.Tables(4).Copy
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_ND, tbNam, "Ma_ND", "Ten_ND", "Ma_ND")

    End Sub
    Private Sub CreateTable_MaLoai()

        Dim DtTMa_Loai As New DataTable
        DtTMa_Loai.Columns.Add("Ma_nhom", GetType(String))
        DtTMa_Loai.Columns.Add("Ten_nhom", GetType(String))

        DtTMa_Loai.Rows.Add("NV", IIf(M_LAN = "V", "Nhân viên", "1"))
        DtTMa_Loai.Rows.Add("TV", IIf(M_LAN = "V", "Thử việc", "2"))

        CyberFill.V_FillComBoxDefaul(Me.CmbMa_nhom, DtTMa_Loai, "Ma_nhom", "Ten_nhom")


    End Sub
    Protected Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Chitieu.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Chitieu.KeyPress, AddressOf TxtCodeError_KeyPress
        'AddHandler CmbMa_ND.SelectedValueChanged, AddressOf V_Ma_ND
    End Sub
    'Private Sub V_Ma_ND(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TxtTen_ND.Text = CmbMa_ND.SelectedValue.
    '    MsgBox(CmbMa_ND.SelectedItem)
    'End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Chitieu.Text = _Value

        If CmbMa_ND.SelectedValue.Trim = "" Then TxtTen_ND.Text = "" Else TxtTen_ND.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_ND", "DmND", "(Ma_ND = N'" + CmbMa_ND.SelectedValue.Trim + "')", CyberSmlib)


        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub


#End Region
End Class
