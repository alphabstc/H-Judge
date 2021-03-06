﻿using System.Collections.Generic;
using hjudge.Core;

namespace hjudge.WebHost.Models.Judge
{
    public class SubmitModel
    {
        public int ProblemId { get; set; }
        public int ContestId { get; set; }
        public int GroupId { get; set; }
        public string Language { get; set; } = string.Empty;
        public List<Source> Content { get; set; } = new List<Source>();
    }
}
