using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_NiEL
{
    public partial class tablet : Form
    {
        static int doris2_x = 12;
        static int doris2_y = 339;
        public static bool doris_fin = false;
        private nights nightsInstance;
        static int K_step;
        static int E_step;
        static int D_step;
        static List<Panel> K_pn_l = new List<Panel>();
        static List<Panel> E_pn_l = new List<Panel>();
        static List<Panel> D_pn_l = new List<Panel>();
        public tablet(nights doris)
        {
            InitializeComponent();
            nightsInstance = doris;

            K_pn_l = GetAllPanel("kenny", 8);
            E_pn_l = GetAllPanel("evan", 9);
            D_pn_l = GetAllPanel("doris", 2);
        }

        private void buttonCloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check_Tick(object sender, EventArgs e)
        {
            if (nights.hour == 0)
            {
                label1.Text = "12 AM";
            }
            else
            {
                label1.Text = $"{nights.hour} AM";
            }

            label2.Text = $"Power: {nights.power_left}%";

            music_panel.Size = new Size(music_panel.Width, nights.music);
            music_panel.Location = new Point(444, 269 + (90 - nights.music));

            K_step = nights.K_step;
            E_step = nights.E_step;
            D_step = nights.D_step;

            if (nights.door1)
            {
                door1_pnl.Visible = true;
            }
            else
            {
                door1_pnl.Visible = false;
            }

            if (nights.door2)
            {
                door2_pnl.Visible = true;
            }
            else
            {
                door2_pnl.Visible = false;
            }

            AnimLocation(K_step, K_pn_l);
            AnimLocation(E_step, E_pn_l);

            switch (D_step)
            {
                case 0:
                    doris_1.Visible = true;
                    doris_2.Visible = false;
                    doris_2.Location = new Point(12, 339);
                    doris2_x = 12;
                    doris2_y = 339;
                    break;
                case 1:
                    doris_2.Visible= true;
                    doris_1.Visible= false;
                    doris_2.Location = new Point(12, 339);
                    doris2_x = 12;
                    doris2_y = 339;
                    break;
                case 2:
                    if (doris2_x == 407)
                    {
                        if (doris2_y == 275)
                        {
                            doris_fin = true;
                            nightsInstance.D_trigger(sender, e);
                        }
                        else
                        {
                            doris2_y = doris2_y -1;
                            doris_2.Location = new Point(doris2_x,doris2_y);
                        }
                    }
                    else
                    {
                        doris2_x = doris2_x + 1;
                        doris_2.Location = new Point(doris2_x, doris2_y);
                    }
                    break;
            }
        }

        private void AnimLocation(int step, List<Panel> pn_l)
        {
            foreach (var pn in pn_l)
            {
                pn.Visible = false;
            }

            if (step <= pn_l.Count() && step > 0)
            {
                pn_l[step].Visible = true;
            }
            else
            {
                pn_l[0].Visible = true;
            }
        }

        private List<Panel> GetAllPanel(string letter, int max)
        {
            List<Panel> paneles = new List<Panel>();

            int counting = 1;
            bool fin = true;

            while (fin)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Panel panel)
                    {
                        if (panel.Name == $"{letter}_{counting}")
                        {
                            paneles.Add(panel);
                            counting++;

                            if (panel.Name == $"{letter}_{max}")
                            {
                                fin = false;
                            }
                        }
                    }
                }
            }
            return paneles;
        }
    }
}
