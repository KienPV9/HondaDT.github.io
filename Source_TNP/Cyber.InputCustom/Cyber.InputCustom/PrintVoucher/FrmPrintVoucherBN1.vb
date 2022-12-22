Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class FrmPrintVoucherUNC
    Dim CyberSmlib As New Cyber.SmLib.Sys
    Dim CyberSmodb As New Cyber.Smodb.Sys
    Dim CyberSupport As New Cyber.Support.Sys
    Dim CyberFill As New Cyber.Fill.Sys
    Dim CyberLists As New Cyber.SmLists.Sys
    Dim DrReturn As DataRow
    Dim M_Lan As String
    Dim M_Para As String()
    Dim osysvar As Collection
    Dim M_Appconn As SqlConnection
    Dim M_DrDmCt As DataRow
    Dim M_Stt_Rec As String = ""
    Private Sub FrmPrintVoucherUNC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Stt_Rec = Me.Stt_Rec
        V_Load()
        RemoveHandler CmdPrint.Click, AddressOf V_Print
        RemoveHandler CmdPriview.Click, AddressOf V_Preview
        RemoveHandler CmdModify.Click, AddressOf V_Modify

        AddHandler CmdPrint.Click, AddressOf V_Print
        AddHandler CmdPriview.Click, AddressOf V_Preview
        AddHandler CmdModify.Click, AddressOf V_Modify
        AddHandler CbbMa_In.SelectedValueChanged, AddressOf V_Ma_In

    End Sub
    Private Sub V_Load()
        M_Lan = Me.Lan
        M_Para = Me.Para
        osysvar = Me.Sysvar
        M_Appconn = Me.AppConn
        M_DrDmCt = Me.DrDmct
        txtTitle1.Text = M_DrDmCt.Item("Tieu_De_Ct").ToString.ToUpper
        txtTitle2.Text = M_DrDmCt.Item("Tieu_De2").ToString.ToUpper
        CyberFill.V_FillComBoxDefaul(CbbMa_In, DtMaIn, "Ma_In", IIf(Me.Lan = "V", "ten_IN", "ten_IN2"), "Ngam_Dinh")
        CyberSmodb.GetValueToControler(Me)
        '---
        CyberSupport.Translaste(Me, Me.Lan, True)
        Me.Loai_In = "Preview"
        Me.ReturnOk = False
        Me.Tag_Field = ""
        Me.Tag_Value = ""
        V_LoadTTUNC()
    End Sub
    Private Sub V_LoadTTUNC()
        Dim tb_Print As DataTable
        Dim ds_Print As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_PrintBN1GetorSaveDefault", _
        M_Stt_Rec.Trim + "#" + TxtMa_kh.Text.Trim + "#" + TxtTK.Text.Trim + "#" + TxtTk_NH1.Text.Trim + "#" + _
        TxtTk_NH2.Text.Trim + "#" + TxtTen_kh.Text.Trim + "#" + TxtTP1.Text.Trim + "#" + TxtTP2.Text.Trim + "#" + _
        TxtTen_NH1.Text.Trim + "#" + TxtTen_NH2.Text.Trim + "#" + TxtNoi_Dung.Text.Trim + "#" + "1")
        tb_Print = ds_Print.Tables(0)

        If tb_Print.Rows.Count > 0 Then
            TxtTen_kh.Text = tb_Print.Rows(0).Item("Ten_Kh").ToString.Trim
            TxtTen_NH1.Text = tb_Print.Rows(0).Item("Ten_NH1").ToString.Trim
            TxtTen_NH2.Text = tb_Print.Rows(0).Item("Ten_NH2").ToString.Trim
            TxtTk_NH1.Text = tb_Print.Rows(0).Item("TK_NH1").ToString.Trim
            TxtTk_NH2.Text = tb_Print.Rows(0).Item("TK_NH2").ToString.Trim
            TxtTP1.Text = tb_Print.Rows(0).Item("TP1").ToString.Trim
            TxtTP2.Text = tb_Print.Rows(0).Item("TP2").ToString.Trim
            TxtNoi_Dung.Text = tb_Print.Rows(0).Item("Noi_Dung").ToString.Trim
        End If
    End Sub
    Private Sub V_Save()
        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_PrintBN1GetorSaveDefault", _
        M_Stt_Rec.Trim + "#" + TxtMa_kh.Text.Trim + "#" + TxtTK.Text.Trim + "#" + TxtTk_NH1.Text.Trim + "#" + _
        TxtTk_NH2.Text.Trim + "#" + TxtTen_kh.Text.Trim + "#" + TxtTP1.Text.Trim + "#" + TxtTP2.Text.Trim + "#" + _
        TxtTen_NH1.Text.Trim + "#" + TxtTen_NH2.Text.Trim + "#" + TxtNoi_Dung.Text.Trim + "#" + "2")
    End Sub
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.Lan = "V", "Xem & In", "Priview"), AddressOf V_Preview, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.Lan = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
    Private Sub V_Print(ByVal _Status)
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""

        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        Me.Title1 = txtTitle1.Text
        Me.Title2 = txtTitle2.Text
        Me.Ma_In = CbbMa_In.SelectedValue
        Me.Loai_In = _Status
        Me.So_Ct = TxtSo_Ct_Goc.Text
        Me.So_Lien = TxtSo_lien.Double
        Me.ReturnOk = True
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
    End Sub
    Private Sub V_Ma_In(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim So_lien As Integer = 1
        Dim So_Ct_goc As String = ""
        For Each dr As DataRow In DtMaIn.Rows
            If dr("Ma_In") = CbbMa_In.SelectedValue Then
                If DtMaIn.Columns.Contains("So_Lien") Then So_lien = dr("So_Lien")
                If DtMaIn.Columns.Contains("So_Ct_goc") Then So_Ct_goc = dr("So_Ct_goc")
                Exit For
            End If
        Next
        TxtSo_lien.Text = So_lien
        TxtSo_Ct_Goc.Text = So_Ct_goc
    End Sub
    Private Sub V_Preview(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Save()
        V_Print("PREVIEW")
        Me.Close()
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Save()
        V_Print("PRINT")
        Me.Close()
    End Sub
    Private Sub V_Modify(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Print("MODI")
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ReturnOk = False
        Me.Close()
    End Sub

End Class
