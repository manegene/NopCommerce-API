using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class EmailAccount
    {
        public EmailAccount()
        {
            QueuedEmails = new HashSet<QueuedEmail>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public bool UseDefaultCredentials { get; set; }

        public virtual ICollection<QueuedEmail> QueuedEmails { get; set; }
    }
}
