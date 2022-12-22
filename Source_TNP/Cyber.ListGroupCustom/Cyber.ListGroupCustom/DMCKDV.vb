Public Class DMCKDV
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub CK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa)
        TxtMa.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        V_LoadThangNam()
        TxtNgay_Ct.Value = Now.Date
    End Sub
    Private Sub V_LoadThangNam()

        'CBBMa_Dvcs.SelectedValue = M_Ma_DVCS
        Dim Nam, Thang As DataTable
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_Loadnam", "")
        Nam = DsTmp.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.cmdnam, Nam, "Ma_nam", "ten_nam", "")
        Thang = DsTmp.Tables(1).Copy
        CyberFill.V_FillComBoxValue(Me.CmdThang, Thang, "Ma_Thang", "ten_thang", "")
        'Thang = DsTmp.Tables(1).Copy
        'CyberFill.V_FillComBoxDefaul(Me.cmbThang, Thang, "Ma_Thang", "Ten_Thang", "")
        'cmbThang.Text = Month(Now.Date)
        cmdnam.Text = Year(Now.Date)
        CmdThang.Text = Month(Now.Date)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa.KeyPress, AddressOf TxtCodeError_KeyPress



    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub


#End Region
End Class
