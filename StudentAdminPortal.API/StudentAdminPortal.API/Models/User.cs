namespace StudentAdminPortal.API.Models
{
    public class User
    {

        private Guid Id { get; set; }
        private string UserName { get; set; }
        private string Email { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Password { get; set; }

       
        //   public void SetPassword(string password)
        //{
        //    Password = Crypto.HashPassword(password);
        //}
         
          
         
        
       
       
    }
}
