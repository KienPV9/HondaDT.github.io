Public Class DoiBienSo
    Public Property Dr() As DataRow
        Get
            Dr = M_Dr
        End Get
        Set(ByVal Value As DataRow)
            M_Dr = Value
        End Set
    End Property
    Public Property Drv() As DataRowView
        Get
            Drv = M_Drv
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv = Value
        End Set
    End Property
    Public Property Dt() As DataTable
        Get
            Dt = M_Dt
        End Get
        Set(ByVal Value As DataTable)
            M_Dt = Value
        End Set
    End Property
    Public Property Ma_Xe As String
        Get
            Ma_Xe = M_Ma_Xe
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe = Value
        End Set
    End Property
    Public Property Ma_Xe_Old As String
        Get
            Ma_Xe_Old = M_Ma_Xe_Old
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe_Old = Value
        End Set
    End Property
    Dim M_Dr As DataRow
    Dim M_Drv As DataRowView
    Dim M_Dt As DataTable
    Public M_Thang1 As String = ""
    Public M_Thang2 As String = ""
    Public M_Nam1 As String = ""
    Public M_Nam2 As String = ""
    Public M_Loai As String = ""
    Public M_Dt_Return As DataTable
    Public M_Ma_Xe As String = ""
    Public M_Ma_Xe_Old As String = ""

    Private Sub CP_BELapKHGX_KeHoach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        TxtMa_Xe.Text = M_Ma_Xe_Old

        V_AddHandler()
        Me.Text = "Đổi biển số xe"
        AddHandler ButtOK.Click, AddressOf V_Nhan
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub

    Private Sub V_Load()
        Dim _Strpara As String = "LOAD##"
        _Strpara = _Strpara & "#" & M_Ma_Dvcs
        _Strpara = _Strpara & "#" & M_User_Name
        Dim _Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BELapKHGX_DoiBienSo", _Strpara)
        Dim _Dr As DataRow = _Dstmp.Tables(0).Rows(0)
        CyberSmodb.SetValueTObj(Me, _Dr)
        _Dstmp.Dispose()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Strpara As String = "SAVE#" & TxtMa_Xe.Text.Trim & "#" & TxtMa_Xe_New.Text.Trim
        _Strpara = _Strpara & "#" & M_Ma_Dvcs
        _Strpara = _Strpara & "#" & M_User_Name
        Dim _Ma_xe As String
        Dim Dstmp1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BELapKHGX_DoiBienSo", _Strpara)
        If Not CyberSupport.V_MsgChk(Dstmp1.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub

        _Ma_xe = Dstmp1.Tables(1).Rows(0).Item("Ma_Xe").ToString

        Me.Save_OK = True
        M_Ma_Xe = _Ma_xe
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Dstmp1.Dispose()

        Me.Close()
    End Sub

#Region "V_AddHandler"
    Private Sub V_AddHandler()
    End Sub
#End Region
End Class
