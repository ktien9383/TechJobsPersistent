using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Job Name must be between 3 and 50 characters")]
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }

        [Required(ErrorMessage = "Skill is required.")]
        public string [] selectedSkills { get; set; }
        public List<Skill>  Skills { get; set; }
        
        public AddJobViewModel(List<Employer> possibleEmployers, List<Skill> possibleSkills)
        {
            Employers = new List<SelectListItem>();
            Skills = new List<Skill>();

            foreach (var employer in possibleEmployers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }

            foreach (var skill in possibleSkills)
            {
                Skills.Add(skill);

            }

        }
        
        public AddJobViewModel() { }
    }
}
