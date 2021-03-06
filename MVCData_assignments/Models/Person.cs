﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCData_assignments.Models
{
    public class Person
    {


        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        [Display(Name = "Phone no.")]
        public string Phonenumber { get; set; }

        public Person() { }
        public Person(string name, string city, string phonenumber)
        {
            Name = name;
            City = city;
            Phonenumber = phonenumber;
        }
        public Person(int id, string name, string city, string phonenumber) : this(name, city, phonenumber)         //que???
        {
            Id = id;
        }
    }
}