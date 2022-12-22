Imports System.Data.SqlClient
Public Class DMKX
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Tbma_hang, TbKieu_Dang As DataTable
    Private vTbma_hang, vTbKieu_Dang As DataView
    Private Sub DmKX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_LoadMa_hang()
        V_LoadKieu_Dang()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_KX.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If TxtNh_Kx1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKX", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Kx1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kx2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKX", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Kx2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kx3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKX", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Kx3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kx4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKX", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Kx4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kx5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKX", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Kx5.Text.Trim + "')", CyberSmlib)
        If TxtMa_Kho.Text.Trim = "" Then TxtTen_KHO.Text = "" Else TxtTen_KHO.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmlib)

        If TxtTk_VT.Text.Trim = "" Then TxtTen_Tk_VT.Text = "" Else TxtTen_Tk_VT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_VT.Text.Trim + "')", CyberSmlib)
        If TxtTk_GV.Text.Trim = "" Then TxtTen_TK_GV.Text = "" Else TxtTen_TK_GV.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_GV.Text.Trim + "')", CyberSmlib)
        If TxtTk_DT.Text.Trim = "" Then TxtTen_TK_DT.Text = "" Else TxtTen_TK_DT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_DT.Text.Trim + "')", CyberSmlib)
        If TxtTk_TL.Text.Trim = "" Then TxtTen_TK_TL.Text = "" Else TxtTen_TK_TL.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_TL.Text.Trim + "')", CyberSmlib)
        If TxtTk_Ck.Text.Trim = "" Then TxtTen_TK_CK.Text = "" Else TxtTen_TK_CK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTk_Ck.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Me.Mode = "M" Then ChkIs_KD.Checked = False

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_KX.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_KX.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Ma_KHO
        RemoveHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        RemoveHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_Kho
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_Kho

        '--BP1
        RemoveHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_KX1
        RemoveHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_KX1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_KX1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_KX1
        '--BP2
        RemoveHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_KX2
        RemoveHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_KX2
        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_KX2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_KX2
        '--BP3
        RemoveHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_KX3
        RemoveHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_KX3
        AddHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_KX3
        AddHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_KX3
        '--BP4
        RemoveHandler TxtNh_Kx4.CyberValiting, AddressOf V_Nh_KX4
        RemoveHandler TxtNh_Kx4.CyberLeave, AddressOf L_Nh_KX4
        AddHandler TxtNh_Kx4.CyberValiting, AddressOf V_Nh_KX4
        AddHandler TxtNh_Kx4.CyberLeave, AddressOf L_Nh_KX4
        '--BP5
        RemoveHandler TxtNh_Kx5.CyberValiting, AddressOf V_Nh_KX5
        RemoveHandler TxtNh_Kx5.CyberLeave, AddressOf L_Nh_KX5
        AddHandler TxtNh_Kx5.CyberValiting, AddressOf V_Nh_KX5
        AddHandler TxtNh_Kx5.CyberLeave, AddressOf L_Nh_KX5

        '--Tk_VT
        RemoveHandler TxtTk_VT.CyberValiting, AddressOf V_Tk_VT
        RemoveHandler TxtTk_VT.CyberLeave, AddressOf L_Tk_VT
        AddHandler TxtTk_VT.CyberValiting, AddressOf V_Tk_VT
        AddHandler TxtTk_VT.CyberLeave, AddressOf L_Tk_VT
        '--Tk_GV
        RemoveHandler TxtTk_GV.CyberValiting, AddressOf V_Tk_GV
        RemoveHandler TxtTk_GV.CyberLeave, AddressOf L_Tk_GV
        AddHandler TxtTk_GV.CyberValiting, AddressOf V_Tk_GV
        AddHandler TxtTk_GV.CyberLeave, AddressOf L_Tk_GV
        '--Tk_DT
        RemoveHandler TxtTk_DT.CyberValiting, AddressOf V_Tk_DT
        RemoveHandler TxtTk_DT.CyberLeave, AddressOf L_Tk_DT
        AddHandler TxtTk_DT.CyberValiting, AddressOf V_Tk_DT
        AddHandler TxtTk_DT.CyberLeave, AddressOf L_Tk_DT
       
        '--Tk_TL
        RemoveHandler TxtTk_TL.CyberValiting, AddressOf V_Tk_TL
        RemoveHandler TxtTk_TL.CyberLeave, AddressOf L_Tk_TL
        AddHandler TxtTk_TL.CyberValiting, AddressOf V_Tk_TL
        AddHandler TxtTk_TL.CyberLeave, AddressOf L_Tk_TL
        '--Tk_CK
        RemoveHandler TxtTk_Ck.CyberValiting, AddressOf V_Tk_CK
        RemoveHandler TxtTk_Ck.CyberLeave, AddressOf L_Tk_CK
        AddHandler TxtTk_Ck.CyberValiting, AddressOf V_Tk_CK
        AddHandler TxtTk_Ck.CyberLeave, AddressOf L_Tk_CK

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Kho"
    Private Sub V_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kho.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kho.Text = "" Then
            TxtTen_KHO.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_KHO.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_KHO.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_KX1"
    Private Sub V_Nh_KX1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_KX1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If TxtNh_Kx1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_KX2"
    Private Sub V_Nh_KX2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_KX2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_KX3"
    Private Sub V_Nh_KX3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_KX3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_KX4"
    Private Sub V_Nh_KX4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_KX4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_KX5"
    Private Sub V_Nh_KX5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_KX5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Kx5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_VT"
    Private Sub V_Tk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_VT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_VT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_VT.Text = "" Then
            TxtTen_Tk_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_VT.Text = DrReturn.Item("TK")
            TxtTen_Tk_VT.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_VT.Text = ""
            TxtTen_Tk_VT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_GV"
    Private Sub V_Tk_GV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_GV.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_GV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_GV.Text = "" Then
            TxtTen_TK_GV.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_GV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_GV.Text = DrReturn.Item("TK")
            TxtTen_TK_GV.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_GV.Text = ""
            TxtTen_TK_GV.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_DT"
    Private Sub V_Tk_DT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_DT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_DT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_DT.Text = "" Then
            TxtTen_TK_DT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_DT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_DT.Text = DrReturn.Item("TK")
            TxtTen_TK_DT.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_DT.Text = ""
            TxtTen_TK_DT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_TL"
    Private Sub V_Tk_TL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_TL.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_TL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_TL.Text = "" Then
            TxtTen_TK_TL.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_TL.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_TL.Text = DrReturn.Item("TK")
            TxtTen_TK_TL.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_TL.Text = ""
            TxtTen_TK_TL.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CK"
    Private Sub V_Tk_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Ck.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Ck.Text = "" Then
            TxtTen_TK_CK.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Ck.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Ck.Text = DrReturn.Item("TK")
            TxtTen_TK_CK.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Ck.Text = ""
            TxtTen_TK_CK.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_hang"
    Private Sub V_LoadMa_hang()
        Dim DsTbma_hang As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetCombox", "MobiDmHang#1=1#ma_hang#" & M_User_Name)
        Tbma_hang = DsTbma_hang.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbMa_hang, Tbma_hang, "Ma_hang", "Ten_hang", "")
    End Sub
#End Region
#Region "Vali --- Kieu_Dang"
    Private Sub V_LoadKieu_Dang()
        Dim DsTbKieu_Dang As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetCombox", "MobiDmKieu_Dang#1=1#Kieu_Dang#" & M_User_Name)
        TbKieu_Dang = DsTbKieu_Dang.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CmbKieu_dang, TbKieu_Dang, "Kieu_Dang", "Ten", "")
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_KX.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
