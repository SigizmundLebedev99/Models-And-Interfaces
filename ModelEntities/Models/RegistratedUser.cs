using System.ComponentModel.DataAnnotations;

namespace ModelEntities.Models
{
    public class RegistredUser : User
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public RegistredUser(string phone, string name, string surname, string password) : base(phone)
        {
            Name = name;
            Surname = surname;
            Password = password;
        }
    }
}
