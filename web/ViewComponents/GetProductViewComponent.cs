using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewsModels;

namespace Web.ViewComponents
{
    public class GetProductViewComponent : ViewComponent
    {
        public GetProductViewComponent(IUnitOfWork<Categorie> categorie, IUnitOfWork<Product> product, IUnitOfWork<Rating> rating)
        {
            Categorie = categorie;
            Product = product;
            Rating = rating;
        }

        public IUnitOfWork<Categorie> Categorie { get; }
        public IUnitOfWork<Product> Product { get; }
        public IUnitOfWork<Rating> Rating { get; }

        public IViewComponentResult Invoke(string name)
        {
            if (name == "Recent")
            {
                return View(this.GetRecentProducts());
            }
           else if (name == "Hot")
            {
                return View(this.GetHotProducts());
            }
                return View(this.GetCategoryProducts(name));

        }
        private IList<ProductLevelVM> GetCategoryProducts(string name)
        {
            Categorie cat;
            IEnumerable<Categorie> list = null;
            IEnumerable<Product> AllProducts;
            if (name == "")
            {
                AllProducts = Product.Entity.GetAll();
            }
            else
            {
                list = Categorie.Entity.GetAll().Where(b => b.Name == name);
                if (list.Count() != 0)
                {
                    cat = list.First();
                    AllProducts = Product.Entity.GetAll().Where(a => a.CategorieId == cat.Id);
                }
                else
                {
                    AllProducts = Product.Entity.GetAll().Where(a => a.ProductName.Contains(name));
                }

            }

            var AllProductsWithMax = Rating.Entity.GetAll().GroupBy(i => i.ProductId).Select(g => new
            {
                Id = g.Key,
                level = g.Max(row => row.Level)
            }).Join(AllProducts, e => e.Id, p => p.Id, (p, e)
                => new
                {
                    Product = e,
                    Max = p.level
                });
            List<ProductLevelVM> Products = new List<ProductLevelVM>();
            foreach (var item in AllProductsWithMax.ToList())
            {
                Products.Add(
                    new ProductLevelVM() { Product = item.Product, Max = item.Max }
                    );
            }
            return Products;
        }
        private IList<ProductLevelVM> GetRecentProducts()
        {
            IEnumerable<Product> AllProducts;
            AllProducts = Product.Entity.GetAll();
            IEnumerable<Rating> AllRatings = Rating.Entity.GetAll();
            var AllProductsWithMax = Rating.Entity.GetAll().GroupBy(i => i.ProductId).Select(g => new
            {
                Id = g.Key,
                level = g.Max(row => row.Level)
            }).Join(AllProducts, e => e.Id, p => p.Id, (p, e)
                => new
                {
                    Id = p.Id,
                    Product = e,
                    Max = p.level
                }).Join(AllRatings, e => e.Id, p => p.ProductId, (p, e)
                => new
                {
                    Product = p.Product,
                    Max = p.Max,
                    Date = e.Date
                });
            List<ProductLevelVM> Products = new List<ProductLevelVM>();
            foreach (var item in AllProductsWithMax.ToList())
            {
                Products.Add(
                    new ProductLevelVM() { Product = item.Product, Max = item.Max, Date = item.Date }
                    );
            }
            var _Products = Products.Where(x => x.Date >= new DateTime(2021, 09, 04,00,00,00));
            return _Products.ToList();
        }
        private IList<ProductLevelVM> GetHotProducts()
        {
            var AllProducts = Product.Entity.GetAll();
            var HotProducts = Rating.Entity.GetAll().GroupBy(i => i.ProductId).Select(g => new
            {
                Id = g.Key,
                number = g.Count()
            }).Join(AllProducts, e => e.Id, p => p.Id, (p, e)
                => new
                {
                    Product = e,
                    number = p.number
                }).OrderByDescending(x => x.number).Take(2);
            var selectedProducts = Rating.Entity.GetAll().GroupBy(i => i.ProductId).Select(g => new
            {
                Id = g.Key,
                level = g.Max(row => row.Level)
            }).Join(HotProducts, e => e.Id, p => p.Product.Id, (e,p)
                => new
                {
                    Product = p.Product,
                    Max = e.level
                });
            List<ProductLevelVM> Products = new List<ProductLevelVM>();
            foreach (var item in selectedProducts.ToList())
            {
                Products.Add(
                    new ProductLevelVM() { Product = item.Product, Max = item.Max }
                    );
            }
            return Products;
        }
    }
}
