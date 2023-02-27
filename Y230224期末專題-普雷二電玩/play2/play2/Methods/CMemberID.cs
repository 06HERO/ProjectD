using play2.Controllers;
using play2.EFModels;

namespace play2.Methods
{
    public class CMemberID
    {        
        private readonly Play2Context db;

        public CMemberID(Play2Context db)
        {        
            this.db = db;
        }

        public string RegularID(string 身分證號)
        {
            string date = DateTime.Now.ToString("yyMMdd");
            string pid = 身分證號.Trim().Substring(1, 4) + 身分證號.Trim().Substring(6,4);
            string ID="";
            bool a = false;
            while (!a)
            {
                ID = "B" + date + pid + (new CgetCode()).get三位亂碼();
                a = !db.TMembers.Any(t => t.MemberId == ID);
            }
            return ID;
        }
        public string CompanyID(string 統一編號)
        {
            string date = DateTime.Now.ToString("yyMMdd");           
            string code = (new CgetCode()).get三位亂碼();
            string ID="";
            bool a = false;
            while (!a)
            {
                ID = "A" + date + 統一編號.Trim() + (new CgetCode()).get三位亂碼();
                a = !db.TMembers.Any(t => t.MemberId == ID);
            }
            return ID;
        }

    }
}
