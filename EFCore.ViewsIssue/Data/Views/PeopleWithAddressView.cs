using EFCore.ViewsIssue.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.ViewsIssue.Data.Views
{
    public class PeopleWithAddressView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

    }
}
