using Microsoft.JSInterop;
using System.Globalization;
namespace SeminarWork.Classes
{
    public class Inventory
    {
        public Inventory(IJSRuntime js) 
        {
            this.js = js;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("cs-CZ"); //en-US
        }

        public IJSRuntime js;
        public List<Record> Catalogue { get; set; } = new List<Record>();
        public Record Record { get; set; } = new Record();
        public string RecordsPrint { get; set; } = "";
        public bool UpdateMode { get; set; } = false;

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

        public void ShowStatistics() 
        {
            RecordsPrint = "";
            RecordsPrint += $"Minimum: {Minimum()} <br>";
            RecordsPrint += $"Maximum: {Maximum()} <br>";
            RecordsPrint += $"Average: {Average()} <br>";
        }

        private double Minimum() 
        {
            return (Catalogue.Count == 0) ? double.NaN : Catalogue.Min(x => x.Gain);
        }

        private double Maximum()
        {
            return (Catalogue.Count == 0) ? double.NaN : Catalogue.Max(x => x.Gain);
        }

        private double Average()
        {
            return (Catalogue.Count == 0) ? double.NaN : Catalogue.Average(x => x.Gain);
        }

        public async Task RecordDelete(Record record)
        {
            var notice = $"Do you want to delete this record? \nDate: {record.Date} - Gain: {record.Gain}";
            if (await js.InvokeAsync<bool>("confirm", notice)) Catalogue.Remove(record);
            //js.InvokeVoidAsync("alert", notice);
        }

        public void RecordUpdate(Record record)
        {
            if (Record != record)
            {
                UpdateMode = true;
                Record = record;
            }
            else 
            {
                UpdateMode = false;
                Record = new Record();
            }
        }
    }
}
