namespace GeometriaModels.Models;

public class CirculoModel:FiguraModel
{
    public double? Radio { get; set; }
    
    public CirculoModel() { }
    public CirculoModel(double radio, int id, double area):base(id,area)
    {
        this.Radio = radio;
    }
}
