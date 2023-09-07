using System.Formats.Asn1;

namespace aruppgift
{
    public class Triangle: Shape
    {
        public Triangle(float input1, float input2) : base(input1, input2)
        {
        }

        public float Omkrets(float height, float width)
        {
            var omkrets = Math.Sqrt((height * height) + (width * width)) + height + width;
            return (float)omkrets;
        }

        public float Area(float height, float width)
        {
            var area = (height * width) / 2;
            return area;
        }

    }
}