﻿using System;
using System.Collections.Generic;

namespace FarmTracker_services.Models.DB
{
    public partial class EntityDetails
    {
        public Guid Duid { get; set; }
        public Guid Euid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? RemainderDate { get; set; }
        public bool? RemainderCompletedFlag { get; set; }
        public DateTime? RemainderCompletedDate { get; set; }
        public Guid? RemainderCompletedByUuid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid CreatedByUuid { get; set; }
        public bool DeletedFlag { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? DeletedByUuid { get; set; }

        public virtual Users CreatedByUu { get; set; }
        public virtual Users DeletedByUu { get; set; }
        public virtual EntityOfFp Eu { get; set; }
    }
}
