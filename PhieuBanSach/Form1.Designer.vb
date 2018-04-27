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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaPhieuBan = New System.Windows.Forms.TextBox()
        Me.txtNgayLap = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddKH = New System.Windows.Forms.Button()
        Me.dgvHD = New System.Windows.Forms.DataGridView()
        Me.txtThanhTienNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtThanhTienChar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTienNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(319, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 93)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phiếu Bán Sách"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Phiếu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(11, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày Lập"
        '
        'txtMaPhieuBan
        '
        Me.txtMaPhieuBan.Enabled = False
        Me.txtMaPhieuBan.HideSelection = False
        Me.txtMaPhieuBan.Location = New System.Drawing.Point(152, 12)
        Me.txtMaPhieuBan.Name = "txtMaPhieuBan"
        Me.txtMaPhieuBan.ReadOnly = True
        Me.txtMaPhieuBan.Size = New System.Drawing.Size(89, 20)
        Me.txtMaPhieuBan.TabIndex = 0
        '
        'txtNgayLap
        '
        Me.txtNgayLap.Enabled = False
        Me.txtNgayLap.HideSelection = False
        Me.txtNgayLap.Location = New System.Drawing.Point(152, 50)
        Me.txtNgayLap.Name = "txtNgayLap"
        Me.txtNgayLap.ReadOnly = True
        Me.txtNgayLap.Size = New System.Drawing.Size(89, 20)
        Me.txtNgayLap.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoCheck = False
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(131, 53)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtMaKH
        '
        Me.txtMaKH.Enabled = False
        Me.txtMaKH.HideSelection = False
        Me.txtMaKH.Location = New System.Drawing.Point(231, 27)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(79, 20)
        Me.txtMaKH.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mã Khách Hàng"
        '
        'txtHoTen
        '
        Me.txtHoTen.HideSelection = False
        Me.txtHoTen.Location = New System.Drawing.Point(149, 70)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.ReadOnly = True
        Me.txtHoTen.Size = New System.Drawing.Size(161, 20)
        Me.txtHoTen.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(30, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Họ Tên"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(382, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 26)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.HideSelection = False
        Me.txtEmail.Location = New System.Drawing.Point(501, 27)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(161, 20)
        Me.txtEmail.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(382, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 26)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "SĐT"
        '
        'txtSDT
        '
        Me.txtSDT.HideSelection = False
        Me.txtSDT.Location = New System.Drawing.Point(501, 112)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.ReadOnly = True
        Me.txtSDT.Size = New System.Drawing.Size(161, 20)
        Me.txtSDT.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnAddKH)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTienNo)
        Me.Panel1.Controls.Add(Me.txtDiaChi)
        Me.Panel1.Controls.Add(Me.txtSDT)
        Me.Panel1.Controls.Add(Me.txtMaKH)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtHoTen)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(12, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 149)
        Me.Panel1.TabIndex = 0
        '
        'btnAddKH
        '
        Me.btnAddKH.BackColor = System.Drawing.Color.Blue
        Me.btnAddKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddKH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddKH.Location = New System.Drawing.Point(693, 38)
        Me.btnAddKH.Name = "btnAddKH"
        Me.btnAddKH.Size = New System.Drawing.Size(106, 52)
        Me.btnAddKH.TabIndex = 4
        Me.btnAddKH.Text = "Thêm Khách Hàng Mới"
        Me.btnAddKH.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddKH.UseVisualStyleBackColor = False
        '
        'dgvHD
        '
        Me.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHD.Location = New System.Drawing.Point(12, 240)
        Me.dgvHD.Name = "dgvHD"
        Me.dgvHD.Size = New System.Drawing.Size(806, 160)
        Me.dgvHD.TabIndex = 11
        '
        'txtThanhTienNum
        '
        Me.txtThanhTienNum.Enabled = False
        Me.txtThanhTienNum.HideSelection = False
        Me.txtThanhTienNum.Location = New System.Drawing.Point(235, 424)
        Me.txtThanhTienNum.Name = "txtThanhTienNum"
        Me.txtThanhTienNum.ReadOnly = True
        Me.txtThanhTienNum.Size = New System.Drawing.Size(578, 20)
        Me.txtThanhTienNum.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(34, 418)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 26)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Thành Tiền"
        '
        'txtThanhTienChar
        '
        Me.txtThanhTienChar.Enabled = False
        Me.txtThanhTienChar.HideSelection = False
        Me.txtThanhTienChar.Location = New System.Drawing.Point(235, 460)
        Me.txtThanhTienChar.Name = "txtThanhTienChar"
        Me.txtThanhTienChar.ReadOnly = True
        Me.txtThanhTienChar.Size = New System.Drawing.Size(578, 20)
        Me.txtThanhTienChar.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(34, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 26)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Thành Tiền ( Chữ )"
        '
        'dgvKH
        '
        Me.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(836, 27)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(271, 371)
        Me.dgvKH.TabIndex = 12
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.btnRefresh.Location = New System.Drawing.Point(847, 429)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 43)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Làm Mới"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Location = New System.Drawing.Point(988, 429)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 43)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Xuất Hóa Đơn"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(30, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 26)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Tiền Nợ"
        '
        'txtTienNo
        '
        Me.txtTienNo.HideSelection = False
        Me.txtTienNo.Location = New System.Drawing.Point(149, 112)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.ReadOnly = True
        Me.txtTienNo.Size = New System.Drawing.Size(161, 20)
        Me.txtTienNo.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(382, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 26)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Địa Chỉ"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.HideSelection = False
        Me.txtDiaChi.Location = New System.Drawing.Point(501, 70)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(161, 20)
        Me.txtDiaChi.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1119, 500)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.dgvHD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtThanhTienChar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtThanhTienNum)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtNgayLap)
        Me.Controls.Add(Me.txtMaPhieuBan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaPhieuBan As TextBox
    Friend WithEvents txtNgayLap As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddKH As Button
    Friend WithEvents dgvHD As DataGridView
    Friend WithEvents txtThanhTienNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtThanhTienChar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvKH As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTienNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label11 As Label
End Class
