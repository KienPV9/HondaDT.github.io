Public Class FrmUpdateRoHang
    Public Property So_Ro_hang() As String
        Get
            So_Ro_hang = M_So_Ro_hang
        End Get
        Set(ByVal Value As String)
            M_So_Ro_hang = Value
        End Set
    End Property
    Dim M_So_Ro_hang As String = ""
    Private Sub FrmUpdateRoHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtSo_Ro_Hang.Text = M_So_Ro_hang
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        'Me.Tag = M_strParameterStore
        Me.So_Ro_hang = TxtSo_Ro_Hang.Text
        M_So_Ro_hang = TxtSo_Ro_Hang.Text
        'CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
