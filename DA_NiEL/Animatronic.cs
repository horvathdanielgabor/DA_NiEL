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
        public int StepsMax;
        public string Letter;
        public List<Image> Jumpscare_ls;

        public Animatronic(string name, string letter, string steps)
        {
            Name = name;
            Letter = letter;
            StepsMax = Convert.ToInt32(steps);
        }

        public void jumpscAdd(string Name, List<Image> jumps)
        {
            for (int i = 0; i < jumps.Count; i++)
            {
                Jumpscare_ls[int.Parse(Name)] = jumps[i];
            }
        }
    }
}
