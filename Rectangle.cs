namespace aruppgift
{
    public class Rectangle: Shape
    {
        public float area;
        public float omkrets;
        public Rectangle(float input1, float input2) : base(input1, input2)
        {
            omkrets = Omkrets(input1, input2);
            area = Area(input1, input2);    
        }

        public float Omkrets(float height, float width)
        {
            var omkrets = height * 2 + width * 2;
            return omkrets;
        }

        public float Area(float height, float width)
        {
            var area = (height * width);
            return area;
        }
    }
}