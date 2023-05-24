using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car.Model
{
    public class NavigationModel
    {
        public List<Navigation> Navigations { get; set; }
    }
    public class Navigation
    {
        public string NavigationTitle { get; set; }
        public string NavigationUrl { get; set; }
        public bool IsActiveLink { get; set; }
        public List<Navigation> Children { get; set; }
    }
}