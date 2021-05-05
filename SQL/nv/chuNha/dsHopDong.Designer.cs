
namespace SQL.nv.chuNha
{
    partial class dsHopDong
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.btnCus = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(951, 18);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(843, 18);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 28);
            this.btnUser.TabIndex = 17;
            this.btnUser.Text = "Cá nhân";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(17, 24);
            this.labelHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(106, 17);
            this.labelHello.TabIndex = 24;
            this.labelHello.Text = "Xin chào, NV01";
            this.labelHello.Click += new System.EventHandler(this.labelHello_Click);
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(16, 61);
            this.btnCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(347, 64);
            this.btnCus.TabIndex = 19;
            this.btnCus.Text = "Khách hàng";
            this.btnCus.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(371, 61);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(357, 64);
            this.btnPost.TabIndex = 20;
            this.btnPost.Text = "Bài đăng";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(736, 61);
            this.btnOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(315, 64);
            this.btnOwner.TabIndex = 21;
            this.btnOwner.Text = "Chủ nhà";
            this.btnOwner.UseVisualStyleBackColor = true;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(16, 143);
            this.labelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(140, 17);
            this.labelList.TabIndex = 22;
            this.labelList.Text = "Danh sách hợp đồng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 177);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 313);
            this.dataGridView1.TabIndex = 23;
            // 
            // dsHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogout);
            this.Name = "dsHopDong";
            this.Text = "dsHopDong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}