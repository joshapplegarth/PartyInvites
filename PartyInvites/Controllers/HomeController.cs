using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Collections.Generic;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // F i e l d s


        // C o n s t r u c t o r s


        // Me t h o d s
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RsvpForm()
        {
            IActionResult answer = View();
            return answer;
        }
        [HttpPost]
        public IActionResult RsvpForm(GuestResponse gr)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(gr);
                return View("Thanks", gr);
            }
            else
            {
                return View();

            }
        }
        public IActionResult ListResponses()
        {
            List<GuestResponse> responses = Repository.Getresponses();
            return View(responses);
        }
        //public IActionResult ListResponses()
        //{
        //    List<GuestResponse> responses = Repository.Getresponses();
        //    List<GuestResponse> willAttend
        //        = responses.Where(responses => responses.WillAttend == true).ToList();
        //    return View(willAttend);
        //}
    }
}
