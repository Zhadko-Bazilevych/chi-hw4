using System.ComponentModel.DataAnnotations;

namespace HW4.Models
{
    public class User
    {
        [Required(ErrorMessage = "Ім'я обов'язкове")]
        [MinLength(4, ErrorMessage = "Ім'я повинно бути довшим 3 символів")]
        [StringLength(40)] // ErrorMessage не потрібне, форма не дасть ввести більше 40 символів
        [RegularExpression(@"^[a-zA-ZА-Яа-яёЁЇїІіЄєҐґ']+(?: [a-zA-ZА-Яа-яёЁЇїІіЄєҐґ'\\-]+){0,1}$", ErrorMessage = "Ім'я введено невірно")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пошта обов'язкова")]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Пошта введена невірно")]
        public string Email { get; set; }
    }
}

