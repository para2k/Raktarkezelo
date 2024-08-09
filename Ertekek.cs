using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProOktatasVizsgaFeladat
{
    /// <summary>
    /// Konstans változók tárolására szolgáló egyedi osztály, ami publikus információt oszt meg a többi osztály számára.
    /// </summary>
    public static class Ertekek
    {
        public static readonly float afaSzorzo = 1.27f;
        public static readonly string[] processzorEngedelyezettGyartok = { "AMD", "Intel" };
        public static readonly string[] alaplapEngedelyezettGyartok = { "ASRock", "ASUS", "MSI", "Gigabyte" };
        public static readonly string[] memoriaEngedelyezettGyartok = { "APACER", "Crucial","Corsair","Hynix", "Kingstone", "Gskill" };
        public static readonly string[] videokartyaEngedelyezettGyartok = { "AMD", "Intel", "NVIDIA" };
        public static readonly string[] tapegysegEngedelyezettGyartok = { "Corsair", "Chieftech", "CoolerMaster", "DeepCool", "FSP", "EVGA", "ZALMAN" };
        public static readonly Color helyesSzin = Color.MidnightBlue;
        public static readonly Color helytelenSzin = Color.Firebrick;
    }
}
