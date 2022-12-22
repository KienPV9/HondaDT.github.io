Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class FrmPrintVoucher
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
    Private Sub FrmPrintVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        RemoveHandler CmdPrint.Click, AddressOf V_Print
        RemoveHandler CmdPriview.Click, AddressOf V_Preview
        RemoveHandler CmdModify.Click, AddressOf V_Modify

        AddHandler CmdPrint.Click, AddressOf V_Print
        AddHandler CmdPriview.Click, AddressOf V_Preview
        AddHandler CmdModify.Click, AddressOf V_Modify
        AddHandler CbbMa_In.SelectedValueChanged, AddressOf V_Ma_In
        V_Ma_In(Nothing, Nothing)
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
    Private Sub V_Preview(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Print("PREVIEW")
        Me.Close()
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
End Class
