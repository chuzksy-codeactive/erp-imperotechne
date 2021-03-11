using System.ComponentModel.DataAnnotations;

namespace JPSAGE_ERP.Application.Models.Account
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string StaffNumber { get; set; }
        public int CompanyId { get; set; }
        public int RoleId { get; set; }
    }
}
