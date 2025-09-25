using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaABM.GeometriaModels.Models
{
    public class RectanguloModels:FiguraModels
    {
        public double Ancho {  get; set; }
        public double Largo { get; set; }

        public RectanguloModels(double ancho, double largo,int id, double area) : base(id, area)
        {
            Ancho = ancho;
            Largo = largo;
        }
    }
}
