namespace RentaCars.EN
{
    using System;
    using System.Data.Entity.Spatial;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Data.Entity;
    using System.Data.Entity.SqlServer;



    public partial class Modelo : DbContext
    {
        const string ConnString = "Data Source=.; initial Catalog=RentaCars; Integrated Security=True";
        public Modelo() : base(ConnString)
        {
            var ensureDLLIsCopied = SqlProviderServices.Instance;
        }
       
        

        public  DbSet<Estado> Estado { get; set; }
        public  DbSet<Renta> Renta { get; set; }
        public  DbSet<Reserva> Reserva { get; set; }
        public  DbSet<TipoUsuario> TipoUsuario { get; set; }
        public  DbSet<Usuario> Usuario { get; set; }
        public  DbSet<Vehiculo> Vehiculo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
