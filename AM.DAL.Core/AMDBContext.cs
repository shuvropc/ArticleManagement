﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;

namespace AM.DAL.Core
{
    public class AMDBContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public AMDBContext()
        {

        }
        public AMDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public AMDBContext(DbContextOptions<AMDBContext> options)
            : base(options)
        {
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DBConnection"));
            }
        }

        public object Query<T>(string v)
        {
            throw new NotImplementedException();
        }
    }
}
