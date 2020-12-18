using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp2
{
    class AutobusArray
    {
        private Autobus[] arr;
        private int lenght;
        public AutobusArray() 
        {
            lenght = 0;
            arr = new Autobus[0];
        }
        public void addAutobus(string id,DateTime dateTime) 
        {
            lenght++;
            Autobus[] arrtemp = new Autobus[lenght];
            arrtemp[lenght - 1] = new Autobus(id,dateTime);
            for (int i = 0; i < lenght - 1; i++) 
            {
                arrtemp[i] = arr[i];
            }
            arr = arrtemp;
        }
        public void makeRepair(string id)
        {
            for (int i = 0; i < lenght; i++)
            {
                if (arr[i].numberAutobus == id)
                {
                    arr[i].MakeRepair();
                    return;
                }
            }
            throw new Exception("autobus not find");
        }
        public void makeplein(string id)
        {
            for (int i = 0; i < lenght; i++)
            {
                if (arr[i].numberAutobus == id)
                {
                    arr[i].Makeplein();
                    return;
                }
            }
            throw new Exception("autobus not find");
        }

        public void faireRoute(string id,int nombrekim)
        {
            for (int i = 0; i < lenght; i++)
            {
                if (arr[i].numberAutobus == id)
                {
                    arr[i].MakeRoute(nombrekim);
                    return;
                }
            }
            throw new Exception("autobus not find");
        }
    }
}
