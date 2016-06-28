﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pengdylan.ACE.DAL.DALImplement;
using Pengdylan.ACE.Data;

namespace Pengdylan.ACE.DAL
{
    public class AccountDAL : IAccountDAL
    {
        public bool Add(Data.Account account)
        {
            bool result = false;
            if (account == null)
                return result;
            var context = new DataContext();
            context.Account.Add(account);
            context.SaveChanges();
            return result;
        }
    }
}
