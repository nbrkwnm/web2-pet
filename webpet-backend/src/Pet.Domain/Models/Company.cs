namespace Pet.Domain.Models
{
    public class Company
    {
        public Document Document { get; set; }
        public string FantasyName { get; set; }
        public string CorporateName { get; set; }
        public License License { get; set; }

        public Company()
        { }
    }
}