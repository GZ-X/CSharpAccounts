using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class AccountItem
    {
        public string Name;
        public enum Category
        {
            Spending,
            Income
        }
        public string Content;
        public string Note;
        public Money Amount;
        public DateTime OccuredTime;

        public AccountItem(string name, Category category, string Content, string Note, Money money, DateTime occuredTime)
    }
}
