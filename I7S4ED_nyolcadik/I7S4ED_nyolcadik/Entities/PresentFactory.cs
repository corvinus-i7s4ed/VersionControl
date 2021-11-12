using I7S4ED_nyolcadik.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I7S4ED_nyolcadik.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }

        public Toy CreateNew()
        {
            return new Present(Color1, Color2);
        }
    }
}
