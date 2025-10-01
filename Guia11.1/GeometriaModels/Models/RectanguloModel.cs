namespace GeometriaModels.Models;

public class RectanguloModel:FiguraModel
{
    public double? Ancho {  get; set; }
    public double? Largo { get; set; }

    public RectanguloModel() { }
    public RectanguloModel(double? ancho, double? largo,int? id, double? area) : base(id, area)
    {
        this.Ancho = ancho;
        this.Largo = largo;
    }
}

