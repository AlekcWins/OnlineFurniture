﻿

using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность-склад товаров
    /// </summary>
    public class Stock : Entity
    {
        /// <summary>
        /// Продукт, хранимый на складе
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Количество хранимого товара
        /// </summary>
        public int Quantity { get; set; }
    }
}