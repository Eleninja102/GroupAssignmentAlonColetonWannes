﻿using GroupAssignmentAlonColetonWannes.Items;
using GroupAssignmentAlonColetonWannes.Search;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentAlonColetonWannes.Main
{
    public class clsMainLogic
    {
        //

        public clsMainLogic() { }


        public static void testSQLStatement()
        {
            



            clsSearchLogic.loadInvoices();
            
            clsSearchLogic.loadInvoices(5000, null, null);
            DateTime x = DateTime.Now;
            clsSearchLogic.loadInvoices(null, x, null);

            clsSearchLogic.loadInvoices(5000, x, null);

            clsSearchLogic.loadInvoices(null, x, 120);

            int z = 0;

            clsItemsSQL.getInvoicesWithItemCode("A", ref z);


            Dictionary<int, string> invoiceItems = clsMainSQL.getInvoiceItems(5000);
        }
    }
}
