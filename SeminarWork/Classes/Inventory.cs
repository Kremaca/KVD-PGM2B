namespace SeminarWork.Classes
{
    public class Inventory
    {
        public List<Record> Catalogue { get; set; } = new List<Record>();
        public Record Record { get; set; } = new Record();
        public string RecordsPrint { get; set; } = "";

        public void AddToCatalogue() 
        {
            Catalogue.Add(new Record(Record.Date, Record.Expense, Record.Produce));
            // Record = new Record();
        }

        public void NumberOfRecords() 
        {
            RecordsPrint = $"Number of records: {Catalogue.Count}"; 
        }

        public void ShowAllRecords()
        {
            RecordsPrint = $"All records:<br> {string.Join("<br>", Catalogue)}";
        }
    }
}
