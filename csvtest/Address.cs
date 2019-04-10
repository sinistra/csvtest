namespace csvtest
{
    public class Address : CsvBase
    {
        public Address()
        {
        }

        public Address(string city, string country)
        {
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return " " + City + " / " + Country;
        }

        public string City { get; set; }

        public string Country { get; set; }

    }
}