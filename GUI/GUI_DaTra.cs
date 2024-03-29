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
    public partial class GUI_DaTra : UserControl
    {
        BLL_DaTra bLLDaTra = new BLL_DaTra(); 
        public GUI_DaTra()
        {
            InitializeComponent();
            LoadDaTraDaTa();
        }
        void LoadDaTraDaTa(int? day = null, int? month = null, int? year = null)
        {
            Load_Da_Tra.DataSource = bLLDaTra.GetPhieuTraInfos();
            Load_Da_Tra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Load_Da_Tra.ScrollBars = ScrollBars.Vertical;
            Load_Da_Tra.Refresh();
        }
       
        private void btn_DaTra_Click(object sender, EventArgs e)
        {
            int day = selectDate.Value.Day;
            int month = selectDate.Value.Month;
            int year = selectDate.Value.Year;
            LoadDaTraDaTa(day, month, year);
        }

        private void Load_DaTra_Click(object sender, EventArgs e)
        {
            LoadDaTraDaTa();
        }

    }
}
