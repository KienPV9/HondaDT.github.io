Public Class GLTC2
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_FillDataKind()
        V_FillCommboxGiam_tru()
        V_FillDataTaget()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtFile_MauBC.Text = Key_Sub2
        End If
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        AddHandler CmdV_Tk_No.Click, AddressOf V_Tk_No
        AddHandler CmdV_Tk_Co.Click, AddressOf V_Tk_Co


        AddHandler CmdV_Ma_Vv.Click, AddressOf V_Ma_Vv
        AddHandler CmdV_Ma_Phi.Click, AddressOf V_Ma_Phi
        AddHandler CmdV_Ma_HD.Click, AddressOf V_Ma_HD
        AddHandler CmdV_Ma_SP.Click, AddressOf V_Ma_SP
        AddHandler CmdV_Ma_Ku.Click, AddressOf V_Ma_Ku

        AddHandler CmdV_Ma_TTLN.Click, AddressOf V_Ma_TTLN
        AddHandler CmdV_Ma_TTCP.Click, AddressOf V_Ma_TTCP
        AddHandler CmdV_Ma_BP.Click, AddressOf V_Ma_BP
        AddHandler CmdV_Ma_HS.Click, AddressOf V_Ma_HS
        AddHandler CmdV_Ma_CD.Click, AddressOf V_Ma_CD

        AddHandler CmdV_Ma_TD1.Click, AddressOf V_Ma_TD1
        AddHandler CmdV_Ma_TD2.Click, AddressOf V_Ma_TD2
        AddHandler CmdV_Ma_TD3.Click, AddressOf V_Ma_TD3
        AddHandler CmdV_Ma_TD4.Click, AddressOf V_Ma_TD4
        AddHandler CmdV_Ma_TD5.Click, AddressOf V_Ma_TD5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_FillDataKind()
        Dim tbkind As New DataTable
        tbkind.Columns.Add("Name")
        tbkind.Columns.Add("Values")
        tbkind.Rows.Add("0- Tính theo các mã số", "0")
        tbkind.Rows.Add("1- Tính theo số dư tài khoản", "1")
        CyberFill.V_FillComBoxValue(CmbKind, tbkind, "Values", "Name", "1")
    End Sub
    Private Sub V_FillDataTaget()
        Dim tbTaget As New DataTable
        tbTaget.Columns.Add("Name")
        tbTaget.Columns.Add("Values")
        tbTaget.Rows.Add("0- Tổng cộng", "0")
        tbTaget.Rows.Add("1- Phòng kinh doanh", "1")
        tbTaget.Rows.Add("2- Phòng dịch vụ", "2")
        CyberFill.V_FillComBoxValue(CmbTaget, tbTaget, "Values", "Name", "0")
    End Sub
    Private Sub V_FillCommboxGiam_tru()
        Dim TbGiam_tru As New DataTable
        TbGiam_tru.Columns.Add("Name")
        TbGiam_tru.Columns.Add("Value")
        TbGiam_tru.Columns.Add("Default")
        TbGiam_tru.Rows.Add("0 - Không tính giảm trừ", "0")
        TbGiam_tru.Rows.Add(" 1 - Tính giảm trừ", "1")
        CyberFill.V_FillComBoxValue(CmbGiam_tru, TbGiam_tru, "Value", "Name", "0")
        'CmbKind
    End Sub
#End Region
#Region "Valid: Tk No/Co"
    Private Sub V_Tk_No(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DMTK#" & TxtTk_no.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        TxtTk_no.Text = str
    End Sub
    Private Sub V_Tk_Co(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DMTK#" & TxtTk_co.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        TxtTk_co.Text = str
    End Sub
#End Region
#Region "Valid: VV/HD.."
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmVV#" & txtMa_vv.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        If str.Trim = "" Then Exit Sub
        'txtMa_vv.Text = str
    End Sub
    Private Sub V_Ma_Phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmPhi#" & txtMa_PHI.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_PHI.Text = str
    End Sub
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmHD#" & txtMa_hd.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_hd.Text = str
    End Sub
    Private Sub V_Ma_SP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmSP#" & txtMa_sp.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_sp.Text = str
    End Sub
    Private Sub V_Ma_KU(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmKU#" & txtMa_Ku.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_Ku.Text = str
    End Sub
#End Region
#Region "Valid: TTLN/TTCP/BP/HS/CD"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmTTLN#" & txtMa_TTLN.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_TTLN.Text = str
    End Sub
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmTTCP#" & TxtMa_TTCP.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        TxtMa_TTCP.Text = str
    End Sub
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmBP#" & txtMa_BP.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_BP.Text = str
    End Sub
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmHS#" & txtMa_HS.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_HS.Text = str
    End Sub

    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmCD#" & txtMa_CD.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_CD.Text = str
    End Sub
#End Region
#Region "Valid: Tu Do"
    Private Sub V_Ma_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmTD1#" & txtMa_TD1.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_TD1.Text = str
    End Sub
    Private Sub V_Ma_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmTD2#" & txtMa_TD2.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_TD2.Text = str
    End Sub
    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmTD3#" & txtMa_TD3.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_TD3.Text = str
    End Sub
    Private Sub V_Ma_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmTD4#" & txtMa_TD4.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_TD4.Text = str
    End Sub
    Private Sub V_Ma_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        str = CyberSupport.V_GetStrSelectList(Appconn, oSysvar, M_Para, "CP_GetListSelect", "DmTD5#" & txtMa_TD5.Text.Trim & "#" & TxtFile_MauBC.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If str Is Nothing Then Exit Sub
        txtMa_TD5.Text = str
    End Sub

#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Xu ly truoc khi luu du lieu vao truong trinh viet vao day
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        Dim DsGetCode As New DataSet
        DsGetCode = V_GetCode(Mode, M_Ma_Dvcs, M_User_Name)
        'If Not DsGetCode Is Nothing Then TxtMa_BP.Text = DsGetCode.Tables(0).Rows(0)("Value").ToString.Trim
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class