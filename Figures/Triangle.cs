namespace Figures;

public class Triangle : IFigure
{
    private readonly List<float> _sides;

    private bool _isRight;
    private float _square;

    public Triangle(float a, float b, float c)
    {
        var sides = new List<float>
        {
            float.Abs(a),
            float.Abs(b),
            float.Abs(c)
        };
        
        sides.Sort();

        if (sides[2] > sides[1] + sides[0])
        {
            var impossibleTriangleEx = new Exception("Triangle is impossible");
            throw impossibleTriangleEx;
        }

        _sides = new List<float>
        {
            float.Abs(a),
            float.Abs(b),
            float.Abs(c)
        };

        _square = GetSquare();
    }

    public bool IsRight => _isRight;
    public float Square => _square;
    
    private float GetSquare()
    {
        var tempSides = new List<float>(_sides);
        _sides.Sort();
        
        var result = tempSides[2] * tempSides[2] - (tempSides[1] * tempSides[1] + tempSides[0] * tempSides[0]);
        _isRight = result == 0;

        var semiPer = tempSides.Sum(side => side / 2);

        var square =
            (float) Math.Sqrt(semiPer * (semiPer - tempSides[0]) * (semiPer - tempSides[1]) * (semiPer - tempSides[2]));

        return square;
    }
}