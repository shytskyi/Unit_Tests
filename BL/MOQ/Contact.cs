namespace BL.MOQ
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Contact(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}