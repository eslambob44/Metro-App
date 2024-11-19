using Metro_business_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_windows_forms_layer
{
    public partial class frmShowRoad : Form
    {

        clsRoad Road = null;
        DataRow drFirstStation = null;
        DataRow drLastStation = null;
        public frmShowRoad(clsRoad Road)
        {
            InitializeComponent();
            this.Road = Road;
            
        }

        void LoadForm()
        {
            drFirstStation = Road.dtRoad.Rows[0];
            drLastStation = Road.dtRoad.Rows[Road.dtRoad.Rows.Count - 1];
            string StationFrom = (string)drFirstStation["StationName"];
            string StationTo = (string)drLastStation["StationName"];
            lblStationFrom.Text = StationFrom;
            lblStationTo.Text = StationTo;
            lblPriceCost.Text = Road.Price + " جنيه";
            lblPriceStationsCount.Text = Road.StationsCount.ToString();
            lblRoadDetails.Text = Road.Message;
            panelListStations.Visible = true;
            ListStationsInList(lvLineStations);
        }

        private void frmShowRoad_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        ListViewItem PrepareListViewItem(string StationName, int Line)
        {
            ListViewItem lviStation = new ListViewItem(StationName);
            lviStation.ImageIndex = Line - 1;
            return lviStation;
        }

        void ListStationsInList(ListView lvStations)
        {
            lvStations.Items.Clear();
            foreach (DataRow dr in Road.dtRoad.Rows)
            {
                string StationName = dr["StationName"].ToString();
                int Line = (int)(double)dr["LineNumber"];
                ListViewItem lviStation = PrepareListViewItem(StationName, Line);
                lvStations.Items.Add(lviStation);
            }
        }
    }
}
