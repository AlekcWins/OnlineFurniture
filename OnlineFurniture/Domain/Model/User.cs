﻿using OnlineFurniture.Domain.Model.Common;
using Shop.Domain.Models;
using System.Collections.Generic;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность-пользователь
    /// </summary>
    public class User : Entity
    {

        public long UserId { get; set; }
        public Customer Customer { get; set; }
        /// <summary>
        /// Роль пользователя
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
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

     
    }
}
