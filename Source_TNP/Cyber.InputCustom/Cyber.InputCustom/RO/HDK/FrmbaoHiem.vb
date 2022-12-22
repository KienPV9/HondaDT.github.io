Public Class FrmbaoHiem
#Region "AddProperty"
    Public Property _Dr() As DataRow
        Get
            _Dr = M_Dr
        End Get
        Set(ByVal Value As DataRow)
            M_Dr = Value
        End Set
    End Property
#End Region
#Region "Khai báo biến"
    Dim M_Dr As DataRow
    Dim _Dt_BH_DS, _Dt_BH_VC, _Dt_BH_NL As DataTable
#End Region
    Private Sub FrmbaoHiem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        AddAndFillBH()
        CyberSmodb.SetValueTObj(Me, _Dr)
    End Sub
    Private Sub AddAndFillBH()
        Dim DsBaohiem As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "DmBH#1=1#Ma_BH")
        _Dt_BH_DS = DsBaohiem.Tables(0).Copy
        _Dt_BH_VC = DsBaohiem.Tables(0).Copy
        _Dt_BH_NL = DsBaohiem.Tables(0).Copy
        DsBaohiem.Dispose()
        CyberFill.V_FillComBoxDefaul(CbbMa_BH_DS, _Dt_BH_DS, "Ma_BH", "Ten_BH")
        CyberFill.V_FillComBoxDefaul(CbbMa_BH_VC, _Dt_BH_VC, "Ma_BH", "Ten_BH")
        CyberFill.V_FillComBoxDefaul(CbbMa_BH_NL, _Dt_BH_NL, "Ma_BH", "Ten_BH")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmodb.AddValueToRow(_Dr, Me)
        _Dr.Item("Ma_Dvcs") = M_Ma_Dvcs
        _Dr.Item("User_id") = M_User_ID.Trim

        Dim _Dt_BH_DS As Date = TxtNgay_DS.Value
        Dim _Dt_BH_VC As Date = TxtNgay_VC.Value
        Dim _Dt_BH_NL As Date = TxtNgay_NL.Value

        Dim _Ma_BH_DS As String = CyberSmodb.GetvalueFromCombox(CbbMa_BH_DS).Trim
        Dim _Ma_BH_VC As String = CyberSmodb.GetvalueFromCombox(CbbMa_BH_VC).Trim
        Dim _Ma_BH_NL As String = CyberSmodb.GetvalueFromCombox(CbbMa_BH_NL).Trim

        'If (_Ma_BH_DS = "" And _Dt_BH_DS.ToString("yyyyMMdd") <> "19000101") Or (_Ma_BH_VC = "" And _Ma_BH_VC.ToString("yyyyMMdd") <> "19000101") Or (_Ma_BH_NL = "" And _Dt_BH_NL.ToString("yyyyMMdd") <> "19000101") Then
        '    MsgBox("Bạn chưa chọn đơn vị bảo hiểm", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
        '    Return
        'End If

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ICGetNgayBHSave", TxtMa_Xe.Text + "#" + _Dt_BH_DS.ToString("yyyyMMdd") + "#" + _Dt_BH_VC.ToString("yyyyMMdd") + "#" + _Dt_BH_NL.ToString("yyyyMMdd") + "#" + _Ma_BH_DS + "#" + _Ma_BH_VC + "#" + _Ma_BH_NL + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        Me.Save_OK = True

        'Dim _Key As String = " Ma_Xe = N'" + TxtMa_Xe.Text.Trim + "' AND Ma_Dvcs = N'" + M_Ma_Dvcs.Trim + "'"
        'If Not CyberSmodb.V_SaveToSQL(AppConn, Me.Sysvar, M_User_Name, _Dr, "DmXeBaoHiem", "S", _Key) Then Exit Sub
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
