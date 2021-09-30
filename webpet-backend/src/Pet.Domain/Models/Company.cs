namespace Pet.Domain.Models
{
    public class Company
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public virtual Document Document { get; set; }
        public string FantasyName { get; set; }
        public string CorporateName { get; set; }
        public int LicenseId { get; set; }
        public License License { get; set; }

        public Company()
        { }
    }
}