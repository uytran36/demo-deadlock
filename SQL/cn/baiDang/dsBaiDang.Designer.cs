
namespace SQL.cn.baiDang
{
    partial class dsBaiDang
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewBaiDang = new System.Windows.Forms.DataGridView();
            this.labelList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaiDang)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cá nhân";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(977, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 33;
            this.button2.Text = "Đăng xuất";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBaiDang
            // 
            this.dataGridViewBaiDang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaiDang.Location = new System.Drawing.Point(43, 148);
            this.dataGridViewBaiDang.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBaiDang.Name = "dataGridViewBaiDang";
            this.dataGridViewBaiDang.RowHeadersWidth = 51;
            this.dataGridViewBaiDang.Size = new System.Drawing.Size(1031, 366);
            this.dataGridViewBaiDang.TabIndex = 31;
            this.dataGridViewBaiDang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBaiDang_CellClick);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(40, 119);
            this.labelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(135, 17);
            this.labelList.TabIndex = 30;
            this.labelList.Text = "Danh sách bài đăng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Xin chào, CHINHANH01";
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(550, 51);
            this.btnOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(251, 64);
            this.btnOwner.TabIndex = 208;
            this.btnOwner.Text = "Chủ nhà";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(809, 51);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(269, 64);
            this.btnStaff.TabIndex = 206;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(303, 51);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(239, 64);
            this.btnPost.TabIndex = 207;
            this.btnPost.Text = "Bài đăng";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(43, 51);
            this.btnCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(252, 64);
            this.btnCus.TabIndex = 205;
            this.btnCus.Text = "Khách hàng";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(530, 522);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 209;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dsBaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 605);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewBaiDang);
            this.Controls.Add(this.labelList);
            this.Name = "dsBaiDang";
            this.Text = "dsBaiDang";
            this.Load += new System.EventHandler(this.dsBaiDang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaiDang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewBaiDang;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button btnAdd;
    }
}