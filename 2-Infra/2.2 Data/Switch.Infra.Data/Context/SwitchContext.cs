using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Identificacao> Identificacao { get; set; }
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<InstituicaoEnsino> InstituicoesEnsino { get; set; }
        public DbSet<LocalTrabalho> LocaisTrabalho { get; set; }
        public DbSet<ProcurandoPor> ProcurandoPor { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Usuario>(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration<Amigo>(new AmigoConfiguration());
            modelBuilder.ApplyConfiguration<Comentario>(new ComentarioConfiguration());
            modelBuilder.ApplyConfiguration<InstituicaoEnsino>(new InstituicaoEnsinoConfiguration());
            modelBuilder.ApplyConfiguration<LocalTrabalho>(new LocalTrabalhoConfiguration());
            modelBuilder.ApplyConfiguration<StatusRelacionamento>(new StatusRelacionamentoConfiguration());
            modelBuilder.ApplyConfiguration<ProcurandoPor>(new ProcurandoPorConfiguration());

            modelBuilder.ApplyConfiguration<Postagem>(new PostagemConfiguration());
            modelBuilder.ApplyConfiguration<Grupo>(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration<UsuarioGrupo>(new UsuaruiGrupoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
