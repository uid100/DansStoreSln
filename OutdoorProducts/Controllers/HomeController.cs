﻿using Microsoft.AspNetCore.Mvc;
using OutdoorProducts.Models;
using System.Linq;
using OutdoorProducts.Models.ViewModels;

namespace OutdoorProducts.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController( IStoreRepository repo)
        {
            repository = repo;
        }

        // public IActionResult Index() => View(repository.Products);

        public ViewResult Index(string category, int productPage = 1)
        {
            var plvm = new ProductsListViewModel
            {
                Products = repository.Products
                                    .Where(p => category == null | p.Category == category)
                                    .OrderBy(p => p.ProductID)
                                    .Skip((productPage - 1) * PageSize)
                                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            };


            return View(plvm);
        }


    }
}
 