using MessagingCRM.Business.Intelligence;
using MessagingCRM.Business.Intelligence.Interfaces;
using MessagingCRM.Business.Intelligence.Interfaces.IRepositoryWork;
using MessagingCRM.Business.Intelligence.Models.EntityModels;
using MessagingCRM.DataStore.Entities;
using MessagingCRM.DataStore.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessagingCRM.Controllers
{
    public class MembersController : Controller
    {
        readonly IUnitOfWork unitOfWork = new UnitOfWork(new MessagingCRMEntities());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Members Member)
        {
            IdentityStore.AddIdentityUser(Member.EmailAddress, "Passw0rd123*");
            unitOfWork.Members.Add(Member);
            unitOfWork.SaveChanges();
            return View();
        }
    }
}