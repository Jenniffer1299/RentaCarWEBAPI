namespace RentaCars.EN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Renta")]
    public partial class Renta
    {
        public int RentaID { get; set; }

        public int UsuarioID { get; set; }

        public int ReservaID { get; set; }

        public int EstadoID { get; set; }

       
    }
}
