using System;
namespace JwtWebApiTutorial
{
    public class User
    {

        public string UserName { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PassowordSalt { get; set; }

    }
}

