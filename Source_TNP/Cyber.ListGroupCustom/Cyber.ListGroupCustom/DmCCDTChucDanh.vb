Public Class DMCCDTChucDanh
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, Nothing)
        TxtMa_chucdanh.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtMa_chucdanh.Text.Trim = "" Then TxtTen_chucdanh.Text = "" Else TxtTen_chucdanh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Chucdanh", "Dmchucdanh", "(Ma_chucdanh = N'" + TxtMa_chucdanh.Text.Trim + "')", CyberSmlib)
        If TxtMa_ccdt.Text.Trim = "" Then TxtTen_ccdt.Text = "" Else TxtTen_ccdt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_ccdt", "Dmccdt", "(Ma_ccdt = N'" + TxtMa_ccdt.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        AddHandler TxtMa_chucdanh.CyberValiting, AddressOf V_Ma_chucdanh
        AddHandler TxtMa_chucdanh.CyberLeave, AddressOf L_Ma_chucdanh

        AddHandler TxtMa_ccdt.CyberValiting, AddressOf V_Ma_ccdt
        AddHandler TxtMa_ccdt.CyberLeave, AddressOf L_Ma_ccdt


    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
    Private Sub V_Ma_chucdanh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_chucdanh", "Dmchucdanh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_chucdanh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_chucdanh.Text = DrReturn.Item("Ma_chucdanh")
            TxtTen_chucdanh.Text = DrReturn.Item("Ten_chucdanh")

        Else
            TxtMa_chucdanh.Text = ""
            TxtTen_chucdanh.Text = ""

        End If
    End Sub
    Private Sub V_Ma_ccdt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_ccdt", "Dmccdt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ccdt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ccdt.Text = DrReturn.Item("Ma_ccdt")
            TxtTen_ccdt.Text = DrReturn.Item("Ten_ccdt")

        Else
            TxtMa_ccdt.Text = ""
            TxtTen_ccdt.Text = ""

        End If
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_chucdanh.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub


#End Region
End Class
