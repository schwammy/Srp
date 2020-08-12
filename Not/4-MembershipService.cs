using Shared;
using System;
using System.Linq;
using System.Net.Mail;

namespace Not
{
    public class MembershipService
    {
        public void Join(string userName, string password)
        {
            DemoDbContext _dbContext = new DemoDbContext();

            //validate username
            if (userName.Length < 5)
                throw new Exception("invalid username");
            if (!userName.Contains("@"))
                throw new Exception("not an email address");
            //validate password
            if (password.Length < 5)
                throw new Exception("invalid password");


            //check for duplicate users
            if (_dbContext.Users.Any(m => m.UserName == userName))
                throw new Exception("Duplicate username");

            //convert
            User u = new User { UserName = userName };
            // this could be much more complicated


            //join
            _dbContext.Users.Add(u);
            _dbContext.SaveChanges();

            //send email
            MailMessage message = new MailMessage();
            message.Subject = "Welcome";
            message.Body = "Thanks for joining!";
            message.To.Add(userName);
            SmtpClient client = new SmtpClient();
            client.Send(message);

        }

    }
}
