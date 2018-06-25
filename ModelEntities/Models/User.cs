using System.ComponentModel.DataAnnotations;

namespace ModelEntities.Models
{
    public class User
    {
        public int Id { get; private set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public User(string phone)
        {
            Phone = phone;
        }
    }  
}
