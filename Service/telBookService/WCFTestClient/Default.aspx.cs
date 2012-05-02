using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFTestClient
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PhonebookService.ItelBookServiceClient client = new PhonebookService.ItelBookServiceClient("http://localhost:8732/Design_Time_Addresses/telBookService/Service1/mex");
            PhonebookService.Contact[] kontkaktid = client.getContacts();
            throw new Exception(kontkaktid.Length.ToString());
        }
    }
}
