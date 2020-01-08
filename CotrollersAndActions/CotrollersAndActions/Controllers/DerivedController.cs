using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotrollersAndActions.Controllers {
    public class DerivedController : Controller {

        public ViewResult Index() => View("Result", $"this is a derived controller");

        public ViewResult Headers() => View("DictionaryResult",
            Request.Headers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First()));
    }
}
