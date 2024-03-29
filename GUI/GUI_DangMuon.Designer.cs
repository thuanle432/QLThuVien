
namespace GUI
{
    partial class GUI_DangMuon
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
            this.List_Dang_Muon = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ListMuon = new System.Windows.Forms.Button();
            this.btn_Search_DangMuon = new System.Windows.Forms.Button();
            this.textMaPhieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.List_Dang_Muon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách Mượn Sách";
            // 
            // List_Dang_Muon
            // 
            this.List_Dang_Muon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_Dang_Muon.Location = new System.Drawing.Point(136, 195);
            this.List_Dang_Muon.Name = "List_Dang_Muon";
            this.List_Dang_Muon.RowHeadersWidth = 51;
            this.List_Dang_Muon.RowTemplate.Height = 24;
            this.List_Dang_Muon.Size = new System.Drawing.Size(956, 317);
            this.List_Dang_Muon.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMaPhieu);
            this.groupBox1.Controls.Add(this.btn_Search_DangMuon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_ListMuon);
            this.groupBox1.Location = new System.Drawing.Point(136, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã phiếu";
            // 
            // btn_ListMuon
            // 
            this.btn_ListMuon.Location = new System.Drawing.Point(725, 24);
            this.btn_ListMuon.Name = "btn_ListMuon";
            this.btn_ListMuon.Size = new System.Drawing.Size(122, 23);
            this.btn_ListMuon.TabIndex = 5;
            this.btn_ListMuon.Text = "Danh sách";
            this.btn_ListMuon.UseVisualStyleBackColor = true;
            this.btn_ListMuon.Click += new System.EventHandler(this.btn_ListMuon_Click);
            // 
            // btn_Search_DangMuon
            // 
            this.btn_Search_DangMuon.Location = new System.Drawing.Point(382, 29);
            this.btn_Search_DangMuon.Name = "btn_Search_DangMuon";
            this.btn_Search_DangMuon.Size = new System.Drawing.Size(75, 23);
            this.btn_Search_DangMuon.TabIndex = 7;
            this.btn_Search_DangMuon.Text = "Tìm";
            this.btn_Search_DangMuon.UseVisualStyleBackColor = true;
            this.btn_Search_DangMuon.Click += new System.EventHandler(this.btn_Search_DangMuon_Click);
            // 
            // textMaPhieu
            // 
            this.textMaPhieu.Location = new System.Drawing.Point(175, 29);
            this.textMaPhieu.Name = "textMaPhieu";
            this.textMaPhieu.Size = new System.Drawing.Size(179, 22);
            this.textMaPhieu.TabIndex = 8;
            // 
            // GUI_DangMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.List_Dang_Muon);
            this.Controls.Add(this.label1);
            this.Name = "GUI_DangMuon";
            this.Size = new System.Drawing.Size(1215, 571);
            ((System.ComponentModel.ISupportInitialize)(this.List_Dang_Muon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView List_Dang_Muon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ListMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMaPhieu;
        private System.Windows.Forms.Button btn_Search_DangMuon;
    }
}
