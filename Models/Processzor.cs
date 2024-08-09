using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProOktatasVizsgaFeladat
{
    public enum Tokozas{ LGA1200, LGA1700, AM4, AM5 }
    public class Processzor : Alkatresz
    {
        Tokozas tokozas;
        uint orajele; // (1000-6000 Mhz-ig)
        uint l3CacheMerete; // (2-256 MB-ig)
        byte magszam; // (1-32 db-ig)

        public Tokozas Tokozas { 
            get => tokozas;
            set
            {
                //AMD GYÁRTÓRA SZŰRÜNK
                if(gyarto == Ertekek.processzorEngedelyezettGyartok[0])
                {
                    if(value == Tokozas.AM4 || value == Tokozas.AM5)
                    {
                        tokozas = value;
                    }
                    else
                    {
                        throw new ArgumentException("Ez a fajta tokozás nem lehetséges AMD gyártó esetén!");
                    }
                }
                //INTEL GYÁRTÓRA SZŰRÜNK
                else if (gyarto == Ertekek.processzorEngedelyezettGyartok[1])
                {
                    if(value == Tokozas.LGA1200 || value == Tokozas.LGA1700)
                    {
                        tokozas = value;
                    }
                    else
                    {
                        throw new ArgumentException("Ez a fajta tokozás nem lehetséges Intel gyártó esetén!");
                    }
                }
                else
                {
                    throw new ArgumentException("Ismeretlen gyártó! Csak AMD vagy Intel engedélyezett!");
                }
            } 
        }
        public uint Orajele {
            get => orajele;
            set 
            { 
                if(value >= 1000 && value <= 6000)
                {
                    orajele = value;
                }
                else
                {
                    throw new ArgumentException("Nem megfelelő órajel értéke! Csak 1000 és 6000 között engedélyezett!");
                }
            } 
        }
        public uint L3CacheMerete { 
            get => l3CacheMerete;
            set 
            {
                if (value >= 2 && value <= 256)
                {
                    l3CacheMerete = value;
                }
                else
                {
                    throw new ArgumentException("Nem megfelelő az L3 Cache mérete! Csak 2 és 256 között engedélyezett!");
                }
            }
        }
        public byte Magszam { 
            get => magszam;
            set 
            {
                if(value >= 1 && value <= 32)
                {
                    magszam = value;
                }
                else
                {
                    throw new ArgumentException("Nem megfelelő a magszám értéke! Csak 1 és 32 között engedélyezett!");
                }
            }
        }

        /// <summary>
        /// TOOLTIP: Specifikus paraméterek helye az adatbázisban 18-21
        /// AZ ÁR PARAMÉTER IGNORÁLVA LESZ, FUNKCIÓ SZÁMOLJA KI AZ ÁRAT!
        /// </summary>
        public Processzor( Tokozas tokozas, uint orajelErteke, uint l3CacheMerete, byte magszam,int id, string gyarto, string tipus, int garancia,int ar) 
            : base (id,gyarto, tipus, garancia, ar )
        {
            Tokozas = tokozas;
            Orajele = orajelErteke;
            L3CacheMerete = l3CacheMerete;
            Magszam = magszam;
            Ar = (int)ArSzamitas();
        }

        float ArSzamitas()
        {
            return ((orajele / 100) * l3CacheMerete * magszam);
        }
    }
}
