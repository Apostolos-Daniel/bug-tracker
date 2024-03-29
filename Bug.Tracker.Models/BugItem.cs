﻿using Bug.Tracker.Models.Enums;
using System;
using System.Collections.Generic;

namespace Bug.Tracker.Models
{
    public class BugItem : IRecordWithGuid
    {
        public BugItem()
        {
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
                DateCreated = DateTime.Now;
                AssignedTo = "Kenneth";
                Status = BugStatus.open;
            }
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string AssignedTo { get; set; }
        public BugStatus Status { get; set; }

        public IEnumerable<string> Values => new List<string> { Title, Description, DateCreated.ToString(), AssignedTo, Status.ToString() };

        public Guid Id { get; set; }
    }
}