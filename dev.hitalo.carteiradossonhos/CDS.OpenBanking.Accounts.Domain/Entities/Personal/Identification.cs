namespace CDS.OpenBanking.Accounts.Domain.Entities.Personal
{
    public class Identification
    {
        public string UpdateDateTime { get; set; }
        public string PersonalId { get; set; }
        public string BrandName { get; set; }
        public string CivilName { get; set; }
        public string SocialName { get; set; }
        public string BirthDate { get; set; }
        public string MaritalStatusCode { get; set; }
        public string MaritalStatusAdditionalInfo { get; set; }
        public string Sex { get; set; }
        public string[] CompanyCnpj { get; set; }
        public Documents Documents { get; set; }
        public OtherDocuments[] OtherDocuments { get; set; }
        public string HasBrazilianNationality { get; set; }
        public Nationality[] Nationality { get; set; }
        public Filiation[] Filiation { get; set; }
        public Contacts Contacts { get; set; }
    }

    public class Documents
    {
        public string CpfNumber { get; set; }
        public string PassportNumber { get; set; }
        public string PassportCountry { get; set; }
        public string PassportExpirationDate { get; set; }
        public string PassportIssueDate { get; set; }
    }

    public class OtherDocuments
    {
        public string Type { get; set; }
        public string TypeAdditionalInfo { get; set; }
        public string Number { get; set; }
        public string CheckDigit { get; set; }
        public string AdditionalInfo { get; set; }
        public string ExpirationDate { get; set; }
    }

    public class Nationality
    {
        public string OtherNationalitiesInfo { get; set; }
        public DocumentsNationality[] Documents { get; set; }
    }

    public class DocumentsNationality
    {
        public string Type { get; set; }
        public string Number { get; set; }
        public string ExpirationDate { get; set; }
        public string IssueDate { get; set; }
        public string Country { get; set; }
        public string TypeAdditionalInfo { get; set; }
    }

    public class Filiation
    {
        public string Type { get; set; }
        public string CivilName { get; set; }
        public string SocialName { get; set; }
    }

    public class Contacts
    {
        public PostalAddresses[] PostalAddresses { get; set; }
        public Phones[] Phones { get; set; }
        public Emails[] Emails { get; set; }
    }

    public class PostalAddresses
    {
        public string IsMain { get; set; }
        public string Address { get; set; }
        public string AdditionalInfo { get; set; }
        public string DistrictName { get; set; }
        public string TownName { get; set; }
        public string IbgeTownCode { get; set; }
        public string CountrySubDivision { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public GeographicCoordinates GeographicCoordinates { get; set; }
    }

    public class GeographicCoordinates
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class Phones
    {
        public string IsMain { get; set; }
        public string Type { get; set; }
        public string AdditionalInfo { get; set; }
        public string CountryCallingCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
        public string PhoneExtension { get; set; }
    }

    public class Emails
    {
        public string IsMain { get; set; }
        public string Email { get; set; }
    }
}