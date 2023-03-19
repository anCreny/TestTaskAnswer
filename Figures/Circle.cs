namespace Figures;

public class Circle : IFigure
{
    private readonly float _radius;
    private float _square;

    private const float Pi = 3.1415926535f;
    
    public Circle(float radius)
    {
        _radius = radius;
        _square = GetSquare();
    }

    public float Square => _square;
    
    private float GetSquare()
    {
        var square = Pi * _radius * _radius;
        return square;
    }
}