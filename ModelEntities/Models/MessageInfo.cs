using System;
using System.ComponentModel.DataAnnotations;

namespace ModelEntities.Models
{
    public class MessageInfo
    {
        public int Id { get; private set; }

        [Required]
        public User User { get; set; }

        [Required]
        public Operator Operator { get; set; }

        [Required]
        public string Message { get; set; }

        [Display(Name = "Variant One")]
        public string VarOne { get; set; }

        [Display(Name = "Variant Two")]
        public string VarTwo { get; set; }

        [Display(Name = "Variant Three")]
        public string VarThree { get; set; }

        [Display(Name = "Operator's Variant")]
        public string OperatorsVar { get; set; }

        [Range(0, 1)]
        public float Agility { get; set; }

        public int Parent { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy hh: mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}
