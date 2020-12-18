using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp2
{
    class autobusStation
    {
        public int numberStation {  get; protected set; }
        protected double lattitude;
        protected double longitude;
        protected string stationAdress;

        public autobusStation(int numberStation,string adress = " ")

        {
            this.numberStation = numberStation;
            Random x = new Random();
            lattitude = x.NextDouble() * 180 - 90;
            longitude = x.NextDouble() * 360 - 180;
            this.stationAdress =adress;

        }
        public override string ToString()
        {
            return "numberStation: "+ numberStation.ToString()+"lattitude: "+lattitude.ToString()+"longitude: "+longitude.ToString()+"adresse: "+stationAdress;
        }
        







    }
}
