namespace CS_7._2
{
    public partial class Student
    {
        public int Age { get; set; }
        public partial class Address
        {
            public string Street { get; set; }
        }
    }


    public partial class Student
    {
        public string Name { get; set; }

        public partial class Address
        {
            public string ZipCode { get; set; }
        }
    }


    public partial class Student
    {
        public string Surname { get; set; }
    }
}
