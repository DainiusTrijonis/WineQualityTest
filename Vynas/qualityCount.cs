using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vynas
{
    class QualityCount
    {
        public int quality { get; set; }
        public int counter { get; set; }

        public QualityCount(int quality)
        {
            this.quality = quality;
            this.counter = 0;
        }

        public void addCounter()
        {
            counter++;
        }
    }
}
