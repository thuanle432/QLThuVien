using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class GUI_DangMuon : UserControl
    {
        BLL_DangMuon bLLDangMuon = new BLL_DangMuon();

        public GUI_DangMuon()
        {
            InitializeComponent();
            LoadDangMuonData();
        }
        public void LoadDangMuonData()
        {
    

            List_Dang_Muon.DataSource = bLLDangMuon.GetPhieuMuonInfos();
            List_Dang_Muon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List_Dang_Muon.ScrollBars = ScrollBars.Vertical;
            List_Dang_Muon.Refresh();
        }

        private void btn_ListMuon_Click(object sender, EventArgs e)
        {
            List_Dang_Muon.DataSource = bLLDangMuon.GetPhieuMuonInfos();
        }

        private void btn_Search_DangMuon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textMaPhieu.Text))
            {
                int maPhieuMuon;
                if (int.TryParse(textMaPhieu.Text, out maPhieuMuon))
                {
                    var result = bLLDangMuon.GetPhieuMuonByMa(maPhieuMuon).Cast<dynamic>().ToList();
                    if (result.Any())
                    {
                        List_Dang_Muon.DataSource = result;
                        List_Dang_Muon.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã phiếu mượn.");
                        LoadDangMuonData();
                        List_Dang_Muon.DataSource = null;
                        List_Dang_Muon.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Mã phiếu mượn phải là số.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã phiếu mượn cần tìm.");
            }
        }
    }
}
