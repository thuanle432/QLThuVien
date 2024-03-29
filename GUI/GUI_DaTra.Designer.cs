
namespace GUI
{
    partial class GUI_DaTra
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Load_Da_Tra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Load_DaTra = new System.Windows.Forms.Button();
            this.btn_DaTra = new System.Windows.Forms.Button();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Load_Da_Tra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách Đã Trả";
            // 
            // Load_Da_Tra
            // 
            this.Load_Da_Tra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Load_Da_Tra.Location = new System.Drawing.Point(182, 232);
            this.Load_Da_Tra.Name = "Load_Da_Tra";
            this.Load_Da_Tra.RowHeadersWidth = 51;
            this.Load_Da_Tra.RowTemplate.Height = 24;
            this.Load_Da_Tra.Size = new System.Drawing.Size(842, 194);
            this.Load_Da_Tra.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Load_DaTra);
            this.groupBox1.Controls.Add(this.btn_DaTra);
            this.groupBox1.Controls.Add(this.selectDate);
            this.groupBox1.Location = new System.Drawing.Point(182, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // Load_DaTra
            // 
            this.Load_DaTra.Location = new System.Drawing.Point(721, 20);
            this.Load_DaTra.Name = "Load_DaTra";
            this.Load_DaTra.Size = new System.Drawing.Size(95, 23);
            this.Load_DaTra.TabIndex = 2;
            this.Load_DaTra.Text = "Danh sách";
            this.Load_DaTra.UseVisualStyleBackColor = true;
            this.Load_DaTra.Click += new System.EventHandler(this.Load_DaTra_Click);
            // 
            // btn_DaTra
            // 
            this.btn_DaTra.Location = new System.Drawing.Point(384, 21);
            this.btn_DaTra.Name = "btn_DaTra";
            this.btn_DaTra.Size = new System.Drawing.Size(75, 23);
            this.btn_DaTra.TabIndex = 1;
            this.btn_DaTra.Text = "Tìm";
            this.btn_DaTra.UseVisualStyleBackColor = true;
            this.btn_DaTra.Click += new System.EventHandler(this.btn_DaTra_Click);
            // 
            // selectDate
            // 
            this.selectDate.Location = new System.Drawing.Point(156, 22);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(200, 22);
            this.selectDate.TabIndex = 0;
            // 
            // GUI_DaTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Load_Da_Tra);
            this.Controls.Add(this.label1);
            this.Name = "GUI_DaTra";
            this.Size = new System.Drawing.Size(1233, 618);
            ((System.ComponentModel.ISupportInitialize)(this.Load_Da_Tra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Load_Da_Tra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Load_DaTra;
        private System.Windows.Forms.Button btn_DaTra;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
