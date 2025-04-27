using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DA_NiEL
{
    internal class Animatronic
    {
        public string Name;
        public int Steps;
        public string Letter;
        public List<Image> Jumpscare_ls = new List<Image>();

        public Animatronic(string name, string steps, string letter, List<Image> jump)
        {
            Name = name;
            Steps = Convert.ToInt32(steps);
            Letter = letter;
            Jumpscare_ls = jump;
        }
    }
}
