namespace ConsoleApp2.Entities
{
    public class Vehincle
    {
        public string Model { get; set; }

        public Vehincle() { }
        public Vehincle(string model)
        {
            Model = model;
        }
    }
}