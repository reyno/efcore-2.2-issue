using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.ViewsIssue.Data.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
