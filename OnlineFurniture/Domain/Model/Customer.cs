using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность-пользователь
    /// </summary>
    public class Customer 
    {
        /// <summary>
        /// ID 
        /// </summary>
        public  long Id { get; set; }
        
        /// <summary>
        /// Роль пользователя
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество пользователя
        /// </summary>
        public string Patronymic { set; get; }

        /// <summary>
        /// Адрес пользователя
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Телефонный номер
        /// </summary>
        public string Phone { get; set; }
        
        
        public ICollection<Order> Orders { get; set; }
    }
}
