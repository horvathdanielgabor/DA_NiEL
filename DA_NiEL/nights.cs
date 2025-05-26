using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace DA_NiEL
{
    public partial class nights : Form
    {
        private AxWMPLib.AxWindowsMediaPlayer background1;
        private AxWMPLib.AxWindowsMediaPlayer fan;
        private AxWMPLib.AxWindowsMediaPlayer jumpscare_sound;
        private Random random = new Random();
        private int maxConcurrentSounds = 1;
        private int currentSoundCount = 0;

        public static int hour = 0;
        public static int power_left = 100;
        public static int E_step = 0;
        public static int K_step = 0;
        public static int D_step = 0;
        static char scare;
        static int frame = 1;
        public static int music = 90;
        static double power = 100;
        static int waste = 1;
        static Image front = Properties.Resources.front;
        static Image right = Properties.Resources.right;
        static Image back = Properties.Resources.back;
        private tablet newForm = null;
        static float scaleRatio;
        static float widthRatio;
        static float heightRatio;

        public static bool door1 = false;
        public static bool door2 = false;

        static Random AI = new Random();
        public nights()
        {
            InitializeComponent();

            if (formMenu.E_max > 0)
            {
                E_timer.Start();
            }

            jumpscare_timer.Interval = Convert.ToInt32(1000 / 30);

            this.FormClosed += MainForm_FormClosed;

            fan = new AxWMPLib.AxWindowsMediaPlayer();
            fan.CreateControl();
            fan.settings.setMode("loop", true);
            fan.URL = "ceiling_fan.mp3";
            this.Controls.Add(fan);

            background1 = new AxWindowsMediaPlayer();
            background1.CreateControl();
            background1.settings.setMode("loop", false);
            this.Controls.Add(background1);

            soundEffects = new Timer();
            if (random != null)
            {
                soundEffects.Interval = GetRandomInterval();
            }

            soundEffects.Tick += soundEffects_Tick;
            soundEffects.Start();
        }

        public static int GetScare()
        {
            return FileIO.hany;
        }

        private int GetRandomInterval()
        {
            return random.Next(2000, 7000);
        }

        private void Night_1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = front;

            jumpscare_pcb.Visible = false;
            wind_up.Visible = true;
            camera_btn.Visible = true;
            left_look.Visible = false;
            right_look.Visible = true;
            door_btn1.Visible = false;
            door_pib2.Visible = false;
            door_pib1.Visible = false;
            door_btn2.Visible = false;

            E_step = 1;
            K_step = 1;
            D_step = 1;

            nights_Resize(sender, e);

            left_look.Visible = false;
            hours.Start();
            K_timer.Start();
            // D_timer.Start();
            // music_box.Start();
            power_conter.Start();
        }

        private void buttonCloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hours_Tick(object sender, EventArgs e)
        {
            hour++;
            if (hour == 6)
            {
                hours.Stop();
                E_timer.Stop();
                K_timer.Stop();
                D_timer.Stop();
                S_timer.Stop();
                power_conter.Stop();
                _6AM.Start();
                wind_up.Visible = false;
                camera_btn.Visible = false;
                left_look.Visible = false;
                right_look.Visible = false;
                door_btn1.Visible = false;
                door_pib1.Visible = false;
                door_pib2.Visible = false;
                door_btn2.Visible = false;
                if (newForm != null && !newForm.IsDisposed)
                {
                    newForm.Close();
                }
                if (formMenu.counter == formMenu.night)
                {
                    formMenu.counter++;
                }
                this.BackgroundImage = null;
            }
        }

        private void camera_btn_MouseEnter(object sender, EventArgs e)
        {
            if (newForm == null || newForm.IsDisposed)
            {
                newForm = new tablet(this);
                newForm.FormClosed += NewForm_FormClosed;
                newForm.Show();
            }
            else
            {
                newForm.Activate();
            }
        }

        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            newForm = null;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (newForm != null && !newForm.IsDisposed)
            {
                newForm.Close();
            }
        }

        private void nights_Resize(object sender, EventArgs e)
        {
            widthRatio = (float)this.ClientSize.Width / 2200;
            heightRatio = (float)this.ClientSize.Height / 1300;
            scaleRatio = Math.Min(widthRatio, heightRatio);

            door_pib2.Width = this.ClientSize.Width;
            door_pib2.Height = this.ClientSize.Height;
            door_pib2.Location = new Point(0, 0);

            door_pib1.Width = this.ClientSize.Width;
            door_pib1.Height = this.ClientSize.Height;
            door_pib1.Location = new Point(0, 0);

            door_btn1.Width = (int)(94 * widthRatio);
            door_btn1.Height = (int)(78 * heightRatio);
            door_btn1.Location = new Point((int)((this.ClientSize.Width - door_btn1.Width) * 10.75 / 16), (int)((this.ClientSize.Height - door_btn1.Height) * 9.65 / 16 ));
            door_btn1.BringToFront();

            door_btn2.Width = (int)(84 * widthRatio);
            door_btn2.Height = (int)(73 * heightRatio);
            door_btn2.Location = new Point((int)((this.ClientSize.Width - door_btn2.Width) * 10.77 / 16), (int)((this.ClientSize.Height - door_btn2.Height) * 9.56 / 16));
            door_btn2.BringToFront();

            wind_up.Width = (int)(300 * widthRatio);
            wind_up.Height = (int)(215 * heightRatio);
            wind_up.Location = new Point((int)((this.ClientSize.Width - wind_up.Width) * 8 / 16), (int)((this.ClientSize.Height - wind_up.Height) * 10.25 / 16));
            wind_up.BringToFront();

            camera_btn.Width = (int)(1200 * widthRatio);
            camera_btn.Height = (int)(102 * heightRatio);
            camera_btn.Location = new Point((int)((this.ClientSize.Width - camera_btn.Width) * 8 / 16), (int)((this.ClientSize.Height - camera_btn.Height) * 15.85 / 16));
            camera_btn.BringToFront();

            left_look.Width = (int)(68 * widthRatio);
            left_look.Height = (int)(800 * heightRatio);
            left_look.Location = new Point((int)((this.ClientSize.Width - left_look.Width) * 0.15 / 16), (int)((this.ClientSize.Height - left_look.Height) * 8 / 16));
            left_look.BringToFront();

            right_look.Width = (int)(68 * widthRatio);
            right_look.Height = (int)(800 * heightRatio);
            right_look.Location = new Point((int)((this.ClientSize.Width - right_look.Width) * 15.85 / 16), (int)((this.ClientSize.Height - right_look.Height) * 8 / 16));
            right_look.BringToFront();

            jumpscare_pcb.Width = this.ClientSize.Width;
            jumpscare_pcb.Height = this.ClientSize.Height;
            jumpscare_pcb.Location = new Point(0, 0);
            jumpscare_pcb.BringToFront();

        }

        private void _6AM_Tick(object sender, EventArgs e)
        {
            _6AM.Stop();
            this.Close();
        }

        private void power_conter_Tick(object sender, EventArgs e)
        {
            if (waste == 3)
            {
                power = power - 0.05;
            }
            else if (waste == 2)
            {
                power = power - 0.01;
            }
            else if (waste == 1)
            {
                power = power - 0.005;
            }
            power_left = Convert.ToInt32(power);
        }

        private void E_timer_Tick(object sender, EventArgs e)
        {
            if (Animatronic_step(E_step, door1))
            {
                GameOverEffect();
                jumpscare_timer.Start();
                scare = 'E';
            }
            else
            {
                K_step = Animatronic_AI(E_step, formMenu.E_max);
            }
        }

        private void D_timer_Tick(object sender, EventArgs e)
        {
            int D_AI = AI.Next(1, 21);

            if (D_step == 2)
            {
                D_timer.Enabled = false;
            }
            if (tablet.doris_fin == true)
            {
                if (door2 == true)
                {
                    tablet.doris_fin = false;
                    D_step = 0;
                    D_timer.Enabled = true;
                }
                else
                {
                    if (newForm != null && !newForm.IsDisposed)
                    {
                        newForm.Close();
                    }
                    D_step = 0;
                }
            }
            else if (D_AI <= formMenu.D_max)
            {
                if (D_step != 2)
                {
                    D_step++;
                }
            }
        }

        public void D_trigger(object sender, EventArgs e)
        {
            D_timer.Start();
        }

        private void door_btn1_Click(object sender, EventArgs e)
        {
            if (door1)
            {
                door1 = false;
                waste--;
                door_pib1.Visible = false;
            }
            else
            {
                door1 = true;
                waste++;
                door_pib1.Visible = true;
            }
        }

        private void door_btn2_Click(object sender, EventArgs e)
        {
            if (door2)
            {
                door2 = false;
                waste--;
                door_pib2.Visible = false;
            }
            else
            {
                door2 = true;
                waste++;
                door_pib2.Visible = true;
            }
        }

        private void wind_up_Click(object sender, EventArgs e)
        {
            if (music < 88)
            {
                music = music + 2;
                if (music == 91)
                {
                    music--;
                }
            }
        }

        private void soundEffects_Tick(object sender, EventArgs e)
        {
            if (currentSoundCount < maxConcurrentSounds)
            {
                // Véletlenszerű hang kiválasztása
                string[] sounds = { "game_ambience1.mp3", "game_ambience2.mp3"};
                Random random = new Random();
                if (sounds != null && sounds.Length > 0)
                {
                    background1.URL = sounds[random.Next(sounds.Length)];
                    background1.Ctlcontrols.play();
                }

                // Növeljük a hangok számlálóját, és regisztráljuk az eseményt a csökkentéshez
                currentSoundCount++;
                background1.PlayStateChange += (s, args) =>
                {
                    if (args.newState == 1) // Leállított állapot
                        currentSoundCount--;
                };
            }

            // Új időintervallum beállítása a következő effekt lejátszásához
            soundEffects.Interval = GetRandomInterval();
        }

        private void music_box_Tick(object sender, EventArgs e)
        {
            music--;
        }

        private void right_look_Click(object sender, EventArgs e)
        {
            if (this.BackgroundImage == front)
            {
                this.BackgroundImage = right;
                wind_up.Visible = false;
                camera_btn.Visible = false;
                left_look.Visible = true;
                right_look.Visible = true;
                door_btn1.Visible = true;
                if (door1)
                {
                    door_pib1.Visible = true;
                }
                else
                {
                    door_pib1.Visible = false;
                }
                door_pib2.Visible = false;
                door_btn2.Visible = false;
            }
            else if (this.BackgroundImage == right)
            {
                this.BackgroundImage = back;
                wind_up.Visible = false;
                camera_btn.Visible = false;
                left_look.Visible = true;
                right_look.Visible = false;
                door_btn2.Visible = true;
                if (door2)
                {
                    door_pib2.Visible = true;
                }
                else
                {
                    door_pib2.Visible = false;
                }
                door_pib1.Visible = false;
                door_btn1.Visible = false;
            }
        }

        private void left_look_Click(object sender, EventArgs e)
        {
            if (this.BackgroundImage == right)
            {
                this.BackgroundImage = front;
                wind_up.Visible = true;
                camera_btn.Visible = true;
                left_look.Visible = false;
                right_look.Visible = true;
                door_btn1.Visible = false;
                door_pib2.Visible = false;
                door_pib1.Visible = false;
                door_btn2.Visible = false;
            }
            else if (this.BackgroundImage == back)
            {
                this.BackgroundImage = right;
                wind_up.Visible = false;
                camera_btn.Visible = false;
                left_look.Visible = true;
                right_look.Visible = true;
                door_btn1.Visible = true;
                if (door1)
                {
                    door_pib1.Visible = true;
                }
                else
                {
                    door_pib1.Visible = false;
                }
                door_pib2.Visible = false;
                door_btn2.Visible = false;
            }
        }

        private void jumpscare_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                //jumpscare_pcb.Image = formMenu.jumpscare_K_ls[frame];
                frame++;
            }
            catch
            {
                jumpscare_timer.Stop();
                this.Close();
            }

            jumpscare_sound = new AxWMPLib.AxWindowsMediaPlayer();
            jumpscare_sound.CreateControl();
            jumpscare_sound.URL = "jumpscare.mp3";
            this.Controls.Add(jumpscare_sound);
        }

        private void K_timer_Tick(object sender, EventArgs e)
        {
            if (Animatronic_step(K_step, door1))
            {
                GameOverEffect();
                scare = 'K';
                //jumpscare_timer.Start();
            }
            else
            {
                K_step = Animatronic_AI(K_step,formMenu.K_max);
            }
        }

        private int Animatronic_AI(int step, int maxAI)
        {
            if (AI.Next(1, 21) <= maxAI)
            {
                step++;
            }

            return step;
        }

        private bool Animatronic_step(int step, bool door)
        {
            if (step == 7)
            {
                if (door == true)
                {
                    step = 0;
                }
                else
                {
                    if (newForm != null && !newForm.IsDisposed)
                    {
                        newForm.Close();
                    }

                    return true;
                }
            }

            return false;
        }

        private void GameOverEffect()
        {
            door_pib2.Visible = false;
            door_pib1.Visible = false;
            door_btn1.Visible = false;
            door_btn2.Visible = false;
            wind_up.Visible = false;
            left_look.Visible = false;
            right_look.Visible = false;
            camera_btn.Visible = false;
            soundEffects.Stop();
            K_timer.Stop();
            E_timer.Stop();
            D_timer.Stop();
            music_box.Stop();
            S_timer.Stop();

            fan.settings.mute = true;
            background1.settings.mute = true;

            jumpscare_pcb.Visible = true;
        }
    }
}
