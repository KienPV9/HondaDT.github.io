Public Class DMGIACV
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FSysList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_cv.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_ban.Value = Now.Date
        End If


        TxtTen_cv.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_cv", "Dmcv", "(Ma_cv = N'" + TxtMa_CV.Text.Trim + "')", CyberSmlib)
        TxtTen_ctcv.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_ctcv", "Dmctcv", "(Ma_ctcv = N'" + TxtMa_ctcv.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_VT
        RemoveHandler TxtMa_CV.CyberValiting, AddressOf V_Ma_cv
        RemoveHandler TxtMa_CV.CyberLeave, AddressOf L_Ma_cv
        AddHandler TxtMa_CV.CyberValiting, AddressOf V_Ma_cv
        AddHandler TxtMa_CV.CyberLeave, AddressOf L_Ma_cv

        '-Ma_Kho

        RemoveHandler TxtMa_ctcv.CyberValiting, AddressOf V_Ma_ctcv
        RemoveHandler TxtMa_ctcv.CyberLeave, AddressOf L_Ma_ctcv
        AddHandler TxtMa_ctcv.CyberValiting, AddressOf V_Ma_ctcv
        AddHandler TxtMa_ctcv.CyberLeave, AddressOf L_Ma_ctcv


        '--KH1

        '--KH2


    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Vt"
    Private Sub V_Ma_cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_CV.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_cv", "Dmcv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_CV.Text = "" Then
            TxtTen_cv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CV.Text = DrReturn.Item("Ma_cv")
            TxtTen_cv.Text = DrReturn.Item("Ten_cv")
        Else
            TxtMa_CV.Text = ""
            TxtTen_cv.Text = ""
        End If
    End Sub

    Private Sub V_Ma_ctcv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_ctcv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_ctcv", "Dmctcv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ctcv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_ctcv.Text = "" Then
            TxtTen_ctcv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_ctcv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ctcv.Text = DrReturn.Item("Ma_ctcv")
            TxtTen_ctcv.Text = DrReturn.Item("Ten_ctcv")
        Else
            TxtMa_ctcv.Text = ""
            TxtTen_ctcv.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_kho"

#End Region
#Region "Vali --- Ma_db"
    Private Sub V_Ma_db(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_CV.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_db", "Dmdb", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_db(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_CV.Text = "" Then
            TxtTen_cv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CV.Text = DrReturn.Item("Ma_db")
            TxtTen_cv.Text = DrReturn.Item("Ten_db")
        Else
            TxtMa_CV.Text = ""
            TxtTen_cv.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_ctcv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_ctcv.Text = "" Then
            TxtTen_ctcv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_ctcv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ctcv.Text = DrReturn.Item("Ma_KH")
            TxtTen_ctcv.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_ctcv.Text = ""
            TxtTen_ctcv.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH1"

#End Region
#Region "Vali --- NH_KH2"

#End Region



#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Txtgia2.Double = TxtGia_nt2.Double
        TxtGia3.Double = TxtGia_nt3.Double

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
