using System.Net.Mail;

namespace play2.Methods
{
    public class CMails
    {
        public void send驗證信(string 收件人, string 驗證碼)
        {
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("play2sev@gmail.com", "驗證碼如下");

            //收信者email
            mail.To.Add(收件人);

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "普雷二電玩驗證碼";

            //內容
            mail.Body = $"<h1>驗證碼如下:{驗證碼}</h1>";

            //內容使用html
            mail.IsBodyHtml = true;

            //設定gmail的smtp (這是google的)
            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

            //您在gmail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("play2sev", "thapisiklbcphuxy");

            //開啟ssl
            MySmtp.EnableSsl = true;

            //發送郵件
            MySmtp.Send(mail);

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
        }
        public void send靜待註冊(string 收件人)
        {
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("play2sev@gmail.com", "普雷二書面認證");

            //收信者email
            mail.To.Add(收件人);

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "普雷二書面認證";

            //內容
            mail.Body = $"<h2>顧客您好，本公司已收到您們的書面認證，預計於三個工作天內審核並通知。</h2>";

            //內容使用html
            mail.IsBodyHtml = true;

            //設定gmail的smtp (這是google的)
            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

            //您在gmail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("play2sev", "thapisiklbcphuxy");

            //開啟ssl
            MySmtp.EnableSsl = true;

            //發送郵件
            MySmtp.Send(mail);

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
        }
        public void send認證通過(string 收件人)
        {
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("play2sev@gmail.com", "普雷二書面認證通過");

            //收信者email
            mail.To.Add(收件人);

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "普雷二書面認證通過";

            //內容
            mail.Body = $"<h2>顧客您好，本公司已審核過你們書面認證文件並確認所有的資料都符合，會員系統已開通完成。</h2>";

            //內容使用html
            mail.IsBodyHtml = true;

            //設定gmail的smtp (這是google的)
            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

            //您在gmail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("play2sev", "thapisiklbcphuxy");

            //開啟ssl
            MySmtp.EnableSsl = true;

            //發送郵件
            MySmtp.Send(mail);

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
        }
        public void send認證未通過(string 收件人)
        {
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("play2sev@gmail.com", "普雷二書面認證未通過");

            //收信者email
            mail.To.Add(收件人);

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "普雷二書面認證未通過";

            //內容
            mail.Body = $"<h2>顧客您好，本公司已審核過你們書面認證文件，但其中有些資料不符合，請繳交正確的認證文件。</h2>" +"</br>"+
                $"<p>請於一月內上傳，不然此帳號將被註銷，需重新申請。</p>";

            //內容使用html
            mail.IsBodyHtml = true;

            //設定gmail的smtp (這是google的)
            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

            //您在gmail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("play2sev", "thapisiklbcphuxy");

            //開啟ssl
            MySmtp.EnableSsl = true;

            //發送郵件
            MySmtp.Send(mail);

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
        }
        public void send取消資格(string 收件人,string 內容)
        {
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("play2sev@gmail.com", "普雷二會員資格取消");

            //收信者email
            mail.To.Add(收件人);

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "普雷二會員資格取消";

            //內容
            mail.Body = $"<h2>顧客您好，因為發現您的會員帳號有以下行為</h2></br>" +
                                 $"<h3>{內容}</h3></br>" +
                                 $"<h3>所以自收到這封信件同時將您的會員帳號停權。</h3>";

            //內容使用html
            mail.IsBodyHtml = true;

            //設定gmail的smtp (這是google的)
            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

            //您在gmail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("play2sev", "thapisiklbcphuxy");

            //開啟ssl
            MySmtp.EnableSsl = true;

            //發送郵件
            MySmtp.Send(mail);

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
        }
        public void send刪除帳號(string 收件人)
        {
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("play2sev@gmail.com", "普雷二會員帳號註銷");

            //收信者email
            mail.To.Add(收件人);

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "普雷二會員帳號註銷";

            //內容
            mail.Body = $"<h2>顧客您好，因為發現您的會員帳號一直沒有完成認證且長時間沒有操作，所以將此帳號註銷。</h2>";

            //內容使用html
            mail.IsBodyHtml = true;

            //設定gmail的smtp (這是google的)
            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

            //您在gmail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("play2sev", "thapisiklbcphuxy");

            //開啟ssl
            MySmtp.EnableSsl = true;

            //發送郵件
            MySmtp.Send(mail);

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
        }
        public void send還原帳號(string 收件人)
        {
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("play2sev@gmail.com", "普雷二會員帳號還原");

            //收信者email
            mail.To.Add(收件人);

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "普雷二會員帳號還原";

            //內容
            mail.Body = $"<h2>顧客您好，您遭到停權的帳號已還原。</h2>";

            //內容使用html
            mail.IsBodyHtml = true;

            //設定gmail的smtp (這是google的)
            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

            //您在gmail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("play2sev", "thapisiklbcphuxy");

            //開啟ssl
            MySmtp.EnableSsl = true;

            //發送郵件
            MySmtp.Send(mail);

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
        }

        public void send訂單成立通知(string 收件人,string 訂單成立)
        {
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("play2sev@gmail.com", "普雷二官方通知");

            //收信者email
            mail.To.Add(收件人);

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "普雷二會員訂單成立";

            //內容
            mail.Body = $"<h2>顧客您好，您的訂單已成立，成立時間於{訂單成立}。預計七天以內到貨，如有改動會再寄信通知或電話聯絡。</h2>";

            //內容使用html
            mail.IsBodyHtml = true;

            //設定gmail的smtp (這是google的)
            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

            //您在gmail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("play2sev", "thapisiklbcphuxy");

            //開啟ssl
            MySmtp.EnableSsl = true;

            //發送郵件
            MySmtp.Send(mail);

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
        }


        public void send客服回應(string 收件人, string 客服回應)
        {
            MailMessage mail = new MailMessage();
            //前面是發信email後面是顯示的名稱
            mail.From = new MailAddress("play2sev@gmail.com", "普雷二官方通知");

            //收信者email
            mail.To.Add(收件人);

            //設定優先權
            mail.Priority = MailPriority.Normal;

            //標題
            mail.Subject = "普雷咪已回應您提出的問題~喵";

            //內容
            mail.Body = $"<h2>尊敬的大人您好，普雷咪已收到您提出的問題，回應如下<br>{客服回應}<br>感謝您的光臨。</h2>";

            //內容使用html
            mail.IsBodyHtml = true;

            //設定gmail的smtp (這是google的)
            SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

            //您在gmail的帳號密碼
            MySmtp.Credentials = new System.Net.NetworkCredential("play2sev", "thapisiklbcphuxy");

            //開啟ssl
            MySmtp.EnableSsl = true;

            //發送郵件
            MySmtp.Send(mail);

            //放掉宣告出來的MySmtp
            MySmtp = null;

            //放掉宣告出來的mail
            mail.Dispose();
        }

    }
}
