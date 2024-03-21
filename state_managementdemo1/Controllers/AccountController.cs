using Microsoft.AspNetCore.Mvc;
using state_managementdemo1.Models;
using System.Diagnostics;

namespace state_managementdemo1.Controllers
{

    //private readonly IHttpContextAccessor contex;
    [Route("[action]/[controller]/{id?}")]
    public class AccountController : Controller
    {
        private readonly IHttpContextAccessor contex;
        public AccountController(IHttpContextAccessor contex)
        {
            this.contex = contex;
        }

        public IActionResult Index()
        {
            return View();
        }
        /*[Route("TrAmnt")]
        [Route("AX/SC/DV/FB/RG")]*/
        public IActionResult TransferAmount()
        {
            return View();
        }
        public IActionResult VerifyTransaction(string FormAccountNo,string FormAccountName,string ToAccountNo,
            string ToAccountName,string Account,string Mode)
        {
            contex.HttpContext.Session.SetString("FormAccountNo", FormAccountNo);
            contex.HttpContext.Session.SetString("FormAccountName", FormAccountName);
            contex.HttpContext.Session.SetString("ToAccountNo", ToAccountNo);
            contex.HttpContext.Session.SetString("ToAccountName", ToAccountName);
            contex.HttpContext.Session.SetString("Account", Account);
            contex.HttpContext.Session.SetString("Mode", Mode);
            return View();
        }

    }
}
