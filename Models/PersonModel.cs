namespace Problem1808.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; }
        public string PersonName  { get; set; }
        public string PersonCode { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public bool isManager { get; set; }
        public bool isActive { get; set; }
    }
}
