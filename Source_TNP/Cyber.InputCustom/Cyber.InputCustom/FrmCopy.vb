Public Class FrmCopy
    Dim CyberSmlib As New Cyber.SmLib.Sys
    Dim CyberSupport As New Cyber.Support.Sys
    Private Sub FrmCopy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RemoveHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        RemoveHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        RemoveHandler txtSo_ct.Enter, AddressOf V_So_Ct

        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler txtSo_ct.Enter, AddressOf V_So_Ct
    End Sub
#Region "Ngay ct, ngay lap chung tu,so chung tu"
    Private Sub V_Ngay_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub

        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher("M", txtSo_ct.Text, Me.Stt_Rec, _Ngay_Ct, _Ngay_LCt, DrDmct.Item("MA_CT"), Me.Ma_Dvcs, Me.Para(6).Trim, Me.SysApp, CyberSmlib)
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        'txtSo_ct.Text = CyberSupport.V_GetNoVoucher("M", txtSo_ct.Text, Me.Stt_Rec, _Ngay_Ct, _Ngay_LCt, DrDmct.Item("MA_CT"), Me.Ma_Dvcs, Me.Para(6).Trim, Me.SysApp, CyberSmlib)
    End Sub
    Private Sub V_So_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher("M", txtSo_ct.Text, Me.Stt_Rec, _Ngay_Ct, _Ngay_LCt, DrDmct.Item("MA_CT"), Me.Ma_Dvcs, Me.Para(6).Trim, Me.SysApp, CyberSmlib)
    End Sub
#End Region
End Class
