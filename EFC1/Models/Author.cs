using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC1.Models;
[Table("authors")]
public class Author {
    [Key, Column("id",Order =0)]
    public int Id { get; set; }

    [Column("full_name",TypeName ="varchar(75)",Order =2)]
    public string FullName { get; set; }

    [Column("email", TypeName = "varchar(75)", Order = 1)]
    public string Email { get; set; }

    [Column("salary"),Precision(14,2)]
    public double Salary { get; set; }


    [Column("birth_date")]
    public DateTime BirthDate { get; set; }


    public override string ToString() {
        return $"ID: {Id}, Nombre:{FullName}, EMail:{Email}, Salary:{Salary},Cumple:{BirthDate}";
    }
}
    

