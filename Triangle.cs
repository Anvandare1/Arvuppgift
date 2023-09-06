using System.Formats.Asn1;

namespace aruppgift
{
    public class Triangle: Shape
    {
        public float area;
        public float omkrets;
        public Triangle(float input1, float input2) : base(input1, input2)
        {
            omkrets = Omkrets(input1, input2);
            area = Area(input1, input2);    
        }

        public float Omkrets(float height, float width)
        {
            var omkrets = height + width;
            return omkrets;
        }

        public float Area(float height, float width)
        {
            var area = (height * width) / 2;
            return area;
        }
    }
}