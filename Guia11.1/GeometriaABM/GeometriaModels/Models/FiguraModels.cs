using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaABM.GeometriaModels.Models
{
    public abstract class FiguraModels
    {
        public int Id { get; set; }

        public double Area { get; set; }

        public FiguraModels(int id, double area)
        {
            Id = id;
            Area = area;
        }
    }
}
