/*
 * Blaine Smith
 * Project walkthrough Due Tuesday, 02-12-2019
 * NONE
 * This program will test the methods created to see if they will provide the correct result.
 */
using System.Web.Mvc;

namespace TestingDemo
{
    public class AdminController : Controller
    {
        private IUserRepository repository;

        public AdminController(IUserRepository repo)
        {
            repository = repo;
        }

        public ActionResult ChangeLoginName(string oldName, string newName)
        {
            User user = repository.FetchByLoginName(oldName);
            user.LoginName = newName;
            repository.SubmitChanges();
            return View();
        }
    }
}