namespace Metro_windows_forms_layer
{
    partial class frmShowRoad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowRoad));
            this.ilStationLine = new System.Windows.Forms.ImageList(this.components);
            this.lblStationFrom = new System.Windows.Forms.Label();
            this.lblStationTo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelShowlTotalPrice = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPriceCost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelPriceShowStationsCount = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPriceStationsCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRoadDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelListStations = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lvLineStations = new System.Windows.Forms.ListView();
            this.chStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelShowlTotalPrice.SuspendLayout();
            this.panelPriceShowStationsCount.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelListStations.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilStationLine
            // 
            this.ilStationLine.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilStationLine.ImageStream")));
            this.ilStationLine.TransparentColor = System.Drawing.Color.Transparent;
            this.ilStationLine.Images.SetKeyName(0, "blue-circle.512x512.png");
            this.ilStationLine.Images.SetKeyName(1, "red-circle.512x512.png");
            this.ilStationLine.Images.SetKeyName(2, "Green.png");
            // 
            // lblStationFrom
            // 
            resources.ApplyResources(this.lblStationFrom, "lblStationFrom");
            this.lblStationFrom.Name = "lblStationFrom";
            // 
            // lblStationTo
            // 
            resources.ApplyResources(this.lblStationTo, "lblStationTo");
            this.lblStationTo.Name = "lblStationTo";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Name = "label12";
            // 
            // panelShowlTotalPrice
            // 
            this.panelShowlTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelShowlTotalPrice.Controls.Add(this.lblPriceCost);
            this.panelShowlTotalPrice.Controls.Add(this.label11);
            resources.ApplyResources(this.panelShowlTotalPrice, "panelShowlTotalPrice");
            this.panelShowlTotalPrice.Name = "panelShowlTotalPrice";
            // 
            // lblPriceCost
            // 
            resources.ApplyResources(this.lblPriceCost, "lblPriceCost");
            this.lblPriceCost.Name = "lblPriceCost";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // panelPriceShowStationsCount
            // 
            this.panelPriceShowStationsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelPriceShowStationsCount.Controls.Add(this.lblPriceStationsCount);
            this.panelPriceShowStationsCount.Controls.Add(this.label10);
            resources.ApplyResources(this.panelPriceShowStationsCount, "panelPriceShowStationsCount");
            this.panelPriceShowStationsCount.Name = "panelPriceShowStationsCount";
            // 
            // lblPriceStationsCount
            // 
            resources.ApplyResources(this.lblPriceStationsCount, "lblPriceStationsCount");
            this.lblPriceStationsCount.Name = "lblPriceStationsCount";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.guna2Panel1.Controls.Add(this.lblRoadDetails);
            this.guna2Panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Name = "guna2Panel1";
            // 
            // lblRoadDetails
            // 
            resources.ApplyResources(this.lblRoadDetails, "lblRoadDetails");
            this.lblRoadDetails.Name = "lblRoadDetails";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Name = "label1";
            // 
            // panelListStations
            // 
            this.panelListStations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelListStations.Controls.Add(this.label5);
            this.panelListStations.Controls.Add(this.lvLineStations);
            resources.ApplyResources(this.panelListStations, "panelListStations");
            this.panelListStations.Name = "panelListStations";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // lvLineStations
            // 
            this.lvLineStations.AutoArrange = false;
            this.lvLineStations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.lvLineStations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStation});
            resources.ApplyResources(this.lvLineStations, "lvLineStations");
            this.lvLineStations.ForeColor = System.Drawing.Color.White;
            this.lvLineStations.HideSelection = false;
            this.lvLineStations.LargeImageList = this.ilStationLine;
            this.lvLineStations.MultiSelect = false;
            this.lvLineStations.Name = "lvLineStations";
            this.lvLineStations.ShowGroups = false;
            this.lvLineStations.SmallImageList = this.ilStationLine;
            this.lvLineStations.StateImageList = this.ilStationLine;
            this.lvLineStations.UseCompatibleStateImageBehavior = false;
            this.lvLineStations.View = System.Windows.Forms.View.Tile;
            // 
            // chStation
            // 
            resources.ApplyResources(this.chStation, "chStation");
            // 
            // frmShowRoad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.panelListStations);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelShowlTotalPrice);
            this.Controls.Add(this.panelPriceShowStationsCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblStationTo);
            this.Controls.Add(this.lblStationFrom);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmShowRoad";
            this.Load += new System.EventHandler(this.frmShowRoad_Load);
            this.panelShowlTotalPrice.ResumeLayout(false);
            this.panelShowlTotalPrice.PerformLayout();
            this.panelPriceShowStationsCount.ResumeLayout(false);
            this.panelPriceShowStationsCount.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelListStations.ResumeLayout(false);
            this.panelListStations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ilStationLine;
        private System.Windows.Forms.Label lblStationFrom;
        private System.Windows.Forms.Label lblStationTo;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel panelShowlTotalPrice;
        private System.Windows.Forms.Label lblPriceCost;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Panel panelPriceShowStationsCount;
        private System.Windows.Forms.Label lblPriceStationsCount;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblRoadDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelListStations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvLineStations;
        private System.Windows.Forms.ColumnHeader chStation;
    }
}