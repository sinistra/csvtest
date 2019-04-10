namespace csvtest
{
    public class Person : CsvBase
    {
        public Person()
        {

        }
        public Person(int id, string name, string lastname, Address address)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Address = address;
        }

        public override string ToString()
        {
            return Name + " " + Lastname + " " + Address;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Address Address { get; set; }
    }
}