using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreeView.Models
{
    public class Step
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string StepDescription { get; set; }

        public string StepResponsible { get; set; }

        public Task Task { get; set; }

        public Step ParentStep { get; set; }
        public List<Step> SubSteps { get; set; }
    }
}
