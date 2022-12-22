Public Class DMHHGD
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtTen_GDV)
        TxtTen_GDV.Focus()

        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        'If TxtMa_Chitieu.Text.Trim = "" Then cmbMa_nhom.Text = "" Else cmbMa_nhom.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_ND", "DmKPINS", "(Ma_Chitieu = N'" + TxtMa_Chitieu.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        'CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        'V_LoadNam()
    End Sub
    'Private Sub V_LoadNam()
    '    Dim tbNam As DataTable
    '    Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_LoadDVCS", M_Ma_Dvcs & "#" & M_User_Name)
    '    tbNam = DsTmp.Tables(0).Copy
    '    CyberFill.V_FillComBoxDefaul(Me.cbbMa_dvcs, tbNam, "Ma_DVCS", "Ten_DVCS", "ngam_dinh")

    'End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        'RemoveHandler TxtMa_may.KeyPress, AddressOf TxtCodeError_KeyPress
        'AddHandler TxtMa_may.KeyPress, AddressOf TxtCodeError_KeyPress

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        'If Not _Value.Trim = "" Then TxtMa_may.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub


#End Region
End Class
