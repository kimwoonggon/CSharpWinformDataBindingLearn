using WinFormLearn.Data;
using WinFormLearn.Dtos;
using WinFormLearn.Entities;
using Microsoft.EntityFrameworkCore;

namespace WinFormLearn.Services
{
    public class ProductService
    {
        public void EnsureDatabase()
        {
            using var db = new AppDbContext();
            db.Database.EnsureCreated();
        }

        public List<ProductDto> GetAll()
        {
            using var db = new AppDbContext();
            return db.Products
                .AsNoTracking()
                .Select(p => new ProductDto { Id = p.Id, Name = p.Name, Price = p.Price })
                .ToList();
        }

        public ProductDto? GetById(int id)
        {
            using var db = new AppDbContext();
            var entity = db.Products.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (entity == null) return null;
            return new ProductDto { Id = entity.Id, Name = entity.Name, Price = entity.Price };
        }

        public void Add(ProductDto dto)
        {
            using var db = new AppDbContext();
            var entity = new ProductEntity { Name = dto.Name, Price = dto.Price };
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public bool Update(ProductDto dto)
        {
            using var db = new AppDbContext();
            var entity = db.Products.Find(dto.Id);
            if (entity == null) return false;
            entity.Name = dto.Name;
            entity.Price = dto.Price;
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            using var db = new AppDbContext();
            var entity = db.Products.Find(id);
            if (entity == null) return false;
            db.Products.Remove(entity);
            db.SaveChanges();
            return true;
        }
    }
}
