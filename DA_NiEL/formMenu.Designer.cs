using System.Windows.Forms;
using System;

namespace DA_NiEL
{
    partial class formMenu
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
            this.Start_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Night1_button = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Night5_button = new System.Windows.Forms.Label();
            this.Night4_button = new System.Windows.Forms.Label();
            this.Night2_button = new System.Windows.Forms.Label();
            this.Night3_button = new System.Windows.Forms.Label();
            this.star_pcb = new System.Windows.Forms.PictureBox();
            this.patch_note_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star_pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.Color.Black;
            this.Start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_button.Location = new System.Drawing.Point(54, 28);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(219, 71);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            this.Start_button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Start_button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Black;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.Exit_button.Location = new System.Drawing.Point(54, 282);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(219, 71);
            this.Exit_button.TabIndex = 2;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.buttonExit_Click);
            this.Exit_button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Exit_button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Night1_button
            // 
            this.Night1_button.AutoSize = true;
            this.Night1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Night1_button.Location = new System.Drawing.Point(14, 9);
            this.Night1_button.Name = "Night1_button";
            this.Night1_button.Size = new System.Drawing.Size(59, 20);
            this.Night1_button.TabIndex = 9;
            this.Night1_button.Text = "Night 1";
            this.Night1_button.Click += new System.EventHandler(this.button1_Click);
            this.Night1_button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Night1_button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.Night5_button);
            this.panel3.Controls.Add(this.Night1_button);
            this.panel3.Controls.Add(this.Night4_button);
            this.panel3.Controls.Add(this.Night2_button);
            this.panel3.Controls.Add(this.Night3_button);
            this.panel3.Location = new System.Drawing.Point(118, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 161);
            this.panel3.TabIndex = 10;
            // 
            // Night5_button
            // 
            this.Night5_button.AutoSize = true;
            this.Night5_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Night5_button.Location = new System.Drawing.Point(14, 129);
            this.Night5_button.Name = "Night5_button";
            this.Night5_button.Size = new System.Drawing.Size(59, 20);
            this.Night5_button.TabIndex = 13;
            this.Night5_button.Text = "Night 5";
            this.Night5_button.Click += new System.EventHandler(this.button5_Click);
            this.Night5_button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Night5_button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Night4_button
            // 
            this.Night4_button.AutoSize = true;
            this.Night4_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Night4_button.Location = new System.Drawing.Point(14, 99);
            this.Night4_button.Name = "Night4_button";
            this.Night4_button.Size = new System.Drawing.Size(59, 20);
            this.Night4_button.TabIndex = 12;
            this.Night4_button.Text = "Night 4";
            this.Night4_button.Click += new System.EventHandler(this.button4_Click);
            this.Night4_button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Night4_button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Night2_button
            // 
            this.Night2_button.AutoSize = true;
            this.Night2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Night2_button.Location = new System.Drawing.Point(14, 38);
            this.Night2_button.Name = "Night2_button";
            this.Night2_button.Size = new System.Drawing.Size(59, 20);
            this.Night2_button.TabIndex = 10;
            this.Night2_button.Text = "Night 2";
            this.Night2_button.Click += new System.EventHandler(this.button2_Click);
            this.Night2_button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Night2_button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Night3_button
            // 
            this.Night3_button.AutoSize = true;
            this.Night3_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Night3_button.Location = new System.Drawing.Point(14, 69);
            this.Night3_button.Name = "Night3_button";
            this.Night3_button.Size = new System.Drawing.Size(59, 20);
            this.Night3_button.TabIndex = 11;
            this.Night3_button.Text = "Night 3";
            this.Night3_button.Click += new System.EventHandler(this.button3_Click);
            this.Night3_button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Night3_button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // star_pcb
            // 
            this.star_pcb.BackColor = System.Drawing.Color.Transparent;
            this.star_pcb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.star_pcb.Image = global::DA_NiEL.Properties.Resources.Star;
            this.star_pcb.Location = new System.Drawing.Point(297, 9);
            this.star_pcb.Name = "star_pcb";
            this.star_pcb.Size = new System.Drawing.Size(100, 100);
            this.star_pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star_pcb.TabIndex = 7;
            this.star_pcb.TabStop = false;
            // 
            // patch_note_lbl
            // 
            this.patch_note_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patch_note_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patch_note_lbl.Location = new System.Drawing.Point(480, 70);
            this.patch_note_lbl.Name = "patch_note_lbl";
            this.patch_note_lbl.Size = new System.Drawing.Size(285, 283);
            this.patch_note_lbl.TabIndex = 11;
            this.patch_note_lbl.Text = "Patch notes\r\nDA_niel v.alpha_1\r\n\r\n\r\n- Egy animatronic + az ő jumpscare-e\r\n\r\n- Mon" +
    "itorhoz való igazodás\r\n\r\n- Egy éjszaka van egyenlőre még\r\n\r\n- A jumpscare nagyon" +
    " hangos 💀\r\n\r\n\r\n";
            this.patch_note_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "0/18";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 396);
            this.progressBar1.Maximum = 18;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(814, 33);
            this.progressBar1.TabIndex = 13;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patch_note_lbl);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.star_pcb);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(2560, 1440);
            this.MinimumSize = new System.Drawing.Size(854, 480);
            this.Name = "formMenu";
            this.Text = "DA_NiEL";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.formMenu_Activated);
            this.Resize += new System.EventHandler(this.formMenu_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star_pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Start_button;
        private Button Exit_button;
        private PictureBox star_pcb;
        private Label Night1_button;
        private Panel panel3;
        private Label Night5_button;
        private Label Night4_button;
        private Label Night2_button;
        private Label Night3_button;
        private Label patch_note_lbl;
        private Label label1;
        private ProgressBar progressBar1;
        private Timer timer1;
    }
}