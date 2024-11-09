
Imports MySql.Data.MySqlClient

Public Class BorrowedBooks

    ReadOnly dtBorrowBooks As New DataTable()
    Dim available As Boolean = False

    Private mainForm As Form1

    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub


    Private Sub BorrowedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConOpen()
        LoadBorrowBooks()
        LoadReturnedBooks()
    End Sub


    Public Sub LoadBorrowBooks()

        con.Close()
        Try
            con.Open()
            Dim query As String = "SELECT borrowed_book.*, COALESCE(books.title, 'Deleted Book') as title 
                                   FROM borrowed_book 
                                   LEFT JOIN books 
                                    ON books.book_id = borrowed_book.book_id
                                   WHERE status = 'Not returned' ORDER BY num_cnt DESC"
            Using cmd As New MySqlCommand(query, con)
                Using adptr As New MySqlDataAdapter(cmd)
                    dtBorrowBooks.Clear()
                    adptr.Fill(dtBorrowBooks)

                    If dtBorrowBooks.Rows.Count > 0 Then
                        DgvBorrow.DataSource = dtBorrowBooks
                        DgvBorrow.Refresh()
                        For i = 0 To DgvBorrow.Rows.Count - 1
                            DgvBorrow.Rows(i).Height = 50
                        Next
                        DgvBorrow.ClearSelection()
                    Else
                        DgvBorrow.DataSource = dtBorrowBooks
                        DgvBorrow.Refresh()
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


    Dim selectedBorrowId As String
    Dim selectedBorrowedBookId As String

    Private Sub DgvBorrow_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBorrow.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim i As Integer = DgvBorrow.CurrentRow.Index
            selectedBorrowId = DgvBorrow.Item(1, i).Value
            selectedBorrowedBookId = DgvBorrow.Item(2, i).Value
            BtnReturned.Enabled = True
        End If
    End Sub



    '==============================================================================================================
    Dim OnView As String = "not returned"
    Private Sub BtnViewReturnedBorrow_Click(sender As Object, e As EventArgs) Handles BtnViewReturnedBorrow.Click
        If OnView = "not returned" Then
            OnView = "returned"
            Label2.ForeColor = Color.Blue
            Label2.Text = "Returned"
            LoadReturnedBooks()
            BtnReturned.Enabled = False
            BtnViewReturnedBorrow.Text = "View Not Returned"
            DgvReturned.Visible = True
            LoadReturnedBooks()
        Else
            OnView = "not returned"
            Label2.ForeColor = Color.Red
            Label2.Text = "Not Returned"
            LoadBorrowBooks()
            DgvReturned.Visible = False
            BtnViewReturnedBorrow.Text = "View Returned"
        End If

    End Sub


    ReadOnly dtReturnedBooks As New DataTable()
    Public Sub LoadReturnedBooks()

        con.Close()
        Try
            con.Open()
            Dim query As String = "SELECT borrowed_book.*, COALESCE(books.title, 'Deleted Book') as title
                                   FROM borrowed_book 
                                   LEFT JOIN books 
                                    ON books.book_id = borrowed_book.book_id
                                   WHERE status = 'Returned' ORDER BY num_cnt DESC"
            Using cmd As New MySqlCommand(query, con)
                Using adptr As New MySqlDataAdapter(cmd)
                    dtReturnedBooks.Clear()
                    adptr.Fill(dtReturnedBooks)

                    If dtReturnedBooks.Rows.Count > 0 Then
                        DgvReturned.DataSource = dtReturnedBooks
                        DgvReturned.Refresh()
                        For i = 0 To DgvReturned.Rows.Count - 1
                            DgvReturned.Rows(i).Height = 50
                        Next
                        DgvReturned.ClearSelection()
                    Else
                        DgvReturned.DataSource = dtReturnedBooks
                        DgvReturned.Refresh()
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

    Private Sub BtnReturned_Click(sender As Object, e As EventArgs) Handles BtnReturned.Click
        Dim confirmation As DialogResult = MessageBox.Show("Set this book status as returned?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmation = DialogResult.Yes Then
            ReturnBook()
        End If
    End Sub


    Public Sub ReturnBook()
        con.Close()
        Try
            con.Open()
            Dim query As String = "UPDATE borrowed_book SET `status`= @newStatus WHERE borrow_id=@selectedBorrowId"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@newStatus", "Returned")
                cmd.Parameters.AddWithValue("@selectedBorrowId", selectedBorrowId)
                cmd.ExecuteNonQuery()
            End Using
            UpdateQnty(selectedBorrowedBookId)
            mainForm.LoadBooks()
            LoadBorrowBooks()
            BtnReturned.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on while loading list of books", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub


    Public Sub UpdateQnty(BookID)
        con.Close()
        Try
            con.Open()
            Dim query As String = "SELECT quantity FROM books WHERE book_id=@id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", BookID)
                Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar())

                count += 1


                Dim query2 As String = "UPDATE books SET quantity=@newQnty WHERE book_id=@id"
                Using cmd2 As New MySqlCommand(query2, con)
                    cmd2.Parameters.AddWithValue("@id", BookID)
                    cmd2.Parameters.AddWithValue("@newQnty", count)
                    cmd2.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on updating book quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub




    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If TxtSearch.Text <> "" Then

            If OnView = "not returned" Then
                con.Close()
                Try
                    con.Open()
                    Dim query As String = "SELECT borrowed_book.*, COALESCE(books.title, 'Deleted Book') as title 
                                       FROM borrowed_book 
                                       LEFT JOIN books 
                                        ON books.book_id = borrowed_book.book_id
                                       WHERE 
                                         (books.title LIKE @toSearch 
                                         OR borrowed_book.book_id LIKE @toSearch 
                                         OR borrowed_book.borrow_id LIKE @toSearch 
                                         OR borrowed_book.borrower_name LIKE @toSearch 
                                         OR borrowed_book.borrower_mobile LIKE @toSearch 
                                         OR borrowed_book.date_borrow LIKE @toSearch 
                                         OR borrowed_book.time_borrow LIKE @toSearch
                                         OR borrowed_book.date_to_return LIKE @toSearch)  
                                         AND status = 'Not returned' 
                                         
                                       ORDER BY num_cnt DESC"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@toSearch", "%" & TxtSearch.Text.Trim & "%")
                        Using adptr As New MySqlDataAdapter(cmd)
                            dtBorrowBooks.Clear()
                            adptr.Fill(dtBorrowBooks)

                            If dtBorrowBooks.Rows.Count > 0 Then
                                DgvBorrow.DataSource = dtBorrowBooks
                                DgvBorrow.Refresh()
                                For i = 0 To DgvBorrow.Rows.Count - 1
                                    DgvBorrow.Rows(i).Height = 50
                                Next
                                DgvBorrow.ClearSelection()
                            Else
                                DgvBorrow.DataSource = dtBorrowBooks
                                DgvBorrow.Refresh()
                            End If

                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error Occurred on while loading list of books", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                Finally
                    con.Close()
                End Try

            Else
                con.Close()
                Try
                    con.Open()
                    Dim query As String = "SELECT borrowed_book.*, COALESCE(books.title, 'Deleted Book') as title 
                                       FROM borrowed_book 
                                       LEFT JOIN books 
                                        ON books.book_id = borrowed_book.book_id
                                       WHERE 
                                         (books.title LIKE @toSearch 
                                         OR borrowed_book.book_id LIKE @toSearch 
                                         OR borrowed_book.borrow_id LIKE @toSearch 
                                         OR borrowed_book.borrower_name LIKE @toSearch 
                                         OR borrowed_book.borrower_mobile LIKE @toSearch 
                                         OR borrowed_book.date_borrow LIKE @toSearch 
                                         OR borrowed_book.time_borrow LIKE @toSearch
                                         OR borrowed_book.date_to_return LIKE @toSearch)  
                                         AND status = 'Returned' 
                                         
                                       ORDER BY num_cnt DESC"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@toSearch", "%" & TxtSearch.Text.Trim & "%")
                        Using adptr As New MySqlDataAdapter(cmd)
                            dtReturnedBooks.Clear()
                            adptr.Fill(dtReturnedBooks)

                            If dtReturnedBooks.Rows.Count > 0 Then
                                DgvReturned.DataSource = dtReturnedBooks
                                DgvReturned.Refresh()
                                For i = 0 To DgvReturned.Rows.Count - 1
                                    DgvReturned.Rows(i).Height = 50
                                Next
                                DgvReturned.ClearSelection()
                            Else
                                DgvReturned.DataSource = dtReturnedBooks
                                DgvReturned.Refresh()
                            End If

                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error Occurred on while loading list of books", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                Finally
                    con.Close()
                End Try
            End If

        End If
    End Sub

    Private Sub TxtSearch_Leave(sender As Object, e As EventArgs) Handles TxtSearch.Leave
        If TxtSearch.Text = "" Then
            LoadBorrowBooks()
            LoadReturnedBooks()
        End If
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If TxtSearch.Text <> "" Then
            If e.KeyCode = 13 Then
                BtnSearch.PerformClick()
            End If
        End If
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        If TxtSearch.Text = "" Then
            LoadBorrowBooks()
            LoadReturnedBooks()
        End If
    End Sub

    Private Sub clearSearch_Click(sender As Object, e As EventArgs) Handles clearSearch.Click
        TxtSearch.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadBorrowBooks()
        LoadReturnedBooks()
    End Sub
End Class