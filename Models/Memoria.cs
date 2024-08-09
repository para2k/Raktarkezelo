using System;
using System.Linq;

namespace ProOktatasVizsgaFeladat
{
    public enum Generacio { DDR4, DDR5 }
    public class Memoria : Alkatresz
    {
        byte merete; //(8-128GB)
        uint orajele; //(3000-8000 Mhz-ig)
        Generacio generacio;
        byte idozites; //(CL 8 - 60-ig)


        public override string Gyarto
        {
            get => gyarto;
            set
            {
                //MEGVIZSGÁLJUK, HOGY A MEGADOTT ÉRTÉK AZ ENGEDÉLYEZETT MEMÓRIA GYÁRTÓLISTÁBAN VAN-E
                if (Ertekek.memoriaEngedelyezettGyartok.Contains(value))
                {
                    gyarto = value;
                }
                else
                {
                    throw new ArgumentException("Ez a gyártó memória esetén nem engedélyezett!");
                }
            }
        }
        public byte Merete
        {
            get => merete;
            set
            {
                if (value >= 8 && value <= 128)
                {
                    merete = value;
                }
                else
                {
                    throw new ArgumentException("A méret 8 és 128 GB között engedélyezett!");
                }
            }
        }
        public uint Orajele
        {
            get => orajele;
            set
            {
                if (value >= 3000 && value <= 8000)
                {
                    orajele = value;
                }
                else
                {
                    throw new ArgumentException("Az órajel 3000 és 8000 Mhz között engedélyezett!");
                }
            }
        }
        public Generacio Generacio {
            get => generacio;
            set 
            {
                if(value == Generacio.DDR4)
                {
                    if(orajele >= 3000 && orajele <= 4400)
                    {
                        generacio = value;
                    }
                    else
                    {
                        throw new ArgumentException($"DDR4-es generáció {orajele} órajel szám esetén nem engedélyezett!");
                    }
                }
                else if (value == Generacio.DDR5)
                {
                    if(orajele >= 5200 && orajele <= 8000)
                    {
                        generacio = value;
                    }
                    else
                    {
                        throw new ArgumentException($"DDR5-ös generáció {orajele} órajel szám esetén nem engedélyezett!");
                    }
                }
                else
                {
                    throw new ArgumentException("Ez a generáció nem engedélyezett!");
                }
            }
        }
        public byte Idozites
        {
            get => idozites;
            set
            {
                if (value >= 8 && value <= 60)
                {
                    idozites = value;
                }
                else
                {
                    throw new ArgumentException("Az időzítés értéke 8 és 60 között engedélyezett!");
                }
            }
        }
        /// <summary>
        /// TOOLTIP: Specifikus paraméterek helye az adatbázisban 9-12
        /// AZ ÁR PARAMÉTER IGNORÁLVA LESZ, FUNKCIÓ SZÁMOLJA KI AZ ÁRAT!
        /// </summary>
        public Memoria(byte merete, uint orajele, Generacio gen, byte idozites, int id, string gyarto, string tipus, int garancia, int ar=0)
            : base(id, gyarto, tipus, garancia, ar)
        {
            Merete = merete;
            Orajele = orajele;
            Generacio = gen;
            Idozites = idozites;
            Ar = (int)ArSzamitas();
        }

        float ArSzamitas()
        {
            return orajele / 10 * merete * 2;
        }
    }
}
