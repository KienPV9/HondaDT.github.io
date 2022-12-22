Public Class DMKH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private vTbTP, vTbQuan, vTbXa As DataView
    Private _Load_TP As Boolean = False
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()
        V_LoadTinh_Quan_Xa()
        V_Load()
        V_AddhanderMaster()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Kh, TxtNh_KH1, TxtNh_KH2, TxtNh_KH3, TxtNh_KH4, TxtNh_KH5)
        TxtMa_Kh.Focus()
    End Sub
#Region "LoadTinh_Quan_Xa"
    Private Sub V_LoadTinh_Quan_Xa()
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetTPQuanXa", M_Ma_Dvcs + "#" + M_User_Name)
        TbTP = DsTb.Tables(0).Copy
        TbQuan = DsTb.Tables(1).Copy
        TbXa = DsTb.Tables(2).Copy

        vTbTP = New DataView(TbTP)
        vTbQuan = New DataView(TbQuan)
        vTbXa = New DataView(TbXa)

        CyberFill.V_FillComBoxDefaul(Me.CmbMa_TP, vTbTP, "Ma_TP", "Ten_TP")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Quan, vTbQuan, "Ma_Quan", "Ten_Quan")
        CyberFill.V_FillComBoxDefaul(Me.CmbMa_Xa, vTbXa, "Ma_Xa", "Ten_Xa")
    End Sub
    Private Function GetTab(ByVal Tb_name As String, Optional ByVal Order As String = "1=1", Optional ByVal Key As String = "1=1") As DataTable
        Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetTable", Tb_name + "#" + Key + "#" + Order)
        GetTab = DsTb.Tables(0).Copy
    End Function
    Private Sub V_Ma_TP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_TP(False)
        V_Ma_Quan(False)
    End Sub
    Private Sub V_Ma_Quan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_Quan(False)
    End Sub
    Private Sub V_Ma_xa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ma_Xa(False)
    End Sub
    Private Sub V_Ma_TP(ByVal Load As Boolean)
        If Load Then
            CmbMa_TP.SelectedValue = TxtMa_TP.Text.Trim
        Else
            TxtMa_TP.Text = CmbMa_TP.SelectedValue.ToString.Trim
        End If
        vTbQuan.RowFilter = "Ma_Tp = '" & TxtMa_TP.Text.Trim & "'"
    End Sub
    Private Sub V_Ma_Quan(ByVal Load As Boolean)
        If Load Then
            CmbMa_Quan.SelectedValue = TxtMa_Quan.Text.Trim
        Else
            TxtMa_Quan.Text = CmbMa_Quan.SelectedValue.ToString.Trim
        End If
        vTbXa.RowFilter = "Ma_Quan = '" & TxtMa_Quan.Text.Trim() & "'"
    End Sub
    Private Sub V_Ma_Xa(ByVal Load As Boolean)
        If Load Then
            CmbMa_Xa.SelectedValue = TxtMA_Xa.Text.Trim
        Else
            TxtMA_Xa.Text = CmbMa_Xa.SelectedValue.ToString.Trim
        End If
    End Sub
#End Region
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_KH1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_KH1.Text.Trim + "')", CyberSmlib)
        If TxtNh_KH2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_KH2.Text.Trim + "')", CyberSmlib)
        If TxtNh_KH3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_KH3.Text.Trim + "')", CyberSmlib)
        If TxtNh_KH4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_KH4.Text.Trim + "')", CyberSmlib)
        If TxtNh_KH5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_KH5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub

    Protected Sub V_AddhanderMaster()

        AddHandler TxtMa_Kh.KeyPress, AddressOf TxtCodeError_KeyPress

        '---TInh thanh
        AddHandler CmbMa_TP.SelectedValueChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedValueChanged, AddressOf V_Ma_Quan_SelectedIndexChanged
        AddHandler CmbMa_Xa.SelectedValueChanged, AddressOf V_Ma_xa_SelectedIndexChanged


        AddHandler CmbMa_TP.SelectedIndexChanged, AddressOf V_Ma_TP_SelectedIndexChanged
        AddHandler CmbMa_Quan.SelectedIndexChanged, AddressOf V_Ma_Quan_SelectedIndexChanged
        '---Ten_KH

        RemoveHandler TxtTen_KH.Leave, AddressOf V_TxtTen_kh
        RemoveHandler txtDia_chi.Leave, AddressOf V_TxtDia_Chi
        AddHandler TxtTen_KH.Leave, AddressOf V_TxtTen_kh
        AddHandler txtDia_chi.Leave, AddressOf V_TxtDia_Chi

        RemoveHandler TxtMa_NH.CyberValiting, AddressOf V_Ma_Nh
        RemoveHandler TxtMa_NH.CyberLeave, AddressOf L_Ma_Nh
        AddHandler TxtMa_NH.CyberValiting, AddressOf V_Ma_Nh
        AddHandler TxtMa_NH.CyberLeave, AddressOf L_Ma_NH
        '--KH1
        RemoveHandler TxtNh_KH1.CyberValiting, AddressOf V_NH_KH1
        RemoveHandler TxtNh_KH1.CyberLeave, AddressOf L_NH_KH1
        AddHandler TxtNh_KH1.CyberValiting, AddressOf V_NH_KH1
        AddHandler TxtNh_KH1.CyberLeave, AddressOf L_NH_KH1
        '--KH2
        RemoveHandler TxtNh_KH2.CyberValiting, AddressOf V_NH_KH2
        RemoveHandler TxtNh_KH2.CyberLeave, AddressOf L_NH_KH2
        AddHandler TxtNh_KH2.CyberValiting, AddressOf V_NH_KH2
        AddHandler TxtNh_KH2.CyberLeave, AddressOf L_NH_KH2
        '--KH3
        RemoveHandler TxtNh_KH3.CyberValiting, AddressOf V_NH_KH3
        RemoveHandler TxtNh_KH3.CyberLeave, AddressOf L_NH_KH3
        AddHandler TxtNh_KH3.CyberValiting, AddressOf V_NH_KH3
        AddHandler TxtNh_KH3.CyberLeave, AddressOf L_NH_KH3
        '--KH4
        RemoveHandler TxtNh_KH4.CyberValiting, AddressOf V_NH_KH4
        RemoveHandler TxtNh_KH4.CyberLeave, AddressOf L_NH_KH4
        AddHandler TxtNh_KH4.CyberValiting, AddressOf V_NH_KH4
        AddHandler TxtNh_KH4.CyberLeave, AddressOf L_NH_KH4
        '--KH5
        RemoveHandler TxtNh_KH5.CyberValiting, AddressOf V_NH_KH5
        RemoveHandler TxtNh_KH5.CyberLeave, AddressOf L_NH_KH5
        AddHandler TxtNh_KH5.CyberValiting, AddressOf V_NH_KH5
        AddHandler TxtNh_KH5.CyberLeave, AddressOf L_NH_KH5

        '--TK
        RemoveHandler TxtTK.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTK.CyberLeave, AddressOf L_TK
        AddHandler TxtTK.CyberValiting, AddressOf V_TK
        AddHandler TxtTK.CyberLeave, AddressOf L_TK
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

#End Region
#Region "Valid"
#Region "Vali --- Ten_KH,Dia_Chi"
    Private Sub V_TxtTen_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtTen_khVAT.Text = IIf(txtTen_khVAT.Text.Trim = "", TxtTen_KH.Text, txtTen_khVAT.Text)
    End Sub
    Private Sub V_TxtDia_Chi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim = "", txtDia_chi.Text, TxtDia_ChiVAT.Text)
    End Sub
#End Region
#Region "Vali --- NH_KH1"
    Private Sub V_NH_KH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_KH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH2"
    Private Sub V_NH_KH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_KH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH3"
    Private Sub V_NH_KH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_KH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH4"
    Private Sub V_NH_KH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_KH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH5"
    Private Sub V_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTK.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTK.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then TxtTK.Text = DrReturn.Item("TK")
        If TxtTK.Text = "" Then Exit Sub
    End Sub
    Private Sub V_Ma_NH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_NH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTraGop", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_NH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NH.Text = DrReturn.Item("Ma_NH")
            Txtten_nh.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtMa_NH.Text = ""
            Txtten_nh.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Kh.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
