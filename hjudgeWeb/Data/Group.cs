﻿using hjudgeWeb.Data.Identity;
using System;
using System.Collections.Generic;

namespace hjudgeWeb.Data
{
    public partial class Group
    {
        public Group()
        {
            GroupContestConfig = new HashSet<GroupContestConfig>();
            GroupJoin = new HashSet<GroupJoin>();
            Judge = new HashSet<Judge>();
            VotesRecord = new HashSet<VotesRecord>();
            Discussion = new HashSet<Discussion>();
            Announcement = new HashSet<Announcement>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsPrivate { get; set; }
        public string AdditionalInfo { get; set; }

        public UserInfo UserInfo { get; set; }

        public ICollection<GroupContestConfig> GroupContestConfig { get; set; }
        public ICollection<GroupJoin> GroupJoin { get; set; }
        public ICollection<Judge> Judge { get; set; }
        public ICollection<VotesRecord> VotesRecord { get; set; }
        public ICollection<Discussion> Discussion { get; set; }
        public ICollection<Announcement> Announcement { get; set; }
    }
}