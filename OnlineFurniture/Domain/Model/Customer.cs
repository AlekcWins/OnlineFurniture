using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineFurniture.Models;

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
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        
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

        
        public Basket Basket { get; set; }

        public ICollection<Order> Orders { get; set; }
  

        


    }
}
