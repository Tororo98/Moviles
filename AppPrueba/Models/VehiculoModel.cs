using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPrueba.Models
{
    public class VehiculoModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(ClienteModel))]
        public int ClienteId { get; set; }
    }
}
