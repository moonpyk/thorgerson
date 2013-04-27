using System.Data.Entity;

namespace Thorgerson.Models
{
    public class ThorgersonContext : DbContext
    {
        // Vous pouvez ajouter du code personnalisé à ce fichier. Les modifications ne seront pas remplacées.
        // 
        // Si vous voulez qu’Entity Framework abandonne et régénère la base de données
        // automatiquement à chaque fois que vous modifiez le schéma du modèle, ajoutez le code
        // suivant à la méthode Application_Start dans le fichier Global.asax.
        // Remarque : cette opération supprime et recrée la base de données à chaque modification du modèle.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Thorgerson.Models.ThorgersonContext>());

        static ThorgersonContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ThorgersonContext>());
        }

        public ThorgersonContext()
            : base("name=ThorgersonContext")
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
