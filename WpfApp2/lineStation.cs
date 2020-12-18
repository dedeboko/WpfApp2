using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp2
{
    class lineStation:autobusStation
    {
        public float distance { get; protected set; }
        public float time { get; protected set; }
        public  lineStation(float distance, float time, int numberStation, string adress = " ") : base(numberStation, adress)

        {
            this.distance = distance;
            this.time = time;
        }



    }
}
