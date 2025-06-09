using Microsoft.EntityFrameworkCore;

namespace Chronica.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<Personagem> Personagens { get; set; }

        // Novos DbSets para gerenciar dados de jogos predefinidos
        public DbSet<Habilidade> Habilidade { get; set; } // Represents "Habilidade de Nascença", "Kekijutsu", "Respiração", etc.
        public DbSet<SubHabilidade> SubHabilidades { get; set; } // Specific techniques like "Vazio Roxo", "Black Flash"
        public DbSet<Item> ItemTipos { get; set; } // Predefined items
        public DbSet<ClaOuFamilia> ClaOuFamilias { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Pericia> PericiaTipos { get; set; } // Predefined skill types
        public DbSet<VarianteRacial> VariantesRaciais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Table-Per-Hierarchy (TPH) for Personagem, AgentesModel, and AmeaçasModel
            // EF Core will automatically create a 'Discriminator' column to differentiate types
            modelBuilder.Entity<Personagem>()
                .HasDiscriminator<string>("TipoPersonagem") // 'TipoPersonagem' will be the column name
                .HasValue<AgentesModel>("Agente")           // Value for AgentesModel
                .HasValue<AmeacasModel>("Ameaca");          // Value for AmeaçasModel

            // Define relationships (these remain largely the same, but refer to PersonagemId)

            // Personagem to HabilidadeTipo (Many-to-Many through PersonagemHabilidade)
            modelBuilder.Entity<PersonagemHabilidade>()
                .HasKey(ph => new { ph.PersonagemId, ph.HabilidadeTipoId });

            modelBuilder.Entity<PersonagemHabilidade>()
                .HasOne(ph => ph.Personagem)
                .WithMany(p => p.PersonagemHabilidades)
                .HasForeignKey(ph => ph.PersonagemId);

            modelBuilder.Entity<PersonagemHabilidade>()
                .HasOne(ph => ph.Habilidade)
                .WithMany(ht => ht.PersonagemHabilidades)
                .HasForeignKey(ph => ph.HabilidadeTipoId);


            // Personagem to SubHabilidade (Many-to-Many through PersonagemSubHabilidade)
            modelBuilder.Entity<PersonagemSubHabilidade>()
                .HasKey(psh => new { psh.PersonagemId, psh.SubHabilidadeId });

            modelBuilder.Entity<PersonagemSubHabilidade>()
                .HasOne(psh => psh.Personagem)
                .WithMany(p => p.PersonagemSubHabilidades)
                .HasForeignKey(psh => psh.PersonagemId);

            modelBuilder.Entity<PersonagemSubHabilidade>()
                .HasOne(psh => psh.SubHabilidade)
                .WithMany(sh => sh.PersonagemSubHabilidades)
                .HasForeignKey(psh => psh.SubHabilidadeId);


            // HabilidadeTipo to SubHabilidade (One-to-Many)
            modelBuilder.Entity<SubHabilidade>()
                .HasOne(sh => sh.Habilidade)
                .WithMany(ht => ht.SubHabilidades)
                .HasForeignKey(sh => sh.HabilidadeTipoId)
                .IsRequired();


            // Personagem to ItemTipo (Many-to-Many through PersonagemItem)
            modelBuilder.Entity<PersonagemItem>()
                .HasKey(pi => new { pi.PersonagemId, pi.ItemId });

            modelBuilder.Entity<PersonagemItem>()
                .HasOne(pi => pi.Personagem)
                .WithMany(p => p.PersonagemItens)
                .HasForeignKey(pi => pi.PersonagemId);

            modelBuilder.Entity<PersonagemItem>()
                .HasOne(pi => pi.Item)
                .WithMany(it => it.PersonagemItens)
                .HasForeignKey(pi => pi.ItemId);


            // Personagem to PericiaTipo (Many-to-Many through PersonagemPericia)
            modelBuilder.Entity<PersonagemPericia>()
                .HasKey(pp => new { pp.PersonagemId, pp.PericiaId });

            modelBuilder.Entity<PersonagemPericia>()
                .HasOne(pp => pp.Personagem)
                .WithMany(p => p.PersonagemPericias)
                .HasForeignKey(pp => pp.PersonagemId);

            modelBuilder.Entity<PersonagemPericia>()
                .HasOne(pp => pp.Pericia)
                .WithMany(pt => pt.PersonagemPericias)
                .HasForeignKey(pp => pp.PericiaId);


            // Personagem to ClaOuFamilia (One-to-Many)
            modelBuilder.Entity<Personagem>()
                .HasOne(p => p.ClaOuFamilia)
                .WithMany(c => c.Personagens) // Changed from Agentes to Personagens
                .HasForeignKey(p => p.ClaOuFamiliaId)
                .IsRequired(false);


            // Personagem to Classe (One-to-Many)
            modelBuilder.Entity<Personagem>()
                .HasOne(p => p.Classe)
                .WithMany(c => c.Personagens) // Changed from Agentes to Personagens
                .HasForeignKey(p => p.ClasseId)
                .IsRequired(false);


            // Personagem to VarianteRacial (One-to-Many)
            modelBuilder.Entity<Personagem>()
                .HasOne(p => p.VarianteRacial)
                .WithMany(vr => vr.Personagens) // Changed from Agentes to Personagens
                .HasForeignKey(p => p.VarianteRacialId)
                .IsRequired(false);
        }
    }
}