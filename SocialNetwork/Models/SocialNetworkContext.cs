using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SocialNetwork.Models;

public partial class SocialNetworkContext : DbContext
{
    public SocialNetworkContext()
    {
    }

    public SocialNetworkContext(DbContextOptions<SocialNetworkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-FKDF8KP\\SQLSERVR;database=SocialNetwork;trusted_connection=true;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasIndex(e => e.MessageId, "IX_Feedbacks_MessageId");

            entity.HasIndex(e => e.UserId, "IX_Feedbacks_UserId");

            entity.HasOne(d => d.Message).WithMany(p => p.Feedbacks).HasForeignKey(d => d.MessageId);

            entity.HasOne(d => d.User).WithMany(p => p.Feedbacks).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasIndex(e => e.TopicId, "IX_Messages_TopicId");

            entity.HasIndex(e => e.UserId, "IX_Messages_UserId");

            entity.HasOne(d => d.Topic).WithMany(p => p.Messages).HasForeignKey(d => d.TopicId);

            entity.HasOne(d => d.User).WithMany(p => p.Messages).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Topics_CategoryId");

            entity.HasOne(d => d.Category).WithMany(p => p.Topics).HasForeignKey(d => d.CategoryId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
