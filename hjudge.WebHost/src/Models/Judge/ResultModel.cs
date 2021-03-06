using System;
using System.Collections.Generic;
using hjudge.Core;

namespace hjudge.WebHost.Models.Judge
{
    public class ResultModel
    {
        public int ResultId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public int ProblemId { get; set; }
        public string ProblemName { get; set; } = string.Empty;
        public int? ContestId { get; set; }
        public string? ContestName { get; set; }
        public int? GroupId { get; set; }
        public string? GroupName { get; set; }
        public int ResultType { get; set; }
        public string Result => Enum.GetName(typeof(ResultCode), ResultType)?.Replace("_", " ") ?? "Unknown Error";
        public List<Source> Content { get; set; } = new List<Source>();
        public int Type { get; set; }
        public DateTime Time { get; set; }
        public int ResultDisplayType { get; set; }
        public string? Language { get; set; }
        public JudgeResult JudgeResult { get; set; } = new JudgeResult();
    }
}