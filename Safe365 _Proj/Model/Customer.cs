using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Safe365__Proj.Model
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BusinessName { get; set; }
        public DateTime DateCreated { get; set; }
    }

    [DataContract]
    public class Customer2
    {
        [DataMember]
        public string FirstName { get; set; }
    }
}
