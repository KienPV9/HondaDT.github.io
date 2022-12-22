Public Class BEXEPXE_PDS
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
    Dim M_Dr As DataRow
    Dim M_Drv As DataRowView
    Private Sub BEXEPXE_PDS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        Me.Text = "YÊU CẦU LÀM PDS"
        AddHandler ButtOK.Click, AddressOf V_Nhan
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, Drv)
        ' TxtTen_loai.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Loai", "DmPlts", "(Ma_Loai= N'" + TxtMa_Loai.Text.Trim + "')", CyberSmlib)
        TxtNgay_CT.Value = Now.Date
        TxtNgay_YC.Value = Now.Date
        TxtGio_YC.Text = Strings.Right("00" & Now.Hour.ToString.Trim, 2) & ":" & Strings.Right("00" & Now.Minute.ToString.Trim, 2)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 1 * FROM dbo.DmPDS WHERE Ma_Dvcs = N'" & M_Ma_Dvcs.Trim & "' AND So_Khung = N'" & TxtSo_Khung.Text & "'#" & M_Ma_Dvcs & "#" & M_User_Name)

        If Dstmp.Tables(0).Rows.Count = 0 Then Exit Sub
        If Dstmp.Tables(0).Columns.Contains("Ngay_CT") Then TxtNgay_YC.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_CT")
        If Dstmp.Tables(0).Columns.Contains("Ngay_YC") Then TxtNgay_YC.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_Yc")
        If Dstmp.Tables(0).Columns.Contains("Gio_YC") Then TxtGio_YC.Text = Dstmp.Tables(0).Rows(0).Item("Gio_YC")
        If Dstmp.Tables(0).Columns.Contains("Dien_Giai") Then TxtGio_YC.Text = Dstmp.Tables(0).Rows(0).Item("Dien_Giai")

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
        Dim strField As String = ""
        Dim strValue As String = ""
        CyberSmodb.GetValueControler(Me, strField, strValue)
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BEXEPXE_SVAE_PDS", strField & "#" & strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub

        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore

        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
