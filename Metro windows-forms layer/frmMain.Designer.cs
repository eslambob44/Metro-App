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
            this.panelShowlTotalPrice = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPriceCost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelPriceShowStationsCount = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPriceStationsCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelRoadPrice = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPriceCount = new Guna.UI2.WinForms.Guna2Button();
            this.nudNumberOfPeople = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPriceStationTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPriceStationTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPriceStationFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPriceStationFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpListLines = new System.Windows.Forms.TabPage();
            this.panelListStations = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lvLineStations = new System.Windows.Forms.ListView();
            this.chStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilStationLine = new System.Windows.Forms.ImageList(this.components);
            this.panelChooseLine = new Guna.UI2.WinForms.Guna2Panel();
            this.cbLines = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbMetroMap = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRoadCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.txtRoadStationTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbRoadStationTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRoadStationFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbRoadStationFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ilTabs = new System.Windows.Forms.ImageList(this.components);
            this.tcMain.SuspendLayout();
            this.tpRoadCost.SuspendLayout();
            this.panelShowlTotalPrice.SuspendLayout();
            this.panelPriceShowStationsCount.SuspendLayout();
            this.panelRoadPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).BeginInit();
            this.tpListLines.SuspendLayout();
            this.panelListStations.SuspendLayout();
            this.panelChooseLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMetroMap)).BeginInit();
            this.tpMain.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            this.tpRoadCost.Controls.Add(this.panelShowlTotalPrice);
            this.tpRoadCost.Controls.Add(this.panelPriceShowStationsCount);
            this.tpRoadCost.Controls.Add(this.panelRoadPrice);
            this.tpRoadCost.Controls.Add(this.label6);
            this.tpRoadCost.ImageIndex = 2;
            this.tpRoadCost.Location = new System.Drawing.Point(4, 4);
            this.tpRoadCost.Name = "tpRoadCost";
            this.tpRoadCost.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoadCost.Size = new System.Drawing.Size(538, 721);
            this.tpRoadCost.TabIndex = 0;
            // 
            // panelShowlTotalPrice
            // 
            this.panelShowlTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelShowlTotalPrice.Controls.Add(this.lblPriceCost);
            this.panelShowlTotalPrice.Controls.Add(this.label11);
            this.panelShowlTotalPrice.Location = new System.Drawing.Point(185, 601);
            this.panelShowlTotalPrice.Name = "panelShowlTotalPrice";
            this.panelShowlTotalPrice.Size = new System.Drawing.Size(336, 78);
            this.panelShowlTotalPrice.TabIndex = 14;
            this.panelShowlTotalPrice.Visible = false;
            // 
            // lblPriceCost
            // 
            this.lblPriceCost.AutoSize = true;
            this.lblPriceCost.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceCost.Location = new System.Drawing.Point(260, 37);
            this.lblPriceCost.Name = "lblPriceCost";
            this.lblPriceCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPriceCost.Size = new System.Drawing.Size(61, 23);
            this.lblPriceCost.TabIndex = 2;
            this.lblPriceCost.Text = "10 جنيه";
            this.lblPriceCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(203, 14);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(131, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "المبلغ الى هيدفع...";
            // 
            // panelPriceShowStationsCount
            // 
            this.panelPriceShowStationsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelPriceShowStationsCount.Controls.Add(this.lblPriceStationsCount);
            this.panelPriceShowStationsCount.Controls.Add(this.label10);
            this.panelPriceShowStationsCount.Location = new System.Drawing.Point(360, 507);
            this.panelPriceShowStationsCount.Name = "panelPriceShowStationsCount";
            this.panelPriceShowStationsCount.Size = new System.Drawing.Size(161, 78);
            this.panelPriceShowStationsCount.TabIndex = 12;
            this.panelPriceShowStationsCount.Visible = false;
            // 
            // lblPriceStationsCount
            // 
            this.lblPriceStationsCount.AutoSize = true;
            this.lblPriceStationsCount.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceStationsCount.Location = new System.Drawing.Point(85, 20);
            this.lblPriceStationsCount.Name = "lblPriceStationsCount";
            this.lblPriceStationsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPriceStationsCount.Size = new System.Drawing.Size(22, 23);
            this.lblPriceStationsCount.TabIndex = 3;
            this.lblPriceStationsCount.Text = "11";
            this.lblPriceStationsCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "محطات";
            // 
            // panelRoadPrice
            // 
            this.panelRoadPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelRoadPrice.Controls.Add(this.btnPriceCount);
            this.panelRoadPrice.Controls.Add(this.nudNumberOfPeople);
            this.panelRoadPrice.Controls.Add(this.label9);
            this.panelRoadPrice.Controls.Add(this.txtPriceStationTo);
            this.panelRoadPrice.Controls.Add(this.cbPriceStationTo);
            this.panelRoadPrice.Controls.Add(this.txtPriceStationFrom);
            this.panelRoadPrice.Controls.Add(this.cbPriceStationFrom);
            this.panelRoadPrice.Controls.Add(this.label7);
            this.panelRoadPrice.Controls.Add(this.label8);
            this.panelRoadPrice.Location = new System.Drawing.Point(12, 81);
            this.panelRoadPrice.Name = "panelRoadPrice";
            this.panelRoadPrice.Size = new System.Drawing.Size(507, 401);
            this.panelRoadPrice.TabIndex = 5;
            // 
            // btnPriceCount
            // 
            this.btnPriceCount.AutoRoundedCorners = true;
            this.btnPriceCount.BorderRadius = 21;
            this.btnPriceCount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPriceCount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPriceCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPriceCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPriceCount.Enabled = false;
            this.btnPriceCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(243)))));
            this.btnPriceCount.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.btnPriceCount.ForeColor = System.Drawing.Color.White;
            this.btnPriceCount.Location = new System.Drawing.Point(66, 329);
            this.btnPriceCount.Name = "btnPriceCount";
            this.btnPriceCount.Size = new System.Drawing.Size(385, 45);
            this.btnPriceCount.TabIndex = 11;
            this.btnPriceCount.Text = "احسب";
            this.btnPriceCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // nudNumberOfPeople
            // 
            this.nudNumberOfPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.nudNumberOfPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumberOfPeople.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.nudNumberOfPeople.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.nudNumberOfPeople.ForeColor = System.Drawing.Color.White;
            this.nudNumberOfPeople.Location = new System.Drawing.Point(315, 276);
            this.nudNumberOfPeople.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudNumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfPeople.Name = "nudNumberOfPeople";
            this.nudNumberOfPeople.Size = new System.Drawing.Size(78, 26);
            this.nudNumberOfPeople.TabIndex = 5;
            this.nudNumberOfPeople.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudNumberOfPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfPeople.ValueChanged += new System.EventHandler(this.nudNumberOfPeople_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(409, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "عدد الأفراد";
            // 
            // txtPriceStationTo
            // 
            this.txtPriceStationTo.AutoRoundedCorners = true;
            this.txtPriceStationTo.BorderRadius = 17;
            this.txtPriceStationTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceStationTo.DefaultText = "";
            this.txtPriceStationTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceStationTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceStationTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceStationTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceStationTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.txtPriceStationTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceStationTo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.txtPriceStationTo.ForeColor = System.Drawing.Color.White;
            this.txtPriceStationTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceStationTo.Location = new System.Drawing.Point(339, 178);
            this.txtPriceStationTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriceStationTo.Name = "txtPriceStationTo";
            this.txtPriceStationTo.PasswordChar = '\0';
            this.txtPriceStationTo.PlaceholderText = "إلي";
            this.txtPriceStationTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPriceStationTo.SelectedText = "";
            this.txtPriceStationTo.Size = new System.Drawing.Size(143, 36);
            this.txtPriceStationTo.TabIndex = 3;
            this.txtPriceStationTo.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // cbPriceStationTo
            // 
            this.cbPriceStationTo.AutoRoundedCorners = true;
            this.cbPriceStationTo.BackColor = System.Drawing.Color.Transparent;
            this.cbPriceStationTo.BorderRadius = 17;
            this.cbPriceStationTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPriceStationTo.DropDownHeight = 200;
            this.cbPriceStationTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriceStationTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.cbPriceStationTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPriceStationTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPriceStationTo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.cbPriceStationTo.ForeColor = System.Drawing.Color.White;
            this.cbPriceStationTo.IntegralHeight = false;
            this.cbPriceStationTo.ItemHeight = 30;
            this.cbPriceStationTo.Items.AddRange(new object[] {
            "الخط الأول",
            "الخط التاني",
            "الخط التالت"});
            this.cbPriceStationTo.Location = new System.Drawing.Point(198, 221);
            this.cbPriceStationTo.MaxDropDownItems = 5;
            this.cbPriceStationTo.Name = "cbPriceStationTo";
            this.cbPriceStationTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbPriceStationTo.Size = new System.Drawing.Size(284, 36);
            this.cbPriceStationTo.TabIndex = 4;
            this.cbPriceStationTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbPriceStationTo.SelectedIndexChanged += new System.EventHandler(this.cbPriceStation_SelectedIndexChanged);
            // 
            // txtPriceStationFrom
            // 
            this.txtPriceStationFrom.AutoRoundedCorners = true;
            this.txtPriceStationFrom.BorderRadius = 17;
            this.txtPriceStationFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceStationFrom.DefaultText = "";
            this.txtPriceStationFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceStationFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceStationFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceStationFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceStationFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.txtPriceStationFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceStationFrom.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.txtPriceStationFrom.ForeColor = System.Drawing.Color.White;
            this.txtPriceStationFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceStationFrom.Location = new System.Drawing.Point(339, 78);
            this.txtPriceStationFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriceStationFrom.Name = "txtPriceStationFrom";
            this.txtPriceStationFrom.PasswordChar = '\0';
            this.txtPriceStationFrom.PlaceholderText = "من";
            this.txtPriceStationFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPriceStationFrom.SelectedText = "";
            this.txtPriceStationFrom.Size = new System.Drawing.Size(143, 36);
            this.txtPriceStationFrom.TabIndex = 1;
            this.txtPriceStationFrom.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // cbPriceStationFrom
            // 
            this.cbPriceStationFrom.AutoRoundedCorners = true;
            this.cbPriceStationFrom.BackColor = System.Drawing.Color.Transparent;
            this.cbPriceStationFrom.BorderRadius = 17;
            this.cbPriceStationFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPriceStationFrom.DropDownHeight = 200;
            this.cbPriceStationFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriceStationFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.cbPriceStationFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPriceStationFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPriceStationFrom.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.cbPriceStationFrom.ForeColor = System.Drawing.Color.White;
            this.cbPriceStationFrom.IntegralHeight = false;
            this.cbPriceStationFrom.ItemHeight = 30;
            this.cbPriceStationFrom.Items.AddRange(new object[] {
            "الخط الأول",
            "الخط التاني",
            "الخط التالت"});
            this.cbPriceStationFrom.Location = new System.Drawing.Point(198, 121);
            this.cbPriceStationFrom.MaxDropDownItems = 5;
            this.cbPriceStationFrom.Name = "cbPriceStationFrom";
            this.cbPriceStationFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbPriceStationFrom.Size = new System.Drawing.Size(284, 36);
            this.cbPriceStationFrom.TabIndex = 2;
            this.cbPriceStationFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbPriceStationFrom.SelectedIndexChanged += new System.EventHandler(this.cbPriceStation_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(211, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "اختار المحطات وعدد الأفراد وهنقولك هتدفع كام";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(310, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "احسب سعر مشوارك";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(355, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "سعر تذكرة المترو";
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
            this.tpListLines.Padding = new System.Windows.Forms.Padding(3);
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
            this.tpMain.Controls.Add(this.guna2Panel1);
            this.tpMain.Controls.Add(this.label13);
            this.tpMain.Controls.Add(this.label12);
            this.tpMain.ImageIndex = 0;
            this.tpMain.Location = new System.Drawing.Point(4, 4);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(538, 721);
            this.tpMain.TabIndex = 2;
            this.tpMain.ToolTipText = "Home";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.guna2Panel1.Controls.Add(this.btnRoadCalculate);
            this.guna2Panel1.Controls.Add(this.txtRoadStationTo);
            this.guna2Panel1.Controls.Add(this.cbRoadStationTo);
            this.guna2Panel1.Controls.Add(this.txtRoadStationFrom);
            this.guna2Panel1.Controls.Add(this.cbRoadStationFrom);
            this.guna2Panel1.Controls.Add(this.label15);
            this.guna2Panel1.Controls.Add(this.label16);
            this.guna2Panel1.Location = new System.Drawing.Point(19, 86);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(507, 344);
            this.guna2Panel1.TabIndex = 7;
            // 
            // btnRoadCalculate
            // 
            this.btnRoadCalculate.AutoRoundedCorners = true;
            this.btnRoadCalculate.BorderRadius = 21;
            this.btnRoadCalculate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoadCalculate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoadCalculate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoadCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoadCalculate.Enabled = false;
            this.btnRoadCalculate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(243)))));
            this.btnRoadCalculate.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.btnRoadCalculate.ForeColor = System.Drawing.Color.White;
            this.btnRoadCalculate.Location = new System.Drawing.Point(66, 278);
            this.btnRoadCalculate.Name = "btnRoadCalculate";
            this.btnRoadCalculate.Size = new System.Drawing.Size(385, 45);
            this.btnRoadCalculate.TabIndex = 11;
            this.btnRoadCalculate.Text = "عرفني";
            this.btnRoadCalculate.Click += new System.EventHandler(this.btnRoadCalculate_Click);
            // 
            // txtRoadStationTo
            // 
            this.txtRoadStationTo.AutoRoundedCorners = true;
            this.txtRoadStationTo.BorderRadius = 17;
            this.txtRoadStationTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoadStationTo.DefaultText = "";
            this.txtRoadStationTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoadStationTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoadStationTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoadStationTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoadStationTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.txtRoadStationTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoadStationTo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.txtRoadStationTo.ForeColor = System.Drawing.Color.White;
            this.txtRoadStationTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoadStationTo.Location = new System.Drawing.Point(339, 178);
            this.txtRoadStationTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoadStationTo.Name = "txtRoadStationTo";
            this.txtRoadStationTo.PasswordChar = '\0';
            this.txtRoadStationTo.PlaceholderText = "إلي";
            this.txtRoadStationTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRoadStationTo.SelectedText = "";
            this.txtRoadStationTo.Size = new System.Drawing.Size(143, 36);
            this.txtRoadStationTo.TabIndex = 3;
            this.txtRoadStationTo.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // cbRoadStationTo
            // 
            this.cbRoadStationTo.AutoRoundedCorners = true;
            this.cbRoadStationTo.BackColor = System.Drawing.Color.Transparent;
            this.cbRoadStationTo.BorderRadius = 17;
            this.cbRoadStationTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoadStationTo.DropDownHeight = 200;
            this.cbRoadStationTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoadStationTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.cbRoadStationTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoadStationTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoadStationTo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.cbRoadStationTo.ForeColor = System.Drawing.Color.White;
            this.cbRoadStationTo.IntegralHeight = false;
            this.cbRoadStationTo.ItemHeight = 30;
            this.cbRoadStationTo.Items.AddRange(new object[] {
            "الخط الأول",
            "الخط التاني",
            "الخط التالت"});
            this.cbRoadStationTo.Location = new System.Drawing.Point(198, 221);
            this.cbRoadStationTo.MaxDropDownItems = 5;
            this.cbRoadStationTo.Name = "cbRoadStationTo";
            this.cbRoadStationTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbRoadStationTo.Size = new System.Drawing.Size(284, 36);
            this.cbRoadStationTo.TabIndex = 4;
            this.cbRoadStationTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbRoadStationTo.SelectedIndexChanged += new System.EventHandler(this.cbRoadStation_SelectedIndexChanged);
            // 
            // txtRoadStationFrom
            // 
            this.txtRoadStationFrom.AutoRoundedCorners = true;
            this.txtRoadStationFrom.BorderRadius = 17;
            this.txtRoadStationFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoadStationFrom.DefaultText = "";
            this.txtRoadStationFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoadStationFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoadStationFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoadStationFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoadStationFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.txtRoadStationFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoadStationFrom.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.txtRoadStationFrom.ForeColor = System.Drawing.Color.White;
            this.txtRoadStationFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoadStationFrom.Location = new System.Drawing.Point(339, 78);
            this.txtRoadStationFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoadStationFrom.Name = "txtRoadStationFrom";
            this.txtRoadStationFrom.PasswordChar = '\0';
            this.txtRoadStationFrom.PlaceholderText = "من";
            this.txtRoadStationFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRoadStationFrom.SelectedText = "";
            this.txtRoadStationFrom.Size = new System.Drawing.Size(143, 36);
            this.txtRoadStationFrom.TabIndex = 1;
            this.txtRoadStationFrom.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // cbRoadStationFrom
            // 
            this.cbRoadStationFrom.AutoRoundedCorners = true;
            this.cbRoadStationFrom.BackColor = System.Drawing.Color.Transparent;
            this.cbRoadStationFrom.BorderRadius = 17;
            this.cbRoadStationFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoadStationFrom.DropDownHeight = 200;
            this.cbRoadStationFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoadStationFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.cbRoadStationFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoadStationFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoadStationFrom.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.cbRoadStationFrom.ForeColor = System.Drawing.Color.White;
            this.cbRoadStationFrom.IntegralHeight = false;
            this.cbRoadStationFrom.ItemHeight = 30;
            this.cbRoadStationFrom.Items.AddRange(new object[] {
            "الخط الأول",
            "الخط التاني",
            "الخط التالت"});
            this.cbRoadStationFrom.Location = new System.Drawing.Point(198, 121);
            this.cbRoadStationFrom.MaxDropDownItems = 5;
            this.cbRoadStationFrom.Name = "cbRoadStationFrom";
            this.cbRoadStationFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbRoadStationFrom.Size = new System.Drawing.Size(284, 36);
            this.cbRoadStationFrom.TabIndex = 2;
            this.cbRoadStationFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbRoadStationFrom.SelectedIndexChanged += new System.EventHandler(this.cbRoadStation_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(211, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(282, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "دخل المحطات وهتعرف تفاصيل رحلتك وخط السير";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(315, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 27);
            this.label16.TabIndex = 3;
            this.label16.Text = "اعرف تفاصيل رحلتك";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.Location = new System.Drawing.Point(342, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 30);
            this.label13.TabIndex = 6;
            this.label13.Text = "بنتمنالك مشوار سهل";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(444, 18);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(86, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "مساء الخير";
            // 
            // ilTabs
            // 
            this.ilTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTabs.ImageStream")));
            this.ilTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTabs.Images.SetKeyName(0, "Home.png");
            this.ilTabs.Images.SetKeyName(1, "Road.png");
            this.ilTabs.Images.SetKeyName(2, "Ticket.png");
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
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpRoadCost.ResumeLayout(false);
            this.tpRoadCost.PerformLayout();
            this.panelShowlTotalPrice.ResumeLayout(false);
            this.panelShowlTotalPrice.PerformLayout();
            this.panelPriceShowStationsCount.ResumeLayout(false);
            this.panelPriceShowStationsCount.PerformLayout();
            this.panelRoadPrice.ResumeLayout(false);
            this.panelRoadPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).EndInit();
            this.tpListLines.ResumeLayout(false);
            this.tpListLines.PerformLayout();
            this.panelListStations.ResumeLayout(false);
            this.panelListStations.PerformLayout();
            this.panelChooseLine.ResumeLayout(false);
            this.panelChooseLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMetroMap)).EndInit();
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel panelRoadPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cbPriceStationFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceStationFrom;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceStationTo;
        private Guna.UI2.WinForms.Guna2ComboBox cbPriceStationTo;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumberOfPeople;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnPriceCount;
        private Guna.UI2.WinForms.Guna2Panel panelShowlTotalPrice;
        private Guna.UI2.WinForms.Guna2Panel panelPriceShowStationsCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPriceCost;
        private System.Windows.Forms.Label lblPriceStationsCount;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnRoadCalculate;
        private Guna.UI2.WinForms.Guna2TextBox txtRoadStationTo;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoadStationTo;
        private Guna.UI2.WinForms.Guna2TextBox txtRoadStationFrom;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoadStationFrom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
    }
}

