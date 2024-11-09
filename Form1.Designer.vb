<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBorrowedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddBookForm = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.EditForm = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtEditQnty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEditId = New System.Windows.Forms.TextBox()
        Me.BtnCancelEditing = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEditAuthor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEditTitle = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.BorrowForm = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DtpDateReturn = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtMobile = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBorrowBookId = New System.Windows.Forms.TextBox()
        Me.BtnCancelBorrow = New System.Windows.Forms.Button()
        Me.BtnBorrowSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBorrowBookTitle = New System.Windows.Forms.TextBox()
        Me.ReserveForm = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DtpPickupDate = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtReserveMobile = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtReserveBookId = New System.Windows.Forms.TextBox()
        Me.BtnCancelReserve = New System.Windows.Forms.Button()
        Me.BtnSaveReserve = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtReserveName = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtReserveBookTitle = New System.Windows.Forms.TextBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.DgvReserve = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BtnViewFulfilled = New System.Windows.Forms.Button()
        Me.BtnViewCancelled = New System.Windows.Forms.Button()
        Me.BtnViewReserved = New System.Windows.Forms.Button()
        Me.BtnFulfilled = New System.Windows.Forms.Button()
        Me.BtnCancelReservation = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnConfirmFulfill = New System.Windows.Forms.Button()
        Me.BtnCancelFulfill = New System.Windows.Forms.Button()
        Me.DtpReservedToReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.clearSearch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnBorrow = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddBookForm.SuspendLayout()
        Me.EditForm.SuspendLayout()
        Me.BorrowForm.SuspendLayout()
        Me.ReserveForm.SuspendLayout()
        CType(Me.DgvReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.BooksToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 42)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(62, 38)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_logout_20
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(104, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewBorrowedBooksToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(64, 38)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'ViewBorrowedBooksToolStripMenuItem
        '
        Me.ViewBorrowedBooksToolStripMenuItem.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_books_emoji_20
        Me.ViewBorrowedBooksToolStripMenuItem.Name = "ViewBorrowedBooksToolStripMenuItem"
        Me.ViewBorrowedBooksToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.ViewBorrowedBooksToolStripMenuItem.Text = "View Borrowed Books"
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgvBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.book_id, Me.title, Me.author, Me.Column6, Me.Column8})
        Me.dgvBooks.Location = New System.Drawing.Point(458, 115)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.RowHeadersVisible = False
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(880, 609)
        Me.dgvBooks.TabIndex = 1
        '
        'book_id
        '
        Me.book_id.DataPropertyName = "book_id"
        Me.book_id.FillWeight = 99.49239!
        Me.book_id.HeaderText = "BookID"
        Me.book_id.Name = "book_id"
        Me.book_id.ReadOnly = True
        '
        'title
        '
        Me.title.DataPropertyName = "title"
        Me.title.FillWeight = 99.49239!
        Me.title.HeaderText = "TITLE"
        Me.title.Name = "title"
        Me.title.ReadOnly = True
        '
        'author
        '
        Me.author.DataPropertyName = "author"
        Me.author.FillWeight = 99.49239!
        Me.author.HeaderText = "AUTHOR"
        Me.author.Name = "author"
        Me.author.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.DataPropertyName = "quantity"
        Me.Column6.FillWeight = 101.5228!
        Me.Column6.HeaderText = "QUANTITY"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "num_cnt"
        Me.Column8.HeaderText = "#"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'AddBookForm
        '
        Me.AddBookForm.BackColor = System.Drawing.Color.CornflowerBlue
        Me.AddBookForm.Controls.Add(Me.Label17)
        Me.AddBookForm.Controls.Add(Me.TxtQuantity)
        Me.AddBookForm.Controls.Add(Me.Label3)
        Me.AddBookForm.Controls.Add(Me.BtnCancel)
        Me.AddBookForm.Controls.Add(Me.BtnAdd)
        Me.AddBookForm.Controls.Add(Me.Label2)
        Me.AddBookForm.Controls.Add(Me.txtAuthor)
        Me.AddBookForm.Controls.Add(Me.Label1)
        Me.AddBookForm.Controls.Add(Me.txtTitle)
        Me.AddBookForm.Location = New System.Drawing.Point(12, 115)
        Me.AddBookForm.Name = "AddBookForm"
        Me.AddBookForm.Size = New System.Drawing.Size(440, 239)
        Me.AddBookForm.TabIndex = 2
        Me.AddBookForm.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 161)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Qnty :"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(68, 155)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(74, 26)
        Me.TxtQuantity.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(434, 37)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ADD BOOK"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_close_window_19
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(346, 195)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 28)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_add_21
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(247, 195)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(93, 28)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "ADD BOOK"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AUTHOR :"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(69, 117)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(345, 26)
        Me.txtAuthor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TITLE :"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(69, 79)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(345, 26)
        Me.txtTitle.TabIndex = 0
        '
        'EditForm
        '
        Me.EditForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditForm.BackColor = System.Drawing.Color.CornflowerBlue
        Me.EditForm.Controls.Add(Me.Label4)
        Me.EditForm.Controls.Add(Me.Label27)
        Me.EditForm.Controls.Add(Me.txtEditQnty)
        Me.EditForm.Controls.Add(Me.Label7)
        Me.EditForm.Controls.Add(Me.txtEditId)
        Me.EditForm.Controls.Add(Me.BtnCancelEditing)
        Me.EditForm.Controls.Add(Me.BtnUpdate)
        Me.EditForm.Controls.Add(Me.Label5)
        Me.EditForm.Controls.Add(Me.txtEditAuthor)
        Me.EditForm.Controls.Add(Me.Label6)
        Me.EditForm.Controls.Add(Me.txtEditTitle)
        Me.EditForm.Location = New System.Drawing.Point(620, 118)
        Me.EditForm.Name = "EditForm"
        Me.EditForm.Size = New System.Drawing.Size(612, 0)
        Me.EditForm.TabIndex = 7
        Me.EditForm.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(606, 37)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "EDIT BOOK"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(50, 220)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 13)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "QNTY :"
        '
        'txtEditQnty
        '
        Me.txtEditQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditQnty.Location = New System.Drawing.Point(53, 236)
        Me.txtEditQnty.Name = "txtEditQnty"
        Me.txtEditQnty.Size = New System.Drawing.Size(100, 26)
        Me.txtEditQnty.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "BOOK ID:"
        '
        'txtEditId
        '
        Me.txtEditId.Enabled = False
        Me.txtEditId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditId.Location = New System.Drawing.Point(106, 68)
        Me.txtEditId.Name = "txtEditId"
        Me.txtEditId.Size = New System.Drawing.Size(100, 26)
        Me.txtEditId.TabIndex = 7
        '
        'BtnCancelEditing
        '
        Me.BtnCancelEditing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelEditing.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_close_window_19
        Me.BtnCancelEditing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelEditing.Location = New System.Drawing.Point(470, 255)
        Me.BtnCancelEditing.Name = "BtnCancelEditing"
        Me.BtnCancelEditing.Size = New System.Drawing.Size(81, 28)
        Me.BtnCancelEditing.TabIndex = 5
        Me.BtnCancelEditing.Text = "CANCEL"
        Me.BtnCancelEditing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelEditing.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_update_28
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(371, 255)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(81, 28)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "AUTHOR"
        '
        'txtEditAuthor
        '
        Me.txtEditAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditAuthor.Location = New System.Drawing.Point(53, 182)
        Me.txtEditAuthor.Name = "txtEditAuthor"
        Me.txtEditAuthor.Size = New System.Drawing.Size(492, 26)
        Me.txtEditAuthor.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "TITLE:"
        '
        'txtEditTitle
        '
        Me.txtEditTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditTitle.Location = New System.Drawing.Point(53, 126)
        Me.txtEditTitle.Name = "txtEditTitle"
        Me.txtEditTitle.Size = New System.Drawing.Size(492, 26)
        Me.txtEditTitle.TabIndex = 0
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ForeColor = System.Drawing.Color.Navy
        Me.LblDate.Location = New System.Drawing.Point(12, 52)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(48, 20)
        Me.LblDate.TabIndex = 9
        Me.LblDate.Text = "Date"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.Navy
        Me.LblTime.Location = New System.Drawing.Point(11, 86)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(47, 20)
        Me.LblTime.TabIndex = 10
        Me.LblTime.Text = "Time"
        '
        'BorrowForm
        '
        Me.BorrowForm.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BorrowForm.Controls.Add(Me.Label9)
        Me.BorrowForm.Controls.Add(Me.Label16)
        Me.BorrowForm.Controls.Add(Me.DtpDateReturn)
        Me.BorrowForm.Controls.Add(Me.Label15)
        Me.BorrowForm.Controls.Add(Me.Label14)
        Me.BorrowForm.Controls.Add(Me.Label13)
        Me.BorrowForm.Controls.Add(Me.TxtMobile)
        Me.BorrowForm.Controls.Add(Me.Label12)
        Me.BorrowForm.Controls.Add(Me.Label8)
        Me.BorrowForm.Controls.Add(Me.TxtBorrowBookId)
        Me.BorrowForm.Controls.Add(Me.BtnCancelBorrow)
        Me.BorrowForm.Controls.Add(Me.BtnBorrowSave)
        Me.BorrowForm.Controls.Add(Me.Label10)
        Me.BorrowForm.Controls.Add(Me.TxtName)
        Me.BorrowForm.Controls.Add(Me.Label11)
        Me.BorrowForm.Controls.Add(Me.TxtBorrowBookTitle)
        Me.BorrowForm.Enabled = False
        Me.BorrowForm.Location = New System.Drawing.Point(12, 363)
        Me.BorrowForm.Name = "BorrowForm"
        Me.BorrowForm.Size = New System.Drawing.Size(440, 336)
        Me.BorrowForm.TabIndex = 9
        Me.BorrowForm.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(3, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(434, 37)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "BORROW BOOK"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(134, 224)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "( Date Today )"
        '
        'DtpDateReturn
        '
        Me.DtpDateReturn.Location = New System.Drawing.Point(137, 249)
        Me.DtpDateReturn.Name = "DtpDateReturn"
        Me.DtpDateReturn.Size = New System.Drawing.Size(200, 20)
        Me.DtpDateReturn.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 251)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "DATE TO RETURN :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "BORROW DATE :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(65, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "MOBILE :"
        '
        'TxtMobile
        '
        Me.TxtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMobile.Location = New System.Drawing.Point(137, 190)
        Me.TxtMobile.Name = "TxtMobile"
        Me.TxtMobile.Size = New System.Drawing.Size(279, 22)
        Me.TxtMobile.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "NAME :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "BOOK ID:"
        '
        'TxtBorrowBookId
        '
        Me.TxtBorrowBookId.Enabled = False
        Me.TxtBorrowBookId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBorrowBookId.Location = New System.Drawing.Point(69, 60)
        Me.TxtBorrowBookId.Name = "TxtBorrowBookId"
        Me.TxtBorrowBookId.Size = New System.Drawing.Size(100, 22)
        Me.TxtBorrowBookId.TabIndex = 7
        '
        'BtnCancelBorrow
        '
        Me.BtnCancelBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelBorrow.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_close_window_19
        Me.BtnCancelBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelBorrow.Location = New System.Drawing.Point(339, 287)
        Me.BtnCancelBorrow.Name = "BtnCancelBorrow"
        Me.BtnCancelBorrow.Size = New System.Drawing.Size(81, 28)
        Me.BtnCancelBorrow.TabIndex = 5
        Me.BtnCancelBorrow.Text = "CANCEL"
        Me.BtnCancelBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelBorrow.UseVisualStyleBackColor = True
        '
        'BtnBorrowSave
        '
        Me.BtnBorrowSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBorrowSave.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_book_shelf_20
        Me.BtnBorrowSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrowSave.Location = New System.Drawing.Point(194, 287)
        Me.BtnBorrowSave.Name = "BtnBorrowSave"
        Me.BtnBorrowSave.Size = New System.Drawing.Size(134, 28)
        Me.BtnBorrowSave.TabIndex = 4
        Me.BtnBorrowSave.Text = "CONFIRM BORROW"
        Me.BtnBorrowSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBorrowSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "BORROWER'S DETAILS"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(137, 160)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(279, 22)
        Me.TxtName.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "TITLE:"
        '
        'TxtBorrowBookTitle
        '
        Me.TxtBorrowBookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBorrowBookTitle.Location = New System.Drawing.Point(69, 95)
        Me.TxtBorrowBookTitle.Name = "TxtBorrowBookTitle"
        Me.TxtBorrowBookTitle.Size = New System.Drawing.Size(347, 22)
        Me.TxtBorrowBookTitle.TabIndex = 0
        '
        'ReserveForm
        '
        Me.ReserveForm.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ReserveForm.Controls.Add(Me.Label24)
        Me.ReserveForm.Controls.Add(Me.Label18)
        Me.ReserveForm.Controls.Add(Me.DtpPickupDate)
        Me.ReserveForm.Controls.Add(Me.Label19)
        Me.ReserveForm.Controls.Add(Me.Label20)
        Me.ReserveForm.Controls.Add(Me.Label21)
        Me.ReserveForm.Controls.Add(Me.TxtReserveMobile)
        Me.ReserveForm.Controls.Add(Me.Label22)
        Me.ReserveForm.Controls.Add(Me.Label23)
        Me.ReserveForm.Controls.Add(Me.TxtReserveBookId)
        Me.ReserveForm.Controls.Add(Me.BtnCancelReserve)
        Me.ReserveForm.Controls.Add(Me.BtnSaveReserve)
        Me.ReserveForm.Controls.Add(Me.Label25)
        Me.ReserveForm.Controls.Add(Me.TxtReserveName)
        Me.ReserveForm.Controls.Add(Me.Label26)
        Me.ReserveForm.Controls.Add(Me.TxtReserveBookTitle)
        Me.ReserveForm.Location = New System.Drawing.Point(12, 357)
        Me.ReserveForm.Name = "ReserveForm"
        Me.ReserveForm.Size = New System.Drawing.Size(440, 342)
        Me.ReserveForm.TabIndex = 16
        Me.ReserveForm.TabStop = False
        Me.ReserveForm.Visible = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Control
        Me.Label24.Location = New System.Drawing.Point(3, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(434, 37)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "RESERVE BOOK"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(134, 223)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "( Date Today )"
        '
        'DtpPickupDate
        '
        Me.DtpPickupDate.Location = New System.Drawing.Point(137, 248)
        Me.DtpPickupDate.Name = "DtpPickupDate"
        Me.DtpPickupDate.Size = New System.Drawing.Size(200, 20)
        Me.DtpPickupDate.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(45, 251)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "PICKUP DATE :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 223)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "RESERVATION DATE :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(65, 194)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "MOBILE :"
        '
        'TxtReserveMobile
        '
        Me.TxtReserveMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReserveMobile.Location = New System.Drawing.Point(137, 189)
        Me.TxtReserveMobile.Name = "TxtReserveMobile"
        Me.TxtReserveMobile.Size = New System.Drawing.Size(279, 22)
        Me.TxtReserveMobile.TabIndex = 10
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(73, 163)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 13)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "NAME :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "BOOK ID:"
        '
        'TxtReserveBookId
        '
        Me.TxtReserveBookId.Enabled = False
        Me.TxtReserveBookId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReserveBookId.Location = New System.Drawing.Point(69, 60)
        Me.TxtReserveBookId.Name = "TxtReserveBookId"
        Me.TxtReserveBookId.Size = New System.Drawing.Size(100, 22)
        Me.TxtReserveBookId.TabIndex = 7
        '
        'BtnCancelReserve
        '
        Me.BtnCancelReserve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelReserve.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_close_window_19
        Me.BtnCancelReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelReserve.Location = New System.Drawing.Point(346, 290)
        Me.BtnCancelReserve.Name = "BtnCancelReserve"
        Me.BtnCancelReserve.Size = New System.Drawing.Size(75, 28)
        Me.BtnCancelReserve.TabIndex = 5
        Me.BtnCancelReserve.Text = "CANCEL"
        Me.BtnCancelReserve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelReserve.UseVisualStyleBackColor = True
        '
        'BtnSaveReserve
        '
        Me.BtnSaveReserve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveReserve.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_books_28
        Me.BtnSaveReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSaveReserve.Location = New System.Drawing.Point(247, 290)
        Me.BtnSaveReserve.Name = "BtnSaveReserve"
        Me.BtnSaveReserve.Size = New System.Drawing.Size(92, 28)
        Me.BtnSaveReserve.TabIndex = 4
        Me.BtnSaveReserve.Text = "RESERVE"
        Me.BtnSaveReserve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSaveReserve.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 132)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(129, 13)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "BORROWER'S DETAILS"
        '
        'TxtReserveName
        '
        Me.TxtReserveName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReserveName.Location = New System.Drawing.Point(137, 158)
        Me.TxtReserveName.Name = "TxtReserveName"
        Me.TxtReserveName.Size = New System.Drawing.Size(279, 22)
        Me.TxtReserveName.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(27, 98)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "TITLE:"
        '
        'TxtReserveBookTitle
        '
        Me.TxtReserveBookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReserveBookTitle.Location = New System.Drawing.Point(69, 94)
        Me.TxtReserveBookTitle.Name = "TxtReserveBookTitle"
        Me.TxtReserveBookTitle.Size = New System.Drawing.Size(347, 22)
        Me.TxtReserveBookTitle.TabIndex = 0
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(458, 86)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(199, 22)
        Me.TxtSearch.TabIndex = 12
        '
        'DgvReserve
        '
        Me.DgvReserve.AllowUserToAddRows = False
        Me.DgvReserve.AllowUserToDeleteRows = False
        Me.DgvReserve.AllowUserToResizeColumns = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DgvReserve.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvReserve.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReserve.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DgvReserve.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReserve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReserve.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column2, Me.Column3, Me.DataGridViewTextBoxColumn3, Me.Column4, Me.Column5, Me.Column7})
        Me.DgvReserve.Location = New System.Drawing.Point(123, 115)
        Me.DgvReserve.Name = "DgvReserve"
        Me.DgvReserve.ReadOnly = True
        Me.DgvReserve.RowHeadersVisible = False
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReserve.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvReserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvReserve.Size = New System.Drawing.Size(1215, 609)
        Me.DgvReserve.TabIndex = 14
        Me.DgvReserve.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "reservation_id"
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column1.HeaderText = "RESERVE ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "book_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BOOK ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TITLE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "name"
        Me.Column2.HeaderText = "NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "mobile"
        Me.Column3.HeaderText = "MOBILE NO."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "date_reserved"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DATE RESERVED"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "pickup_date"
        Me.Column4.HeaderText = "PICKUP DATE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "status"
        Me.Column5.HeaderText = "STATUS"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "num_cnt"
        Me.Column7.HeaderText = "#"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.BtnViewFulfilled)
        Me.Panel1.Controls.Add(Me.BtnViewCancelled)
        Me.Panel1.Controls.Add(Me.BtnViewReserved)
        Me.Panel1.Controls.Add(Me.BtnFulfilled)
        Me.Panel1.Controls.Add(Me.BtnCancelReservation)
        Me.Panel1.Location = New System.Drawing.Point(10, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(118, 609)
        Me.Panel1.TabIndex = 20
        Me.Panel1.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(13, 204)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 13)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "ACTION"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(14, 35)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(35, 13)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "VIEW"
        '
        'BtnViewFulfilled
        '
        Me.BtnViewFulfilled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewFulfilled.Location = New System.Drawing.Point(10, 96)
        Me.BtnViewFulfilled.Name = "BtnViewFulfilled"
        Me.BtnViewFulfilled.Size = New System.Drawing.Size(97, 34)
        Me.BtnViewFulfilled.TabIndex = 22
        Me.BtnViewFulfilled.Text = "FULFILLED"
        Me.BtnViewFulfilled.UseVisualStyleBackColor = True
        '
        'BtnViewCancelled
        '
        Me.BtnViewCancelled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewCancelled.Location = New System.Drawing.Point(10, 134)
        Me.BtnViewCancelled.Name = "BtnViewCancelled"
        Me.BtnViewCancelled.Size = New System.Drawing.Size(97, 34)
        Me.BtnViewCancelled.TabIndex = 21
        Me.BtnViewCancelled.Text = "CANCELLED"
        Me.BtnViewCancelled.UseVisualStyleBackColor = True
        '
        'BtnViewReserved
        '
        Me.BtnViewReserved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewReserved.Location = New System.Drawing.Point(10, 59)
        Me.BtnViewReserved.Name = "BtnViewReserved"
        Me.BtnViewReserved.Size = New System.Drawing.Size(97, 34)
        Me.BtnViewReserved.TabIndex = 20
        Me.BtnViewReserved.Text = "RESERVED"
        Me.BtnViewReserved.UseVisualStyleBackColor = True
        '
        'BtnFulfilled
        '
        Me.BtnFulfilled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFulfilled.Enabled = False
        Me.BtnFulfilled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFulfilled.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_check_30__1_
        Me.BtnFulfilled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFulfilled.Location = New System.Drawing.Point(10, 228)
        Me.BtnFulfilled.Name = "BtnFulfilled"
        Me.BtnFulfilled.Size = New System.Drawing.Size(97, 34)
        Me.BtnFulfilled.TabIndex = 19
        Me.BtnFulfilled.Text = "Fulfilled"
        Me.BtnFulfilled.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFulfilled.UseVisualStyleBackColor = True
        '
        'BtnCancelReservation
        '
        Me.BtnCancelReservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelReservation.Enabled = False
        Me.BtnCancelReservation.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_close_window_19
        Me.BtnCancelReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelReservation.Location = New System.Drawing.Point(10, 267)
        Me.BtnCancelReservation.Name = "BtnCancelReservation"
        Me.BtnCancelReservation.Size = New System.Drawing.Size(97, 34)
        Me.BtnCancelReservation.TabIndex = 18
        Me.BtnCancelReservation.Text = "CANCEL"
        Me.BtnCancelReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelReservation.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnConfirmFulfill)
        Me.Panel2.Controls.Add(Me.BtnCancelFulfill)
        Me.Panel2.Controls.Add(Me.DtpReservedToReturnDate)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Location = New System.Drawing.Point(129, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(287, 112)
        Me.Panel2.TabIndex = 21
        Me.Panel2.Visible = False
        '
        'BtnConfirmFulfill
        '
        Me.BtnConfirmFulfill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfirmFulfill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmFulfill.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_check_30__1_
        Me.BtnConfirmFulfill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfirmFulfill.Location = New System.Drawing.Point(44, 71)
        Me.BtnConfirmFulfill.Name = "BtnConfirmFulfill"
        Me.BtnConfirmFulfill.Size = New System.Drawing.Size(77, 32)
        Me.BtnConfirmFulfill.TabIndex = 25
        Me.BtnConfirmFulfill.Text = "Done"
        Me.BtnConfirmFulfill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConfirmFulfill.UseVisualStyleBackColor = True
        '
        'BtnCancelFulfill
        '
        Me.BtnCancelFulfill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelFulfill.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_close_window_19
        Me.BtnCancelFulfill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelFulfill.Location = New System.Drawing.Point(169, 71)
        Me.BtnCancelFulfill.Name = "BtnCancelFulfill"
        Me.BtnCancelFulfill.Size = New System.Drawing.Size(77, 32)
        Me.BtnCancelFulfill.TabIndex = 19
        Me.BtnCancelFulfill.Text = "CANCEL"
        Me.BtnCancelFulfill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelFulfill.UseVisualStyleBackColor = True
        '
        'DtpReservedToReturnDate
        '
        Me.DtpReservedToReturnDate.Location = New System.Drawing.Point(44, 34)
        Me.DtpReservedToReturnDate.Name = "DtpReservedToReturnDate"
        Me.DtpReservedToReturnDate.Size = New System.Drawing.Size(200, 20)
        Me.DtpReservedToReturnDate.TabIndex = 1
        '
        'Label30
        '
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(0, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(285, 23)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "ENTER DATE TO RETURN"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_update_done_21__1_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(715, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 28)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "REFRESH"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'clearSearch
        '
        Me.clearSearch.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_x_10
        Me.clearSearch.Location = New System.Drawing.Point(635, 89)
        Me.clearSearch.Name = "clearSearch"
        Me.clearSearch.Size = New System.Drawing.Size(20, 16)
        Me.clearSearch.TabIndex = 17
        Me.clearSearch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_management_26
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1219, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 28)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "VIEW RESERVE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Enabled = False
        Me.Button3.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_books_28
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(1058, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 28)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "MAKE RESERVATION"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Image = Global.LibraryManagementSystem.My.Resources.Resources.find2
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSearch.Location = New System.Drawing.Point(663, 85)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(81, 23)
        Me.BtnSearch.TabIndex = 13
        Me.BtnSearch.Text = "SEARCH"
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnBorrow
        '
        Me.BtnBorrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBorrow.Enabled = False
        Me.BtnBorrow.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_book_shelf_20
        Me.BtnBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrow.Location = New System.Drawing.Point(809, 51)
        Me.BtnBorrow.Name = "BtnBorrow"
        Me.BtnBorrow.Size = New System.Drawing.Size(81, 28)
        Me.BtnBorrow.TabIndex = 11
        Me.BtnBorrow.Text = "BORROW"
        Me.BtnBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBorrow.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_edit_text_file_21
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(896, 51)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 28)
        Me.BtnEdit.TabIndex = 8
        Me.BtnEdit.Text = "EDIT"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDel.Enabled = False
        Me.BtnDel.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_delete_211
        Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDel.Location = New System.Drawing.Point(977, 51)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(75, 28)
        Me.BtnDel.TabIndex = 7
        Me.BtnDel.Text = "DELETE"
        Me.BtnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvReserve)
        Me.Controls.Add(Me.ReserveForm)
        Me.Controls.Add(Me.EditForm)
        Me.Controls.Add(Me.clearSearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.BtnBorrow)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.AddBookForm)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BorrowForm)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(895, 500)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIBRARY MANAGEMENT SYSTEM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddBookForm.ResumeLayout(False)
        Me.AddBookForm.PerformLayout()
        Me.EditForm.ResumeLayout(False)
        Me.EditForm.PerformLayout()
        Me.BorrowForm.ResumeLayout(False)
        Me.BorrowForm.PerformLayout()
        Me.ReserveForm.ResumeLayout(False)
        Me.ReserveForm.PerformLayout()
        CType(Me.DgvReserve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBorrowedBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents AddBookForm As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents EditForm As GroupBox
    Friend WithEvents BtnCancelEditing As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEditAuthor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEditTitle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEditId As TextBox
    Friend WithEvents Timer As Timer
    Friend WithEvents LblDate As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtMobile As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBorrowBookId As TextBox
    Friend WithEvents BtnCancelBorrow As Button
    Friend WithEvents BtnBorrowSave As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtBorrowBookTitle As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DtpDateReturn As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Public WithEvents BorrowForm As GroupBox
    Friend WithEvents BtnBorrow As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtQuantity As TextBox
    Public WithEvents ReserveForm As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents DtpPickupDate As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtReserveMobile As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtReserveBookId As TextBox
    Friend WithEvents BtnCancelReserve As Button
    Friend WithEvents BtnSaveReserve As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtReserveName As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TxtReserveBookTitle As TextBox
    Friend WithEvents DgvReserve As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents txtEditQnty As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents book_id As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents author As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents clearSearch As Button
    Friend WithEvents BtnCancelReservation As Button
    Friend WithEvents BtnFulfilled As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents BtnViewFulfilled As Button
    Friend WithEvents BtnViewCancelled As Button
    Friend WithEvents BtnViewReserved As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnConfirmFulfill As Button
    Friend WithEvents BtnCancelFulfill As Button
    Friend WithEvents DtpReservedToReturnDate As DateTimePicker
    Friend WithEvents Label30 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
