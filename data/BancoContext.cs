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

        // Principais 
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<UsuarioCampanha> UsuarioCampanhas { get; set; }
        public DbSet<PersonagemCampanha> PersonagemCampanhas { get; set; }
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

            // --- CONFIGURAÇÕES DE RELACIONAMENTOS COM USUÁRIO ---

            // Um Usuário tem muitas Campanhas Criadas
            modelBuilder.Entity<Campanha>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.CampanhasCriadas)
                .HasForeignKey(c => c.UsuarioId)
                .IsRequired();

            // Um Usuário tem muitos Personagens Criados
            modelBuilder.Entity<Personagem>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.PersonagensCriados)
                .HasForeignKey(p => p.UsuarioId)
                .IsRequired(); // Personagem deve ter um Usuário criador

            // Um Usuário tem muitos Itens Criados
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Usuario)
                .WithMany(u => u.ItensCriados)
                .HasForeignKey(i => i.UsuarioId)
                .IsRequired();

            // Um Usuário tem muitas Habilidades Criadas
            modelBuilder.Entity<Habilidade>()
                .HasOne(h => h.Usuario)
                .WithMany(u => u.HabilidadesCriadas)
                .HasForeignKey(h => h.UsuarioId)
                .IsRequired();

            // Um Usuário tem muitos HabilidadeTipos Criados
            modelBuilder.Entity<HabilidadeTipo>()
                .HasOne(ht => ht.Usuario)
                .WithMany(u => u.HabilidadeTiposCriados)
                .HasForeignKey(ht => ht.UsuarioId)
                .IsRequired();

            // Repita para ItemTipo, PericiaTipo, Vantagens, Desvantagens, Origem, Classe, VarianteRacial
            // Se você quiser que esses também sejam "propriedade" de um usuário.
            modelBuilder.Entity<ItemTipo>()
                .HasOne(it => it.Usuario)
                .WithMany(u => u.ItemTiposCriados)
                .HasForeignKey(it => it.UsuarioId)
                .IsRequired();
            modelBuilder.Entity<Pericia>()
                .HasOne(pt => pt.Usuario)
                .WithMany(u => u.PericiaTiposCriados)
                .HasForeignKey(pt => pt.UsuarioId)
                .IsRequired();
            modelBuilder.Entity<Vantagens>()
                .HasOne(v => v.Usuario)
                .WithMany(u => u.VantagensCriadas)
                .HasForeignKey(v => v.UsuarioId)
                .IsRequired();
            modelBuilder.Entity<Desvantagens>()
                .HasOne(d => d.Usuario)
                .WithMany(u => u.DesvantagensCriadas)
                .HasForeignKey(d => d.UsuarioId)
                .IsRequired();
            modelBuilder.Entity<Origem>()
                .HasOne(o => o.Usuario)
                .WithMany(u => u.OrigensCriadas)
                .HasForeignKey(o => o.UsuarioId)
                .IsRequired();
            modelBuilder.Entity<Classe>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.ClassesCriadas)
                .HasForeignKey(c => c.UsuarioId)
                .IsRequired();
            modelBuilder.Entity<VarianteRacial>()
                .HasOne(vr => vr.Usuario)
                .WithMany(u => u.VariantesRaciaisCriadas)
                .HasForeignKey(vr => vr.UsuarioId)
                .IsRequired();

            // --- CONFIGURAÇÃO DE COMPARTILHAMENTO VIA CAMPANHA ---

            // Usuario para Campanha (Many-to-Many através de UsuarioCampanha)
            // Um usuário pode participar de várias campanhas, e uma campanha pode ter vários usuários.
            modelBuilder.Entity<UsuarioCampanha>()
                .HasKey(uc => new { uc.UsuarioId, uc.CampanhaId });

            modelBuilder.Entity<UsuarioCampanha>()
                .HasOne(uc => uc.Usuario)
                .WithMany(u => u.UsuarioCampanhas)
                .HasForeignKey(uc => uc.UsuarioId);

            modelBuilder.Entity<UsuarioCampanha>()
                .HasOne(uc => uc.Campanha)
                .WithMany(c => c.UsuarioCampanhas)
                .HasForeignKey(uc => uc.CampanhaId);

            // Personagem para Campanha (Many-to-Many através de PersonagemCampanha)
            // Um personagem pode estar em várias campanhas, e uma campanha pode ter vários personagens.
            modelBuilder.Entity<PersonagemCampanha>()
                .HasKey(pc => new { pc.PersonagemId, pc.CampanhaId });

            modelBuilder.Entity<PersonagemCampanha>()
                .HasOne(pc => pc.Personagem)
                .WithMany(p => p.PersonagemCampanhas)
                .HasForeignKey(pc => pc.PersonagemId);

            modelBuilder.Entity<PersonagemCampanha>()
                .HasOne(pc => pc.Campanha)
                .WithMany(c => c.PersonagemCampanhas)
                .HasForeignKey(pc => pc.CampanhaId);

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