using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIVAT.Layers
{
    public class ROI : Layer
    {
        public ROI(string name)
        {
            Name = name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetBoundingBox()
        {

        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
