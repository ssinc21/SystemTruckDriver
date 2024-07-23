namespace SystemTruckDriver.Models
{
    public class TruckModel
    {

        public int Id { get; set; }
        public string TruckName { get; set; }
        public string CodeTruck { get; set; }

        public string Status { get; set; } 

        public TruckModel(
            string truckname,
            string codetruck,
            string status)
        {
            TruckName = truckname;
            CodeTruck = codetruck;
            Status = status;
        }
    }
}
