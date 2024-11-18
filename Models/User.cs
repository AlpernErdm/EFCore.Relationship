using System.ComponentModel.DataAnnotations;

namespace EFCore.Relationship.Models
{
    public sealed class User
    {
        public User()
        {
           Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; }= default!;
        public string FullName => string.Join("", FirstName, LastName);
    }

    public sealed class UserInformation
    {
       
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string IdentityNumber { get; set; } = default!;
        public string FullAdress { get; set; }=default!;
    }
}
