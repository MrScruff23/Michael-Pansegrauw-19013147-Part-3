namespace Part_1
{
    partial class UI
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
            this.grbMap = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtUnitInfo = new System.Windows.Forms.RichTextBox();
            this.lblUnitInfo = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTeam1resources = new System.Windows.Forms.Label();
            this.lblTeam2resources = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtXSize = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblXSize = new System.Windows.Forms.Label();
            this.lblYSize = new System.Windows.Forms.Label();
            this.txtYSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // grbMap
            // 
            this.grbMap.Location = new System.Drawing.Point(2, 1);
            this.grbMap.Name = "grbMap";
            this.grbMap.Size = new System.Drawing.Size(982, 868);
            this.grbMap.TabIndex = 0;
            this.grbMap.TabStop = false;
            this.grbMap.Text = "Map";
            this.grbMap.Enter += new System.EventHandler(this.grbMap_Enter);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1004, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(65, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(1075, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(62, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // txtUnitInfo
            // 
            this.txtUnitInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitInfo.Location = new System.Drawing.Point(1017, 74);
            this.txtUnitInfo.Name = "txtUnitInfo";
            this.txtUnitInfo.ReadOnly = true;
            this.txtUnitInfo.Size = new System.Drawing.Size(221, 345);
            this.txtUnitInfo.TabIndex = 2;
            this.txtUnitInfo.Text = "";
            // 
            // lblUnitInfo
            // 
            this.lblUnitInfo.AutoSize = true;
            this.lblUnitInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitInfo.Location = new System.Drawing.Point(1013, 38);
            this.lblUnitInfo.Name = "lblUnitInfo";
            this.lblUnitInfo.Size = new System.Drawing.Size(82, 24);
            this.lblUnitInfo.TabIndex = 3;
            this.lblUnitInfo.Text = "Unit info:";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(1143, 12);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(65, 20);
            this.lblRound.TabIndex = 4;
            this.lblRound.Text = "Round: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblTeam1resources
            // 
            this.lblTeam1resources.AutoSize = true;
            this.lblTeam1resources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1resources.Location = new System.Drawing.Point(1013, 437);
            this.lblTeam1resources.Name = "lblTeam1resources";
            this.lblTeam1resources.Size = new System.Drawing.Size(144, 20);
            this.lblTeam1resources.TabIndex = 5;
            this.lblTeam1resources.Text = "Team 1 resources: ";
            // 
            // lblTeam2resources
            // 
            this.lblTeam2resources.AutoSize = true;
            this.lblTeam2resources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2resources.Location = new System.Drawing.Point(1013, 475);
            this.lblTeam2resources.Name = "lblTeam2resources";
            this.lblTeam2resources.Size = new System.Drawing.Size(144, 20);
            this.lblTeam2resources.TabIndex = 6;
            this.lblTeam2resources.Text = "Team 2 resources: ";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1004, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(1092, 515);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(65, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtXSize
            // 
            this.txtXSize.Location = new System.Drawing.Point(1311, 44);
            this.txtXSize.Name = "txtXSize";
            this.txtXSize.Size = new System.Drawing.Size(52, 20);
            this.txtXSize.TabIndex = 9;
            this.txtXSize.TextChanged += new System.EventHandler(this.txtXSize_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblXSize
            // 
            this.lblXSize.AutoSize = true;
            this.lblXSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXSize.Location = new System.Drawing.Point(1253, 42);
            this.lblXSize.Name = "lblXSize";
            this.lblXSize.Size = new System.Drawing.Size(52, 20);
            this.lblXSize.TabIndex = 11;
            this.lblXSize.Text = "X size";
            // 
            // lblYSize
            // 
            this.lblYSize.AutoSize = true;
            this.lblYSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYSize.Location = new System.Drawing.Point(1253, 74);
            this.lblYSize.Name = "lblYSize";
            this.lblYSize.Size = new System.Drawing.Size(52, 20);
            this.lblYSize.TabIndex = 13;
            this.lblYSize.Text = "Y size";
            // 
            // txtYSize
            // 
            this.txtYSize.Location = new System.Drawing.Point(1311, 76);
            this.txtYSize.Name = "txtYSize";
            this.txtYSize.Size = new System.Drawing.Size(52, 20);
            this.txtYSize.TabIndex = 12;
            this.txtYSize.TextChanged += new System.EventHandler(this.txtYSize_TextChanged);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 881);
            this.Controls.Add(this.lblYSize);
            this.Controls.Add(this.txtYSize);
            this.Controls.Add(this.lblXSize);
            this.Controls.Add(this.txtXSize);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTeam2resources);
            this.Controls.Add(this.lblTeam1resources);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblUnitInfo);
            this.Controls.Add(this.txtUnitInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grbMap);
            this.Name = "UI";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblUnitInfo;
        public System.Windows.Forms.GroupBox grbMap;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblRound;
        public System.Windows.Forms.RichTextBox txtUnitInfo;
        public System.Windows.Forms.Label lblTeam1resources;
        public System.Windows.Forms.Label lblTeam2resources;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtXSize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Label lblXSize;
        public System.Windows.Forms.Label lblYSize;
        private System.Windows.Forms.TextBox txtYSize;
    }
}

