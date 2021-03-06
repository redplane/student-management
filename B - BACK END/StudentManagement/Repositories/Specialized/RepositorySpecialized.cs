﻿using System.Data.Entity;
using StudentManagement.Interfaces.Repositories.Specialized;

namespace StudentManagement.Repositories.Specialized
{
    public class RepositorySpecialized : ParentRepository<Database.Models.Entities.Specialized>,
        IRepositorySpecialized
    {
        #region Constructor

        /// <inheritdoc />
        /// <summary>
        ///     Initiate repository with injectors.
        /// </summary>
        /// <param name="dbContext"></param>
        public RepositorySpecialized(DbContext dbContext) : base(dbContext)
        {
        }

        #endregion
    }
}