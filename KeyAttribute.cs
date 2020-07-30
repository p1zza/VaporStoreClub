using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStoreClubNamespace
{
    class KeyValidate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string key = value.ToString();
                if (!key.Contains(" "))
                    return true;
                else
                    this.ErrorMessage = "Ключ не должен быть с пробелом";
            }
            return false;
        }
    }
}
