using System;
using System.Collections.Generic;

namespace WpfApp2
{
    class ligneDeBus:IComparable<ligneDeBus>
    {
        private autobusStation firstStation;
        public int numberLine {  get; private set; }
        private lineStation lastStation;

        private List<lineStation> linestations;
        public ligneDeBus(int station,autobusStation first,lineStation last)
        {
            numberLine = station;
            firstStation = first;
            lastStation = last;
            linestations = new List<lineStation>();
        }
        public void addStation(lineStation stationToAdd ,int position=0)
        {
            linestations.Insert(position,stationToAdd);

        }

        protected ligneDeBus TeteMassloul(int key1, int key2)
        {
            int index = Math.Max(indexStation(key1), indexStation(key2));
            int index2 = Math.Min(indexStation(key1), indexStation(key2));
            if (index == -2 || index2 == -2)
            {
                return null;
            }
            ligneDeBus x = new ligneDeBus(0, linestations[index2], linestations[index]);
            for (; index2 < index;index++)
            {
                 x.addStation(linestations[index2]);
            }
            return x;
        }
        public void deleteStation (int numberStation)
        {
            for(int i=0;i<linestations.Count;i++)
            {
                if(linestations[i].numberStation == numberStation)
                {
                    linestations.RemoveAt(i);
                    return;
                }
            }
        }

        public override string ToString()
        {
            string v ="";
            for(int i = 0; i < linestations.Count; i++)
            {
                v += linestations[i].ToString();
                v += "\n";
            }
            return v;
        }
        public bool verificationStation(int numberStation)
        {
            if(lastStation.numberStation==numberStation||firstStation.numberStation==numberStation)
            {
                return true;
            }
            
            for (int i = 0; i < linestations.Count; i++)
            {
                if (linestations[i].numberStation == numberStation)
                {
                    return true;
                }
            }
            return false;
        }

        public int indexStation (int key)
        {
            if(firstStation.numberStation==key)
            {
                return -1;
            }
            if (lastStation.numberStation == key)
            {
                return linestations.Count;
            }

            for (int i = 0; i < linestations.Count; i++)
            {
                if (linestations[i].numberStation == key)
                {
                    return i;
                }
            }
            return -2;
        }
        
        
        
        
        public float nombreStation (int key1, int key2)
        {
            float distance = 0;
            int index = Math.Max(indexStation(key1), indexStation(key2));
            int index2 = Math.Min(indexStation(key1), indexStation(key2))+1;
            if (index == -2 || index2 == -2)
            {
                return - 1;
            }
            if (index == linestations.Count)
            {
                index--;
                distance += lastStation.distance;
            }
            for (; index2 < index;)
            {
                distance += linestations[index2].distance;
            }
            return distance;
        }

        public float diffTime (int key1 ,int key2)
        {
            float timer = 0;
            
            int index = Math.Max(indexStation(key1), indexStation(key2));
            int index2 = Math.Min(indexStation(key1), indexStation(key2)) + 1;
            if (index == -2 || index2 == -2)
            {
                return -1;
            }
            if (index == linestations.Count)
            {
                index--;
                timer += lastStation.time;
                
            }
            for (; index2 < index;)
            {
                timer += linestations[index2].time;
            }
            return timer;
        }

        public float maxTime ()
        {
            float timer = 0;
            for(int i=0;i<linestations.Count;i++)
            {
                timer += linestations[i].time;
            }
            timer += lastStation.time;
            return timer;
        }

        public int CompareTo( ligneDeBus other)
        {
          return   this.maxTime().CompareTo(other.maxTime());
        }

    }
}
