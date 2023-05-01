using Core.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Web.ViewsModels;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork<Rater> rater;
        private readonly IUnitOfWork<Product> product;
        private readonly IHostingEnvironment hosting;
        private readonly IUnitOfWork<Rating> rating;
        private readonly IUnitOfWork<Categorie> category;

        public ProductController(IHostingEnvironment hosting, IUnitOfWork<Rating> rating, IUnitOfWork<Categorie> category, IUnitOfWork<Rater> rater, IUnitOfWork<Product> product)
        {
            this.rater = rater;
            this.product = product;
            this.hosting = hosting;
            this.rating = rating;
            this.category = category;
        }
        public IActionResult GetProduct(Guid Id)
        {
            ViewBag.ProductId = Id;
            ViewBag.ProductName = product.Entity.GetById(Id).ProductName;
            return View();
        }
        // [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductAddVM product)
        {
            string img = "default.png";
            Guid Gid = Guid.NewGuid();
            var Default = rating.Entity.GetAll().Where(x => x.Description == "empty").FirstOrDefault();
            if (ModelState.IsValid)
            {
                var findProduct = this.product.Entity.GetAll().Where(x => x.ProductName == product.ProductName);
                if (findProduct.Count() != 0)
                {
                    ModelState.AddModelError("", "Error this product is already exist");
                    ViewBag.ProductInfo = product;
                    return View();
                }
                if (product.File != null)
                {
                    img = Gid.ToString() + product.File.FileName.ToString().Substring(product.File.FileName.Length - 4);
                    string uploads = Path.Combine(hosting.WebRootPath, @"Images\Products");
                    string fullpath = Path.Combine(uploads, img);
                    product.File.CopyTo(new FileStream(fullpath, FileMode.Create));
                }
                Product Product = new Product()
                {
                    Id = Gid,
                    ProductName = product.ProductName,
                    ImageUrl = img,
                    Link = product.Link,
                    Description = product.Description,
                    CategorieId = product.CategorieId
                };
                Default.Id = Guid.NewGuid();
                Default.ProductId = Gid;
                this.product.Entity.Insert(Product);
                rating.Entity.Insert(Default);
                this.product.Save();
                rating.Save();
                return RedirectToAction("Mobiles","Categorie");
            }
            ModelState.AddModelError("","Error");
            ViewBag.ProductInfo = product;
            return View();
        }
        [HttpPost]
        public IActionResult AddComment(RatingVM rating)
        {
            if (ModelState.IsValid)
            {
                Rating Rating = new Rating()
                {
                    Id = Guid.NewGuid(),
                    Level = rating.Level,
                    Date = DateTime.Now,
                    Description = rating.Description,
                    ProductId = rating.ProductId,
                    RaterId = rating.RaterId
                };
                this.rating.Entity.Insert(Rating);
                this.rating.Save();
                return RedirectToAction("GetProduct", new { Id = rating.ProductId });
            }
            ModelState.AddModelError("", "Sorry there is some errors we can't add your comment");
            return View("GetProduct", new { Id = rating.ProductId });
        }
        [HttpPost]
        public IActionResult Search(string search)
        {
            return RedirectToAction("Products", "Categorie",new { name = search});
        }
        [HttpPost]
        public IList<ProductInfoVM> GetInfo(string name)
        {
            IList<ProductInfoVM> list = new List<ProductInfoVM>() ;
            try
            {
 foreach (var item in product.Entity.GetAll().Where(x => x.ProductName.Contains(name)))
            {
                list.Add(new ProductInfoVM()
                {
                    Id = item.Id,
                    ProductName=item.ProductName
                });
            }
            return list;
            }catch(Exception e)
            {
                return null;
            }
           
        }
        
    }
}
