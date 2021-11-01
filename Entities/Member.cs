using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesDemo.Entities
{
    class Member:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationaalityId { get; set; }

    }
}
