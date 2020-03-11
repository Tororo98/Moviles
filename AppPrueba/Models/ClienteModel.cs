using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace AppPrueba.Models
{
    public class ClienteModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public int ClienteId { get; set; }
    }
}
