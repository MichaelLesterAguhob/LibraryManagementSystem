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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBorrowedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddBookForm = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.EditForm = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEditId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCancelEditing = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEditAuthor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEditTitle = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddBookForm.SuspendLayout()
        Me.EditForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.BooksToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(62, 25)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(104, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewBooksToolStripMenuItem, Me.ViewBorrowedBooksToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'ViewBooksToolStripMenuItem
        '
        Me.ViewBooksToolStripMenuItem.Name = "ViewBooksToolStripMenuItem"
        Me.ViewBooksToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.ViewBooksToolStripMenuItem.Text = "View Books"
        '
        'ViewBorrowedBooksToolStripMenuItem
        '
        Me.ViewBorrowedBooksToolStripMenuItem.Name = "ViewBorrowedBooksToolStripMenuItem"
        Me.ViewBorrowedBooksToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.ViewBorrowedBooksToolStripMenuItem.Text = "View Borrowed Books"
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AllowUserToResizeColumns = False
        Me.dgvBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.BackgroundColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.book_id, Me.title, Me.author})
        Me.dgvBooks.Location = New System.Drawing.Point(458, 69)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.RowHeadersVisible = False
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(880, 648)
        Me.dgvBooks.TabIndex = 1
        '
        'book_id
        '
        Me.book_id.DataPropertyName = "book_id"
        Me.book_id.HeaderText = "BookID"
        Me.book_id.Name = "book_id"
        '
        'title
        '
        Me.title.DataPropertyName = "title"
        Me.title.HeaderText = "TITLE"
        Me.title.Name = "title"
        '
        'author
        '
        Me.author.DataPropertyName = "author"
        Me.author.HeaderText = "AUTHOR"
        Me.author.Name = "author"
        '
        'AddBookForm
        '
        Me.AddBookForm.BackColor = System.Drawing.Color.SteelBlue
        Me.AddBookForm.Controls.Add(Me.Label3)
        Me.AddBookForm.Controls.Add(Me.BtnCancel)
        Me.AddBookForm.Controls.Add(Me.BtnAdd)
        Me.AddBookForm.Controls.Add(Me.Label2)
        Me.AddBookForm.Controls.Add(Me.txtAuthor)
        Me.AddBookForm.Controls.Add(Me.Label1)
        Me.AddBookForm.Controls.Add(Me.txtTitle)
        Me.AddBookForm.Location = New System.Drawing.Point(12, 69)
        Me.AddBookForm.Name = "AddBookForm"
        Me.AddBookForm.Size = New System.Drawing.Size(440, 239)
        Me.AddBookForm.TabIndex = 2
        Me.AddBookForm.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(173, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ADD BOOK"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(340, 195)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(259, 195)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "ADD BOOK"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AUTHOR"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(17, 150)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(398, 26)
        Me.txtAuthor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TITLE:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(17, 94)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(398, 26)
        Me.txtTitle.TabIndex = 0
        '
        'BtnDel
        '
        Me.BtnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDel.Enabled = False
        Me.BtnDel.Location = New System.Drawing.Point(1263, 40)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(75, 23)
        Me.BtnDel.TabIndex = 7
        Me.BtnDel.Text = "DELETE"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.Location = New System.Drawing.Point(1182, 40)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 8
        Me.BtnEdit.Text = "EDIT"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'EditForm
        '
        Me.EditForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditForm.BackColor = System.Drawing.Color.SteelBlue
        Me.EditForm.Controls.Add(Me.Label7)
        Me.EditForm.Controls.Add(Me.txtEditId)
        Me.EditForm.Controls.Add(Me.Label4)
        Me.EditForm.Controls.Add(Me.BtnCancelEditing)
        Me.EditForm.Controls.Add(Me.BtnUpdate)
        Me.EditForm.Controls.Add(Me.Label5)
        Me.EditForm.Controls.Add(Me.txtEditAuthor)
        Me.EditForm.Controls.Add(Me.Label6)
        Me.EditForm.Controls.Add(Me.txtEditTitle)
        Me.EditForm.Location = New System.Drawing.Point(608, 73)
        Me.EditForm.Name = "EditForm"
        Me.EditForm.Size = New System.Drawing.Size(612, 327)
        Me.EditForm.TabIndex = 7
        Me.EditForm.TabStop = False
        Me.EditForm.Visible = False
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EDIT BOOK"
        '
        'BtnCancelEditing
        '
        Me.BtnCancelEditing.Location = New System.Drawing.Point(470, 248)
        Me.BtnCancelEditing.Name = "BtnCancelEditing"
        Me.BtnCancelEditing.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelEditing.TabIndex = 5
        Me.BtnCancelEditing.Text = "CANCEL"
        Me.BtnCancelEditing.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(378, 248)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "UPDATE"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.EditForm)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.AddBookForm)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Library Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddBookForm.ResumeLayout(False)
        Me.AddBookForm.PerformLayout()
        Me.EditForm.ResumeLayout(False)
        Me.EditForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBooksToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCancelEditing As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEditAuthor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEditTitle As TextBox
    Friend WithEvents book_id As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents author As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEditId As TextBox
End Class
