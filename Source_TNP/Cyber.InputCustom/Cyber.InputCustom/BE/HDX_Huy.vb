Public Class HDX_Huy
    Public Property Stt_rec() As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Public Property Is_Huy() As Integer
        Get
            Is_Huy = M_Is_Huy
        End Get
        Set(ByVal Value As Integer)
            M_Is_Huy = Value
        End Set
    End Property
    Dim M_Stt_rec As String = ""
    Dim M_Is_Huy As Integer
    Dim M_Nh
    Dim DtNh As DataTable
    Private Sub HDX_Vay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtStt_Rec.Text = M_Stt_rec
        TxtTien_KHTT.ReadOnly = True
        TxtSo_Bien_Ban.ReadOnly = True

        DtNh = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmLyDoTL", "Ma_LyDoTL", "Acti =N'1'", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CmbMa_LyDoTL, DtNh, "Ma_LyDoTL", If(M_LAN = "V", "Ten_LyDoTL", "Ten_LyDoTL2"), "01")
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadSaveHDX_Huy", "LOAD#" + M_Stt_rec & "#" &
                 Me.Is_Huy & "##" & "" & "#" & "" & "#" & "" & "#" & "0" & "#" & Me.M_Ma_Dvcs & "#" & M_User_Name)

        CyberSmodb.SetValueTObj_1(Me, DsTmp.Tables(0).Rows(0))
        DsTmp.Dispose()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        If TxtNgay_Huy.Text = "__/__/____" Then
            TxtNgay_Huy.Focus()
            Exit Sub
        End If
        Dim M_strParameterStore As String = ""
        'Me.Tag = M_strParameterStore
        Me.Stt_rec = TxtStt_rec.Text
        M_Stt_rec = TxtStt_Rec.Text
        'CyberSmlib.FlushMemorySave()
        Dim ngay_huy As Date = TxtNgay_Huy.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LoadSaveHDX_Huy", "SAVE#" + M_Stt_rec & "#" &
                 IIf(ChkIs_Huy.Checked, "1", "0") & "#" & TxtSo_Bien_Ban.Text.Trim & "#" & ngay_huy.ToString("yyyMMdd") & "#" & CmbMa_LyDoTL.SelectedValue.ToString.Trim & "#" & TxtDien_Giai.Text.Trim & "#" & TxtTien_Tra_Coc.Double.ToString & "#" & Me.M_Ma_Dvcs & "#" & M_User_Name & "#" &
                 IIf(ChkIs_TM.Checked, "1", "0") & "#" & IIf(ChkIs_CK.Checked, "1", "0") & "#" & TxtTen_TK_NC.Text & "#" & TxtTK_NC.Text & "#" & TxtNH_NC.Text & "#" & TxtNH_TC1.Text & "#" & TxtLD_NHTC1.Text & "#" & TxtNH_TC2.Text & "#" & TxtLD_NHTC2.Text)

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        DsTmp.Dispose()
        Me.Close()
    End Sub

End Class
