namespace WebApp.WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// 
    /// </summary>
    [Table("UserInfo")]
    public partial class UserInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string UserPass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? RegTime { get; set; }
    }
}
