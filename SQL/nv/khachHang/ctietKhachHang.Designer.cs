﻿namespace SQL
{
    partial class ctietKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHello = new System.Windows.Forms.Label();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelDetail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelMaChiNhanh = new System.Windows.Forms.Label();
            this.labelMaNhanVien = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbMaChiNhanh = new System.Windows.Forms.TextBox();
            this.tbMaNhanVien = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelTieuChi = new System.Windows.Forms.Label();
            this.tbThongTin = new System.Windows.Forms.TextBox();
            this.tbTieuChi = new System.Windows.Forms.TextBox();
            this.btnLichSuThue = new System.Windows.Forms.Button();
            this.btnLichSuXem = new System.Windows.Forms.Button();
            this.btnDanhSachNha = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(16, 9);
            this.labelHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(106, 17);
            this.labelHello.TabIndex = 13;
            this.labelHello.Text = "Xin chào, NV01";
            this.labelHello.Click += new System.EventHandler(this.labelHello_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(736, 55);
            this.btnOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(315, 64);
            this.btnOwner.TabIndex = 12;
            this.btnOwner.Text = "Chủ nhà";
            this.btnOwner.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(371, 55);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(357, 64);
            this.btnPost.TabIndex = 11;
            this.btnPost.Text = "Bài đăng";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(16, 55);
            this.btnCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(347, 64);
            this.btnCus.TabIndex = 10;
            this.btnCus.Text = "Khách hàng";
            this.btnCus.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(843, 12);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 28);
            this.btnUser.TabIndex = 8;
            this.btnUser.Text = "Cá nhân";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(951, 12);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Location = new System.Drawing.Point(16, 123);
            this.labelDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(129, 17);
            this.labelDetail.TabIndex = 14;
            this.labelDetail.Text = "Chi tiết khách hàng";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(196, 192);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 17);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Họ tên:";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Location = new System.Drawing.Point(196, 223);
            this.labelSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(91, 17);
            this.labelSDT.TabIndex = 15;
            this.labelSDT.Text = "Số điện thoại";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(196, 257);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(55, 17);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Địa chỉ:";
            // 
            // labelMaChiNhanh
            // 
            this.labelMaChiNhanh.AutoSize = true;
            this.labelMaChiNhanh.Location = new System.Drawing.Point(196, 288);
            this.labelMaChiNhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaChiNhanh.Name = "labelMaChiNhanh";
            this.labelMaChiNhanh.Size = new System.Drawing.Size(147, 17);
            this.labelMaChiNhanh.TabIndex = 15;
            this.labelMaChiNhanh.Text = "Mã chi nhánh quản lý:";
            // 
            // labelMaNhanVien
            // 
            this.labelMaNhanVien.AutoSize = true;
            this.labelMaNhanVien.Location = new System.Drawing.Point(196, 319);
            this.labelMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaNhanVien.Name = "labelMaNhanVien";
            this.labelMaNhanVien.Size = new System.Drawing.Size(97, 17);
            this.labelMaNhanVien.TabIndex = 15;
            this.labelMaNhanVien.Text = "Mã nhân viên:";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(412, 192);
            this.tbTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(279, 22);
            this.tbTen.TabIndex = 16;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(412, 224);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(279, 22);
            this.tbSDT.TabIndex = 16;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(412, 257);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(279, 22);
            this.tbDiaChi.TabIndex = 16;
            // 
            // tbMaChiNhanh
            // 
            this.tbMaChiNhanh.Location = new System.Drawing.Point(412, 288);
            this.tbMaChiNhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMaChiNhanh.Name = "tbMaChiNhanh";
            this.tbMaChiNhanh.Size = new System.Drawing.Size(279, 22);
            this.tbMaChiNhanh.TabIndex = 16;
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.Location = new System.Drawing.Point(412, 319);
            this.tbMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.Size = new System.Drawing.Size(279, 22);
            this.tbMaNhanVien.TabIndex = 16;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(196, 353);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(180, 17);
            this.labelInfo.TabIndex = 15;
            this.labelInfo.Text = "Thông tin loại nhà yêu cầu:";
            // 
            // labelTieuChi
            // 
            this.labelTieuChi.AutoSize = true;
            this.labelTieuChi.Location = new System.Drawing.Point(196, 388);
            this.labelTieuChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTieuChi.Name = "labelTieuChi";
            this.labelTieuChi.Size = new System.Drawing.Size(62, 17);
            this.labelTieuChi.TabIndex = 15;
            this.labelTieuChi.Text = "Tiêu chí:";
            // 
            // tbThongTin
            // 
            this.tbThongTin.Location = new System.Drawing.Point(412, 351);
            this.tbThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.tbThongTin.Name = "tbThongTin";
            this.tbThongTin.Size = new System.Drawing.Size(279, 22);
            this.tbThongTin.TabIndex = 16;
            // 
            // tbTieuChi
            // 
            this.tbTieuChi.Location = new System.Drawing.Point(412, 382);
            this.tbTieuChi.Margin = new System.Windows.Forms.Padding(4);
            this.tbTieuChi.Name = "tbTieuChi";
            this.tbTieuChi.Size = new System.Drawing.Size(279, 22);
            this.tbTieuChi.TabIndex = 16;
            // 
            // btnLichSuThue
            // 
            this.btnLichSuThue.Location = new System.Drawing.Point(412, 476);
            this.btnLichSuThue.Margin = new System.Windows.Forms.Padding(4);
            this.btnLichSuThue.Name = "btnLichSuThue";
            this.btnLichSuThue.Size = new System.Drawing.Size(100, 28);
            this.btnLichSuThue.TabIndex = 9;
            this.btnLichSuThue.Text = "Lịch sử thuê";
            this.btnLichSuThue.UseVisualStyleBackColor = true;
            // 
            // btnLichSuXem
            // 
            this.btnLichSuXem.Location = new System.Drawing.Point(520, 476);
            this.btnLichSuXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnLichSuXem.Name = "btnLichSuXem";
            this.btnLichSuXem.Size = new System.Drawing.Size(100, 28);
            this.btnLichSuXem.TabIndex = 9;
            this.btnLichSuXem.Text = "Lịch sử xem nhà";
            this.btnLichSuXem.UseVisualStyleBackColor = true;
            // 
            // btnDanhSachNha
            // 
            this.btnDanhSachNha.Location = new System.Drawing.Point(629, 478);
            this.btnDanhSachNha.Margin = new System.Windows.Forms.Padding(4);
            this.btnDanhSachNha.Name = "btnDanhSachNha";
            this.btnDanhSachNha.Size = new System.Drawing.Size(243, 28);
            this.btnDanhSachNha.TabIndex = 9;
            this.btnDanhSachNha.Text = "Danh sách bài đăng theo yêu cầu";
            this.btnDanhSachNha.UseVisualStyleBackColor = true;
            // 
            // btnHopDong
            // 
            this.btnHopDong.Location = new System.Drawing.Point(304, 476);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(100, 28);
            this.btnHopDong.TabIndex = 8;
            this.btnHopDong.Text = "Hợp đồng";
            this.btnHopDong.UseVisualStyleBackColor = true;
            // 
            // ctietKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tbTieuChi);
            this.Controls.Add(this.tbThongTin);
            this.Controls.Add(this.tbMaNhanVien);
            this.Controls.Add(this.tbMaChiNhanh);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.labelTieuChi);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelMaNhanVien);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelMaChiNhanh);
            this.Controls.Add(this.labelSDT);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnDanhSachNha);
            this.Controls.Add(this.btnLichSuXem);
            this.Controls.Add(this.btnLichSuThue);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ctietKhachHang";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelMaChiNhanh;
        private System.Windows.Forms.Label labelMaNhanVien;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbMaChiNhanh;
        private System.Windows.Forms.TextBox tbMaNhanVien;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTieuChi;
        private System.Windows.Forms.TextBox tbThongTin;
        private System.Windows.Forms.TextBox tbTieuChi;
        private System.Windows.Forms.Button btnLichSuThue;
        private System.Windows.Forms.Button btnLichSuXem;
        private System.Windows.Forms.Button btnDanhSachNha;
        private System.Windows.Forms.Button btnHopDong;
    }
}