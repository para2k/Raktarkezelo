using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProOktatasVizsgaFeladat
{
    public enum RamTipus { GDDR6, GDDR6X};
    public class Videokartya : Alkatresz
    {
        byte memoriaMerete; //(8-32 GB-ig)
        uint magOrajel; //(1800-3200 Mhz-ig)
        RamTipus ramTipus;
        uint fogyasztas; //(120-650 Wattig)
        bool raytracingTamogatasVane;


        public override string Gyarto 
        { 
            get => gyarto; 
            set 
            {
                //MEGVIZSGÁLJUK, HOGY A MEGADOTT ÉRTÉK AZ ENGEDÉLYEZETT VIDEOKÁRTYA GYÁRTÓLISTÁBAN VAN-E
                if (Ertekek.videokartyaEngedelyezettGyartok.Contains(value))
                {
                    gyarto = value;
                }
                else
                {
                    throw new ArgumentException("Ez a gyártó videókártya esetén nem engedélyezett!");
                }
            } 
        }

        public override int Ar
        {
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

        public byte MemoriaMerete { 
            get => memoriaMerete;
            set 
            {
                if (value >= 8 && value <= 32)
                {
                    memoriaMerete = value;
                }
                else
                {
                    throw new ArgumentException("A memória mérete 8 és 32GB között engedélyezett!");
                }
            } 
        }
        public uint MagOrajel { 
            get => magOrajel;
            set 
            {
                if(value >= 1800 && value <= 3200)
                {
                    magOrajel = value;
                }
                else
                {
                    throw new ArgumentException("A magórajel 1800 és 3200 Mhz között engedélyezett!");
                }
            } 
        }
        public RamTipus RamTipus { 
            get => ramTipus;
            set 
            { 
                if(value == RamTipus.GDDR6 || value == RamTipus.GDDR6X)
                {
                    ramTipus = value;
                }
                else
                {
                    throw new ArgumentException("Ez a RAM típus nem engedélyezett!");
                }
            }
        }
        public uint Fogyasztas { 
            get => fogyasztas;
            set 
            {
                if(value >= 120 && value <= 650)
                {
                    fogyasztas = value;
                }
                else
                {
                    throw new ArgumentException("A fogyasztás 120 és 650 Watt között engedélyezett!");
                }
            } 
        }
        public bool RaytracingTamogatasVane { get => raytracingTamogatasVane; set => raytracingTamogatasVane = value; }

        /// <summary>
        /// TOOLTIP: Specifikus paraméterek helye az adatbázisban 13-17
        /// </summary>
        public Videokartya(byte memoria, uint magorajel, RamTipus ramtipus, uint fogyasztas, bool rayt, int id, string gyarto, string tipus, int ar, int garancia) 
            : base(id, gyarto, tipus, ar, garancia)
        {
            MemoriaMerete = memoria;
            MagOrajel = magorajel;
            RamTipus = ramtipus;
            Fogyasztas = fogyasztas;
            RaytracingTamogatasVane = rayt;
        }
    }
}
