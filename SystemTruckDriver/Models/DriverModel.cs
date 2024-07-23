namespace SystemTruckDriver.Models
{
    public class DriverModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CodeCNH { get; set; }

        public DriverModel(
            string name,
            string codecnh)
        {
            Name = name;
            CodeCNH = codecnh;
        }
    }
}
