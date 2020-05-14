using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceEx
{
    public class Jungles
    {
        public Jungles(string name)
        {
            JungleName = name;
        }

        public Jungles(string name, int numberOfFrog)
        {
            JungleName = name;
            for (int i = 0; i < numberOfFrog; i++)
            {
                var frog = new Frog(i);
                frog.Name = string.Format("Frog number {0}", i);
                AddFrog(frog);
            }
        }
        public string JungleName { get; set; }

        public IList<Frog> Frogs { get; set; } = new List<Frog>();

        public void AddFrog(Frog frog)
        {
            this.Frogs.Add(frog);
        }

        public IEnumerable<Frog> GetFrogs(int numberOfColors)
        {
            return this.Frogs.Where(x => x.NumberOfColors >= numberOfColors);
        }

        public List<Frog> GetFrogs(float numberOfColors)
        {
            return this.Frogs.Where(x => x.NumberOfColors >= numberOfColors).ToList();
        }
    }
}
