namespace WindowsFormsApplication1
{
    partial class Robot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot));
            this.Connect = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MtDelay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(11, 84);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(100, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(11, 27);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(100, 21);
            this.cbPorts.TabIndex = 1;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(11, 114);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(100, 23);
            this.Disconnect.TabIndex = 2;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(11, 143);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.Right);
            this.groupBox1.Controls.Add(this.Left);
            this.groupBox1.Controls.Add(this.Down);
            this.groupBox1.Controls.Add(this.Up);
            this.groupBox1.Location = new System.Drawing.Point(156, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 249);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motion";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(126, 104);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 53);
            this.Stop.TabIndex = 13;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(246, 104);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(75, 53);
            this.Right.TabIndex = 12;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(10, 104);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(75, 53);
            this.Left.TabIndex = 11;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(126, 189);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(75, 53);
            this.Down.TabIndex = 10;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(126, 15);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(75, 53);
            this.Up.TabIndex = 9;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.cbPorts);
            this.groupBox2.Controls.Add(this.Connect);
            this.groupBox2.Controls.Add(this.Reset);
            this.groupBox2.Controls.Add(this.Disconnect);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 182);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(11, 55);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(26, 16);
            this.tbSpeed.Maximum = 255;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSpeed.Size = new System.Drawing.Size(45, 227);
            this.tbSpeed.TabIndex = 11;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSpeed);
            this.groupBox3.Location = new System.Drawing.Point(509, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 249);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(12, 290);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(596, 72);
            this.tbStatus.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MtDelay);
            this.groupBox4.Location = new System.Drawing.Point(13, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(116, 60);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motion Delay";
            // 
            // MtDelay
            // 
            this.MtDelay.Location = new System.Drawing.Point(10, 33);
            this.MtDelay.Name = "MtDelay";
            this.MtDelay.Size = new System.Drawing.Size(100, 20);
            this.MtDelay.TabIndex = 0;
            this.MtDelay.Text = "250\r\n";
            this.MtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtDelay.TextChanged += new System.EventHandler(this.MtDelay_TextChanged);
            // 
            // Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 374);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Robot";
            this.Text = "Robot";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox MtDelay;
        public System.Windows.Forms.TextBox tbStatus;
    }
}

