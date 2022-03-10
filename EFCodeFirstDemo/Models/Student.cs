using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirstDemo.Models
{
    public class Student
    {
        public int StudentID { get; set; }  //scaler property
        public string  StudentName { get; set; }//scaler property
        public string DateOfBirth { get; set; }//scaler property
        public Address Address { get; set; }  //navigation property
    }
    public class Address {

        public int Id { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}