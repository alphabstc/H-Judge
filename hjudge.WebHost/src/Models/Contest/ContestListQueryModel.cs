﻿using System.Collections.Generic;

namespace hjudge.WebHost.Models.Contest
{

    public class ContestListQueryModel
    {
        public class ContestFilter
        {
            public int Id { get; set; } = 0;
            public string Name { get; set; } = string.Empty;
            public List<int> Status { get; set; } = new List<int>();
        }
        public int Start { get; set; }
        public int StartId { get; set; }
        public int Count { get; set; }
        public bool RequireTotalCount { get; set; }
        public int GroupId { get; set; }
        public ContestFilter Filter { get; set; } = new ContestFilter();
    }

}
