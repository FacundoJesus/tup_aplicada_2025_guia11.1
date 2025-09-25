using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaABM.GeometriaModels.Models
{
    public class CirculoModels:FiguraModels
    {
        public double Radio { get; set; }

        public CirculoModels(double radio, int id, double area):base(id,area)
        {
            Radio = radio;
        }
    }
}
