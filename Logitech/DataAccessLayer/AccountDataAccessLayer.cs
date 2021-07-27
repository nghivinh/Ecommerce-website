using Logitech.Data;
using Logitech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.DataAccessLayer
{
    public class AccountDataAccessLayer
    {
        LogitechContext context = new LogitechContext();

        public IEnumerable<Account> GetAllAccounts()
        {
            return context.Accounts.ToList();
        }

        public Account GetAccountData(int id)
        {
            return context.Accounts.Find(id);
        }

        public int AddAccount(Account _account)
        {
            var account = new Account()
            {
                UserName = _account.UserName,
                Password = _account.Password,
                FullName = _account.FullName,
                PhoneNumber = _account.PhoneNumber
            };

            context.Accounts.Add(account);
            context.SaveChanges();
            if (account.Id > 0)
            {
                return 1;
            }
            return 0;
        }

        public int UpdateAccount(int id, Account _account)
        {
            var account = context.Accounts.Find(id);
            account.UserName = _account.UserName;
            account.Password = _account.Password;
            account.FullName = _account.FullName;
            account.PhoneNumber = _account.PhoneNumber;

            context.SaveChanges();
            return 1;
        }

        public int DeleteAccount(int id)
        {
            //Xóa danh sách đánh giá của sản phẩm trước
            context.Ratings.RemoveRange(context.Ratings.Where(r => r.Account.Id == id));

            //Xóa account này
            var account = context.Accounts.Find(id);
            context.Accounts.Remove(account);

            context.SaveChanges();
            return 1;
        }
    }
}
