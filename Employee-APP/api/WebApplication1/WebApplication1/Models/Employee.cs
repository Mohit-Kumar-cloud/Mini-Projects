﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public ObjectId Id { get; set; }
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string Department { get; set; }

        public string PhotoFileName { get; set; }
        public object DateOfJoining { get; set; }
    }
}