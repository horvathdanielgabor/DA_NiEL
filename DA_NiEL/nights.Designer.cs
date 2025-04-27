namespace DA_NiEL
{
    partial class nights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nights));
            this.jumpscare_timer = new System.Windows.Forms.Timer(this.components);
            this.E_timer = new System.Windows.Forms.Timer(this.components);
            this.K_timer = new System.Windows.Forms.Timer(this.components);
            this.D_timer = new System.Windows.Forms.Timer(this.components);
            this.S_timer = new System.Windows.Forms.Timer(this.components);
            this.power_conter = new System.Windows.Forms.Timer(this.components);
            this._6AM = new System.Windows.Forms.Timer(this.components);
            this.soundEffects = new System.Windows.Forms.Timer(this.components);
            this.music_box = new System.Windows.Forms.Timer(this.components);
            this.hours = new System.Windows.Forms.Timer(this.components);
            this.camera_btn = new System.Windows.Forms.Panel();
            this.door_btn1 = new System.Windows.Forms.Panel();
            this.door_btn2 = new System.Windows.Forms.Panel();
            this.door_pib1 = new System.Windows.Forms.Panel();
            this.door_pib2 = new System.Windows.Forms.Panel();
            this.left_look = new System.Windows.Forms.Panel();
            this.right_look = new System.Windows.Forms.Panel();
            this.wind_up = new System.Windows.Forms.Panel();
            this.jumpscare_pcb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jumpscare_pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // jumpscare_timer
            // 
            this.jumpscare_timer.Tick += new System.EventHandler(this.jumpscare_timer_Tick);
            // 
            // E_timer
            // 
            this.E_timer.Interval = 6000;
            this.E_timer.Tick += new System.EventHandler(this.E_timer_Tick);
            // 
            // K_timer
            // 
            this.K_timer.Interval = 6000;
            this.K_timer.Tick += new System.EventHandler(this.K_timer_Tick);
            // 
            // D_timer
            // 
            this.D_timer.Interval = 6000;
            this.D_timer.Tick += new System.EventHandler(this.D_timer_Tick);
            // 
            // S_timer
            // 
            this.S_timer.Interval = 6000;
            // 
            // power_conter
            // 
            this.power_conter.Tick += new System.EventHandler(this.power_conter_Tick);
            // 
            // _6AM
            // 
            this._6AM.Interval = 10000;
            this._6AM.Tick += new System.EventHandler(this._6AM_Tick);
            // 
            // soundEffects
            // 
            this.soundEffects.Interval = 1000;
            this.soundEffects.Tick += new System.EventHandler(this.soundEffects_Tick);
            // 
            // music_box
            // 
            this.music_box.Tick += new System.EventHandler(this.music_box_Tick);
            // 
            // hours
            // 
            this.hours.Interval = 60000;
            this.hours.Tick += new System.EventHandler(this.hours_Tick);
            // 
            // camera_btn
            // 
            this.camera_btn.BackColor = System.Drawing.Color.Transparent;
            this.camera_btn.BackgroundImage = global::DA_NiEL.Properties.Resources.Camera_button;
            this.camera_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.camera_btn.Location = new System.Drawing.Point(257, 404);
            this.camera_btn.Name = "camera_btn";
            this.camera_btn.Size = new System.Drawing.Size(329, 36);
            this.camera_btn.TabIndex = 0;
            this.camera_btn.MouseEnter += new System.EventHandler(this.camera_btn_MouseEnter);
            // 
            // door_btn1
            // 
            this.door_btn1.BackColor = System.Drawing.Color.Transparent;
            this.door_btn1.Location = new System.Drawing.Point(495, 266);
            this.door_btn1.Name = "door_btn1";
            this.door_btn1.Size = new System.Drawing.Size(78, 75);
            this.door_btn1.TabIndex = 1;
            this.door_btn1.Click += new System.EventHandler(this.door_btn1_Click);
            // 
            // door_btn2
            // 
            this.door_btn2.BackColor = System.Drawing.Color.Transparent;
            this.door_btn2.Location = new System.Drawing.Point(257, 266);
            this.door_btn2.Name = "door_btn2";
            this.door_btn2.Size = new System.Drawing.Size(78, 75);
            this.door_btn2.TabIndex = 2;
            this.door_btn2.Click += new System.EventHandler(this.door_btn2_Click);
            // 
            // door_pib1
            // 
            this.door_pib1.BackColor = System.Drawing.Color.Transparent;
            this.door_pib1.BackgroundImage = global::DA_NiEL.Properties.Resources.right_door;
            this.door_pib1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door_pib1.Location = new System.Drawing.Point(496, 135);
            this.door_pib1.Name = "door_pib1";
            this.door_pib1.Size = new System.Drawing.Size(77, 100);
            this.door_pib1.TabIndex = 3;
            // 
            // door_pib2
            // 
            this.door_pib2.BackColor = System.Drawing.Color.Transparent;
            this.door_pib2.BackgroundImage = global::DA_NiEL.Properties.Resources.back_door;
            this.door_pib2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door_pib2.Location = new System.Drawing.Point(257, 135);
            this.door_pib2.Name = "door_pib2";
            this.door_pib2.Size = new System.Drawing.Size(77, 100);
            this.door_pib2.TabIndex = 4;
            // 
            // left_look
            // 
            this.left_look.BackColor = System.Drawing.Color.Transparent;
            this.left_look.BackgroundImage = global::DA_NiEL.Properties.Resources.left_button;
            this.left_look.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left_look.Location = new System.Drawing.Point(12, 73);
            this.left_look.Name = "left_look";
            this.left_look.Size = new System.Drawing.Size(43, 320);
            this.left_look.TabIndex = 5;
            this.left_look.Click += new System.EventHandler(this.left_look_Click);
            // 
            // right_look
            // 
            this.right_look.BackColor = System.Drawing.Color.Transparent;
            this.right_look.BackgroundImage = global::DA_NiEL.Properties.Resources.right_button;
            this.right_look.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.right_look.Location = new System.Drawing.Point(783, 73);
            this.right_look.Name = "right_look";
            this.right_look.Size = new System.Drawing.Size(43, 320);
            this.right_look.TabIndex = 6;
            this.right_look.Click += new System.EventHandler(this.right_look_Click);
            // 
            // wind_up
            // 
            this.wind_up.BackColor = System.Drawing.Color.Transparent;
            this.wind_up.Location = new System.Drawing.Point(379, 266);
            this.wind_up.Name = "wind_up";
            this.wind_up.Size = new System.Drawing.Size(78, 75);
            this.wind_up.TabIndex = 7;
            this.wind_up.Click += new System.EventHandler(this.wind_up_Click);
            // 
            // jumpscare_pcb
            // 
            this.jumpscare_pcb.BackColor = System.Drawing.Color.Transparent;
            this.jumpscare_pcb.Location = new System.Drawing.Point(356, 135);
            this.jumpscare_pcb.Name = "jumpscare_pcb";
            this.jumpscare_pcb.Size = new System.Drawing.Size(117, 100);
            this.jumpscare_pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jumpscare_pcb.TabIndex = 8;
            this.jumpscare_pcb.TabStop = false;
            this.jumpscare_pcb.Visible = false;
            // 
            // nights
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DA_NiEL.Properties.Resources.front;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.jumpscare_pcb);
            this.Controls.Add(this.wind_up);
            this.Controls.Add(this.right_look);
            this.Controls.Add(this.left_look);
            this.Controls.Add(this.door_pib2);
            this.Controls.Add(this.door_pib1);
            this.Controls.Add(this.door_btn2);
            this.Controls.Add(this.door_btn1);
            this.Controls.Add(this.camera_btn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2560, 1440);
            this.MinimumSize = new System.Drawing.Size(854, 480);
            this.Name = "nights";
            this.Load += new System.EventHandler(this.Night_1_Load);
            this.Resize += new System.EventHandler(this.nights_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.jumpscare_pcb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Timer jumpscare_timer;
        private System.Windows.Forms.Timer E_timer;
        private System.Windows.Forms.Timer K_timer;
        private System.Windows.Forms.Timer D_timer;
        private System.Windows.Forms.Timer S_timer;
        private System.Windows.Forms.Timer power_conter;
        private System.Windows.Forms.Timer _6AM;
        private System.Windows.Forms.Timer soundEffects;
        private System.Windows.Forms.Timer music_box;
        private System.Windows.Forms.Timer hours;
        private System.Windows.Forms.Panel camera_btn;
        private System.Windows.Forms.Panel door_btn1;
        private System.Windows.Forms.Panel door_btn2;
        private System.Windows.Forms.Panel door_pib1;
        private System.Windows.Forms.Panel door_pib2;
        private System.Windows.Forms.Panel left_look;
        private System.Windows.Forms.Panel right_look;
        private System.Windows.Forms.Panel wind_up;
        private System.Windows.Forms.PictureBox jumpscare_pcb;
    }
}