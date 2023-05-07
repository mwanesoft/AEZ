using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AEZ.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "navchar(100)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "navchar(100)")]
    public string LastName { get; set; }



}

