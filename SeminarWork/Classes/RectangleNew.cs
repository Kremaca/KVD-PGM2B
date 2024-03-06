namespace SeminarWork.Classes

{
    public class RectangleNew
    {
        private int sideA;
        private int sideB;

        public int SideA { get => sideA; set { if (sideA != value) sideA = (value < 0) ? 0 : value; } }
        public int SideB { get => sideB; set => sideB = Math.Abs(value); }
        public int Circumference => 2 * (SideA + SideB);
        public int Area => sideA * sideB;
        public double Diagonal => Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));

    }
}
