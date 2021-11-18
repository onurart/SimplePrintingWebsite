using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idealBaski.Components
{
    public class Contact:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();

        }
    }
}
