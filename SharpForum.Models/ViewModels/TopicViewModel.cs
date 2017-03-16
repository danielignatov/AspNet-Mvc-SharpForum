﻿namespace SharpForum.Models.ViewModels
{
    using System;

    public class TopicViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public bool IsSticky { get; set; }

        public bool IsLocked { get; set; }

        public DateTime PublishDate { get; set; }
    }
}