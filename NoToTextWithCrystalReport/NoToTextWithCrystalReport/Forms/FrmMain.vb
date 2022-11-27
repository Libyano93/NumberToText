Public Class FrmMain
    Public BasicCurrency As String = "دينار"
    Public PartCurrency As String = "درهم"

    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount.TextChanged
        Try
            If TxtAmount.Text.Trim <> "" Then
                Call GetNomberToArabic()
            Else
                TxtAmountByArabic.Text = String.Empty
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetNomberToArabic()
        Try
            TxtAmountByArabic.Text = NoToTxt(TxtAmount.Text, BasicCurrency, PartCurrency)

        Catch ex As Exception

        Finally

        End Try
    End Sub

    Private Sub BtnPrintSelectedStudent_Click(sender As Object, e As EventArgs) Handles BtnPrintSelectedStudent.Click
        Dim F As New FrmPrint
        Dim C As New CrystalReport1

        F.CrystalReportViewer1.ReportSource = C

        ''تحديث التقرير
        F.CrystalReportViewer1.Refresh()

        C.SetParameterValue(0, TxtAmountByArabic.Text.Trim)
        C.SetParameterValue(1, TxtAmount.Text.Trim)


        ''تغيير عنوان فورم الطباعة
        F.Text = "طباعة سند "
        F.CrystalReportViewer1.Zoom(100%)
        F.WindowState = FormWindowState.Maximized
        F.Show()

    End Sub
End Class