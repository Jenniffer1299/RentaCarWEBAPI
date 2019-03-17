namespace RentaCars.EN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estado")]
    public partial class Estado
    {
       

        public int EstadoID { get; set; }

        [Required]
        public string Nombre { get; set; }

        
    }
}
