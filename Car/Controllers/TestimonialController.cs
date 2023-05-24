using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.IO;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace Car.Controllers
{
    public class TestimonialController : Controller
    {
        public ActionResult Index()
        {
            var dataItem = RenderingContext.Current.Rendering.Item;
            var slideItem = (MultilistField)dataItem.Fields["Slides"];
            var slides = slideItem.GetItems();
            return View("~/Views/Car/Components/Testimonial.cshtml",slides);
        }
    }
}