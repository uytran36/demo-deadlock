namespace SQL.cn.khachHang
{
    partial class dsLichSuXem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelList = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(12, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(124, 13);
            this.labelHello.TabIndex = 33;
            this.labelHello.Text = "Xin chào, CHINHANH01";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 254);
            this.dataGridView1.TabIndex = 32;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(12, 116);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(114, 13);
            this.labelList.TabIndex = 31;
            this.labelList.Text = "Danh sách lịch sử xem";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(632, 15);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 26;
            this.btnUser.Text = "Cá nhân";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(713, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(392, 44);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(188, 52);
            this.btnOwner.TabIndex = 51;
            this.btnOwner.Text = "Chủ nhà";
            this.btnOwner.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(586, 44);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(202, 52);
            this.btnStaff.TabIndex = 49;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(207, 44);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(179, 52);
            this.btnPost.TabIndex = 50;
            this.btnPost.Text = "Bài đăng";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(12, 44);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(189, 52);
            this.btnCus.TabIndex = 48;
            this.btnCus.Text = "Khách hàng";
            this.btnCus.UseVisualStyleBackColor = true;
            // 
            // dsLichSuXem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogout);
            this.Name = "dsLichSuXem";
            this.Text = "dsLichSuXem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCus;
    }
}