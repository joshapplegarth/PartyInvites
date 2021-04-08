using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse //POCO- Plain Old C# Object
    {
        // F i e l d s   &   P r o p e r t i e s

        [Required(ErrorMessage = "Name is required")]
        public string Name      { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = " A valid Email is required")]
        public string Email     { get; set; }    
        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage = " A valid Phone is required")]
        public string Phone     { get; set; }      
        [Required(ErrorMessage = "Are you going to attend?")]
        public bool? WillAttend { get; set; }    


        // C o n s t r u c t o r s 


        // M e t h o d s
    }
}
