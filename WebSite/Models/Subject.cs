using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace WebSite.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле Имя обязательно для заполнения.")]
        [RegularExpression(@"^[^0-9]*$", ErrorMessage = "Цифры не допускаются")]
        [DisplayName("Название предмета")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле Описание обязательно для заполнения.")]
        [RegularExpression(@"^[^0-9]*$", ErrorMessage = "Цифры не допускаются")]
        [DisplayName("Описание")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Поле Количество часов обязательно для заполнения.")]
        [Range(0, int.MaxValue, ErrorMessage = "Значение должно быть неотрицательным")]
        [DisplayName("Количество часов")]
        public int? hours { get; set; }
        [Required(ErrorMessage = "Поле Нагрузка обязательно для заполнения.")]
        [RegularExpression(@"^[^0-9]*$", ErrorMessage = "Цифры не допускаются")]
        [DisplayName("Тип нагрузки")]
        public string loadType { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public Subject()
        {
            Teachers = new List<Teacher>();
        }
        public static int? Sum(IEnumerable<Subject> subjects)
        {
            return subjects.Sum(s => s.hours);
        }
    }
}
