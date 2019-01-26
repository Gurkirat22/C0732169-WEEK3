using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732169
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Countryside
    {
        // how will I make some Villages?
        Village Alst;
        Village Maeland;
        Village Schenig;

        public void InitializeMap()
        {
            Alst = new Village();
            Alst.VillageName = "Alst";
            Maeland = new Village();
            Maeland.VillageName = "Maeland";
            Maeland.isAstrildeHere = true;
            Schenig = new Village();
            Schenig.VillageName = "Schenig";

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;
        }

        public void WalkAround()
        {
            Village CurrentVillage = this.Maeland;
            if (CurrentVillage.isAstrildeHere)
            {
                Console.WriteLine("Hugi found Astrilde!!! celebrations! XOXO");
            }
            Village NextVillage;
            NextVillage = CurrentVillage.NextVillage;

        }
    }

    class Village

    {
       
        public Village PreviousVillage;
        public Village NextVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
        public Village() { }
    }
}
