Public Class CDTK30
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim So_Dau_Nam As Boolean = True
    Dim Dt_DmStt, Dt_No_Co As DataTable

    Private Sub CDTK30_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CreateTabe()
        txtNgay_Ct.Value = Now.Date
        TxtNgay_DK.Value = Now.Date

        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Ct.ReadOnly = True
        txtNgay_Ct.Focus()
    End Sub
    Private Sub CreateTabe()
        Dt_No_Co = New DataTable
        Dt_No_Co.Columns.Add("Ma", GetType(String))
        Dt_No_Co.Columns.Add("Ten", GetType(String))
        Dt_No_Co.Columns.Add("Ten2", GetType(String))
        Dt_No_Co.Rows.Add("0", "Dư nợ", "")
        Dt_No_Co.Rows.Add("1", "Dư có", "")
        CyberFill.V_FillComBoxValue(Me.CbbNo_Co, Dt_No_Co, "Ma", "Ten", "0")
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        TxtMa_Ct.Text = "HD0"
        TxtNam.Text = Me.Key_Nam.ToString
        Txtten_Ct.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Ct", "DmCt", "(ma_Ct = N'" + TxtMa_Ct.Text.Trim + "')", CyberSmlib)
        If TxtTen_TK.Text.Trim = "" Then TxtTen_TK.Text = "" Else TxtTen_TK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(TK = N'" + TxtTK.Text.Trim + "')", CyberSmlib)

        TxtMa_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_NT", "DmTK", "(TK= N'" + TxtTK.Text.Trim + "')", CyberSmlib)

        If TxtMa_NT.Text.Trim = "" Then TxtTen_NT.Text = "" Else TxtTen_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nt", "DmNt", "(Ma_Nt = N'" + TxtMa_NT.Text.Trim + "')", CyberSmlib)
        If TxtMa_kh.Text.Trim.Trim = "" Then TxtTen_kh.Text = "" Else TxtTen_kh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(Ma_kh = N'" + TxtMa_kh.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtMa_Dvcs.Text.Trim = "" Then TxtTen_Dvcs.Text = "" Else TxtTen_Dvcs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then txtNgay_Ct.Value = Now.Date
        If Me.Mode = "M" Then TxtNgay_DK.Value = Now.Date

        If Me.Mode = "M" Then TxtMa_NT.Text = "VND"
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Ma_KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_MA_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_MA_KH
        '--TK
        AddHandler TxtTK.CyberValiting, AddressOf V_TK
        AddHandler TxtTK.CyberLeave, AddressOf L_TK
        '---
        AddHandler TxtMa_NT.CyberValiting, AddressOf V_MA_NT
        AddHandler TxtMa_NT.CyberLeave, AddressOf L_Ma_NT

        AddHandler TxtT_Tien_NT.Leave, AddressOf L_Tinh_Toan
        AddHandler TxtT_Tien.Leave, AddressOf L_Tinh_Toan

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtT_Tien.Double = TxtT_Tien_NT.Double
        End If
    End Sub
#End Region
#Region "Vali --- KH"
    Private Sub V_MA_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kh.Text = DrReturn.Item("Ma_kh")
            TxtTen_kh.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_kh.Text = ""
            TxtTen_kh.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "tk", "DmtkCN", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK.Text = DrReturn.Item("tk")
            TxtTen_TK.Text = DrReturn.Item("Ten_tk")
        Else
            TxtTK.Text = ""
            TxtTen_TK.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NT"
    Private Sub V_MA_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_nt", "Dmnt", "1=1", "1=1")
        L_Tinh_Toan(sender, e)
    End Sub
    Private Sub L_Ma_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
            TxtTen_NT.Text = DrReturn.Item("Ten_nt")
        Else
            TxtMa_NT.Text = ""
            TxtTen_NT.Text = ""
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        L_Tinh_Toan(sender, e)
        ' Kiem tra co nhap tai khoan cong no khong
        If CyberSmodb.SQLGetvalue(Appconn, "TK_CN", "DMTK", "TK = N'" + Me.TxtTK.Text.Trim + "'").ToString.Trim <> "1" Then
            MsgBox(IIf(M_LAN = "V", "Không phải là tài khoản công nợ bạn phải nhập ở số dư các tài khoản!", "Not a debt account you must enter the account in balance"), MsgBoxStyle.OkOnly, oSysvar("M_CYBER_VER"))
            Me.TxtTK.Focus()
            Exit Sub
        End If
        If Me.Mode = "M" Then TxtMa_Ct.Text = "HD0"
        If Me.Mode = "M" Then TxtStt_Rec.Text = Get_Stt_Rec(TxtMa_Ct.Text)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
    Private Function Get_Stt_Rec(ByVal M_Ma_Ct As String) As String
        Dim _Return As String = ""
        Dim Dstmp As New DataSet
        Dstmp = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetSttRecCD", TxtMa_Ct.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        _Return = Dstmp.Tables(0).Rows(0).Item("Stt_Rec").ToString.Trim()
        Get_Stt_Rec = _Return
        Dstmp.Dispose()
    End Function
#End Region
End Class