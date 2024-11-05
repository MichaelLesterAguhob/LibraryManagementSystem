Imports MySql.Data.MySqlClient


Public Class Form1

    Dim selectedBookId As String = ""
    Dim selectedBookTitle As String = ""
    Dim selectedBookAuthor As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConOpen()
        LoadBooks()
    End Sub


    Public Sub AddBook()
        con.Close()
        Try
            con.Open()
            Dim query As String = "INSERT INTO books(`title`,`author`) VALUES(@title, @author)"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim)
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Successfully added book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTitle.Clear()
            txtAuthor.Clear()
            LoadBooks()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on adding book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If txtTitle.Text = "" Or txtAuthor.Text = "" Then
            MessageBox.Show("Fill in the blanks", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        AddBook()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        txtTitle.Clear()
        txtAuthor.Clear()
    End Sub


    '==============================================================================================================
    ReadOnly dtBooks As New DataTable()
    Public Sub LoadBooks()

        con.Close()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM books ORDER BY title ASC"
            Using cmd As New MySqlCommand(query, con)
                Using adptr As New MySqlDataAdapter(cmd)
                    dtBooks.Clear()
                    adptr.Fill(dtBooks)

                    If dtBooks.Rows.Count > 0 Then
                        dgvBooks.DataSource = dtBooks
                        dgvBooks.Refresh()
                        For i = 0 To dgvBooks.Rows.Count - 1
                            dgvBooks.Rows(i).Height = 50
                        Next
                        dgvBooks.ClearSelection()
                    Else
                        dgvBooks.DataSource = dtBooks
                        dgvBooks.Refresh()
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on while loading list of books", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try

    End Sub



    '==============================================================================================================

    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim i As Integer = dgvBooks.CurrentRow.Index
            selectedBookId = dgvBooks.Item(0, i).Value
            selectedBookTitle = dgvBooks.Item(1, i).Value
            selectedBookAuthor = dgvBooks.Item(2, i).Value
            BtnDel.Enabled = True
            BtnEdit.Enabled = True
        End If
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        EditForm.Visible = True
        txtEditId.Text = selectedBookId
        txtEditTitle.Text = selectedBookTitle
        txtEditAuthor.Text = selectedBookAuthor
    End Sub

    Private Sub BtnCancelEditing_Click(sender As Object, e As EventArgs) Handles BtnCancelEditing.Click
        EditForm.Visible = False
        txtEditTitle.Text = ""
        txtEditAuthor.Text = ""
        BtnDel.Enabled = False
        BtnEdit.Enabled = False
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        UpdateBook()
    End Sub

    Public Sub UpdateBook()
        con.Close()
        Try
            con.Open()
            Dim query As String = "UPDATE books 
                                SET 
                                    title=@title, 
                                    author=@author 
                                WHERE book_id=@book_id"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@book_id", txtEditId.Text.Trim)
                cmd.Parameters.AddWithValue("@title", txtEditTitle.Text.Trim)
                cmd.Parameters.AddWithValue("@author", txtEditAuthor.Text.Trim)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Successfully updated book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEditTitle.Clear()
            txtEditAuthor.Clear()
            BtnDel.Enabled = False
            BtnEdit.Enabled = False
            EditForm.Visible = False

            LoadBooks()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on updating book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub


    ''==============================================================================================================
    Public Sub DeleteBook()
        con.Close()
        Try
            con.Open()
            Dim query As String = "DELETE FROM books WHERE book_id=@book_id"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@book_id", selectedBookId)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Successfully updated book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEditTitle.Clear()
            txtEditAuthor.Clear()
            BtnDel.Enabled = False
            BtnEdit.Enabled = False
            EditForm.Visible = False

            LoadBooks()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on updating book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        DeleteBook()
    End Sub
End Class
