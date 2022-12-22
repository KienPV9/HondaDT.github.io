Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms

Public Class VinBusExportExcel
    Public Shared Sub CreateExcel(ByVal ds As DataSet)
        'hieulv chọn đường dẫn lưu file excel
        Dim saveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm|XLTX (*.xltx)|*.xltx|XLTM (*.xltm)|*.xltm|ODS (*.ods)|*.ods|OTS (*.ots)|*.ots|CSV (*.csv)|*.csv|TSV (*.tsv)|*.tsv|HTML (*.html)|*.html|MHTML (.mhtml)|*.mhtml|PDF (*.pdf)|*.pdf|XPS (*.xps)|*.xps|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|WMP (*.wdp)|*.wdp"
        saveFileDialog.FilterIndex = 3

        'export to excel
        If (saveFileDialog.ShowDialog() = DialogResult.OK) Then
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            Try
                xlApp = New Excel.Application()
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Worksheets.Add()

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    For j As Integer = 0 To ds.Tables(0).Columns.Count - 1
                        xlWorkSheet.Cells(i + 1, j + 1) = ds.Tables(0).Rows(i).ItemArray(j).ToString()
                    Next
                Next

                xlWorkBook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)

                xlWorkBook.Close(True, misValue, misValue)
                xlApp.Quit()
                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)
            Catch ex As Exception
                Throw ex
            End Try
            'open file after export
            If DialogResult.Yes = MessageBox.Show("Do you want to open the file", "Excel", MessageBoxButtons.YesNo) Then
                System.Diagnostics.Process.Start(saveFileDialog.FileName)
            End If
        End If
    End Sub

    Public Shared Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Shared Sub ExportToExcel(ByVal Ds As System.Data.DataSet)
        'hieulv chọn đường dẫn lưu file excel
        Dim saveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm|XLTX (*.xltx)|*.xltx|XLTM (*.xltm)|*.xltm|ODS (*.ods)|*.ods|OTS (*.ots)|*.ots|CSV (*.csv)|*.csv|TSV (*.tsv)|*.tsv|HTML (*.html)|*.html|MHTML (.mhtml)|*.mhtml|PDF (*.pdf)|*.pdf|XPS (*.xps)|*.xps|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|WMP (*.wdp)|*.wdp"
        saveFileDialog.FilterIndex = 3

        'export to excel
        If (saveFileDialog.ShowDialog() = DialogResult.OK) Then
            Try
                Dim DtExport As DataTable = Ds.Tables(0).Copy
                Dim DtHead As DataTable = Ds.Tables(1).Copy

                Dim ColumnsCount As Integer = DtExport.Columns.Count
                Dim RowHeadCount As Integer = DtHead.Rows.Count

                If Ds Is Nothing Or ColumnsCount = 0 Then
                    Throw New Exception("ExportToExcel: Null or empty input table!" & vbLf)
                End If

                Dim Excel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
                Excel.Workbooks.Add()
                Dim Worksheet As Microsoft.Office.Interop.Excel._Worksheet = Excel.ActiveSheet
                'Get column_Name 
                Dim Header As Object() = New Object(RowHeadCount - 1) {}

                For i As Integer = 0 To RowHeadCount - 1
                    Header(i) = DtHead.Rows(i).Item("Field_Head1")
                Next
                'Get column_Format
                Dim Header_Format As Object() = New Object(RowHeadCount - 1) {}

                For i As Integer = 0 To RowHeadCount - 1
                    'Header_Format(i) = IIf(DtHead.Rows(i).Item("Format") = "", "@", DtHead.Rows(i).Item("Format")) 'format text
                    Header_Format(i) = IIf(DtHead.Rows(i).Item("Format") = "", "", DtHead.Rows(i).Item("Format")) 'format General
                Next

                Dim HeaderRange As Microsoft.Office.Interop.Excel.Range = Worksheet.Range(CType((Worksheet.Cells(1, 1)), Microsoft.Office.Interop.Excel.Range), CType((Worksheet.Cells(1, ColumnsCount)), Microsoft.Office.Interop.Excel.Range))
                HeaderRange.Value = Header
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)
                HeaderRange.Font.Bold = True
                HeaderRange.Columns.AutoFit()

                Dim RowsCount As Integer = DtExport.Rows.Count
                Dim Cells As Object(,) = New Object(RowsCount - 1, ColumnsCount - 1) {}

                For j As Integer = 0 To RowsCount - 1

                    For i As Integer = 0 To ColumnsCount - 1
                        Cells(j, i) = DtExport.Rows(j)(i)
                    Next
                Next

                'Đổ data
                Dim DataRange As Microsoft.Office.Interop.Excel.Range
                DataRange = Worksheet.Range(CType((Worksheet.Cells(2, 1)), Microsoft.Office.Interop.Excel.Range), CType((Worksheet.Cells(RowsCount + 1, ColumnsCount)), Microsoft.Office.Interop.Excel.Range))
                DataRange.Value = Cells
                DataRange.NumberFormat = Header_Format
                DataRange.Columns.AutoFit()

                Try
                    Worksheet.SaveAs(saveFileDialog.FileName)
                    Excel.Quit()
                    releaseObject(Excel)
                Catch ex As Exception
                    Throw New Exception("ExportToExcel: Excel file could not be saved! Check filepath." & vbLf & ex.Message)
                End Try

            Catch ex As Exception
                Throw New Exception("ExportToExcel: " & vbLf & ex.Message)
            End Try
            'open file after export
            If DialogResult.Yes = MessageBox.Show("Do you want to open the file", "Excel", MessageBoxButtons.YesNo) Then
                System.Diagnostics.Process.Start(saveFileDialog.FileName)
            End If
        End If
    End Sub
End Class
