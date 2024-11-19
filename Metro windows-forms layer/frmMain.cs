using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Metro_business_layer;

namespace Metro_windows_forms_layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void FillcomboboxWithStations(Guna2ComboBox cbStation, DataTable dtStations)
        {
            cbStation.Items.Clear();
            foreach (DataRow dr in dtStations.Rows)
            {
                cbStation.Items.Add(dr["StationName"]);
            }
        }

        void LoadComboBoxesStations()
        {
            dtRoadStations = clsStation.ListStationsByLikeName("");
            FillcomboboxWithStations(cbPriceStationFrom,dtRoadStations);
            FillcomboboxWithStations(cbPriceStationTo,dtRoadStations);
            FillcomboboxWithStations(cbRoadStationFrom,dtRoadStations);
            FillcomboboxWithStations(cbRoadStationTo,dtRoadStations);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadComboBoxesStations();
            tcMain.SelectedIndex = 2;
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

        // Road price tab page

        

        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox txtStation = (Guna2TextBox)sender;
            Guna2ComboBox cbStations = null;
            if(txtStation == txtPriceStationFrom)
            {
                cbStations = cbPriceStationFrom;
            }
            else if(txtStation== txtPriceStationTo)
            {
                cbStations = cbPriceStationTo;
            }
            else if(txtStation == txtRoadStationFrom)
            {
                cbStations= cbRoadStationFrom;
            }
            else if(txtStation == txtRoadStationTo)
            {
                cbStations = cbRoadStationTo;
            }
            dtRoadStations = clsStation.ListStationsByLikeName(txtStation.Text);
            FillcomboboxWithStations(cbStations, dtRoadStations);
            cbStations.DroppedDown = true;

        }

        private void cbPriceStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPriceCount.Enabled = (cbPriceStationFrom.SelectedIndex != -1 && cbPriceStationTo.SelectedIndex != -1);
            panelPriceShowStationsCount.Visible = false;
            panelShowlTotalPrice.Visible=false;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            panelShowlTotalPrice.Visible = true;
            panelPriceShowStationsCount.Visible = true;
            string StationFrom = cbPriceStationFrom.Text;
            string StationTo = cbPriceStationTo.Text;
            short Count = clsRoad.GetRoadCount(StationFrom, StationTo);
            short Price = (short)(clsRoad.GetRoadPrice(StationFrom,StationTo)*nudNumberOfPeople.Value);
            lblPriceCost.Text = Price+" جنيه";
            lblPriceStationsCount.Text = Count.ToString();

        }

        private void nudNumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            panelPriceShowStationsCount.Visible = false;
            panelShowlTotalPrice.Visible = false;
        }

        // Main tap page

        private void cbRoadStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRoadCalculate.Enabled = (cbRoadStationTo.SelectedIndex != -1 && cbRoadStationFrom.SelectedIndex != -1);
        }

        void _ReloadMainTapPage()
        {
            txtRoadStationFrom.Clear();
            txtRoadStationTo.Clear();
            cbRoadStationFrom.SelectedIndex = -1;
            cbRoadStationTo.SelectedIndex = -1;
        }

        private void btnRoadCalculate_Click(object sender, EventArgs e)
        {
            string StationFrom = cbRoadStationFrom.Text;
            string StationTo = cbRoadStationTo.Text;
            clsRoad Road = clsRoad.GetRoad(StationFrom,StationTo);
            if(Road !=null)
            {
                Form frm = new frmShowRoad(Road);
                frm.ShowDialog();
                _ReloadMainTapPage();
            }
        }
    }
}
