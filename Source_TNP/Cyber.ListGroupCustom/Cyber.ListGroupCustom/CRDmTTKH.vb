Public Class CRDmTTKH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub FDMPOST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()

        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_TTKH.Focus()
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        TxtBackgroundcolor.ReadOnly = True
        TxtForceColor.ReadOnly = True
        TxtBackcolor_Test.ReadOnly = True
        TxtBackcolor2_Test.ReadOnly = True

        TxtBackgroundcolor.BackColor = Drawing.Color.White
        TxtForceColor.BackColor = Drawing.Color.White
        TxtBackcolor_Test.BackColor = Drawing.Color.White
        TxtBackcolor2_Test.BackColor = Drawing.Color.White

        TxtBackcolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackgroundcolor.Text)
        TxtBackcolor2_Test.BackColor = CyberColor.GetBacColorkReports(TxtForceColor.Text)
    End Sub
    Private Sub V_Color(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtBackgroundcolor.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtBackcolor_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Color2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtForceColor.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtBackcolor2_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Clear(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtBackgroundcolor.Text = ""
        TxtBackcolor_Test.BackColor = Drawing.Color.White
    End Sub
    Private Sub V_Clear2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtForceColor.Text = ""
        TxtBackcolor2_Test.BackColor = Drawing.Color.White
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        'TxtTen_CT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_CT", "DmCT", "(Ma_CT = N'" + TxtMa_CT.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_TTKH.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_TTKH.KeyPress, AddressOf TxtCodeError_KeyPress

        '--ma_Ct
        RemoveHandler ButtColor.Click, AddressOf V_Color
        RemoveHandler ButtColor2.Click, AddressOf V_Color2

        RemoveHandler ButtClear.Click, AddressOf V_Clear
        RemoveHandler ButtClear2.Click, AddressOf V_Clear2

        AddHandler ButtColor.Click, AddressOf V_Color
        AddHandler ButtColor2.Click, AddressOf V_Color2

        AddHandler ButtClear.Click, AddressOf V_Clear
        AddHandler ButtClear2.Click, AddressOf V_Clear2

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

    Private Sub TxtTen_Post2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTen_TTKH2.TextChanged

    End Sub
End Class
