﻿using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels.Student
{
    public class AddStudentViewModel
    {
        #region Properties

        /// <summary>
        /// Username
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Fullname
        /// </summary>
        [Required]
        public string Fullname { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        [Required]
        public bool Gender { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Phone { get; set; }

        #endregion
    }
}