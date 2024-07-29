Imports System.Data
Imports System.Data.OleDb

Public Class Form1
  Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\test\Desktop\adel-sql\db1.accdb;Persist Security Info=False"
  Dim conn As OleDbConnection
  Dim dataset1 As New DataSet
  Dim searchCriteria As Integer = 0

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    conn = New OleDbConnection(constr)
  End Sub

  Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
    Try
      Using conn As New OleDbConnection(constr)
        conn.Open()
        Dim sqlstr As String = "Insert into tb1 (names, city, phone)" & " values (?, ?, ?);"
        Using cmd As New OleDbCommand(sqlstr, conn)
          cmd.Parameters.AddWithValue("@names", nametext.Text)
          cmd.Parameters.AddWithValue("@city", citytext.Text)
          cmd.Parameters.AddWithValue("@phone", mobtext.Text)
          cmd.ExecuteNonQuery()
        End Using
        MsgBox("Done")
      End Using
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  ' Similar changes can be applied to other methods like delbtn_Click, Editbtn_Click, etc.

  Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
    Try
      dataset1.Clear()
      Dim sqlstr As String = ""
      Select Case searchCriteria
        Case 1
          sqlstr = "SELECT * FROM tb1 WHERE names=?"
        Case 2
          sqlstr = "SELECT * FROM tb1 WHERE city=?"
        Case 3
          sqlstr = "SELECT * FROM tb1 WHERE phone=?"
      End Select
      Using conn As New OleDbConnection(constr)
        conn.Open()
        Using da As New OleDbDataAdapter(sqlstr, conn)
          da.SelectCommand.Parameters.AddWithValue("@?", searchtext.Text)
          da.Fill(dataset1, "tb1")
        End Using
      End Using
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
    searchCriteria = 1
  End Sub

  Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
    searchCriteria = 2
  End Sub

  Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
    searchCriteria = 3
  End Sub

  Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click

  End Sub
End Class
