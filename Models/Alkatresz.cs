using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProOktatasVizsgaFeladat
{
    public abstract class Alkatresz
    {
        protected int id;
        protected string gyarto;
        protected string tipus;
        protected int ar;
        protected int garancia; //=> hónapban kifejezve

        public int Id { 
            get => id; 
            set 
            {
                if(value >= 0)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("Az ID nem lehet negatív!");
                }
            } 
        }
        public virtual string Gyarto { 
            get => gyarto;
            set 
            { 
                if(value.Length >= 3)
                {
                    gyarto = value;
                }
                else
                {
                    throw new ArgumentException("A gyártó neve 3 karaktertől engedélyezett!");
                }
            }
        }
        public string Tipus { 
            get => tipus;
            set 
            { 
                if (value.Length >= 3)
                {
                    tipus = value;
                }
                else
                {
                    throw new ArgumentException("A típus hossza 3 karaktertől engedélyezett!");
                }
            }
        }
        public virtual int Ar { get => ar; set => ar = value; }
        
        public int Garancia { 
            get => garancia;
            set 
            {
                if(value >= 0 && value <= 120)
                {
                    garancia = value;
                }
                else
                {
                    throw new ArgumentException("A garancia csak 0 és 240 hónap (20 év) között engedélyezett!");
                }
            }
        }
        protected Alkatresz(int id, string gyarto, string tipus, int ar, int garancia)
        {
            Id = id;
            Gyarto = gyarto;
            Tipus = tipus;
            Ar = ar;
            Garancia = garancia;
        }

        public float BruttoArSzamitas()
        {
            return Ar * Ertekek.afaSzorzo;
        }

        public override string ToString()
        {
            return $"[{Gyarto}] - {Tipus} - Nettó ára: {Ar} ft";
        }
    }
}
