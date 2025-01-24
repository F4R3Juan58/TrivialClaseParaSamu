using System;
using System.Collections.Generic;

namespace TrivialGeografia
{
    internal class InfoContinenteAprobado
    {
        public static double Europa { get; set; }
        public static double Asia { get; set; }
        public static double NorthAmerica { get; set; }
        public static double SouthAmerica { get; set; }
        public static double Oceania { get; set; }
        public static double Africa { get; set; }
        public static int aprobados { get; set; }

        public static List<string> AciertosLista { get; } = new List<string>();
        public static List<string> FallosLista { get; } = new List<string>();

        public InfoContinenteAprobado()
        {
            Europa = 0;
            Asia = 0;
            NorthAmerica = 0;
            SouthAmerica = 0;
            Oceania = 0;
            Africa = 0;
        }
    }
}
