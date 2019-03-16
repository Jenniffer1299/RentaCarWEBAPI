namespace RentaCars.EN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
       

        public int UsuarioID { get; set; }

        public int TipoUsuarioID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public int Telefono { get; set; }

        public string NombreUser { get; set; }

        public string Pass { get; set; }

        public int EstadoID { get; set; }

        

      
    }
}
