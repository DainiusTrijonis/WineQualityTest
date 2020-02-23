using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vynas
{
    class Wine
    {
        public int id { get; set; }
        public double fixedAcidity { get; set; }
        public double volatileAcidity { get; set; }
        public double citricAcidity { get; set; }
        public double residualSugar { get; set; }
        public double chlorides { get; set; }
        public double freeSulfurDioxide { get; set; }
        public double totalSulfurDioxide { get; set; }
        public double density { get; set; }
        public double pH { get; set; }
        public double sulphates { get; set; }
        public double alcohol { get; set; }
        public int quality { get; set; }

        public Wine(int id, double fixedAcidity, double volatileAcidity, double citricAcidity, double residualSugar, double chlorides,
                    double freeSulfurDioxide, double totalSulfurDioxide, double density, double pH, double sulphates, double alcohol, int quality
                    )
        {
            this.id = id;
            this.fixedAcidity = fixedAcidity;
            this.volatileAcidity = volatileAcidity;
            this.citricAcidity = citricAcidity;
            this.residualSugar = residualSugar;
            this.chlorides = chlorides;
            this.freeSulfurDioxide = freeSulfurDioxide;
            this.totalSulfurDioxide = totalSulfurDioxide;
            this.density = density;
            this.pH = pH;
            this.sulphates = sulphates;
            this.alcohol = alcohol;
            this.quality = quality;
        }
        public double calculateDistance( Wine wine )
        {
            double distance= Math.Sqrt(Math.Pow(fixedAcidity - wine.fixedAcidity,2) + Math.Pow(volatileAcidity - wine.volatileAcidity, 2) +
                                       Math.Pow(citricAcidity - wine.citricAcidity, 2) + Math.Pow(residualSugar - wine.residualSugar, 2) +
                                       Math.Pow(chlorides - wine.chlorides, 2) + Math.Pow(freeSulfurDioxide - wine.freeSulfurDioxide, 2) + 
                                       Math.Pow(totalSulfurDioxide - wine.totalSulfurDioxide, 2) + Math.Pow(density - wine.density, 2) +
                                       Math.Pow(pH - wine.pH, 2) + Math.Pow(sulphates - wine.sulphates, 2) +
                                       Math.Pow(alcohol - wine.alcohol, 2)
                                      );



            return distance;
        }
        public double calculateDistance2(Wine wine)
        {
            double distance = Math.Abs(fixedAcidity - wine.fixedAcidity) + Math.Abs(volatileAcidity - wine.volatileAcidity) +
                              Math.Abs(citricAcidity - wine.citricAcidity) + Math.Abs(residualSugar - wine.residualSugar) +
                              Math.Abs(chlorides - wine.chlorides) + Math.Abs(freeSulfurDioxide - wine.freeSulfurDioxide) +
                              Math.Abs(totalSulfurDioxide - wine.totalSulfurDioxide) + Math.Abs(density - wine.density) +
                              Math.Abs(pH - wine.pH) + Math.Abs(sulphates - wine.sulphates) +
                              Math.Abs(alcohol - wine.alcohol);

            return distance;
        }
    }
}
