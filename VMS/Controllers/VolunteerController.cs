﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMS.Models;

namespace VMS.Controllers
{
    public class VolunteerController : Controller
    {
        private IVolunteerRepository repository;
        public VolunteerController(IVolunteerRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Volunteers);
    }
}
