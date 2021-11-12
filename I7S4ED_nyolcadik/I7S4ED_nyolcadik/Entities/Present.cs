using I7S4ED_nyolcadik.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I7S4ED_nyolcadik.Entities
{
    public class Present : Toy
    {
        public SolidBrush Box { get; set; }
        public SolidBrush Ribbon { get; set; }

        public Present(Color Color1, Color Color2)
        {
            Box = new SolidBrush(Color1);
            Ribbon = new SolidBrush(Color2);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(Box, 0, 0, Width, Height);
            g.FillRectangle(Ribbon, 0, (Height / 5) * 2, Width, Height / 5);
            g.FillRectangle(Ribbon, (Width/5)*2, 0, Width/5, Height);

        }
    }
}
