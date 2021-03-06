﻿using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels.Specialized
{
    public class AddSpecializedViewModel
    {
        #region Properties

        /// <summary>
        /// Name of specialized
        /// </summary>
        [Required]
        public string Name { get; set; }

        #endregion
    }
}