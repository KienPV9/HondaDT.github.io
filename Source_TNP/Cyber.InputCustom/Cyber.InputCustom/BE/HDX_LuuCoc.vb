Public Class HDX_LuuCoc
    Public Property Stt_rec() As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Public Property Is_LuuCoc() As Integer
        Get
            Is_LuuCoc = M_LuuCoc
        End Get
        Set(ByVal Value As Integer)
            M_LuuCoc = Value
        End Set
    End Property
    Dim M_Stt_rec As String = ""
    Dim M_LuuCoc As Integer
    Dim M_Nh
    Dim DtNh As DataTable
    Private Sub HDX_Vay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtStt_Rec.Text = M_Stt_rec
        TxtTien_KHTT.ReadOnly = True
        DtNh = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmLyDoTL", "Ma_LyDoTL", "Acti =N'1'", CyberSmlib)
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadSaveHDX_LuuCoc", "LOAD#" + M_Stt_rec & "#" &
                 Me.M_LuuCoc & "#" & "" & "#" & "" & "#" & Me.M_Ma_Dvcs & "#" & M_User_Name)

        CyberSmodb.SetValueTObj_1(Me, DsTmp.Tables(0).Rows(0))
        DsTmp.Dispose()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        If TxtNgay_LuuCoc.Text = "__/__/____" Then
            TxtNgay_LuuCoc.Focus()
            Exit Sub
        End If
        Dim M_strParameterStore As String = ""
        'Me.Tag = M_strParameterStore
        Me.Stt_rec = TxtStt_Rec.Text
        M_Stt_rec = TxtStt_Rec.Text
        'CyberSmlib.FlushMemorySave()
        Dim ngay_huy As Date = TxtNgay_LuuCoc.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadSaveHDX_LuuCoc", "SAVE#" + M_Stt_rec & "#" &
                 IIf(ChkIs_LuuCoc.Checked, "1", "0") & "#" & ngay_huy.ToString("yyyMMdd") & "#" & TxtDien_Giai.Text.Trim & "#" & Me.M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        DsTmp.Dispose()
        Me.Close()
    End Sub

End Class
