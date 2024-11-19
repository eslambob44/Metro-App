using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metro_business_layer;

namespace Metro_windows_forms_layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        DataTable dtLineStations = new DataTable();
        DataTable dtRoadStations = new DataTable();

        // List stations tab page

        private void pbMetroMap_Click(object sender, EventArgs e)
        {
            Form frm = new frmMetroMap();
            frm.ShowDialog();
        }

        ListViewItem PrepareListViewItem(string StationName , int Line)
        {
            ListViewItem lviStation = new ListViewItem(StationName);
            lviStation.ImageIndex = Line -1;
            return lviStation;
        }

        void ListStationsInList(ListView lvStations , int Line)
        {
            lvStations.Items.Clear();
            foreach(DataRow dr in dtLineStations.Rows)
            {
                string StationName = dr["StationName"].ToString();
                ListViewItem lviStation = PrepareListViewItem(StationName , Line);  
                lvStations.Items.Add(lviStation);
            }
        }

        private void cbLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelListStations.Visible=true;
            
            dtLineStations = clsStation.ListStations(cbLines.SelectedIndex+1);
            ListStationsInList(lvLineStations , cbLines.SelectedIndex+1);
        }

        


    }
}
