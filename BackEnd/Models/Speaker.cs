using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
    {
    public class Speaker
        {
        public int Id
            {
            get; set;
            }

        [Required]
        [StringLength(200)]
        public string Name
            {
            get; set;
            }
        [Required]
        [StringLength(200)]
        public string Bio
            {
            get; set;
            }
        [Required]
        [StringLength(200)]
        public virtual string Website
            {
            get; set;
            }
        }
    }
