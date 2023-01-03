﻿using System;

namespace FilmDukkani.Models.Entities.Abstract
{
    public enum Status { Active = 1 , Modified = 2, Passive = 3}
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        private DateTime _createDate = DateTime.Now;

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get => _status; set => _status = value; }

        private Status _status = Status.Active;
    }
}