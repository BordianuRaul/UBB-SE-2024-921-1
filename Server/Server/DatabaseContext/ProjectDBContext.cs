﻿using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.DatabaseContext
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<Media> Medias { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<PostArchived> PostArchived { get; set; } = null!;
        public DbSet<PostSaved> PostSaved { get; set; } = null!;
        public DbSet<PostReported> PostReported { get; set; } = null!;
    }
}
