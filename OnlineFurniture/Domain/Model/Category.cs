

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность категории товара
    /// </summary>
    public class Category 
    {
        
        /// <summary>
        /// ID Продукта
        /// </summary>
        public  long Id { get; set; }
        
        /// <summary>
        /// Наименование категории
        /// </summary>
        public string CategoryName { get; set; }
    }
}
