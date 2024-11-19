namespace Metro_windows_forms_layer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcMain = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpRoadCost = new System.Windows.Forms.TabPage();
            this.tpListLines = new System.Windows.Forms.TabPage();
            this.panelListStations = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lvLineStations = new System.Windows.Forms.ListView();
            this.panelChooseLine = new Guna.UI2.WinForms.Guna2Panel();
            this.cbLines = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbMetroMap = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.ilTabs = new System.Windows.Forms.ImageList(this.components);
            this.chStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilStationLine = new System.Windows.Forms.ImageList(this.components);
            this.tcMain.SuspendLayout();
            this.tpListLines.SuspendLayout();
            this.panelListStations.SuspendLayout();
            this.panelChooseLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMetroMap)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcMain.Controls.Add(this.tpRoadCost);
            this.tcMain.Controls.Add(this.tpListLines);
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ImageList = this.ilTabs;
            this.tcMain.ItemSize = new System.Drawing.Size(180, 40);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(546, 769);
            this.tcMain.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcMain.TabButtonHoverState.FillColor = System.Drawing.Color.DarkGray;
            this.tcMain.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMain.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcMain.TabButtonHoverState.InnerColor = System.Drawing.Color.Gray;
            this.tcMain.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcMain.TabButtonIdleState.FillColor = System.Drawing.Color.Silver;
            this.tcMain.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMain.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tcMain.TabButtonIdleState.InnerColor = System.Drawing.Color.DarkGray;
            this.tcMain.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcMain.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.tcMain.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcMain.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcMain.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcMain.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcMain.TabIndex = 0;
            this.tcMain.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.tcMain.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom;
            // 
            // tpRoadCost
            // 
            this.tpRoadCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.tpRoadCost.ImageIndex = 2;
            this.tpRoadCost.Location = new System.Drawing.Point(4, 4);
            this.tpRoadCost.Name = "tpRoadCost";
            this.tpRoadCost.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpRoadCost.Size = new System.Drawing.Size(538, 721);
            this.tpRoadCost.TabIndex = 0;
            // 
            // tpListLines
            // 
            this.tpListLines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.tpListLines.Controls.Add(this.panelListStations);
            this.tpListLines.Controls.Add(this.panelChooseLine);
            this.tpListLines.Controls.Add(this.pbMetroMap);
            this.tpListLines.Controls.Add(this.label2);
            this.tpListLines.Controls.Add(this.label1);
            this.tpListLines.ImageIndex = 1;
            this.tpListLines.Location = new System.Drawing.Point(4, 4);
            this.tpListLines.Name = "tpListLines";
            this.tpListLines.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpListLines.Size = new System.Drawing.Size(538, 721);
            this.tpListLines.TabIndex = 1;
            // 
            // panelListStations
            // 
            this.panelListStations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelListStations.Controls.Add(this.label5);
            this.panelListStations.Controls.Add(this.lvLineStations);
            this.panelListStations.Location = new System.Drawing.Point(8, 404);
            this.panelListStations.Name = "panelListStations";
            this.panelListStations.Size = new System.Drawing.Size(507, 311);
            this.panelListStations.TabIndex = 5;
            this.panelListStations.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(349, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "خط سير المترو";
            // 
            // lvLineStations
            // 
            this.lvLineStations.AutoArrange = false;
            this.lvLineStations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.lvLineStations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStation});
            this.lvLineStations.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLineStations.ForeColor = System.Drawing.Color.White;
            this.lvLineStations.HideSelection = false;
            this.lvLineStations.LabelWrap = false;
            this.lvLineStations.LargeImageList = this.ilStationLine;
            this.lvLineStations.Location = new System.Drawing.Point(6, 51);
            this.lvLineStations.MultiSelect = false;
            this.lvLineStations.Name = "lvLineStations";
            this.lvLineStations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvLineStations.RightToLeftLayout = true;
            this.lvLineStations.ShowGroups = false;
            this.lvLineStations.Size = new System.Drawing.Size(501, 257);
            this.lvLineStations.SmallImageList = this.ilStationLine;
            this.lvLineStations.StateImageList = this.ilStationLine;
            this.lvLineStations.TabIndex = 6;
            this.lvLineStations.UseCompatibleStateImageBehavior = false;
            this.lvLineStations.View = System.Windows.Forms.View.Tile;
            // 
            // panelChooseLine
            // 
            this.panelChooseLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelChooseLine.Controls.Add(this.cbLines);
            this.panelChooseLine.Controls.Add(this.label4);
            this.panelChooseLine.Controls.Add(this.label3);
            this.panelChooseLine.Location = new System.Drawing.Point(8, 257);
            this.panelChooseLine.Name = "panelChooseLine";
            this.panelChooseLine.Size = new System.Drawing.Size(507, 130);
            this.panelChooseLine.TabIndex = 4;
            // 
            // cbLines
            // 
            this.cbLines.AutoRoundedCorners = true;
            this.cbLines.BackColor = System.Drawing.Color.Transparent;
            this.cbLines.BorderRadius = 17;
            this.cbLines.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLines.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.cbLines.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLines.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLines.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLines.ForeColor = System.Drawing.Color.White;
            this.cbLines.ItemHeight = 30;
            this.cbLines.Items.AddRange(new object[] {
            "الخط الأول",
            "الخط التاني",
            "الخط التالت"});
            this.cbLines.Location = new System.Drawing.Point(195, 80);
            this.cbLines.Name = "cbLines";
            this.cbLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbLines.Size = new System.Drawing.Size(284, 36);
            this.cbLines.TabIndex = 5;
            this.cbLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbLines.SelectedIndexChanged += new System.EventHandler(this.cbLines_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(244, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "اختار الخط وهنعرفك كل المحطات الي فيه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(310, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "اعرف خطوط المترو";
            // 
            // pbMetroMap
            // 
            this.pbMetroMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMetroMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMetroMap.Image")));
            this.pbMetroMap.ImageRotate = 0F;
            this.pbMetroMap.Location = new System.Drawing.Point(8, 93);
            this.pbMetroMap.Name = "pbMetroMap";
            this.pbMetroMap.Size = new System.Drawing.Size(507, 146);
            this.pbMetroMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMetroMap.TabIndex = 2;
            this.pbMetroMap.TabStop = false;
            this.pbMetroMap.Click += new System.EventHandler(this.pbMetroMap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(413, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "خريطة المترو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(387, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "خطوط المترو";
            // 
            // tpMain
            // 
            this.tpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.tpMain.ImageIndex = 0;
            this.tpMain.Location = new System.Drawing.Point(4, 4);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpMain.Size = new System.Drawing.Size(538, 721);
            this.tpMain.TabIndex = 2;
            this.tpMain.ToolTipText = "Home";
            // 
            // ilTabs
            // 
            this.ilTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTabs.ImageStream")));
            this.ilTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTabs.Images.SetKeyName(0, "Home.png");
            this.ilTabs.Images.SetKeyName(1, "Road.png");
            this.ilTabs.Images.SetKeyName(2, "Ticket.png");
            // 
            // chStation
            // 
            this.chStation.Text = "";
            this.chStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chStation.Width = 468;
            // 
            // ilStationLine
            // 
            this.ilStationLine.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilStationLine.ImageStream")));
            this.ilStationLine.TransparentColor = System.Drawing.Color.Transparent;
            this.ilStationLine.Images.SetKeyName(0, "blue-circle.512x512.png");
            this.ilStationLine.Images.SetKeyName(1, "red-circle.512x512.png");
            this.ilStationLine.Images.SetKeyName(2, "Green.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(546, 769);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.Text = "Metro app";
            this.tcMain.ResumeLayout(false);
            this.tpListLines.ResumeLayout(false);
            this.tpListLines.PerformLayout();
            this.panelListStations.ResumeLayout(false);
            this.panelListStations.PerformLayout();
            this.panelChooseLine.ResumeLayout(false);
            this.panelChooseLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMetroMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcMain;
        private System.Windows.Forms.TabPage tpRoadCost;
        private System.Windows.Forms.TabPage tpListLines;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.ImageList ilTabs;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pbMetroMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelChooseLine;
        private Guna.UI2.WinForms.Guna2ComboBox cbLines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelListStations;
        private System.Windows.Forms.ListView lvLineStations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader chStation;
        private System.Windows.Forms.ImageList ilStationLine;
    }
}

