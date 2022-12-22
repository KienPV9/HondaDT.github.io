Public Class BEXEPXE_IN_BB
    Public Property Ma_HD() As String
        Get
            Ma_HD = M_Ma_HD
        End Get
        Set(ByVal Value As String)
            M_Ma_HD = Value
        End Set
    End Property
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
        End Set
    End Property
    Public Property Stt_Rec0() As String
        Get
            Stt_Rec0 = M_Stt_Rec0
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec0 = Value
        End Set
    End Property
    Public Property So_Khung() As String
        Get
            So_Khung = M_So_khung
        End Get
        Set(ByVal Value As String)
            M_So_khung = Value
        End Set
    End Property
    Public Property Ma_Kx() As String
        Get
            Ma_Kx = M_Ma_Kx
        End Get
        Set(ByVal Value As String)
            M_Ma_Kx = Value
        End Set
    End Property
    Public Property Ma_Mau() As String
        Get
            Ma_Mau = M_Ma_Mau
        End Get
        Set(ByVal Value As String)
            M_Ma_Mau = Value
        End Set
    End Property
    Dim M_Ma_HD As String
    Dim M_Stt_Rec As String
    Dim M_Stt_Rec0 As String
    Dim M_So_khung As String
    Dim M_Ma_Kx As String
    Dim M_Ma_Mau As String
    Dim _DT As DataTable
    Private Sub BESuaKXF3_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        Me.Text = "LỰA CHỌN IN"
        AddHandler CmdPrint.Click, AddressOf V_Print
        AddHandler CmdPriview.Click, AddressOf V_Priview
        AddHandler CmdModify.Click, AddressOf V_Modify
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim dsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXe_In_BB", "LOAD" & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        _DT = dsTmp.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CbbPrint, _DT, "Ma_In", "Ten_in", "Default")
    End Sub
    'Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Me.Key_Sub1 = CbbPrint.SelectedValue.ToString.Trim
        Me.Key_Sub2 = "1"
        Me.Close()
    End Sub
    Private Sub V_Priview(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Me.Key_Sub1 = CbbPrint.SelectedValue.ToString.Trim
        Me.Key_Sub2 = "1"
        Me.Close()
    End Sub
    Private Sub V_Modify(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Me.Key_Sub1 = CbbPrint.SelectedValue.ToString.Trim
        Me.Key_Sub2 = "3"
        Me.Close()
    End Sub
End Class
