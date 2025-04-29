using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backend.Model;

public partial class ExemploContext : DbContext
{
    public ExemploContext()
    {
    }

    public ExemploContext(DbContextOptions<ExemploContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Anotacao> Anotacaos { get; set; }

    public virtual DbSet<Nota> Notas { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-M0B9092\\SQLEXPRESS;Initial Catalog=Exemplo;Integrated Security=SSPI;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Anotacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Anotacao__3214EC070ECC1E4E");

            entity.ToTable("Anotacao");

            entity.Property(e => e.Conteudo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Anotacaos)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__Anotacao__Usuari__3F466844");
        });

        modelBuilder.Entity<Nota>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Notas__3214EC0736CEE1A5");

            entity.Property(e => e.Nota1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Nota");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Nota)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__Notas__UsuarioID__3C69FB99");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Token__3214EC27352585FD");

            entity.ToTable("Token");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Value)
                .IsRequired()
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.Tokens)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Token__UserID__398D8EEE");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC077B338B53");

            entity.ToTable("Usuario");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
