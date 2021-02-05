using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcClinic.MVC.Models
{
    public class ClientBirthDateViewModel
    {
        public List<Client> Clients { get; set; }
        public SelectList DateBirth { get; set; }
        public string SearchDateBirth { get; set; }
        public string SearchString { get; set; }
    }
}
