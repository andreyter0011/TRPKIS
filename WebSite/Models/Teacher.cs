using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace WebSite.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле ФИО обязательно для заполнения.")]
        [RegularExpression(@"^[^0-9]*$", ErrorMessage = "Цифры не допускаются")]
        [DisplayName("ФИО")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле Дата рождения обязательно для заполнения.")]
        [DataType(DataType.Date)]
        [DisplayName("Дата рождения")]
        public DateTime dateOfBirth { get; set; }
        [Required(ErrorMessage = "Поле Номер телефона обязательно для заполнения.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Номер телефона должен состоять из 10 цифр.")]
        public string contactInfo { get; set; }
        [Required(ErrorMessage = "Поле Должность обязательно для заполнения.")]
        [RegularExpression(@"^[^0-9]*$", ErrorMessage = "Цифры не допускаются")]
        [DisplayName("Должность")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Поле Образование обязательно для заполнения.")]
        [RegularExpression(@"^[^0-9]*$", ErrorMessage = "Цифры не допускаются")]
        [DisplayName("Образование")]
        public string education { get; set; }
        [Required(ErrorMessage = "Поле Опыт работы обязательно для заполнения.")]
        [DisplayName("Опыт работы")]
        public string expirience { get; set; }
        [Required(ErrorMessage = "Поле Научные достижения обязательно для заполнения.")]
        [RegularExpression(@"^[^0-9]*$", ErrorMessage = "Цифры не допускаются")]
        [DisplayName("Научный достижения")]
        public string achivments { get; set; }
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
