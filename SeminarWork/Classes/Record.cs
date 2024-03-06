namespace SeminarWork.Classes
{
    public class Record
    {
        public DateOnly Date { get; set; }
        private double expense;

        public double Expense
        {
            get { return expense; }
            set { expense = Math.Abs(value); }
        }

        private double produce;

        public double Produce
        {
            get { return produce; }
            set { produce = Math.Abs(value); }
        }

        public double Gain => Produce - Expense;

    }
}
