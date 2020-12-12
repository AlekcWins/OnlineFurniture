

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность-склад товаров
    /// </summary>
    public class Stock 
    {
        
        /// <summary>
        /// ID 
        /// </summary>
        public  long Id { get; set; }
        
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
