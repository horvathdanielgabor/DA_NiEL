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
        static private string k_filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\k_jumpscare\\", "k_0.png");

        static public List<Animatronic> Beolvasas()
        {
            List<Animatronic> animatronics = new List<Animatronic>();

            try
            {
                StreamReader sr = new StreamReader("animatronics.txt");

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

                    List<Image> jumpscare = JumpscareUpload();

                    animatronics[newindex].jumpscAdd(name, jumpscare);
                }

                sr.Close();
            }
            catch (IOException)
            {

            }

            return animatronics;
        }

        private static List<Image> JumpscareUpload()
        {
            List <Image> jumpscare = new List<Image>();



            return jumpscare;
        }
    }
}
