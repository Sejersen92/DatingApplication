﻿using System;

namespace DatingApplication.Models
{
    public class Message
    {
        public int ID { get; set; }
        public User From { get; set; }
        public User To { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
    }
}