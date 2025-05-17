using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_NiEL
{
    internal class FileIO
    {
        static private string k_filfolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\appdata", "\\k_jumpscare");
        static private string night_data = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\appdata\\", "animatronics.txt");
        static public int hany { get; private set; }
        static public List<Animatronic> Beolvasas()
        {
            List<Animatronic> animatronics = new List<Animatronic>();

            try
            {
                StreamReader sr = new StreamReader(night_data);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string name = line.Split(';')[0];

                    string letter;
                    try
                    {
                        letter = line.Split(';')[1];
                    }
                    catch (FormatException)
                    {
                        letter = name[0].ToString();
                    }

                    string maxstep = line.Split(';')[2];

                    Animatronic newone = new Animatronic(name, letter, maxstep);

                    animatronics.Add(newone);

                    int newindex = animatronics.IndexOf(newone);

                    List<Image> jumpscare = JumpscareUpload(k_filfolder);

                    animatronics[newindex].jumpscAdd(name, jumpscare);
                }

                sr.Close();
            }
            catch (IOException)
            {

            }

            return animatronics;
        }

        private static List<Image> JumpscareUpload(string folder)
        {
            List <Image> jumpscare = new List<Image>();

            bool finish = false;
            int numb = 1;
            do
            {
                try
                {
                    string file = Path.Combine(folder, $"jumpscare_{numb}");
                    Image frame = Bitmap.FromFile(file);
                    jumpscare.Add(frame);
                    hany++;
                    numb++;
                }
                catch (Exception)
                {
                    finish = true;
                }
            }
            while (!finish);

            return jumpscare;
        }
    }
}
