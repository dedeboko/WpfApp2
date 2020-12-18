using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace WpfApp2
{
    class Autobus
    {

        public Autobus(string numberAtobus, DateTime voila)
        {
            numberAutobus = numberAtobus;
            startDate = voila;
            essence = 1200;
            kilometerMade = 0;
        
        }
        public string numberAutobus;
        public DateTime startDate;
        public int kilometerMade;
        public int essence;

        public void MakeRoute(int kilometer)
        {
            if (kilometerMade + kilometer > 20000 || startDate.Year < DateTime.Now.Year)
            {
                throw new Exception("dangerous");
            }
            if (essence - kilometer < 0)
            {
                throw new Exception("make plain");
            }
            kilometerMade = kilometerMade + kilometer;
            essence = essence - kilometer;
        }
        public void Makeplein()
        {
            essence = 1200;
        }
        public void MakeRepair()
        {
            startDate = DateTime.Now;
            kilometerMade = 0;
        }
    }

}