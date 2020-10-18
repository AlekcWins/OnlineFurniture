

using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность категории товара
    /// </summary>
    public class Category : Entity
    {
        /// <summary>
        /// Наименование категории
        /// </summary>
        public string CategoryName { get; set; }
    }
}
