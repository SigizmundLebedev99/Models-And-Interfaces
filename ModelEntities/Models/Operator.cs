using System.ComponentModel.DataAnnotations;

namespace ModelEntities.Models
{
    public class Operator
    {
        public int Id { get; private set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Surname { get; set; }

        [MaxLength(50)]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength =3)]
        public string Password { get; set; }

        public Operator(string name, string surname, string login, string password)
        {
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
        }
    }
}
