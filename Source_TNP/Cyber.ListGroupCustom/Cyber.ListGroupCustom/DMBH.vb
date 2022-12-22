Public Class DMBH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DtMuc As New DataTable
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTable()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_BH.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub CreateTable()
        DtMuc.Columns.Add("Ma_Muc")
        DtMuc.Columns.Add("Ten_Muc")
        DtMuc.Columns.Add("Ten_Muc2")
        DtMuc.Columns.Add("Default")


        DtMuc.Rows.Add("01", "Mức 1", "Leave 1", "1")
        DtMuc.Rows.Add("02", "Mức 2", "Leave 2", "0")
        DtMuc.Rows.Add("03", "Mức 3", "Leave 3", "0")
        DtMuc.Rows.Add("04", "Mức 4", "Leave 4", "0")
        DtMuc.Rows.Add("05", "Mức 5", "Leave 5", "0")
        DtMuc.Rows.Add("06", "Mức 6", "Leave 6", "0")
        DtMuc.Rows.Add("07", "Mức 7", "Leave 7", "0")
        DtMuc.Rows.Add("08", "Mức 8", "Leave 8", "0")
        DtMuc.Rows.Add("09", "Mức 9", "Leave 9", "0")
        DtMuc.Rows.Add("10", "Mức 10", "Leave 10", "0")
        CyberFill.V_FillComBoxDefaul(CmbMa_Muc, DtMuc, "ma_Muc", IIf(M_LAN = "V", "Ten_Muc", "Ten_Muc2"), "Default")

    End Sub

#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If TxtNh_Bh1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBH", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Bh1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Bh2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBH", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Bh2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Bh3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBH", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Bh3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Bh4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBH", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Bh4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Bh5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBH", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Bh5.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_BH.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_BH.KeyPress, AddressOf TxtCodeError_KeyPress
        '--BP1
        RemoveHandler TxtNh_Bh1.CyberValiting, AddressOf V_Nh_Bh1
        RemoveHandler TxtNh_Bh1.CyberLeave, AddressOf L_Nh_Bh1
        AddHandler TxtNh_Bh1.CyberValiting, AddressOf V_Nh_Bh1
        AddHandler TxtNh_Bh1.CyberLeave, AddressOf L_Nh_Bh1
        '--BP2
        RemoveHandler TxtNh_Bh2.CyberValiting, AddressOf V_Nh_Bh2
        RemoveHandler TxtNh_Bh2.CyberLeave, AddressOf L_Nh_Bh2
        AddHandler TxtNh_Bh2.CyberValiting, AddressOf V_Nh_Bh2
        AddHandler TxtNh_Bh2.CyberLeave, AddressOf L_Nh_Bh2
        '--BP3
        RemoveHandler TxtNh_Bh3.CyberValiting, AddressOf V_Nh_Bh3
        RemoveHandler TxtNh_Bh3.CyberLeave, AddressOf L_Nh_Bh3
        AddHandler TxtNh_Bh3.CyberValiting, AddressOf V_Nh_Bh3
        AddHandler TxtNh_Bh3.CyberLeave, AddressOf L_Nh_Bh3
        '--BP4
        RemoveHandler TxtNh_Bh4.CyberValiting, AddressOf V_Nh_Bh4
        RemoveHandler TxtNh_Bh4.CyberLeave, AddressOf L_Nh_Bh4
        AddHandler TxtNh_Bh4.CyberValiting, AddressOf V_Nh_Bh4
        AddHandler TxtNh_Bh4.CyberLeave, AddressOf L_Nh_Bh4
        '--BP5
        RemoveHandler TxtNh_Bh5.CyberValiting, AddressOf V_Nh_Bh5
        RemoveHandler TxtNh_Bh5.CyberLeave, AddressOf L_Nh_Bh5
        AddHandler TxtNh_Bh5.CyberValiting, AddressOf V_Nh_Bh5
        AddHandler TxtNh_Bh5.CyberLeave, AddressOf L_Nh_Bh5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_Bh1"
    Private Sub V_Nh_Bh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Bh1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBh", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Bh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Bh1.GetRowsSelectData(True)
        If TxtNh_Bh1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_Bh1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Bh1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh2"
    Private Sub V_Nh_Bh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Bh2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBh", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Bh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Bh2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Bh2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Bh2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Bh2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh3"
    Private Sub V_Nh_Bh3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Bh3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBh", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Bh3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not DrReturn Is Nothing Then TxtNh_Bh3.Text = DrReturn.Item("Ma_Nh")
        If TxtNh_Bh3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Bh3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Bh3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Bh3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh4"
    Private Sub V_Nh_Bh4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Bh4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBh", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Bh4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Bh4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Bh4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Bh4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Bh4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh5"
    Private Sub V_Nh_Bh5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Bh5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBh", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Bh5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Bh5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Bh5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Bh5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Bh5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_BH.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
