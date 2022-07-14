using System;

namespace Cadastros.Domain.Entities
{
    public class Product
    {
        public Product(DateTime createdAt, string name, decimal price, string brand, DateTime updateAt, int id)
        {
            CreatedAt = createdAt;
            Name = name;
            Price = price;
            Brand = brand;
            UpdateAt = updateAt;
            Id = id;
        }

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Brand { get; private set; }
        public DateTime UpdateAt { get; private set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetPrice(decimal price)
        {
            this.Price = price;
        }
    }
}
