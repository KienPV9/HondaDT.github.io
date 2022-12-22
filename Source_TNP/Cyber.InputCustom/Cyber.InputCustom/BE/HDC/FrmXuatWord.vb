Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class FrmXuatWord
    Public Property Mode() As String
        Get
            Mode = M_Mode
        End Get
        Set(ByVal Value As String)
            M_Mode = Value
        End Set
    End Property
    Public Property Ma_Dvcs() As String
        Get
            Ma_Dvcs = M_Ma_Dvcs
        End Get
        Set(ByVal Value As String)
            M_Ma_Dvcs = Value
        End Set
    End Property
    Public Property User_name() As String
        Get
            User_name = M_User_name
        End Get
        Set(ByVal Value As String)
            M_User_name = Value
        End Set
    End Property
    Dim M_Mode, M_Ma_Dvcs, M_User_name As String
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
    Private Sub FrmXuatWord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim ds As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetPrintVoucher", "HDX_Word" & "#" & M_Ma_Dvcs & "#" & M_User_name)
        DtMaIn = ds.Tables(0)

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
        If (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Stt_Rec = "" Then Exit Sub
        Dim _DsLoc As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_PrintHDX_Word", CbbMa_In.SelectedValue.ToString.Trim & "#" & Stt_Rec & "#" & M_User_name.ToString.Trim)
        If Not CyberSupport.V_MsgChk(_DsLoc.Tables(0), Sysvar, M_Lan) Then
            _DsLoc.Dispose()
            CyberSmlib.FlushMemorySave()
            Exit Sub
        End If
        Dim _File_Name As String = _DsLoc.Tables(0).Rows(0).Item("File_Name").ToString.Trim
        Dim _File_Path As String = _DsLoc.Tables(0).Rows(0).Item("File_Path").ToString.Trim
        Dim _Path_Help As String = Application.StartupPath.ToString.Trim & "\Help\"

        Dim K_Temp As String = Me.Para(1).ToString
        Dim _File_Name_Full As String = _Path_Help + _File_Name.Trim
        Dim isOpenW As Boolean = True
        If Not My.Computer.FileSystem.FileExists(_File_Name_Full) Then
            MsgBox("Không tồn tại tệp mẫu báo cáo, Bạn liên hệ với nhà cung cấp", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, osysvar("M_CYBER_VER"))
            _DsLoc.Dispose()
            CyberSmlib.FlushMemorySave()
            Exit Sub
        End If
        '------------------------------------------------------------------
        Dim CyberEport As New Cyber.Export.Sys
        Dim CyberLoading = New Cyber.Loading.Loading
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm("Đang thực hiện tạo hợp đồng", "Đang thực hiện tạo hợp đồng", Me.Lan)

        CyberEport.WordReplaceText(isOpenW, _Path_Help.Trim & _File_Name, _DsLoc.Tables(0).Rows(0).Item("FullWord_Saves").ToString.Trim, _DsLoc.Tables(1), osysvar, M_User_name)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        '------------------------------------------------------------------
        _DsLoc.Dispose()
        CyberSmlib.FlushMemorySave()
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
