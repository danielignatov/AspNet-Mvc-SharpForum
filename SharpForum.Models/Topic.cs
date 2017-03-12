﻿namespace SharpForum.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Topic
    {
        #region Constructors
        public Topic()
        {
            this.Replies = new HashSet<Reply>();
        }
        #endregion

        #region Properties
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public virtual ICollection<Reply> Replies { get; set; }
        #endregion
    }
}