using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankDbApi.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Customer = new HashSet<Customer>();
        }

        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(10)]
        public string BIC { get; set; }

        [InverseProperty("Bank")]
        public virtual ICollection<Customer> Customer { get; set; }
    }
}