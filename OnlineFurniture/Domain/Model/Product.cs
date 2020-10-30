using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность, представляющая товар
    /// </summary>
    public class Product : Entity
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Стоимость товара
        /// </summary>
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
    }
}
