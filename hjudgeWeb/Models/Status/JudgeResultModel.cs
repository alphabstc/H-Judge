﻿using hjudgeCore;
using System;

namespace hjudgeWeb.Models.Status
{
    public class JudgeResultModel : ResultModel
    {
        public int Id { get; set; }
        public DateTime RawJudgeTime { get; set; }
        public string JudgeTime => $"{RawJudgeTime.ToShortDateString()} {RawJudgeTime.ToLongTimeString()}";
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int ProblemId { get; set; }
        public string ProblemName { get; set; }
        public int ContestId { get; set; }
        public string ContestName { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Language { get; set; }
        public int ResultType { get; set; }
        public string Result => Enum.GetName(typeof(ResultCode), ResultType).Replace("_", " ");
        public int RawType { get; set; }
        public string Type => RawType == 1 ? "提交代码" : "提交答案";
        public float FullScore { get; set; }
        public string Content { get; set; }
        public JudgeResult JudgeResult { get; set; }
    }
}
