using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApp.Controllers
{
    public class Name : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Ronald", "Buck"
        };
    }
}
