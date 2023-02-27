namespace play2.Methods
{
    public class CgetCode
    {
        public string get六位驗證碼()
        {
            Random random = new Random();
            int count = 0;
            string[] arr驗證碼 = new string[6];
            string[] ran = new string[]
            {"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I",
            "J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

            while (count < 6)
            {
                int temp = random.Next(0, ran.Length);
                arr驗證碼[count] = ran[temp];
                count++;
            }

            string s = "";
            foreach (string item in arr驗證碼)
                s += item;
            return s;
        }

        public string get三位亂碼()
        {
            Random random = new Random();
            int count = 0;
            string[] arr驗證碼 = new string[3];
            string[] ran = new string[]
            {"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I",
            "J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

            while (count < 3)
            {
                int temp = random.Next(0, ran.Length);
                arr驗證碼[count] = ran[temp];
                count++;
            }

            string s = "";
            foreach (string item in arr驗證碼)
                s += item;
            return s;
        }
    }
}
