Imports MySql.Data.MySqlClient


Public Class Form1

    Shared ReadOnly dateNow As DateTime = DateTime.Now
    Dim random As New Random()
    Dim randomNumbers As Integer
    Dim UniqueID As String

    Dim selectedBookId As String = ""
    Dim selectedBookTitle As String = ""
    Dim selectedBookAuthor As String = ""
    Dim selectedBookQnty As String = ""

    Dim available As Boolean = False

    Public Sub generateUniqueBookId()
        randomNumbers = random.Next(1, 1000000)

        con.Open()
        Try
            Dim query As String = "SELECT book_id FROM books WHERE book_id=@id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", dateNow.Year.ToString & randomNumbers)
                Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar())
                If count > 0 Then
                    generateUniqueBookId()
                Else
                    UniqueID = dateNow.Year.ToString & randomNumbers
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on generating unique book id", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub generateUniqueBorrowId()
        randomNumbers = random.Next(1, 1000000)

        con.Open()
        Try
            Dim query As String = "SELECT borrow_id FROM borrowed_book WHERE borrow_id=@id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", dateNow.Year.ToString & randomNumbers)
                Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar())
                If count > 0 Then
                    generateUniqueBorrowId()
                Else
                    UniqueID = dateNow.Year.ToString & randomNumbers
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on generating unique borrow id", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub


    Public Sub generateUniqueReserveId()
        randomNumbers = random.Next(1, 1000000)

        con.Open()
        Try
            Dim query As String = "SELECT reservation_id FROM book_reservation WHERE reservation_id=@id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", dateNow.Year.ToString & randomNumbers)
                Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar())
                If count > 0 Then
                    generateUniqueReserveId()
                Else
                    UniqueID = dateNow.Year.ToString & randomNumbers
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on generating unique reservation id", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LblTime.Text = TimeOfDay.ToString("h:mm tt")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConOpen()
        LoadBooks()
        Timer.Start()
        LblDate.Text = dateNow.Date.ToString("dddd, d MMMM yyyy")
        ' LblDate.Text = dateNow.Date.ToString("MM-dd-yyyy")
    End Sub


    Public Sub AddBook()
        generateUniqueBookId()
        con.Close()
        Try
            con.Open()
            Dim query As String = "INSERT INTO books(`book_id`,`title`,`author`,`quantity`) VALUES(@book_id, @title, @author, @qnty)"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@book_id", UniqueID.ToString())
                cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim)
                cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim)
                cmd.Parameters.AddWithValue("@qnty", TxtQuantity.Text.Trim)
                cmd.ExecuteNonQuery()
            End Using
            LoadBooks()
            MessageBox.Show("Successfully added book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTitle.Clear()
            txtAuthor.Clear()
            TxtQuantity.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on adding book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If txtTitle.Text = "" Or txtAuthor.Text = "" Or Not IsNumeric(TxtQuantity.Text) Then
            MessageBox.Show("Fill in the blanks | Quantity must be greater than or equal 1", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        End If

        If Not Convert.ToInt64(TxtQuantity.Text) >= 1 Then
            MessageBox.Show("Fill in the blanks | Quantity must be greater than or equal 1", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        AddBook()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        txtTitle.Clear()
        txtAuthor.Clear()
        TxtQuantity.Clear()
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
            selectedBookQnty = dgvBooks.Item(3, i).Value
            BtnEdit.Enabled = True
            BtnDel.Enabled = True
            BtnBorrow.Enabled = True
            Button3.Enabled = True
            ReserveForm.Visible = False
            BorrowForm.Enabled = False
            TxtBorrowBookTitle.Clear()
            TxtBorrowBookId.Clear()
            TxtName.Clear()
            TxtMobile.Clear()
            EditForm.Height = 0
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        EditForm.Height = 327
        txtEditId.Text = selectedBookId
        txtEditTitle.Text = selectedBookTitle
        txtEditAuthor.Text = selectedBookAuthor
        txtEditQnty.Text = selectedBookQnty
    End Sub

    Private Sub BtnCancelEditing_Click(sender As Object, e As EventArgs) Handles BtnCancelEditing.Click
        EditForm.Height = 0
        txtEditTitle.Text = ""
        txtEditAuthor.Text = ""
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
                                    author=@author,
                                    quantity=@qnty
                                WHERE book_id=@book_id"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@book_id", txtEditId.Text.Trim)
                cmd.Parameters.AddWithValue("@title", txtEditTitle.Text.Trim)
                cmd.Parameters.AddWithValue("@author", txtEditAuthor.Text.Trim)
                cmd.Parameters.AddWithValue("@qnty", txtEditQnty.Text.Trim)
                cmd.ExecuteNonQuery()
            End Using
            EditForm.Height = 0
            LoadBooks()
            MessageBox.Show("Successfully updated book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEditTitle.Clear()
            txtEditAuthor.Clear()
            BtnDel.Enabled = False
            BtnEdit.Enabled = False
            Button3.Enabled = False
            BtnBorrow.Enabled = False
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
            LoadBooks()
            MessageBox.Show("Successfully updated book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEditTitle.Clear()
            txtEditAuthor.Clear()
            BtnDel.Enabled = False
            BtnEdit.Enabled = False
            Button3.Enabled = False
            EditForm.Height = 0
            BtnBorrow.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on updating book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            DeleteBook()
        End If
    End Sub



    ''==============================================================================================================
    Private Sub BtnBorrow_Click(sender As Object, e As EventArgs) Handles BtnBorrow.Click
        BorrowForm.Enabled = True
        TxtBorrowBookId.Text = selectedBookId
        TxtBorrowBookTitle.Text = selectedBookTitle
        TxtName.Focus()
    End Sub

    Private Sub BtnCancelBorrow_Click(sender As Object, e As EventArgs) Handles BtnCancelBorrow.Click
        BorrowForm.Enabled = False
    End Sub


    Public Sub BorrowBook()
        generateUniqueBorrowId()
        UpdateQnty(TxtBorrowBookId.Text.Trim)
        If Not available Then
            Return
        End If
        con.Close()
        Try
            con.Open()
            Dim query As String = "INSERT INTO 
                        borrowed_book
                            (`borrow_id`,`book_id`,`borrower_name`,`borrower_mobile`,`date_borrow`, `time_borrow`, `date_to_return`) 
                        VALUES
                            (@borrow_id, @book_id, @borrower_name, @borrower_mobile, @date_borrow, @time_borrow, @date_to_return)"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@borrow_id", UniqueID.ToString())
                cmd.Parameters.AddWithValue("@book_id", TxtBorrowBookId.Text.Trim)
                cmd.Parameters.AddWithValue("@borrower_name", TxtName.Text.Trim)
                cmd.Parameters.AddWithValue("@borrower_mobile", TxtMobile.Text.Trim)
                cmd.Parameters.AddWithValue("@date_borrow", LblDate.Text.Trim)
                cmd.Parameters.AddWithValue("@time_borrow", LblTime.Text.Trim)
                cmd.Parameters.AddWithValue("@date_to_return", DtpDateReturn.Text.Trim)
                cmd.ExecuteNonQuery()
            End Using

            LoadBooks()
            MessageBox.Show("Successfully borrow book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtBorrowBookTitle.Clear()
            TxtBorrowBookId.Clear()
            TxtName.Clear()
            TxtMobile.Clear()
            BorrowForm.Enabled = False
            BtnDel.Enabled = False
            BtnEdit.Enabled = False
            EditForm.Height = 0
            Button3.Enabled = False
            BtnBorrow.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on borrowing book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub BtnBorrowSave_Click(sender As Object, e As EventArgs) Handles BtnBorrowSave.Click
        BorrowBook()
    End Sub

    Private Sub ViewBorrowedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBorrowedBooksToolStripMenuItem.Click
        Dim borrowedBooks As New BorrowedBooks(Me)
        borrowedBooks.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmation = DialogResult.Yes Then
            End
        End If
    End Sub


    ''==============================================================================================================
    Dim reserveView As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not reserveView Then
            Button1.Text = "HIDE RESERVED"
            DgvReserve.Visible = True
            reserveView = True
            BtnDel.Enabled = False
            BtnEdit.Enabled = False
            EditForm.Height = 0
            Button3.Enabled = False
            BtnBorrow.Enabled = False
            LoadReservedBooks()
        Else
            reserveView = False
            DgvReserve.Visible = False
            Button1.Text = "VIEW RESERVED"
            BtnDel.Enabled = True
            BtnEdit.Enabled = True
            EditForm.Height = 0
            Button3.Enabled = True
            BtnBorrow.Enabled = True
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TxtReserveBookId.Text = selectedBookId
        TxtReserveBookTitle.Text = selectedBookTitle
        BtnDel.Enabled = False
            BtnEdit.Enabled = False
            BtnBorrow.Enabled = False
            EditForm.Height = 0
            ReserveForm.Visible = True
            TxtReserveName.Focus()

    End Sub

    Private Sub BtnCancelReserve_Click(sender As Object, e As EventArgs) Handles BtnCancelReserve.Click
        ReserveForm.Visible = False
        BtnDel.Enabled = True
        BtnEdit.Enabled = True
        BtnBorrow.Enabled = True
    End Sub

    Private Sub BtnSaveReserve_Click(sender As Object, e As EventArgs) Handles BtnSaveReserve.Click
        If TxtReserveBookId.Text = "" Or TxtReserveBookTitle.Text = "" Or Not IsNumeric(TxtReserveMobile.Text) Then
            MessageBox.Show("Fill in the blanks | Quantity must be greater than or equal 1", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SaveReservation()
    End Sub


    Public Sub SaveReservation()
        generateUniqueReserveId()
        UpdateQnty(TxtReserveBookId.Text.Trim)
        If Not available Then
            Return
        End If
        con.Close()
        Try
            con.Open()
            Dim query As String = "INSERT INTO 
                        book_reservation
                            (`reservation_id`,`book_id`,`name`,`mobile`,`date_reserved`, `pickup_date`) 
                        VALUES
                            (@reservation_id, @book_id, @name, @mobile, @date_reserved, @pickup_date)"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@reservation_id", UniqueID.ToString())
                cmd.Parameters.AddWithValue("@book_id", TxtReserveBookId.Text.Trim)
                cmd.Parameters.AddWithValue("@name", TxtReserveName.Text.Trim)
                cmd.Parameters.AddWithValue("@mobile", TxtReserveMobile.Text.Trim)
                cmd.Parameters.AddWithValue("@date_reserved", LblDate.Text.Trim)
                cmd.Parameters.AddWithValue("@pickup_date", DtpPickupDate.Text.Trim)
                cmd.ExecuteNonQuery()
            End Using
            UpdateQnty(TxtReserveBookId.Text.Trim)
            LoadBooks()
            LoadReservedBooks()
            MessageBox.Show("Successfully reserved book", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtReserveBookId.Clear()
            TxtReserveBookTitle.Clear()
            TxtReserveName.Clear()
            TxtReserveMobile.Clear()
            ReserveForm.Visible = False
            BtnDel.Enabled = False
            BtnEdit.Enabled = False
            EditForm.Height = 0
            Button3.Enabled = False
            BtnBorrow.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occurred on borrowing book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        Finally
            con.Close()
        End Try
    End Sub


    ReadOnly dtReservedBooks As New DataTable()
    Public Sub LoadReservedBooks()

        con.Close()
        Try
            con.Open()
            Dim query As String = "SELECT book_reservation.*, books.title 
                                    FROM book_reservation 
                                    INNER JOIN books
                                        ON books.book_id = book_reservation.book_id
                                    "
            Using cmd As New MySqlCommand(query, con)
                Using adptr As New MySqlDataAdapter(cmd)
                    dtReservedBooks.Clear()
                    adptr.Fill(dtReservedBooks)

                    If dtReservedBooks.Rows.Count > 0 Then
                        DgvReserve.DataSource = dtReservedBooks
                        DgvReserve.Refresh()
                        For i = 0 To DgvReserve.Rows.Count - 1
                            DgvReserve.Rows(i).Height = 50
                        Next
                        DgvReserve.ClearSelection()
                    Else
                        DgvReserve.DataSource = dtReservedBooks
                        DgvReserve.Refresh()
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



    Public Sub UpdateQnty(BookID)
        con.Close()
        Try
            con.Open()
            Dim query As String = "SELECT quantity FROM books WHERE book_id=@id"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", BookID)
                Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar())
                If count >= 1 Then
                    count -= 1
                    available = True
                Else
                    MessageBox.Show("Book is Unavailable for borrowing or reservation. No copies left", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    available = False
                    Return
                End If

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
End Class
