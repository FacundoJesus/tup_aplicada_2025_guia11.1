namespace GeometriaModels.Models;

public abstract class FiguraModel
{
    public int? Id { get; set; }

    public double? Area { get; set; }

    public FiguraModel() { }
    public FiguraModel(int? id, double? area)
    {
        this.Id = id;
        this.Area = area;
    }
}
