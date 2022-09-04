using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter ur name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please enter ur email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Pleas enter valid email address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Please enter ur phone number")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}