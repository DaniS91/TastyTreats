using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace TastyTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }

    [Required(ErrorMessage = "Your flavor must have a name")]
    public string Name { get; set; }

    public string Description { get; set; }

     public List<TreatFlavor> JoinEntities { get; }

     public ApplicationUser User { get; set; }
  }
}