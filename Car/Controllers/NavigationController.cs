using Car.Model;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.IO;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace Car.Controllers
{
    public class NavigationController : Controller
    {
        public ActionResult Index()
        {
            List<Navigation> navigations = new List<Navigation>();
            NavigationModel model = new NavigationModel();

            var homeItem = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);

            navigations.Add(new Navigation
            {
                NavigationTitle = homeItem.Fields["Navigation Title"]?.Value,
                NavigationUrl = LinkManager.GetItemUrl(homeItem),
                IsActiveLink = homeItem.ID == Sitecore.Mvc.Presentation.PageContext.Current.Item.ID
            });

            foreach (Item childItem in homeItem.Children)
            {
                navigations.Add(new Navigation
                {
                    NavigationTitle = childItem.Fields["Navigation Title"]?.Value ?? childItem.Name,
                    NavigationUrl = LinkManager.GetItemUrl(childItem),
                    IsActiveLink = childItem.ID == Sitecore.Mvc.Presentation.PageContext.Current.Item.ID,
                    Children = GetNavigations(childItem.Children.ToList())
                });
            }
            model.Navigations = navigations;
            return View("~/Views/Car/Components/Navigation.cshtml", model);
        }
        private List<Navigation> GetNavigations(List<Item> navigationChildren)
        {
            List<Navigation> navigations = new List<Navigation>();
            NavigationModel model = new NavigationModel();

            foreach (Item childItem in navigationChildren)
            {
                navigations.Add(new Navigation
                {
                    NavigationTitle = childItem.Fields["Navigation Title"]?.Value ?? childItem.Name,
                    NavigationUrl = LinkManager.GetItemUrl(childItem),
                    IsActiveLink = childItem.ID == PageContext.Current.Item.ID
                });
            }
            return navigations;


        }
    }
}
