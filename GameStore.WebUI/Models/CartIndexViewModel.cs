using GameStore.Domain.Entities;
using System.Collections.Generic;

namespace GameStore.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}