Imports System.Data.SqlClient
Public Class CRMDMCH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Ch.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "CRMDmNhCH", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Ch1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "CRMDmNhCH", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Ch2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "CRMDmNhCH", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Ch3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "CRMDmNhCH", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Ch4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "CRMDmNhCH", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Ch5.Text.Trim + "')", CyberSmlib)

        TxtTen_Loai.Text = CyberSmodb.SQLGetvalue(Appconn, "CrmTen_Loai", "CRMDmLoai", "CrmMa_Loai = N'" + Txtma_Loai.Text.Trim + "'", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Ch.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Ch.KeyPress, AddressOf TxtCodeError_KeyPress

        '--Ma_Loai
        RemoveHandler Txtma_Loai.CyberValiting, AddressOf V_ma_Loai
        RemoveHandler Txtma_Loai.CyberLeave, AddressOf L_Ma_Loai
        AddHandler Txtma_Loai.CyberValiting, AddressOf V_ma_Loai
        AddHandler Txtma_Loai.CyberLeave, AddressOf L_Ma_Loai

        '--BP1
        RemoveHandler TxtNh_Ch1.CyberValiting, AddressOf V_Nh_CH1
        RemoveHandler TxtNh_Ch1.CyberLeave, AddressOf L_Nh_CH1
        AddHandler TxtNh_Ch1.CyberValiting, AddressOf V_Nh_CH1
        AddHandler TxtNh_Ch1.CyberLeave, AddressOf L_Nh_CH1
        '--BP2
        RemoveHandler TxtNh_Ch2.CyberValiting, AddressOf V_Nh_CH2
        RemoveHandler TxtNh_Ch2.CyberLeave, AddressOf L_Nh_CH2
        AddHandler TxtNh_Ch2.CyberValiting, AddressOf V_Nh_CH2
        AddHandler TxtNh_Ch2.CyberLeave, AddressOf L_Nh_CH2
        '--BP3
        RemoveHandler TxtNh_Ch3.CyberValiting, AddressOf V_Nh_CH3
        RemoveHandler TxtNh_Ch3.CyberLeave, AddressOf L_Nh_CH3
        AddHandler TxtNh_Ch3.CyberValiting, AddressOf V_Nh_CH3
        AddHandler TxtNh_Ch3.CyberLeave, AddressOf L_Nh_CH3
        '--BP4
        RemoveHandler TxtNh_Ch4.CyberValiting, AddressOf V_Nh_CH4
        RemoveHandler TxtNh_Ch4.CyberLeave, AddressOf L_Nh_CH4
        AddHandler TxtNh_Ch4.CyberValiting, AddressOf V_Nh_CH4
        AddHandler TxtNh_Ch4.CyberLeave, AddressOf L_Nh_CH4
        '--BP5
        RemoveHandler TxtNh_Ch5.CyberValiting, AddressOf V_Nh_CH5
        RemoveHandler TxtNh_Ch5.CyberLeave, AddressOf L_Nh_CH5
        AddHandler TxtNh_Ch5.CyberValiting, AddressOf V_Nh_CH5
        AddHandler TxtNh_Ch5.CyberLeave, AddressOf L_Nh_CH5



    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- ma_Loai"
    Private Sub V_ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_Loai.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "CrmMa_Loai", "CRMDmLoai", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = Txtma_Loai.GetRowsSelectData(True)
        If Txtma_Loai.Text = "" Then
            TxtTen_Loai.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            Txtma_Loai.Text = DrReturn.Item("CrmMa_Loai")
            TxtTen_Loai.Text = DrReturn.Item("CrmTen_Loai")
        Else
            Txtma_Loai.Text = ""
            TxtTen_Loai.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CH1"
    Private Sub V_Nh_CH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ch1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "CRMDmNhCH", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_CH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Ch1.GetRowsSelectData(True)
        If TxtNh_Ch1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_Ch1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ch1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CH2"
    Private Sub V_Nh_CH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ch2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "CRMDmNhCH", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_CH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Ch2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Ch2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Ch2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ch2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CH3"
    Private Sub V_Nh_CH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ch3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "CRMDmNhCH", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_CH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not DrReturn Is Nothing Then TxtNh_Ch3.Text = DrReturn.Item("Ma_Nh")
        If TxtNh_Ch3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Ch3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Ch3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ch3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CH4"
    Private Sub V_Nh_CH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ch4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "CRMDmNhCH", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_CH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Ch4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Ch4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Ch4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ch4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CH5"
    Private Sub V_Nh_CH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Ch5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "CRMDmNhCH", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_CH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Ch5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Ch5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Ch5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Ch5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Ch.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
