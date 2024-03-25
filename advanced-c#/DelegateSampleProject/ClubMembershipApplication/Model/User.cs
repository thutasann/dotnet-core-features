using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace ClubMembershipApplication.Model
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string AddressCity { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
    }
}