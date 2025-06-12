using Chronica.Models.Relacoes;
using Chronica.Models.Universe;
using Microsoft.EntityFrameworkCore;

namespace Chronica.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<Personagem> Personagens { get; set; }

        //Habilidades
        public DbSet<HabilidadeTipo> HabilidadeTipos { get; set; } // Represents "Habilidade de Nascença", "Kekijutsu", "Respiração", etc.
        public DbSet<Habilidade> Habilidades { get; set; } // Specific techniques like "Vazio Roxo", "Black Flash"
        public DbSet<PersonagemTipoHabilidade> PersonagemTipoHabilidades { get; set; }
        public DbSet<PersonagemHabilidade> PersonagemHabilidades { get; set; }

        //Itens
        public DbSet<ItemTipo> ItemTipos { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<PersonagemItem> PersonagemItens { get; set; }

        //Pericias
        public DbSet<Pericia> Pericia { get; set; }
        public DbSet<PersonagemPericia> PersonagemPericias { get; set; }

        //Outros
        public DbSet<Origem> Origem { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<VarianteRacial> VariantesRaciais { get; set; }

        //Vantagens e Desvantagens
        public DbSet<Vantagens> Vantagens { get; set; } // Certifique-se que o nome do DbSet é plural
        public DbSet<Desvantagens> Desvantagens { get; set; } // Certifique-se que o nome do DbSet é plural
        public DbSet<PersonagemVantagem> PersonagemVantagens { get; set; }
        public DbSet<PersonagemDesvantagem> PersonagemDesvantagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração de Herança TPH (Table-Per-Hierarchy)
            modelBuilder.Entity<Personagem>()
                .HasDiscriminator<string>("TipoPersonagem")
                .HasValue<AgentesModel>("Agente")
                .HasValue<AmeacasModel>("Ameaca");

            // === CONFIGURAÇÕES DOS RELACIONAMENTOS ATUALIZADOS ===

            // Personagem to HabilidadeTipo (Many-to-Many through PersonagemHabilidadeTipo)
            modelBuilder.Entity<PersonagemTipoHabilidade>()
                .HasKey(pht => new { pht.PersonagemId, pht.HabilidadeTipoId });

            modelBuilder.Entity<PersonagemTipoHabilidade>()
                .HasOne(pht => pht.Personagem)
                .WithMany(p => p.PersonagemTipoHabilidades)
                .HasForeignKey(pht => pht.PersonagemId);

            modelBuilder.Entity<PersonagemTipoHabilidade>()
                .HasOne(pht => pht.HabilidadeTipo)
                .WithMany(ht => ht.PersonagemTipoHabilidades)
                .HasForeignKey(pht => pht.HabilidadeTipoId);

            // Personagem to Habilidades (Many-to-Many through PersonagemHabilidades)
            modelBuilder.Entity<PersonagemHabilidade>()
                .HasKey(ph => new { ph.PersonagemId, ph.HabilidadeId }); // ATUALIZADO

            modelBuilder.Entity<PersonagemHabilidade>()
                .HasOne(ph => ph.Personagem)
                .WithMany(p => p.PersonagemHabilidades) // ATUALIZADO: Coleção em Personagem
                .HasForeignKey(ph => ph.PersonagemId);

            modelBuilder.Entity<PersonagemHabilidade>()
                .HasOne(ph => ph.Habilidade) // ATUALIZADO
                .WithMany(h => h.PersonagemHabilidades) // ATUALIZADO: Coleção em Habilidades
                .HasForeignKey(ph => ph.HabilidadeId); // ATUALIZADO

            // HabilidadeTipo to Habilidades (One-to-Many)
            modelBuilder.Entity<Habilidade>() // ATUALIZADO
                .HasOne(h => h.HabilidadeTipo)
                .WithMany(ht => ht.Habilidades) // ATUALIZADO: Coleção em HabilidadeTipo
                .HasForeignKey(h => h.HabilidadeTipoId)
                .IsRequired(); // Uma Habilidades deve pertencer a um HabilidadeTipo


            // ItemTipo to Item (One-to-Many)
            // Um TipoItem (categoria) tem muitos Itens (específicos)
            modelBuilder.Entity<Item>()
                .HasOne(i => i.ItemTipo)
                .WithMany(it => it.Itens)
                .HasForeignKey(i => i.ItemTipoId)
                .IsRequired();

            modelBuilder.Entity<PersonagemItem>()
                .HasKey(pi => new { pi.PersonagemId, pi.ItemId });

            modelBuilder.Entity<PersonagemItem>()
                .HasOne(pi => pi.Personagem)
                .WithMany(p => p.PersonagemItens)
                .HasForeignKey(pi => pi.PersonagemId);

            modelBuilder.Entity<PersonagemItem>()
                .HasOne(pi => pi.Item)
                .WithMany(i => i.PersonagemItens)
                .HasForeignKey(pi => pi.ItemId);


            // Personagem para Vantagens (Many-to-Many através de PersonagemVantagem)
            modelBuilder.Entity<PersonagemVantagem>()
                .HasKey(pv => new { pv.PersonagemId, pv.VantagemId }); // Chave composta

            modelBuilder.Entity<PersonagemVantagem>()
                .HasOne(pv => pv.Personagem)
                .WithMany(p => p.PersonagemVantagens) // Coleção em Personagem
                .HasForeignKey(pv => pv.PersonagemId);

            modelBuilder.Entity<PersonagemVantagem>()
                .HasOne(pv => pv.Vantagem)
                .WithMany(v => v.PersonagemVantagens) // Coleção em Vantagens
                .HasForeignKey(pv => pv.VantagemId);

            // Personagem para Desvantagens (Many-to-Many através de PersonagemDesvantagem)
            modelBuilder.Entity<PersonagemDesvantagem>()
                .HasKey(pd => new { pd.PersonagemId, pd.DesvantagemId }); // Chave composta

            modelBuilder.Entity<PersonagemDesvantagem>()
                .HasOne(pd => pd.Personagem)
                .WithMany(p => p.PersonagemDesvantagens) // Coleção em Personagem
                .HasForeignKey(pd => pd.PersonagemId);

            modelBuilder.Entity<PersonagemDesvantagem>()
                .HasOne(pd => pd.Desvantagem)
                .WithMany(d => d.PersonagemDesvantagens) // Coleção em Desvantagens
                .HasForeignKey(pd => pd.DesvantagemId);


            // Personagem para PericiaTipo (Many-to-Many através de PersonagemPericia)
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

            modelBuilder.Entity<Personagem>()
                .HasOne(p => p.Origem)
                .WithMany(c => c.Personagens)
                .HasForeignKey(p => p.OrigemId)
                .IsRequired(false);


            // Personagem to Classe (One-to-Many)
            modelBuilder.Entity<Personagem>()
                .HasOne(p => p.Classe)
                .WithMany(c => c.Personagens)
                .HasForeignKey(p => p.ClasseId)
                .IsRequired(false);


            // Personagem to VarianteRacial (One-to-Many)
            modelBuilder.Entity<Personagem>()
                .HasOne(p => p.VarianteRacial)
                .WithMany(vr => vr.Personagens)
                .HasForeignKey(p => p.VarianteRacialId)
                .IsRequired(false);

            // Configuração para AtributosDeEspirito (mantenha sua escolha, ex: ignorado ou JSON)
            modelBuilder.Entity<Personagem>().Ignore(p => p.AtributosDeEspirito);
            // OU
            // modelBuilder.Entity<Personagem>().Property(p => p.AtributosDeEspirito).HasColumnType("jsonb"); // Para PostgreSQL
        }
    }
}