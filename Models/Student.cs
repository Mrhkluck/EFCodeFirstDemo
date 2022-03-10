using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirstDemo.Models
{
    public class Student
    {
        public int StudentID { get; set; } //scaler property propertice 
        public string StudentName { get; set; } //scaler property
        public string DateOfBirth { get; set; } //scaler property

        //Navigation Property It is reperesenting class type HasARelationship
        public Address Address { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}