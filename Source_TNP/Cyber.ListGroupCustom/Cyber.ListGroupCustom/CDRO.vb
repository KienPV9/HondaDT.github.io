Public Class CDRO
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim So_Dau_Nam As Boolean = True
    Dim Dt_DmStt As DataTable
    Private Sub CDRO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        'TxtMa_NT.Properties.ReadOnly = True
        TxtTK.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNam.Text = Year(Date.Now)
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtMa_Dvcs.Text.Trim = "" Then Txtten_DVCS.Text = "" Else Txtten_DVCS.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)
        If TxtTK.Text.Trim = "" Then TxtTen_TK.Text = "" Else TxtTen_TK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(TK0 = N'" + TxtTK.Text.Trim + "')", CyberSmlib)
        If TxtMa_KH.Text.Trim = "" Then TxtTen_KH.Text = "" Else TxtTen_KH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(ma_kh = N'" + TxtMa_KH.Text.Trim + "')", CyberSmlib)
        'If Not TxtTK.Text.Trim = "" Then TxtMa_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_NT", "DmTK", "(TK = N'" + TxtTK.Text.Trim + "')", CyberSmlib)
        'If TxtMa_Nt.Text.Trim = "" Then Txtten_Nt.Text = "" Else Txtten_Nt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nt", "DmNt", "(Ma_Nt = N'" + TxtMa_Nt.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        Dim _DsDmStt As New DataSet
        Dt_DmStt = CyberSmodb.OpenTableKey(Appconn, _DsDmStt, "DmStt", "", "", CyberSmlib)
        _DsDmStt = Nothing
        _DsDmStt = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_Ngay_DauThang", "1#" + TxtNam.Text)
        Dim _Dt_Ngay_Dau_Thang As Date = _DsDmStt.Tables(0).Rows(0).Item("Ngay_Dau_Thang")
        Dim _Dt_DN As Date = Dt_DmStt.Rows(0).Item("Ngay_DN")

        If _Dt_Ngay_Dau_Thang.Day <> _Dt_DN.Day Or _Dt_Ngay_Dau_Thang.Month <> _Dt_DN.Month Then So_Dau_Nam = False Else So_Dau_Nam = True

        TxtDu_Co1.ReadOnly = So_Dau_Nam
        TxtDu_Co_nt1.ReadOnly = So_Dau_Nam
        TxtDu_No1.ReadOnly = So_Dau_Nam
        TxtDu_No_nt1.ReadOnly = So_Dau_Nam
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--TK
        RemoveHandler TxtTK.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTK.CyberLeave, AddressOf L_TK
        AddHandler TxtTK.CyberValiting, AddressOf V_TK
        AddHandler TxtTK.CyberLeave, AddressOf L_TK
        '---
        RemoveHandler TxtDu_no00.Leave, AddressOf V_L_Du_No00
        RemoveHandler TxtDu_No_NT00.Leave, AddressOf V_L_Du_No_NT00
        AddHandler TxtDu_no00.Leave, AddressOf V_L_Du_No00
        AddHandler TxtDu_No_NT00.Leave, AddressOf V_L_Du_No_NT00
        '---
        RemoveHandler TxtDu_Co00.Leave, AddressOf V_L_Du_Co00
        RemoveHandler TxtDu_Co_NT00.Leave, AddressOf V_L_Du_Co_NT00
        AddHandler TxtDu_Co00.Leave, AddressOf V_L_Du_Co00
        AddHandler TxtDu_Co_NT00.Leave, AddressOf V_L_Du_Co_NT00
        '---
        RemoveHandler TxtDu_No1.Leave, AddressOf V_L_Du_No1
        RemoveHandler TxtDu_No_nt1.Leave, AddressOf V_L_Du_No_NT1
        AddHandler TxtDu_No1.Leave, AddressOf V_L_Du_No1
        AddHandler TxtDu_No_nt1.Leave, AddressOf V_L_Du_No_NT1
        '---
        RemoveHandler TxtDu_Co1.Leave, AddressOf V_L_Du_Co1
        RemoveHandler TxtDu_Co_nt1.Leave, AddressOf V_L_Du_Co_NT1
        AddHandler TxtDu_Co1.Leave, AddressOf V_L_Du_Co1
        AddHandler TxtDu_Co_nt1.Leave, AddressOf V_L_Du_Co_NT1

        AddHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
    Private Sub V_L_Du_No00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtDu_no00.Double <> 0 Then
            TxtDu_Co00.Double = 0
            TxtDu_Co_NT00.Double = 0
            If So_Dau_Nam Then TxtDu_Co1.Double = 0
            If So_Dau_Nam Then TxtDu_Co_nt1.Double = 0
        End If
        'If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
        '    TxtDu_No_NT00.Double = TxtDu_no00.Double
        'End If
        If So_Dau_Nam Then TxtDu_No1.Double = TxtDu_no00.Double
        If So_Dau_Nam Then TxtDu_No_nt1.Double = TxtDu_No_NT00.Double
    End Sub
    Private Sub V_L_Du_No_NT00(ByVal sender As Object, ByVal e As System.EventArgs)
        'If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
        '    TxtDu_No_NT00.Double = TxtDu_no00.Double
        'End If

        If TxtDu_No_NT00.Double <> 0 Then TxtDu_Co_NT00.Double = 0
        If So_Dau_Nam Then TxtDu_No_nt1.Double = TxtDu_No_NT00.Double
        If So_Dau_Nam Then TxtDu_Co_nt1.Double = TxtDu_Co_NT00.Double
    End Sub
    '-----------------------------------------------------------------------------
    Private Sub V_L_Du_Co00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtDu_Co00.Double <> 0 Then
            TxtDu_no00.Double = 0
            TxtDu_No_NT00.Double = 0
            If So_Dau_Nam Then TxtDu_No1.Double = 0
            If So_Dau_Nam Then TxtDu_No_nt1.Double = 0
        End If
        'If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
        '    TxtDu_Co_NT00.Double = TxtDu_Co00.Double
        'End If
        If So_Dau_Nam Then TxtDu_Co1.Double = TxtDu_Co00.Double
        If So_Dau_Nam Then TxtDu_Co_nt1.Double = TxtDu_Co_NT00.Double
    End Sub
    Private Sub V_L_Du_Co_NT00(ByVal sender As Object, ByVal e As System.EventArgs)
        'If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
        '    TxtDu_Co_NT00.Double = TxtDu_Co00.Double
        'End If
        If TxtDu_Co_NT00.Double <> 0 Then TxtDu_No_NT00.Double = 0
        If So_Dau_Nam Then TxtDu_No_nt1.Double = TxtDu_No_NT00.Double
        If So_Dau_Nam Then TxtDu_Co_nt1.Double = TxtDu_Co_NT00.Double
    End Sub
    '-----------------------------------------------------------------------------
    Private Sub V_L_Du_No1(ByVal sender As Object, ByVal e As System.EventArgs)
        If So_Dau_Nam Then TxtDu_No1.Double = TxtDu_no00.Double
    End Sub
    Private Sub V_L_Du_No_NT1(ByVal sender As Object, ByVal e As System.EventArgs)
        If So_Dau_Nam Then TxtDu_No_nt1.Double = TxtDu_No_NT00.Double
    End Sub
    '-----------------------------------------------------------------------------
    Private Sub V_L_Du_Co1(ByVal sender As Object, ByVal e As System.EventArgs)
        If So_Dau_Nam Then TxtDu_Co1.Double = TxtDu_Co00.Double
    End Sub
    Private Sub V_L_Du_Co_NT1(ByVal sender As Object, ByVal e As System.EventArgs)
        If So_Dau_Nam Then TxtDu_Co_nt1.Double = TxtDu_Co_NT00.Double
    End Sub
#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTK.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTK.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK.Text = DrReturn.Item("TK")
            TxtTen_TK.Text = DrReturn.Item("Ten_TK")
            'TxtMa_NT.Text = DrReturn.Item("Ma_NT")
            'If TxtMa_Nt.Text.Trim = "" Then Txtten_Nt.Text = "" Else Txtten_Nt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nt", "DmNt", "(Ma_Nt = N'" + TxtMa_Nt.Text.Trim + "')", CyberSmlib)
            'V_Reset()
        Else
            TxtTK.Text = ""
            TxtTen_TK.Text = ""
            'TxtMa_NT.Text = ""
            'TxtTen_NT.Text = ""
        End If
    End Sub
    Private Sub V_Reset()
        'If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
        '    TxtDu_No_NT00.Double = TxtDu_no00.Double
        '    TxtDu_Co_NT00.Double = TxtDu_Co00.Double
        '    TxtDu_No_nt1.Double = TxtDu_No1.Double
        '    TxtDu_Co_nt1.Double = TxtDu_Co1.Double

        '    TxtDu_No_NT00.InputMask = TxtDu_no00.InputMask.ToString.Trim
        '    TxtDu_Co_NT00.InputMask = TxtDu_Co00.InputMask.ToString.Trim
        '    TxtDu_No_nt1.InputMask = TxtDu_No1.InputMask.ToString.Trim
        '    TxtDu_Co_nt1.InputMask = TxtDu_Co1.InputMask.ToString.Trim
        'Else
        '    TxtDu_No_NT00.InputMask = TxtDu_No_NT00.Tag.ToString.Trim
        '    TxtDu_Co_NT00.InputMask = TxtDu_Co_NT00.Tag.ToString.Trim
        '    TxtDu_No_nt1.InputMask = TxtDu_No_nt1.Tag.ToString.Trim
        '    TxtDu_Co_nt1.InputMask = TxtDu_Co_nt1.Tag.ToString.Trim
        'End If
        'TxtDu_No_NT00.Refresh()
        'TxtDu_Co_NT00.Refresh()
        'TxtDu_No_nt1.Refresh()
        'TxtDu_Co_nt1.Refresh()
    End Sub
#End Region
#Region "KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH.Text = DrReturn.Item("Ma_KH")
            TxtTen_KH.Text = DrReturn.Item("Ten_KH")
           
        Else
            TxtMa_KH.Text = ""
            TxtTen_KH.Text = ""
          
        End If
        If TxtMa_KH.Text = "" Then
            TxtMa_KH.Text = ""
            TxtTen_KH.Text = ""
        End If


    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

    
End Class
