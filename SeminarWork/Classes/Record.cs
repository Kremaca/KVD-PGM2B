namespace SeminarWork.Classes
{
    public class Record
    {
        public Record() 
        {
            Date = DateOnly.FromDateTime(DateTime.Now);
        }

        public Record(DateOnly date, double expense, double produce) 
        {
            Date = date;
            Expense = expense;
            Produce = produce;
        }

        public DateOnly Date { get; set; } // DateOnly.FromDateTime(DateTime.Now);
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

        public override string ToString()
        {
            return $"Date: {Date} - Expense: {Expense} - Produce: {Produce}";
        }
    }
}
