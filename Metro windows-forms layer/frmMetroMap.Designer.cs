namespace Metro_windows_forms_layer
{
    partial class frmMetroMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetroMap));
            this.pbMetroMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMetroMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMetroMap
            // 
            this.pbMetroMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMetroMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMetroMap.Image")));
            this.pbMetroMap.Location = new System.Drawing.Point(0, 0);
            this.pbMetroMap.Name = "pbMetroMap";
            this.pbMetroMap.Size = new System.Drawing.Size(792, 792);
            this.pbMetroMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMetroMap.TabIndex = 0;
            this.pbMetroMap.TabStop = false;
            // 
            // frmMetroMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(792, 792);
            this.Controls.Add(this.pbMetroMap);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmMetroMap";
            this.Text = "Metro map";
            ((System.ComponentModel.ISupportInitialize)(this.pbMetroMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMetroMap;
    }
}