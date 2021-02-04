using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcClinic.MVC.Models
{
    public class ClientBornViewModel
    {
        public List<Client> Clients { get; set; }
        public SelectList Borns { get; set; }
        public string ClienteBorn { get; set; }
        public string SearchString { get; set; }
    }
}
