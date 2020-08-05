using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStoreClubNamespace.Workers
{
    class ProductOrdersWorker
    {
        private string company;
        private string comments;
        private DateTime DateTime;
        public ProductOrdersWorker(string who, string text, DateTime when)
        {
            company = who;
            comments = text;
            DateTime = when;
        }

        public string OrderItem(ProductOrdersWorker productOrdersWorker)
        {
            return ("От кого: " + productOrdersWorker.company +"\n "+ 
                "Комментарии: " + productOrdersWorker.comments + "\n "+ 
                "Когда: " + productOrdersWorker.DateTime.Date.ToShortDateString());
        }
    }
}
