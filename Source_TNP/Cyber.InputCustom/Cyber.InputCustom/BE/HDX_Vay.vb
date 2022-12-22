Public Class HDX_Vay
    Public Property Stt_rec() As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Dim M_Stt_rec As String = ""
    Dim M_Nh
    Dim DtNh As DataTable
    Private Sub HDX_Vay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtStt_Rec.Text = M_Stt_rec
        DtNh = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmNhTraGop", "Ma_Nh", "Acti =N'1'", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CmbMa_Nh, DtNh, "Ma_Nh", If(M_LAN = "V", "Ten_Nh", "Ten_Nh2"), "")
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim ngay_tbcv As Date = TxtNgay_TBCV.Value
        Dim ngay_gui_bank As Date = TxtNgay_Gui_Bank.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadSaveHDX_Vay", "LOAD#" + M_Stt_rec & "#" & ngay_gui_bank.ToString("yyyMMdd") & "#" & ngay_tbcv.ToString("yyyMMdd") & "#" & TxtTien_Vay.Double.ToString & "##0#" & Me.M_Ma_Dvcs & "#" & M_User_Name & "#")

        CyberSmodb.SetValueTObj_1(Me, DsTmp.Tables(0).Rows(0))
        DsTmp.Dispose()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        'Me.Tag = M_strParameterStore
        Me.Stt_rec = TxtStt_rec.Text
        M_Stt_rec = TxtStt_rec.Text
        'CyberSmlib.FlushMemorySave()
        Dim ngay_tbcv As Date = TxtNgay_TBCV.Value
        Dim ngay_gui_bank As Date = TxtNgay_Gui_Bank.Value
        Dim ngay_gn As Date = TxtNgay_GN.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadSaveHDX_Vay", "SAVE#" + M_Stt_rec & "#" & ngay_gui_bank.ToString("yyyMMdd") & "#" & ngay_tbcv.ToString("yyyMMdd") & "#" & TxtTien_Vay.Double.ToString & "#" &
                                                                  ngay_gn.ToString("yyyMMdd") & "#" & TxtTien_GN.Double.ToString & "#" & Me.M_Ma_Dvcs & "#" & M_User_Name & "#" & CmbMa_Nh.SelectedValue.ToString.Trim)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        DsTmp.Dispose()

        Me.Close()
    End Sub
End Class
