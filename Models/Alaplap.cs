using System;
using System.Linq;

namespace ProOktatasVizsgaFeladat
{
    public enum ProcesszorFoglalat { LGA1200, LGA1700, AM4, AM5 }
    public enum Chipset { H510, H610, B660, Z690, B760, Z790, B450, X470, B550, X570, B650, X670 }
    public class Alaplap : Alkatresz
    {
        ProcesszorFoglalat foglalat;
        Chipset chipset;
        bool rgbVilagitasVane;


        public override string Gyarto
        {
            get => gyarto;
            set
            {
                //MEGVIZSGÁLJUK, HOGY A MEGADOTT ÉRTÉK AZ ENGEDÉLYEZETT ALAPLAP GYÁRTÓLISTÁBAN VAN-E
                if (Ertekek.alaplapEngedelyezettGyartok.Contains(value))
                {
                    gyarto = value;
                }
                else
                {
                    throw new ArgumentException("Ez a gyártó alaplap esetén nem engedélyezett!");
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
        public ProcesszorFoglalat Foglalat { 
            get => foglalat;
            set 
            {
                if (value == ProcesszorFoglalat.LGA1200 || value == ProcesszorFoglalat.LGA1700 || value == ProcesszorFoglalat.AM4 || value == ProcesszorFoglalat.AM5)
                {
                    foglalat = value;
                }
                else
                {
                    throw new ArgumentException("Ez a processzorfoglalat nem engedélyezett!");
                }
            }
        }
        public Chipset Chipset
        {
            get => chipset;
            set
            {
                switch (foglalat)
                {
                    case ProcesszorFoglalat.LGA1200:
                        if (value == Chipset.H510 || value == Chipset.H610)
                        {
                            chipset = value;
                        }
                        else
                        {
                            throw new ArgumentException("Ez a chipset nem kompatibilis az LGA1200 foglalattal!");
                        }
                        break;
                    case ProcesszorFoglalat.LGA1700:
                        if (value == Chipset.B660 || value == Chipset.Z690 || value == Chipset.B760 || value == Chipset.Z790)
                        {
                            chipset = value;
                        }
                        else
                        {
                            throw new ArgumentException("Ez a chipset nem kompatibilis az LGA1700 foglalattal!");
                        }
                        break;
                    case ProcesszorFoglalat.AM4:
                        if (value == Chipset.B450 || value == Chipset.X470 || value == Chipset.B550 || value == Chipset.X570)
                        {
                            chipset = value;
                        }
                        else
                        {
                            throw new ArgumentException("Ez a chipset nem kompatibilis az AM4 foglalattal!");
                        }
                        break;
                    case ProcesszorFoglalat.AM5:
                        if (value == Chipset.B650 || value == Chipset.X670)
                        {
                            chipset = value;
                        }
                        else
                        {
                            throw new ArgumentException("Ez a chipset nem kompatibilis az AM5 foglalattal!");
                        }
                        break;
                }
            }
        }
        public bool RgbVilagitasVane { get => rgbVilagitasVane; set => rgbVilagitasVane = value; }

        /// <summary>
        /// TOOLTIP: Specifikus paraméterek helye az adatbázisban 6-8
        /// </summary>
        public Alaplap(ProcesszorFoglalat foglalat, Chipset chipset, bool rgbe, int id, string gyarto, string tipus, int ar, int garancia)
            : base(id, gyarto, tipus, ar, garancia)
        {
            Foglalat = foglalat;
            Chipset = chipset;
            RgbVilagitasVane = rgbe;
        }
    }
}
