using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProOktatasVizsgaFeladat
{
    public enum Minoseg { Bronze, Silver, Gold}
    public class Tapegyseg : Alkatresz
    {
        uint teljesitmeny; //(350-1200 Wattig)
        Minoseg minoseg;

        public override string Gyarto { 
            get => gyarto; 
            set 
            {
                //MEGVIZSGÁLJUK, HOGY A MEGADOTT ÉRTÉK AZ ENGEDÉLYEZETT TÁPEGYSÉG GYÁRTÓLISTÁBAN VAN-E
                if (Ertekek.tapegysegEngedelyezettGyartok.Contains(value))
                {
                    gyarto = value;
                }
                else
                {
                    throw new ArgumentException("Ez a gyártó tápegység esetén nem engedélyezett!");
                }
            } 
        }

        public override int Ar { 
            get => ar;
            set
            {
                if (value >= 500 && value <= 20000000)
                {
                    ar = value;
                }
                else
                {
                    throw new ArgumentException("Az ár csak 500Ft-tól engedélyezett!");
                }
            }
        }
        public uint Teljesitmeny { 
            get => teljesitmeny;
            set 
            { 
                if(value >= 350 && value <= 1200)
                {
                    teljesitmeny = value;
                }
                else
                {
                    throw new ArgumentException("A teljesítmény 350 és 1200 Watt között engedélyezett!");
                }
            } 
        }
        public Minoseg Minoseg { 
            get => minoseg;
            set 
            { 
                if(value == Minoseg.Bronze || value == Minoseg.Silver || value == Minoseg.Gold)
                {
                    minoseg = value;
                }
                else
                {
                    throw new ArgumentException("Ez a minőség nem engedélyezett!");
                }
            }
        }

        /// <summary>
        /// TOOLTIP: Specifikus paraméterek helye az adatbázisban 22-23
        /// </summary>
        public Tapegyseg(uint teljesitmeny, Minoseg minoseg, int id, string gyarto, string tipus, int ar, int garancia) : base(id, gyarto, tipus, ar, garancia)
        {
            Teljesitmeny = teljesitmeny;
            Minoseg = minoseg;
        }

    }
}
