Imports System.Data.OleDb


Public Class crystal_coding
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Downloads\Ado.net-main\Ado.net-main\crystall\db2.accdb;Persist Security Info=False")



    Dim myform As New Form2

  Dim res As String
  Private Sub crystal_coding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    myform = Form2.ActiveForm

    Dim query As String = "SELECT * FROM tb1 WHERE city='" & myform.searchtext.Text & "';"
    Dim dataAdapter As New OleDbDataAdapter(query, conn)
    Dim ds As New DataSet1
    dataAdapter.Fill(ds.tb1)

      Dim report As New CrystalReport2
      report.SetDataSource(ds)
    CrystalReportViewer1.ReportSource = report

  End Sub
End Class
