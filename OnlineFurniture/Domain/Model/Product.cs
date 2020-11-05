using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность, представляющая товар
    /// </summary>
    public class Product 
    {
        
        /// <summary>
        /// ID Товара
        /// </summary>
        public  long Id { get; set; }
        
        /// <summary>
        /// ID Категории
        /// </summary>
        public  long CategoryId { get; set; }
        
        /// <summary>
        /// Наименование товара
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Стоимость товара
        /// </summary>
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Изготовитель товара
        /// </summary>
        public string Producer { get; set; }

        /// <summary>
        /// Ширина товара
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Длина товара
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Высота товара
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Материал товара
        /// </summary>
        public string Material { get; set; }

        
        
        /// <summary>
        /// Категория товара
        /// </summary>
        public Category Category { get; set; }
        
        /// <summary>
        /// Список заказов
        /// </summary>
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
