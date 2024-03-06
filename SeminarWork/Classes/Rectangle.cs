namespace SeminarWork.Classes
{
    public class Rectangle
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int Circumference { get; set; }
        public int Area { get; set; }
        public double Diagonal { get; set; }

        public void CalcAll()
        {
            CalcCircumference();
            CalcArea();
            CalcDiagonal();
        }

        private void CalcCircumference()
        {
            Circumference = 2 * (SideA + SideB);
        }

        private void CalcArea()
        {
            Area = SideA * SideB;
        }

        private void CalcDiagonal()
        {
            Diagonal = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        }
    }
}
