using Car.Model;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.IO;
using Sitecore.Mvc.Presentation;
using Sitecore.Shell.Feeds.FeedTypes;
using Sitecore.Syndication;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using static Car.Model.TeamFieldRenderer;

namespace Car.Controllers
{
    public class TeamController : Controller
    {
        public ActionResult Index()
        {
            var dataItem = RenderingContext.Current.Rendering.Item;
            var teamItem = (MultilistField)dataItem.Fields["Teams"];
            var teams = teamItem.GetItems();
            return View("~/Views/Car/Components/Team.cshtml",teams);
        }
        public ActionResult Team()
        {
            var dataSourceItem = RenderingContext.Current.Rendering.Item;
            MultilistField teamItem = dataSourceItem.Fields["Teams"];   
            var teams = teamItem.GetItems();
            List<Repeating_Fields> repeatingFields = new List<Repeating_Fields>();

            foreach(var item in teams)
            {
                repeatingFields.Add(
                    new Repeating_Fields { Image = new MvcHtmlString(FieldRenderer.Render(item, "Image","class=img-fluid")) , 
                                            Name = new MvcHtmlString(FieldRenderer.Render(item, "Name")),
                                            Designation = new MvcHtmlString(FieldRenderer.Render(item, "Designation"))}
                   
                );
            }

            TeamFieldRenderer teamFieldRenderer = new TeamFieldRenderer();

            teamFieldRenderer.RepeatingFields = repeatingFields;

            teamFieldRenderer.Title = new MvcHtmlString(FieldRenderer.Render(dataSourceItem, "Title"));
            teamFieldRenderer.Header = new MvcHtmlString(FieldRenderer.Render(dataSourceItem, "Header"));

            return View("~/Views/Car/Components/TeamFieldRenderer.cshtml",teamFieldRenderer);
        }
    }
}