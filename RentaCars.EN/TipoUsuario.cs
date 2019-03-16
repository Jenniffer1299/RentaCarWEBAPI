namespace RentaCars.EN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoUsuario")]
    public partial class TipoUsuario
    {
       
        

        public int TipoUsuarioID { get; set; }

        public string Nombre { get; set; }

        public int IdEstado { get; set; }

        

       
    }
}
