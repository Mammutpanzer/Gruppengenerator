using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gruppengenerator
{
    class Program
    {
        static string[] namen = new string[20] { "Aaron Boeck", "Christopher Bendel", "Matthias Brasch", "Theodor Gaede", "Paul Gano", "Lucas Hermann", "Michael Kehnscherper", "Stanislav Kovalenko", "Ezequiel Kovar Bodasiuk", "Hannes Kuehl", "Jessica Ludwig", "Felix Martin", "Alexander Noel", "Paul Rutkiewitz", "Jphannes Schumacher", "Ekhard Seer", "Till Sieling", "Jakob Warmhold", "Peter Wolf", "Stefan Braeunlein" };



        public static void Main(string[] args)
        {
            int groupsize;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Wie gross sollen die Gruppen sein?");
                bool boool = int.TryParse(Console.ReadLine().ToString(), out groupsize);
                if (boool)
                {
                    Console.Clear();
                    break;
                }
            }




            List<string> listEingabe = new List<string>(namen);
            List<string> listAusgabe = new List<string>();
            int iCount = listEingabe.Count;
            Random r = new Random();
            for (int i = 0; i < iCount; i++)
            {
                int iIndex = r.Next(listEingabe.Count);
                listAusgabe.Add(listEingabe[iIndex]);
                listEingabe.RemoveAt(iIndex);
            }


            int group = 1;
            int currentsize = 0;
            Console.WriteLine("Gruppe " + group.ToString() + ":"); //Schreibe "Gruppe 1:"


            foreach (string i in listAusgabe)
            {
                if (currentsize >= groupsize) //Hat die derzeitige Größe die maximale Gruppengröße überstiegen
                {
                    group++;
                    currentsize = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Gruppe " + group.ToString() + ":");
                }
                Console.WriteLine(i.ToString());
                currentsize++;
            }

            string end = Console.ReadLine();
        }
    }
}
