using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Model
{
    public class Student
    {

        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string address  { get; set; }


        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string Address3333 { get; set; }


        // login page completed
    }
}
