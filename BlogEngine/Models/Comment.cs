using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogEngine.Models
{
    public class Comment
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}