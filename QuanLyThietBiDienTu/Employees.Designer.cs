namespace QuanLyThietBiDienTu
{
    partial class Employees
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
            this.datagridview_Employees = new System.Windows.Forms.DataGridView();
            this.col_manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Employees)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview_Employees
            // 
            this.datagridview_Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_Employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_manv,
            this.col_hoTen,
            this.col_sdt,
            this.col_ngaysinh,
            this.col_gioitinh,
            this.col_NQL});
            this.datagridview_Employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_Employees.Location = new System.Drawing.Point(0, 42);
            this.datagridview_Employees.Name = "datagridview_Employees";
            this.datagridview_Employees.RowHeadersWidth = 62;
            this.datagridview_Employees.RowTemplate.Height = 28;
            this.datagridview_Employees.Size = new System.Drawing.Size(889, 408);
            this.datagridview_Employees.TabIndex = 6;
            // 
            // col_manv
            // 
            this.col_manv.DataPropertyName = "maNV";
            this.col_manv.HeaderText = "MaNV";
            this.col_manv.MinimumWidth = 8;
            this.col_manv.Name = "col_manv";
            // 
            // col_hoTen
            // 
            this.col_hoTen.DataPropertyName = "hoTen";
            this.col_hoTen.HeaderText = "HoTen";
            this.col_hoTen.MinimumWidth = 8;
            this.col_hoTen.Name = "col_hoTen";
            // 
            // col_sdt
            // 
            this.col_sdt.DataPropertyName = "sdt";
            this.col_sdt.HeaderText = "SDT";
            this.col_sdt.MinimumWidth = 8;
            this.col_sdt.Name = "col_sdt";
            // 
            // col_ngaysinh
            // 
            this.col_ngaysinh.DataPropertyName = "ngaySinh";
            this.col_ngaysinh.HeaderText = "NgaySinh";
            this.col_ngaysinh.MinimumWidth = 8;
            this.col_ngaysinh.Name = "col_ngaysinh";
            // 
            // col_gioitinh
            // 
            this.col_gioitinh.DataPropertyName = "gioiTinh";
            this.col_gioitinh.HeaderText = "Gioi Tinh";
            this.col_gioitinh.MinimumWidth = 8;
            this.col_gioitinh.Name = "col_gioitinh";
            // 
            // col_NQL
            // 
            this.col_NQL.DataPropertyName = "maNQL";
            this.col_NQL.HeaderText = "maNQL";
            this.col_NQL.MinimumWidth = 8;
            this.col_NQL.Name = "col_NQL";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.datagridview_Employees);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.Controls.SetChildIndex(this.datagridview_Employees, 0);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_Employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NQL;
    }
}