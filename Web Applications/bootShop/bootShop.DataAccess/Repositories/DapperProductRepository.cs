using bootShop.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.DataAccess.Repositories
{
    public class DapperProductRepository : IProductRepository
    {

        private readonly IDbConnection configuration;
        public DapperProductRepository(IConfiguration configuration)
        {
            this.configuration = new SqlConnection(configuration.GetConnectionString("db"));
        }


        public async Task<int> Add(Product entity)
        {
            var sql = "INSERT INTO Products (Name,Price,Discount,Descriptipn,CategoryId,ImageUrl) VALUES (@Name,@Price,@Discount,@Descriptipn,@CategoryId,@ImageUrl);" +
    "SELECT CAST (SCOPE_IDENTITY() as int);";

            
            int id = await configuration.QuerySingleAsync<int>(sql, new { entity.Name, entity.Price, entity.Discount, entity.Descriptipn, entity.CategoryId, entity.ImageUrl });
            return id;
        }

        public async Task Delete(int id)
        {
            var sql = "DELETE FROM Products WHERE Id=@Id";
            await configuration.ExecuteAsync(sql, new { Id = id });
        }

        public async Task<IList<Product>> GetAllEntities()
        {
            var sql = "SELECT * FROM Products";
            var products = await configuration.QueryAsync<Product>(sql);

            return products.ToList();
        }

        public async Task<Product> GetEntityById(int id)
        {
            var sql = "SELECT * FROM Products WHERE Id =@Id";
            var products = await configuration.QuerySingleAsync<Product>(sql, new { Id = id });
            return products;
        }

        public async Task<IList<Product>> SearchProductsByName(string name)
        {
            var sql = "SELECT * FROM Products WHERE Name =@Name";
            var products = await configuration.QuerySingleAsync<Product>(sql, new { Name = name });

            return (IList<Product>)products;
        }

        public async Task<int> Update(Product entity)
        {
            var sql = "UPDATE Products set Name=@Name,Price=@Price,Discount=@Discount,Description=@Description,CategoryId=@CategoryId,ImageUrl=@ImageUrl where Id=@Id";
            await configuration.QueryAsync(sql, new { Id = entity.Id, Name = entity.Name, Price = entity.Price, Discount = entity.Discount, Description = entity.Descriptipn, CategoryId = entity.CategoryId, ImageUrl = entity.ImageUrl });
            return entity.Id;
        }
    }
}
