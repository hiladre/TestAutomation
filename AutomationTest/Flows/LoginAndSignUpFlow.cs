using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.Builders;

namespace AutomationTest.Flows
{
    public class LoginAndSignUpFlow : AbstractTestFlow
    {
        public override UserBuilder CreateUser()
        {
            var pass = RandomString(5) + "1234";
            signUp.firstName = RandomString(5);
            signUp.lastName = RandomString(5);
            signUp.email = RandomString(5) + "@" + "gmail.com";
            signUp.password = pass;
            signUp.confirmpassword = pass;
            return new UserBuilder(this);
        }
        private string RandomString(int size)
        {
            var random = new Random();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
