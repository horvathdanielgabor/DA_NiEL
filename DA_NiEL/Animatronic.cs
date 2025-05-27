using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace DA_NiEL
{
    internal class Animatronic
    {
        public string Name { get; private set; }
        public int StepsMax { get; set; }
        public string Letter { get; private set; }
        public List<Image> Jumpscare_ls { get; private set; }

        public int Step { get; set; }

        public Animatronic(string name, string letter, string steps)
        {
            Name = name;
            Letter = letter;
            StepsMax = Convert.ToInt32(steps);
        }

        public static void StepSet(int step)
        {

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
