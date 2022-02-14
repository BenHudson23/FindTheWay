namespace FindTheWay
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PanelSettings = new System.Windows.Forms.TabPage();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtYaxis = new System.Windows.Forms.TextBox();
            this.lblYaxis = new System.Windows.Forms.Label();
            this.txtXaxis = new System.Windows.Forms.TextBox();
            this.lblXaxis = new System.Windows.Forms.Label();
            this.panelVis = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.PanelSettings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PanelSettings);
            this.tabControl1.Controls.Add(this.panelVis);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // PanelSettings
            // 
            this.PanelSettings.Controls.Add(this.btnGenerate);
            this.PanelSettings.Controls.Add(this.txtYaxis);
            this.PanelSettings.Controls.Add(this.lblYaxis);
            this.PanelSettings.Controls.Add(this.txtXaxis);
            this.PanelSettings.Controls.Add(this.lblXaxis);
            this.PanelSettings.Location = new System.Drawing.Point(4, 22);
            this.PanelSettings.Name = "PanelSettings";
            this.PanelSettings.Padding = new System.Windows.Forms.Padding(3);
            this.PanelSettings.Size = new System.Drawing.Size(785, 461);
            this.PanelSettings.TabIndex = 0;
            this.PanelSettings.Text = "Settings";
            this.PanelSettings.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(9, 58);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(219, 33);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Genterate Grid";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtYaxis
            // 
            this.txtYaxis.Location = new System.Drawing.Point(84, 32);
            this.txtYaxis.Name = "txtYaxis";
            this.txtYaxis.Size = new System.Drawing.Size(144, 20);
            this.txtYaxis.TabIndex = 1;
            // 
            // lblYaxis
            // 
            this.lblYaxis.AutoSize = true;
            this.lblYaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaxis.Location = new System.Drawing.Point(6, 33);
            this.lblYaxis.Name = "lblYaxis";
            this.lblYaxis.Size = new System.Drawing.Size(75, 18);
            this.lblYaxis.TabIndex = 0;
            this.lblYaxis.Text = "Get Y axis";
            // 
            // txtXaxis
            // 
            this.txtXaxis.Location = new System.Drawing.Point(84, 6);
            this.txtXaxis.Name = "txtXaxis";
            this.txtXaxis.Size = new System.Drawing.Size(144, 20);
            this.txtXaxis.TabIndex = 1;
            // 
            // lblXaxis
            // 
            this.lblXaxis.AutoSize = true;
            this.lblXaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXaxis.Location = new System.Drawing.Point(6, 7);
            this.lblXaxis.Name = "lblXaxis";
            this.lblXaxis.Size = new System.Drawing.Size(76, 18);
            this.lblXaxis.TabIndex = 0;
            this.lblXaxis.Text = "Get X axis";
            // 
            // panelVis
            // 
            this.panelVis.Location = new System.Drawing.Point(4, 22);
            this.panelVis.Name = "panelVis";
            this.panelVis.Padding = new System.Windows.Forms.Padding(3);
            this.panelVis.Size = new System.Drawing.Size(785, 461);
            this.panelVis.TabIndex = 1;
            this.panelVis.Text = "Visualisation";
            this.panelVis.UseVisualStyleBackColor = true;
            this.panelVis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelVis_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(217, 17);
            this.lblStatus.Text = "choose the grid size then press generate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 487);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "The Way";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.PanelSettings.ResumeLayout(false);
            this.PanelSettings.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PanelSettings;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtYaxis;
        private System.Windows.Forms.Label lblYaxis;
        private System.Windows.Forms.TextBox txtXaxis;
        private System.Windows.Forms.Label lblXaxis;
        private System.Windows.Forms.TabPage panelVis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

