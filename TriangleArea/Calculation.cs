using System.Linq;

namespace TriangleArea
{
    public static class Calculation
    {
        public static double Area(double a, double b, double c)
        {
           var values = new[] {a, b, c};
           return values.Where(x => x != values.Max()).Aggregate(1.0, (x, y) => x * y) / 2;
        }
    }
}
