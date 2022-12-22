Imports System.Data.SqlClient
Public Class TestCT
    Dim oSysvar As Collection
    Dim Appconn As SqlConnection
    Dim M_Para As String()
    Dim _Para As String
    Dim _Ma_Dvcs As String = "01"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CyberSmlib As New Cyber.SmLib.Sys
        Appconn = CyberSmlib.GetConn()
        oSysvar = CyberSmlib.IniSysVar(Appconn, "01", "ABC")
        _Para = "14#C:\#E:\Project\Cyber_TMV\System\#E:\Project\Cyber_TMV\Repo\#E:\Project\Cyber_TMV\Repo-nt\#Cyber Enterprice#ABC#Admin#True#1#02.05.00#Phiếu thu tiền mặt#Cash on hand receipt#V#" + _Ma_Dvcs
    End Sub
    Private Function GetParameter(ByVal _Ma_CT As String, ByVal _Ma_Dvcs As String, ByVal _User_Name As String) As String
        Dim CyberSmlib As New Cyber.SmLib.Sys
        Dim _Return As String = ""
        Dim DsGetCommand As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "Cp_SysGetRunCommand", _Ma_CT + "#" + "" + _Ma_Dvcs + "#" + _User_Name)
        If DsGetCommand.Tables(1).Rows.Count > 0 Then
            Dim _Pr As String = DsGetCommand.Tables(1).Rows(0).Item("Procedure").ToString.Trim
            _Pr.Split("#")
            For i = 1 To _Pr.Split("#").Length - 1
                _Return = _Return + "#" + _Pr.Split("#")(i)
            Next
        End If
        GetParameter = _Return
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim _Para1 As String
        _Para1 = _Para + GetParameter(TxtMa_Ct.Text, _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.InputCustom.Sys
        CyberInvao.Initvao(M_Para)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
