
using System; 
using System.ComponentModel.DataAnnotations;
using System.Resources;
using System.Runtime.Versioning;

namespace Lesson2HomeTask.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "NameRequired")]
        [Display(Name = "Name", ResourceType = typeof(Resources.Resource))]
        public string Name { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "CountryRequired")]
        [Display(Name = "Country", ResourceType = typeof(Resources.Resource))]
        public string State { get; set; }
    }
}