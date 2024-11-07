<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowedBooks
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvBorrow = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.DgvReturned = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_cnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clearSearch = New System.Windows.Forms.Button()
        Me.BtnViewReturnedBorrow = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnReturned = New System.Windows.Forms.Button()
        CType(Me.DgvBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvReturned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvBorrow
        '
        Me.DgvBorrow.AllowUserToAddRows = False
        Me.DgvBorrow.AllowUserToDeleteRows = False
        Me.DgvBorrow.AllowUserToOrderColumns = True
        Me.DgvBorrow.AllowUserToResizeColumns = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DgvBorrow.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvBorrow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBorrow.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DgvBorrow.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBorrow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBorrow.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column10, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column12})
        Me.DgvBorrow.Location = New System.Drawing.Point(12, 109)
        Me.DgvBorrow.Name = "DgvBorrow"
        Me.DgvBorrow.ReadOnly = True
        Me.DgvBorrow.RowHeadersVisible = False
        Me.DgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBorrow.Size = New System.Drawing.Size(1326, 608)
        Me.DgvBorrow.TabIndex = 0
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "borrow_id"
        Me.Column8.HeaderText = "BorrowID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "book_id"
        Me.Column1.HeaderText = "BookID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "title"
        Me.Column10.HeaderText = "TITLE"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "borrower_name"
        Me.Column3.HeaderText = "BORROWER NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "borrower_mobile"
        Me.Column4.HeaderText = "BORROWER MOBILE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "date_borrow"
        Me.Column5.HeaderText = "BORROW DATE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "time_borrow"
        Me.Column6.HeaderText = "BORROW TIME"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "date_to_return"
        Me.Column7.HeaderText = "DATE TO RETURN"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "status"
        Me.Column9.HeaderText = "STATUS"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "num_cnt"
        Me.Column12.HeaderText = "#"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(12, 73)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(374, 26)
        Me.TxtSearch.TabIndex = 2
        '
        'DgvReturned
        '
        Me.DgvReturned.AllowUserToAddRows = False
        Me.DgvReturned.AllowUserToDeleteRows = False
        Me.DgvReturned.AllowUserToOrderColumns = True
        Me.DgvReturned.AllowUserToResizeColumns = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DgvReturned.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvReturned.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvReturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReturned.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DgvReturned.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReturned.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReturned.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.DataGridViewTextBoxColumn2, Me.Column2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.num_cnt})
        Me.DgvReturned.Location = New System.Drawing.Point(12, 109)
        Me.DgvReturned.Name = "DgvReturned"
        Me.DgvReturned.ReadOnly = True
        Me.DgvReturned.RowHeadersVisible = False
        Me.DgvReturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvReturned.Size = New System.Drawing.Size(1326, 608)
        Me.DgvReturned.TabIndex = 6
        Me.DgvReturned.Visible = False
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "borrow_id"
        Me.Column11.HeaderText = "BorrowID"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "book_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BookID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "title"
        Me.Column2.HeaderText = "TITLE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "borrower_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BORROWER NAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "borrower_mobile"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MOBILE NO."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date_borrow"
        Me.DataGridViewTextBoxColumn5.HeaderText = "BORROW DATE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "time_borrow"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TIME"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "date_to_return"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DATE TO RETURN"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'num_cnt
        '
        Me.num_cnt.DataPropertyName = "num_cnt"
        Me.num_cnt.HeaderText = "#"
        Me.num_cnt.Name = "num_cnt"
        Me.num_cnt.ReadOnly = True
        Me.num_cnt.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1350, 48)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Borrowed Books"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(646, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Not Returned"
        '
        'clearSearch
        '
        Me.clearSearch.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_x_10
        Me.clearSearch.Location = New System.Drawing.Point(365, 76)
        Me.clearSearch.Name = "clearSearch"
        Me.clearSearch.Size = New System.Drawing.Size(18, 20)
        Me.clearSearch.TabIndex = 9
        Me.clearSearch.UseVisualStyleBackColor = True
        '
        'BtnViewReturnedBorrow
        '
        Me.BtnViewReturnedBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewReturnedBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewReturnedBorrow.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_eye_44
        Me.BtnViewReturnedBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnViewReturnedBorrow.Location = New System.Drawing.Point(1206, 69)
        Me.BtnViewReturnedBorrow.Name = "BtnViewReturnedBorrow"
        Me.BtnViewReturnedBorrow.Size = New System.Drawing.Size(132, 34)
        Me.BtnViewReturnedBorrow.TabIndex = 5
        Me.BtnViewReturnedBorrow.Text = "View Returned"
        Me.BtnViewReturnedBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnViewReturnedBorrow.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Image = Global.LibraryManagementSystem.My.Resources.Resources.find4
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSearch.Location = New System.Drawing.Point(392, 73)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(90, 26)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "SEARCH"
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnReturned
        '
        Me.BtnReturned.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReturned.Enabled = False
        Me.BtnReturned.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturned.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_check_30__1_
        Me.BtnReturned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReturned.Location = New System.Drawing.Point(1050, 69)
        Me.BtnReturned.Name = "BtnReturned"
        Me.BtnReturned.Size = New System.Drawing.Size(144, 34)
        Me.BtnReturned.TabIndex = 1
        Me.BtnReturned.Text = "Set as Returned"
        Me.BtnReturned.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReturned.UseVisualStyleBackColor = True
        '
        'BorrowedBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.clearSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvReturned)
        Me.Controls.Add(Me.BtnViewReturnedBorrow)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.BtnReturned)
        Me.Controls.Add(Me.DgvBorrow)
        Me.Name = "BorrowedBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BORROWED BOOKS"
        CType(Me.DgvBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvReturned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvBorrow As DataGridView
    Friend WithEvents BtnReturned As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnViewReturnedBorrow As Button
    Friend WithEvents DgvReturned As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents num_cnt As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents clearSearch As Button
End Class
