namespace RentaCars.EN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reserva")]
    public partial class Reserva
    {
       

        public int ReservaID { get; set; }

        public int VehiculoID { get; set; }

        public DateTime FechaEn { get; set; }

        public DateTime FechaDev { get; set; }

        public string HoraDev { get; set; }

        public decimal PagoTotal { get; set; }

        public int EstadoID { get; set; }

        public virtual Estado Estado { get; set; }

       
    }
}
