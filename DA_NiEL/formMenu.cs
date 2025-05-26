using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace DA_NiEL
{
    public partial class formMenu : Form
    {
        public static int counter = 1;
        public static int night;
        public static int E_max = 15;
        public static int K_max = 15;
        public static int D_max = 15;
        static float scaleRatio;
        static float widthRatio;
        static float heightRatio;
        private formMenu foForm;

        public formMenu()
        {
            InitializeComponent();

            progressBar1.Maximum = 18;

            ProgressBarSet();

            patch_note_lbl.Visible = false;
            Start_button.Visible = false;
            Exit_button.Visible = false;

            star_pcb.Visible = false;
            panel3.Size = new Size(panel3.Size.Width, 0);

            Night1_button.Text = "Night 1";

            Night2_button.Text = "Locked";

            Night3_button.Text = "Locked";

            Night4_button.Text = "Locked";

            Night5_button.Text = "Locked";

            star_pcb.Visible = false;

            foreach (Control control in this.Controls)
            {
                if (control is Button || control is System.Windows.Forms.Label)
                {
                    control.MouseEnter += Button_MouseEnter;
                    control.MouseLeave += Button_MouseLeave;
                }
            }
        }

        private void ProgressBarSet()
        {
            progressBar1.Value = nights.GetScare();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            if (Start_button.Text == "Start")
            {
                panel3.Size = new Size(panel3.Size.Width, (int)(220 * heightRatio));
                Start_button.Text = "Close";
                formMenu_Resize(sender, e);
            }
            else
            {
                panel3.Size = new Size(panel3.Size.Width, 0);
                Start_button.Text = "Start";
                formMenu_Resize(sender, e);
            }
        }

        private void Night_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to Leave?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nights form2 = new nights();

            form2.FormClosed += Night_1_FormClosed;

            form2.Show();

            this.Hide();

            night = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Night2_button.Text == "Night 2")
            {
                MessageBox.Show("End of alpha","System");
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Night3_button.Text == "Night 3")
            {
                nights form2 = new nights();

                form2.FormClosed += Night_1_FormClosed;

                form2.Show();

                this.Hide();

                night = 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Night4_button.Text == "Night 4")
            {
                nights form2 = new nights();

                form2.FormClosed += Night_1_FormClosed;

                form2.Show();

                this.Hide();

                night = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Night5_button.Text == "Night 5")
            {
                nights form2 = new nights();

                form2.FormClosed += Night_1_FormClosed;

                form2.Show();

                this.Hide();

                night = 5;
            }
        }

        private void ShowStar()
        {
            star_pcb.Visible = true;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
            }
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            if (label != null)
            {
                label.BackColor = Color.White;
                label.ForeColor = Color.Black;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.Black;
                button.ForeColor = Color.White;
            }
            System.Windows.Forms.Label label = sender as System.Windows.Forms.Label;
            if (label != null)
            {
                label.BackColor = Color.Black;
                label.ForeColor = Color.White;
            }
        }

        private void formMenu_Resize(object sender, EventArgs e)
        {
            widthRatio = (float)this.ClientSize.Width / 2200;
            heightRatio = (float)this.ClientSize.Height / 1300;
            scaleRatio = Math.Min(widthRatio, heightRatio);

            Start_button.Width = (int)(219 * widthRatio);
            Start_button.Height = (int)(71 * heightRatio);
            Start_button.Location = new Point((int)((this.ClientSize.Width - Start_button.Width) * 1.75 / 16), (int)((this.ClientSize.Height - Start_button.Height) * 3 / 16));
            Start_button.Font = new Font(Start_button.Font.FontFamily, 20 * scaleRatio, Start_button.Font.Style);

            panel3.Width = (int)(Start_button.Size.Width);
            panel3.Location = new Point((int)((this.ClientSize.Width - panel3.Width) * 1.75 / 16), (int)(Start_button.Location.Y + Start_button.Height));
            Night1_button.Font = new Font(Night1_button.Font.FontFamily, 18 * scaleRatio, Night1_button.Font.Style);
            Night2_button.Font = new Font(Night2_button.Font.FontFamily, 18 * scaleRatio, Night2_button.Font.Style);
            Night3_button.Font = new Font(Night3_button.Font.FontFamily, 18 * scaleRatio, Night3_button.Font.Style);
            Night4_button.Font = new Font(Night4_button.Font.FontFamily, 18 * scaleRatio, Night4_button.Font.Style);
            Night5_button.Font = new Font(Night5_button.Font.FontFamily, 18 * scaleRatio, Night5_button.Font.Style);

            Exit_button.Width = (int)(219 * widthRatio);
            Exit_button.Height = (int)(71 * heightRatio);
            Exit_button.Location = new Point((int)((this.ClientSize.Width - Exit_button.Width) * 1.75 / 16), (int)(panel3.Location.Y + panel3.ClientSize.Height));
            Exit_button.Font = new Font(Exit_button.Font.FontFamily, 20 * scaleRatio, Exit_button.Font.Style);

            star_pcb.Width = (int)(105 * widthRatio);
            star_pcb.Height = (int)(105 * heightRatio);
            star_pcb.Location = new Point((int)((this.ClientSize.Width - star_pcb.Width) * 3.5 / 16), (int)((this.ClientSize.Height - star_pcb.Height) * 2.5 / 16));

            patch_note_lbl.Width = (int)(485 * widthRatio);
            patch_note_lbl.Height = (int)(680 * heightRatio);
            patch_note_lbl.Location = new Point((int)((this.ClientSize.Width - patch_note_lbl.Width) * 11.5 / 16), (int)((this.ClientSize.Height - patch_note_lbl.Height) * 5.5 / 16));
            patch_note_lbl.Font = new Font(Night1_button.Font.FontFamily, 22 * scaleRatio, Night1_button.Font.Style);
        }

        private void formMenu_Activated(object sender, EventArgs e)
        {
            if (counter == 2)
            {
                Night2_button.Text = "Night 2";
            }
            if (counter == 3)
            {
                Night3_button.Text = "Night 3";
            }
            if (counter == 4)
            {
                counter++;
                Night4_button.Text = "Night 4";
            }
            if (counter == 5)
            {
                counter++;
                Night5_button.Text = "Night 5";
            }
            if (counter == 6)
            {
                ShowStar();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
