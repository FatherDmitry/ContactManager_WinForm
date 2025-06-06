﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Company { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }
    public string PersonalPhone { get; set; }
    public string InternalPhone { get; set; }

    public string FullName => $"{LastName} {FirstName} {MiddleName}".Trim();
}