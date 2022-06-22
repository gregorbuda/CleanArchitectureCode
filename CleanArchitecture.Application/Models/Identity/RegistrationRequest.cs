﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Models.Identity
{
    public class RegistrationRequest
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
