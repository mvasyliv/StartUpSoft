
using System;
using System.ComponentModel.DataAnnotations;

namespace Lesson1HomeTask.Models
{
    public class Post
    {
        #region Fields
        public int Id { get; set; }
        private string _name = String.Empty;

        [Display(Name = "Name post")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description = String.Empty;
        [Display(Name = "Description post")]
        public string Description
        {
            get { return _description;}
            set { _description = value; }
        }
        #endregion
    }
}