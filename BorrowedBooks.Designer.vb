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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.BtnReturned = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnViewReturnedBorrow = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.DgvBorrow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBorrow.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvBorrow.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBorrow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBorrow.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column10, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9})
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
        'BtnReturned
        '
        Me.BtnReturned.Enabled = False
        Me.BtnReturned.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturned.Location = New System.Drawing.Point(1008, 69)
        Me.BtnReturned.Name = "BtnReturned"
        Me.BtnReturned.Size = New System.Drawing.Size(162, 34)
        Me.BtnReturned.TabIndex = 1
        Me.BtnReturned.Text = "Set as Returned"
        Me.BtnReturned.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(392, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 26)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnViewReturnedBorrow
        '
        Me.BtnViewReturnedBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewReturnedBorrow.Location = New System.Drawing.Point(1176, 69)
        Me.BtnViewReturnedBorrow.Name = "BtnViewReturnedBorrow"
        Me.BtnViewReturnedBorrow.Size = New System.Drawing.Size(162, 34)
        Me.BtnViewReturnedBorrow.TabIndex = 5
        Me.BtnViewReturnedBorrow.Text = "View Returned"
        Me.BtnViewReturnedBorrow.UseVisualStyleBackColor = True
        '
        'DgvReturned
        '
        Me.DgvReturned.AllowUserToAddRows = False
        Me.DgvReturned.AllowUserToDeleteRows = False
        Me.DgvReturned.AllowUserToOrderColumns = True
        Me.DgvReturned.AllowUserToResizeColumns = False
        Me.DgvReturned.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvReturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReturned.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DgvReturned.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReturned.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReturned.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.DataGridViewTextBoxColumn2, Me.Column2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1350, 48)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Borrowed Books"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BorrowedBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvReturned)
        Me.Controls.Add(Me.BtnViewReturnedBorrow)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnReturned)
        Me.Controls.Add(Me.DgvBorrow)
        Me.Name = "BorrowedBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BorrowedBooks"
        CType(Me.DgvBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvReturned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvBorrow As DataGridView
    Friend WithEvents BtnReturned As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
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
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
