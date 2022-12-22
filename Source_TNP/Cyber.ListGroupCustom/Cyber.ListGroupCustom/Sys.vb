Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Sys
    'Public TbTP, TbQuan, TbXa, _Tb_GioiTinh, _Tb_TTLV As DataTable
    'Public vTbTP, vTbQuan, vTbXa As DataView
    Public Function V_GetFiller(ByVal Tb_name) As Form
        Dim _Return As Form = Nothing
        Tb_name = Tb_name.ToUpper.Trim
        ''hieulv 24/12 load sẵn data tỉnh thành
        'Dim CyberSmlib As Cyber.SmLib.Sys
        'Dim CyberSmodb As Cyber.Smodb.Sys
        'Dim Appconn As Cyber.Smodb.Sys
        'Dim DsTb As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetTPQuanXa", M_Ma_Dvcs + "#" + M_User_Name)
        'TbTP = DsTb.Tables(0).Copy
        'TbQuan = DsTb.Tables(1).Copy
        'TbXa = DsTb.Tables(2).Copy

        'vTbTP = New DataView(TbTP)
        'vTbQuan = New DataView(TbQuan)
        'vTbXa = New DataView(TbXa)
        'DsTb = Nothing
        '_Tb_GioiTinh = CyberSmodb.OpenTable(Appconn, DsTb, "CRDmGioiTinh", "1", CyberSmlib)
        '_Tb_TTLV = CyberSmodb.OpenTable(Appconn, DsTb, "CRDmTTLV", "1", CyberSmlib)


        'Select Case Tb_name
        '    Case "CDTK", "CDKH", "CDVT", "CDHD", "CDPHI", "CDVV", "CDSP", "CDKU", "CDTTLN", "CDTTCP", "CDBP", "CDHS", "CDCD", "CDTD1", "CDTD2", "CDTD3", "CDTD4", "CDTD5", "CTGS", "DMKC", "DMPB"
        '        _Return = New FDMYEAR
        '    Case Else
        '        _Return = Nothing
        'End Select
        Return _Return
    End Function
    Public Function V_GetFromF3(ByVal Tb_name As String) As Form
        Dim _Return As Form = Nothing
        'If Tb_name = "CDCTCC".ToUpper Then Return New CDCTCC1
        Tb_name = Tb_name.ToUpper.Trim
        _Return = DirectCast(pGettype(Tb_name), Form)
        Return _Return
    End Function
    Private Function pGettype(ByVal ClassName As String) As Object
        Dim class_type As Type = Nothing
        Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        For Each ctrtype As Type In myAssembly.GetExportedTypes
            If ctrtype.Name.Trim.ToString.ToUpper = ClassName.Trim.ToUpper Then
                class_type = ctrtype
                Exit For
            End If
        Next
        If class_type Is Nothing Then Return class_type
        Return Activator.CreateInstance(class_type)
    End Function
    Public Shared Sub SetAutoCode(ByVal AppConn As SqlConnection, ByVal _TbName As String, ByVal M_Mode As String,
                                Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing,
                                 Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing,
                                 Optional ByRef TxtMa As TextBox = Nothing,
                                 Optional ByRef TxtNh1 As Cyber.SmLists.TxtLookup = Nothing,
                                 Optional ByRef TxtNh2 As Cyber.SmLists.TxtLookup = Nothing,
                                 Optional ByRef TxtNh3 As Cyber.SmLists.TxtLookup = Nothing,
                                 Optional ByRef TxtNh4 As Cyber.SmLists.TxtLookup = Nothing,
                                 Optional ByRef TxtNh5 As Cyber.SmLists.TxtLookup = Nothing)
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        Dim Auto As String = CyberSmodb.SQLGetvalue(AppConn, "AutoCode", "SysList", "(Name = N'" + _TbName.Trim + "')", CyberSmlib)
        If Auto = "" Then Auto = "0"
        If Not TxtMa Is Nothing Then TxtMa.Enabled = (Auto = 0)
        If Not TxtNh1 Is Nothing Then If M_Mode = "M" Then TxtNh1.Enabled = True Else TxtNh1.Enabled = (Auto = 0)
        If Not TxtNh2 Is Nothing Then If M_Mode = "M" Then TxtNh2.Enabled = True Else TxtNh2.Enabled = (Auto = 0)
        If Not TxtNh3 Is Nothing Then If M_Mode = "M" Then TxtNh3.Enabled = True Else TxtNh3.Enabled = (Auto = 0)
        If Not TxtNh4 Is Nothing Then If M_Mode = "M" Then TxtNh4.Enabled = True Else TxtNh4.Enabled = (Auto = 0)
        If Not TxtNh5 Is Nothing Then If M_Mode = "M" Then TxtNh5.Enabled = True Else TxtNh5.Enabled = (Auto = 0)
    End Sub
End Class