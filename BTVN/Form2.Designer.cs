namespace BTVN
{
    partial class NhanVienForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btn_Dongy = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lương căn bản";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(254, 62);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(299, 22);
            this.txtMSNV.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(254, 184);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(299, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(254, 274);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(299, 22);
            this.txtLuong.TabIndex = 1;
            // 
            // btn_Dongy
            // 
            this.btn_Dongy.Location = new System.Drawing.Point(254, 357);
            this.btn_Dongy.Name = "btn_Dongy";
            this.btn_Dongy.Size = new System.Drawing.Size(75, 23);
            this.btn_Dongy.TabIndex = 2;
            this.btn_Dongy.Text = "Đồng ý";
            this.btn_Dongy.UseVisualStyleBackColor = true;
            this.btn_Dongy.Click += new System.EventHandler(this.btn_Dongy_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(478, 357);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(75, 23);
            this.btn_boqua.TabIndex = 3;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_Dongy);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhanVienForm";
            this.Text = "Nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btn_Dongy;
        private System.Windows.Forms.Button btn_boqua;
    }
}