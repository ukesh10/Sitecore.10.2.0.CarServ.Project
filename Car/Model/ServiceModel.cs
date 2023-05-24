using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car.Model
{
    public class ServiceModel
    {
        public List<ServiceNavigation> ServiceNavigations { get; set; }
    }
    public class ServiceNavigation
    {
        public string NavigationTitle { get; set; }
        //public string NavigationUrl { get; set; }
        public bool IsActiveLink { get; set; }
        //public List<Navigation> Children { get; set; }
    }
}