namespace BBB_GH_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Z1heat = new System.Windows.Forms.Button();
            this.Z1fans = new System.Windows.Forms.Button();
            this.Z1sprinklers = new System.Windows.Forms.Button();
            this.Z1HMIN = new System.Windows.Forms.TrackBar();
            this.Z1TMIN = new System.Windows.Forms.TrackBar();
            this.Z1TMAX = new System.Windows.Forms.TrackBar();
            this.Z1tabCtrl = new System.Windows.Forms.TabControl();
            this.Z1info = new System.Windows.Forms.TabPage();
            this.Z1temp = new System.Windows.Forms.Label();
            this.Z1humidity = new System.Windows.Forms.Label();
            this.Z1Ttext = new System.Windows.Forms.Label();
            this.Z1Htext = new System.Windows.Forms.Label();
            this.Z1settings = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Z1heatON = new System.Windows.Forms.CheckBox();
            this.Z1sprinklersON = new System.Windows.Forms.CheckBox();
            this.Z1fansON = new System.Windows.Forms.CheckBox();
            this.Z1HMINnum = new System.Windows.Forms.NumericUpDown();
            this.Z1TMINnum = new System.Windows.Forms.NumericUpDown();
            this.Z1TMAXnum = new System.Windows.Forms.NumericUpDown();
            this.Z1HMINtext = new System.Windows.Forms.Label();
            this.Z1TMINtext = new System.Windows.Forms.Label();
            this.Z1TMAXtext = new System.Windows.Forms.Label();
            this.updateTMR = new System.Windows.Forms.Timer();
            this.Z2tabCtrl = new System.Windows.Forms.TabControl();
            this.Z2info = new System.Windows.Forms.TabPage();
            this.Z2temp = new System.Windows.Forms.Label();
            this.Z2Htext = new System.Windows.Forms.Label();
            this.Z2humidity = new System.Windows.Forms.Label();
            this.Z2Ttext = new System.Windows.Forms.Label();
            this.Z2settings = new System.Windows.Forms.TabPage();
            this.Z2HMINnum = new System.Windows.Forms.NumericUpDown();
            this.Z2TMINnum = new System.Windows.Forms.NumericUpDown();
            this.Z2TMAXnum = new System.Windows.Forms.NumericUpDown();
            this.Z2TMAX = new System.Windows.Forms.TrackBar();
            this.Z2HMINtext = new System.Windows.Forms.Label();
            this.Z2TMINtext = new System.Windows.Forms.Label();
            this.Z2TMAXtext = new System.Windows.Forms.Label();
            this.Z2HMIN = new System.Windows.Forms.TrackBar();
            this.Z2TMIN = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Z2sprinklersON = new System.Windows.Forms.CheckBox();
            this.Z2heatON = new System.Windows.Forms.CheckBox();
            this.Z2fansON = new System.Windows.Forms.CheckBox();
            this.Z2sprinklers = new System.Windows.Forms.Button();
            this.Z2heat = new System.Windows.Forms.Button();
            this.Z2fans = new System.Windows.Forms.Button();
            this.Z1text = new System.Windows.Forms.Label();
            this.Z2text = new System.Windows.Forms.Label();
            this.Z1_DHT = new System.Windows.Forms.Label();
            this.Z2_DHT = new System.Windows.Forms.Label();
            this.Z1tabCtrl.SuspendLayout();
            this.Z1info.SuspendLayout();
            this.Z1settings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Z2tabCtrl.SuspendLayout();
            this.Z2info.SuspendLayout();
            this.Z2settings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Z1heat
            // 
            this.Z1heat.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.Z1heat, "Z1heat");
            this.Z1heat.Name = "Z1heat";
            this.Z1heat.Click += new System.EventHandler(this.Z1heat_Click);
            // 
            // Z1fans
            // 
            this.Z1fans.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.Z1fans, "Z1fans");
            this.Z1fans.Name = "Z1fans";
            this.Z1fans.Click += new System.EventHandler(this.Z1fans_Click);
            // 
            // Z1sprinklers
            // 
            this.Z1sprinklers.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.Z1sprinklers, "Z1sprinklers");
            this.Z1sprinklers.Name = "Z1sprinklers";
            this.Z1sprinklers.Click += new System.EventHandler(this.Z1sprinklers_Click);
            // 
            // Z1HMIN
            // 
            resources.ApplyResources(this.Z1HMIN, "Z1HMIN");
            this.Z1HMIN.Maximum = 100;
            this.Z1HMIN.Name = "Z1HMIN";
            this.Z1HMIN.TickFrequency = 10;
            this.Z1HMIN.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Z1HMIN.Value = 30;
            this.Z1HMIN.ValueChanged += new System.EventHandler(this.Z1HMIN_ValueChanged);
            // 
            // Z1TMIN
            // 
            resources.ApplyResources(this.Z1TMIN, "Z1TMIN");
            this.Z1TMIN.Maximum = 100;
            this.Z1TMIN.Name = "Z1TMIN";
            this.Z1TMIN.TickFrequency = 10;
            this.Z1TMIN.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Z1TMIN.Value = 40;
            this.Z1TMIN.ValueChanged += new System.EventHandler(this.Z1TMIN_ValueChanged);
            // 
            // Z1TMAX
            // 
            resources.ApplyResources(this.Z1TMAX, "Z1TMAX");
            this.Z1TMAX.Maximum = 100;
            this.Z1TMAX.Name = "Z1TMAX";
            this.Z1TMAX.TickFrequency = 10;
            this.Z1TMAX.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Z1TMAX.Value = 80;
            this.Z1TMAX.ValueChanged += new System.EventHandler(this.Z1TMAX_ValueChanged);
            // 
            // Z1tabCtrl
            // 
            this.Z1tabCtrl.Controls.Add(this.Z1info);
            this.Z1tabCtrl.Controls.Add(this.Z1settings);
            resources.ApplyResources(this.Z1tabCtrl, "Z1tabCtrl");
            this.Z1tabCtrl.Name = "Z1tabCtrl";
            this.Z1tabCtrl.SelectedIndex = 0;
            this.Z1tabCtrl.Tag = "Settings";
            // 
            // Z1info
            // 
            this.Z1info.Controls.Add(this.Z1temp);
            this.Z1info.Controls.Add(this.Z1humidity);
            this.Z1info.Controls.Add(this.Z1Ttext);
            this.Z1info.Controls.Add(this.Z1Htext);
            resources.ApplyResources(this.Z1info, "Z1info");
            this.Z1info.Name = "Z1info";
            // 
            // Z1temp
            // 
            resources.ApplyResources(this.Z1temp, "Z1temp");
            this.Z1temp.Name = "Z1temp";
            // 
            // Z1humidity
            // 
            resources.ApplyResources(this.Z1humidity, "Z1humidity");
            this.Z1humidity.Name = "Z1humidity";
            // 
            // Z1Ttext
            // 
            resources.ApplyResources(this.Z1Ttext, "Z1Ttext");
            this.Z1Ttext.Name = "Z1Ttext";
            // 
            // Z1Htext
            // 
            resources.ApplyResources(this.Z1Htext, "Z1Htext");
            this.Z1Htext.Name = "Z1Htext";
            // 
            // Z1settings
            // 
            this.Z1settings.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Z1settings.Controls.Add(this.panel2);
            this.Z1settings.Controls.Add(this.Z1HMINnum);
            this.Z1settings.Controls.Add(this.Z1TMINnum);
            this.Z1settings.Controls.Add(this.Z1TMAXnum);
            this.Z1settings.Controls.Add(this.Z1TMAX);
            this.Z1settings.Controls.Add(this.Z1HMINtext);
            this.Z1settings.Controls.Add(this.Z1TMINtext);
            this.Z1settings.Controls.Add(this.Z1TMAXtext);
            this.Z1settings.Controls.Add(this.Z1HMIN);
            this.Z1settings.Controls.Add(this.Z1TMIN);
            resources.ApplyResources(this.Z1settings, "Z1settings");
            this.Z1settings.Name = "Z1settings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Z1heatON);
            this.panel2.Controls.Add(this.Z1sprinklersON);
            this.panel2.Controls.Add(this.Z1fansON);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Z1heatON
            // 
            resources.ApplyResources(this.Z1heatON, "Z1heatON");
            this.Z1heatON.Name = "Z1heatON";
            // 
            // Z1sprinklersON
            // 
            resources.ApplyResources(this.Z1sprinklersON, "Z1sprinklersON");
            this.Z1sprinklersON.Name = "Z1sprinklersON";
            // 
            // Z1fansON
            // 
            this.Z1fansON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            resources.ApplyResources(this.Z1fansON, "Z1fansON");
            this.Z1fansON.Name = "Z1fansON";
            // 
            // Z1HMINnum
            // 
            resources.ApplyResources(this.Z1HMINnum, "Z1HMINnum");
            this.Z1HMINnum.Name = "Z1HMINnum";
            this.Z1HMINnum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Z1HMINnum.ValueChanged += new System.EventHandler(this.Z1HMINnum_ValueChanged);
            // 
            // Z1TMINnum
            // 
            resources.ApplyResources(this.Z1TMINnum, "Z1TMINnum");
            this.Z1TMINnum.Name = "Z1TMINnum";
            this.Z1TMINnum.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Z1TMINnum.ValueChanged += new System.EventHandler(this.Z1TMINnum_ValueChanged);
            // 
            // Z1TMAXnum
            // 
            resources.ApplyResources(this.Z1TMAXnum, "Z1TMAXnum");
            this.Z1TMAXnum.Name = "Z1TMAXnum";
            this.Z1TMAXnum.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.Z1TMAXnum.ValueChanged += new System.EventHandler(this.Z1TMAXnum_ValueChanged);
            // 
            // Z1HMINtext
            // 
            resources.ApplyResources(this.Z1HMINtext, "Z1HMINtext");
            this.Z1HMINtext.Name = "Z1HMINtext";
            // 
            // Z1TMINtext
            // 
            resources.ApplyResources(this.Z1TMINtext, "Z1TMINtext");
            this.Z1TMINtext.Name = "Z1TMINtext";
            // 
            // Z1TMAXtext
            // 
            resources.ApplyResources(this.Z1TMAXtext, "Z1TMAXtext");
            this.Z1TMAXtext.Name = "Z1TMAXtext";
            // 
            // updateTMR
            // 
            this.updateTMR.Interval = 200;
            this.updateTMR.Tick += new System.EventHandler(this.updateTMR_Tick);
            // 
            // Z2tabCtrl
            // 
            this.Z2tabCtrl.Controls.Add(this.Z2info);
            this.Z2tabCtrl.Controls.Add(this.Z2settings);
            resources.ApplyResources(this.Z2tabCtrl, "Z2tabCtrl");
            this.Z2tabCtrl.Name = "Z2tabCtrl";
            this.Z2tabCtrl.SelectedIndex = 0;
            this.Z2tabCtrl.Tag = "Settings";
            // 
            // Z2info
            // 
            this.Z2info.Controls.Add(this.Z2temp);
            this.Z2info.Controls.Add(this.Z2Htext);
            this.Z2info.Controls.Add(this.Z2humidity);
            this.Z2info.Controls.Add(this.Z2Ttext);
            resources.ApplyResources(this.Z2info, "Z2info");
            this.Z2info.Name = "Z2info";
            // 
            // Z2temp
            // 
            resources.ApplyResources(this.Z2temp, "Z2temp");
            this.Z2temp.Name = "Z2temp";
            // 
            // Z2Htext
            // 
            resources.ApplyResources(this.Z2Htext, "Z2Htext");
            this.Z2Htext.Name = "Z2Htext";
            // 
            // Z2humidity
            // 
            resources.ApplyResources(this.Z2humidity, "Z2humidity");
            this.Z2humidity.Name = "Z2humidity";
            // 
            // Z2Ttext
            // 
            resources.ApplyResources(this.Z2Ttext, "Z2Ttext");
            this.Z2Ttext.Name = "Z2Ttext";
            // 
            // Z2settings
            // 
            this.Z2settings.Controls.Add(this.Z2HMINnum);
            this.Z2settings.Controls.Add(this.Z2TMINnum);
            this.Z2settings.Controls.Add(this.Z2TMAXnum);
            this.Z2settings.Controls.Add(this.Z2TMAX);
            this.Z2settings.Controls.Add(this.Z2HMINtext);
            this.Z2settings.Controls.Add(this.Z2TMINtext);
            this.Z2settings.Controls.Add(this.Z2TMAXtext);
            this.Z2settings.Controls.Add(this.Z2HMIN);
            this.Z2settings.Controls.Add(this.Z2TMIN);
            this.Z2settings.Controls.Add(this.panel1);
            resources.ApplyResources(this.Z2settings, "Z2settings");
            this.Z2settings.Name = "Z2settings";
            // 
            // Z2HMINnum
            // 
            resources.ApplyResources(this.Z2HMINnum, "Z2HMINnum");
            this.Z2HMINnum.Name = "Z2HMINnum";
            this.Z2HMINnum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Z2HMINnum.ValueChanged += new System.EventHandler(this.Z2HMINnum_ValueChanged);
            // 
            // Z2TMINnum
            // 
            resources.ApplyResources(this.Z2TMINnum, "Z2TMINnum");
            this.Z2TMINnum.Name = "Z2TMINnum";
            this.Z2TMINnum.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Z2TMINnum.ValueChanged += new System.EventHandler(this.Z2TMINnum_ValueChanged);
            // 
            // Z2TMAXnum
            // 
            resources.ApplyResources(this.Z2TMAXnum, "Z2TMAXnum");
            this.Z2TMAXnum.Name = "Z2TMAXnum";
            this.Z2TMAXnum.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.Z2TMAXnum.ValueChanged += new System.EventHandler(this.Z2TMAXnum_ValueChanged);
            // 
            // Z2TMAX
            // 
            resources.ApplyResources(this.Z2TMAX, "Z2TMAX");
            this.Z2TMAX.Maximum = 100;
            this.Z2TMAX.Name = "Z2TMAX";
            this.Z2TMAX.TickFrequency = 10;
            this.Z2TMAX.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Z2TMAX.Value = 80;
            this.Z2TMAX.ValueChanged += new System.EventHandler(this.Z2TMAX_ValueChanged);
            // 
            // Z2HMINtext
            // 
            resources.ApplyResources(this.Z2HMINtext, "Z2HMINtext");
            this.Z2HMINtext.Name = "Z2HMINtext";
            // 
            // Z2TMINtext
            // 
            resources.ApplyResources(this.Z2TMINtext, "Z2TMINtext");
            this.Z2TMINtext.Name = "Z2TMINtext";
            // 
            // Z2TMAXtext
            // 
            resources.ApplyResources(this.Z2TMAXtext, "Z2TMAXtext");
            this.Z2TMAXtext.Name = "Z2TMAXtext";
            // 
            // Z2HMIN
            // 
            resources.ApplyResources(this.Z2HMIN, "Z2HMIN");
            this.Z2HMIN.Maximum = 100;
            this.Z2HMIN.Name = "Z2HMIN";
            this.Z2HMIN.TickFrequency = 10;
            this.Z2HMIN.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Z2HMIN.Value = 30;
            this.Z2HMIN.ValueChanged += new System.EventHandler(this.Z2HMIN_ValueChanged);
            // 
            // Z2TMIN
            // 
            resources.ApplyResources(this.Z2TMIN, "Z2TMIN");
            this.Z2TMIN.Maximum = 100;
            this.Z2TMIN.Name = "Z2TMIN";
            this.Z2TMIN.TickFrequency = 10;
            this.Z2TMIN.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Z2TMIN.Value = 40;
            this.Z2TMIN.ValueChanged += new System.EventHandler(this.Z2TMIN_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Z2sprinklersON);
            this.panel1.Controls.Add(this.Z2heatON);
            this.panel1.Controls.Add(this.Z2fansON);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Z2sprinklersON
            // 
            resources.ApplyResources(this.Z2sprinklersON, "Z2sprinklersON");
            this.Z2sprinklersON.Name = "Z2sprinklersON";
            // 
            // Z2heatON
            // 
            resources.ApplyResources(this.Z2heatON, "Z2heatON");
            this.Z2heatON.Name = "Z2heatON";
            // 
            // Z2fansON
            // 
            resources.ApplyResources(this.Z2fansON, "Z2fansON");
            this.Z2fansON.Name = "Z2fansON";
            // 
            // Z2sprinklers
            // 
            this.Z2sprinklers.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.Z2sprinklers, "Z2sprinklers");
            this.Z2sprinklers.Name = "Z2sprinklers";
            this.Z2sprinklers.Click += new System.EventHandler(this.Z2sprinklers_Click);
            // 
            // Z2heat
            // 
            this.Z2heat.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.Z2heat, "Z2heat");
            this.Z2heat.Name = "Z2heat";
            this.Z2heat.Click += new System.EventHandler(this.Z2heat_Click);
            // 
            // Z2fans
            // 
            this.Z2fans.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.Z2fans, "Z2fans");
            this.Z2fans.Name = "Z2fans";
            this.Z2fans.Click += new System.EventHandler(this.Z2fans_Click);
            // 
            // Z1text
            // 
            resources.ApplyResources(this.Z1text, "Z1text");
            this.Z1text.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Z1text.Name = "Z1text";
            // 
            // Z2text
            // 
            resources.ApplyResources(this.Z2text, "Z2text");
            this.Z2text.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Z2text.Name = "Z2text";
            // 
            // Z1_DHT
            // 
            resources.ApplyResources(this.Z1_DHT, "Z1_DHT");
            this.Z1_DHT.Name = "Z1_DHT";
            // 
            // Z2_DHT
            // 
            resources.ApplyResources(this.Z2_DHT, "Z2_DHT");
            this.Z2_DHT.Name = "Z2_DHT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.Z2_DHT);
            this.Controls.Add(this.Z1_DHT);
            this.Controls.Add(this.Z1sprinklers);
            this.Controls.Add(this.Z1fans);
            this.Controls.Add(this.Z2tabCtrl);
            this.Controls.Add(this.Z1tabCtrl);
            this.Controls.Add(this.Z1heat);
            this.Controls.Add(this.Z2sprinklers);
            this.Controls.Add(this.Z2fans);
            this.Controls.Add(this.Z2heat);
            this.Controls.Add(this.Z1text);
            this.Controls.Add(this.Z2text);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Z1tabCtrl.ResumeLayout(false);
            this.Z1info.ResumeLayout(false);
            this.Z1settings.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Z2tabCtrl.ResumeLayout(false);
            this.Z2info.ResumeLayout(false);
            this.Z2settings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Z1heat;
        private System.Windows.Forms.Button Z1fans;
        private System.Windows.Forms.Button Z1sprinklers;
        private System.Windows.Forms.TrackBar Z1HMIN;
        private System.Windows.Forms.TrackBar Z1TMIN;
        private System.Windows.Forms.TrackBar Z1TMAX;
        private System.Windows.Forms.TabControl Z1tabCtrl;
        private System.Windows.Forms.TabPage Z1info;
        private System.Windows.Forms.TabPage Z1settings;
        private System.Windows.Forms.Label Z1TMAXtext;
        private System.Windows.Forms.Timer updateTMR;
        private System.Windows.Forms.Label Z1TMINtext;
        private System.Windows.Forms.Label Z1HMINtext;
        private System.Windows.Forms.Label Z1Htext;
        private System.Windows.Forms.TabControl Z2tabCtrl;
        private System.Windows.Forms.TabPage Z2info;
        private System.Windows.Forms.TabPage Z2settings;
        private System.Windows.Forms.TrackBar Z2TMAX;
        private System.Windows.Forms.Button Z2sprinklers;
        private System.Windows.Forms.Label Z2HMINtext;
        private System.Windows.Forms.Button Z2heat;
        private System.Windows.Forms.Button Z2fans;
        private System.Windows.Forms.Label Z2TMINtext;
        private System.Windows.Forms.Label Z2TMAXtext;
        private System.Windows.Forms.TrackBar Z2HMIN;
        private System.Windows.Forms.TrackBar Z2TMIN;
        private System.Windows.Forms.NumericUpDown Z1HMINnum;
        private System.Windows.Forms.NumericUpDown Z1TMINnum;
        private System.Windows.Forms.NumericUpDown Z1TMAXnum;
        private System.Windows.Forms.NumericUpDown Z2HMINnum;
        private System.Windows.Forms.NumericUpDown Z2TMINnum;
        private System.Windows.Forms.NumericUpDown Z2TMAXnum;
        private System.Windows.Forms.CheckBox Z1fansON;
        private System.Windows.Forms.CheckBox Z1heatON;
        private System.Windows.Forms.CheckBox Z1sprinklersON;
        private System.Windows.Forms.CheckBox Z2fansON;
        private System.Windows.Forms.CheckBox Z2heatON;
        private System.Windows.Forms.CheckBox Z2sprinklersON;
        private System.Windows.Forms.Label Z1Ttext;
        private System.Windows.Forms.Label Z1text;
        private System.Windows.Forms.Label Z2text;
        private System.Windows.Forms.Label Z1humidity;
        private System.Windows.Forms.Label Z1temp;
        private System.Windows.Forms.Label Z2temp;
        private System.Windows.Forms.Label Z2humidity;
        private System.Windows.Forms.Label Z2Ttext;
        private System.Windows.Forms.Label Z2Htext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Z1_DHT;
        private System.Windows.Forms.Label Z2_DHT;
    }
}

