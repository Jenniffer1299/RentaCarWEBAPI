namespace RentaCars.EN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehiculo")]
    public partial class Vehiculo
    {
        
      
        

        public int VehiculoID { get; set; }

        public int UsuarioID { get; set; }

        [Required]
        public string Placa { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Modelo { get; set; }

        public DateTime Year { get; set; }

        public int Npuertas { get; set; }

        public decimal PrecioDiario { get; set; }

        public decimal PagoTotal { get; set; }

        public int EstadoID { get; set; }

        public string imagen { get; set; }

     

       
    }
}
