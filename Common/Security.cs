using CompanySystem.DAL;

namespace CompanySystem.Common
{
    public  class Security
    {
        protected readonly CompanyContext _context;
        public Security(CompanyContext context)
        {
            _context = context;
        }
        public static string Encrypt_Password(string password)
        {
            //string pswstr = string.Empty;
            //byte[] psw_encode = new byte[password.Length];
            var password_encode = System.Text.Encoding.UTF8.GetBytes(password);
            var passwordstr = Convert.ToBase64String(password_encode);
            return passwordstr;
        }
        //public static string Decrypt_Password(string encryptpassword)
        //{
        //    string pswstr = string.Empty;
        //    System.Text.UTF8Encoding encode_psw = new System.Text.UTF8Encoding();
        //    System.Text.Decoder Decode = encode_psw.GetDecoder();
        //    byte[] todecode_byte = Convert.FromBase64String(encryptpassword);
        //    int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
        //    char[] decoded_char = new char[charCount];
        //    Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
        //    pswstr = new String(decoded_char);
        //    return pswstr;
        //}
        public bool CheckLoginInput(string email , string password)
        {
            var entity = _context.Employees.FirstOrDefault(entity => entity.Email == email);
            if(entity.Password == Encrypt_Password(password))
                return true;
            return false;
        }


    }
    
}
