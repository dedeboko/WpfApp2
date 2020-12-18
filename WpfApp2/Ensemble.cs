using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WpfApp2
{
    class Ensemble : IEnumerable<ligneDeBus>
    {
        protected List<ligneDeBus> liste;
        public ligneDeBus this[int i]
        {
            get { return liste[i]; }
           
        }

        public Ensemble()
        {
            this.liste = new List<ligneDeBus>();



        }
        
        public void addKav(ligneDeBus newLine)
        {
            int counter = 0;
            foreach(ligneDeBus x in liste)
            {
                if (x.numberLine == newLine.numberLine)
                    counter++;
                

            }
            if (counter == 2)
                Console.WriteLine("ERROR");
            else
                liste.Add(newLine);

        }
        public void deleteKav(int numOfLine)
        {
            foreach (ligneDeBus x in liste)
            {
                if (x.numberLine == numOfLine)
                {
                    liste.Remove(x);
                    break;
                }
            }
            foreach (ligneDeBus x in liste)
            {
                if (x.numberLine == numOfLine)
                {
                    liste.Remove(x);
                    break;
                }
            }
        }
    public List<ligneDeBus> stationCheck (int numOfStation)
            {
            List<ligneDeBus> uneListe = new List<ligneDeBus>();
            foreach(ligneDeBus x in liste)
            {
                if (x.verificationStation(numOfStation))
                    uneListe.Add(x);
            }
            if (uneListe.Count == 0)
                throw new Exception("n existe pas");
            else
                return uneListe;
            }
    public List<ligneDeBus> listSorted()
        {
            liste.Sort();
            return liste; 
        }
        



        public IEnumerator<ligneDeBus> GetEnumerator()
        {
            return liste.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return liste.GetEnumerator();
        }

    }
}
