using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore; 
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Service { get; set; }
        public string Description { get; set; }
        public DataType Daterdv { get; set; }
    }
}