using Logitech.DataAccessLayer;
using Logitech.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Logitech.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class IAccountController : ControllerBase
    {
        AccountDataAccessLayer accountDAL = new AccountDataAccessLayer();

        [HttpGet]
        [Route("api/Account/Index")]
        public IEnumerable<Account> Index()
        {
            return accountDAL.GetAllAccounts();
        }

        [HttpGet]
        [Route("api/Account/Details/{id}")]
        public Account Details(int id)
        {
            return accountDAL.GetAccountData(id);
        }

        [HttpPost]
        [Route("api/Account/Create")]
        public int Create(Account account)
        {
            return accountDAL.AddAccount(account);
        }

        [HttpPut]
        [Route("api/Account/Edit/{id}")]
        public int Edit(int id, Account account)
        {
            return accountDAL.UpdateAccount(id, account);
        }

        [HttpDelete]
        [Route("api/Account/Delete/{id}")]
        public int Delete(int id)
        {
            return accountDAL.DeleteAccount(id);
        }
    }
}
