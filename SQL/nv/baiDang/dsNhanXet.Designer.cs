
namespace SQL.nv.baiDang
{
    partial class dsNhanXet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelList = new System.Windows.Forms.Label();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 173);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 313);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(47, 139);
            this.labelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(232, 17);
            this.labelList.TabIndex = 33;
            this.labelList.Text = "Danh sách nhận xét của bài đăng 1";
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(831, 49);
            this.btnOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(251, 64);
            this.btnOwner.TabIndex = 211;
            this.btnOwner.Text = "Chủ nhà";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(460, 49);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(239, 64);
            this.btnPost.TabIndex = 210;
            this.btnPost.Text = "Bài đăng";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(50, 49);
            this.btnCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(252, 64);
            this.btnCus.TabIndex = 208;
            this.btnCus.Text = "Khách hàng";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(48, 20);
            this.labelHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(106, 17);
            this.labelHello.TabIndex = 207;
            this.labelHello.Text = "Xin chào, NV01";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(875, 14);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 28);
            this.btnUser.TabIndex = 205;
            this.btnUser.Text = "Cá nhân";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(983, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 206;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(396, 509);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 213;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(621, 509);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 214;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dsNhanXet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 550);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelList);
            this.Name = "dsNhanXet";
            this.Text = "dsNhanXet";
            this.Load += new System.EventHandler(this.dsNhanXet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
    }
}