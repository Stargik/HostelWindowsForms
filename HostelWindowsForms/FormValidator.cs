using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelWindowsForms
{
    static class FormValidator
    {
        public static bool IsValid(params string[] strings)
        {
            var res = true;
            foreach (var item in strings)
            {
                if (String.IsNullOrEmpty(item))
                {
                    res = false;
                    return res;
                }
            }
            return res;
        }
        public static bool IsDateValid(DateTime fromDate, DateTime toDate)
        {
            bool res = fromDate <= toDate;
            return res;
        }
    }
}
