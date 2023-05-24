using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car.Model
{
    public class TeamFieldRenderer
    {
        public MvcHtmlString Title { get; set; }
        public MvcHtmlString Header { get; set; }
        public List<Repeating_Fields> RepeatingFields { get; set; }
    }

    public class Repeating_Fields
    {
        public MvcHtmlString Image { get; set; }
        public MvcHtmlString Name { get; set; }
        public MvcHtmlString Designation { get; set; }
    }
}