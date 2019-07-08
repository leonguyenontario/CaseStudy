﻿using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;
namespace CaseStudy.Controllers
{
    public class BrandController : Controller
    {
        AppDbContext _db;
        public BrandController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            BrandModel model = new BrandModel(_db);
            BrandViewModel viewModel = new BrandViewModel();
            viewModel.Brands = model.GetAll();
            return View(viewModel);
        }
    }
}