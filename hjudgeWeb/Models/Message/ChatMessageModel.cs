﻿using System;

namespace hjudgeWeb.Models.Message
{
    public class ChatMessageModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime RawSendTime { get; set; }
        public string SendTime => $"{RawSendTime.ToShortDateString()} {RawSendTime.ToLongTimeString()}";
    }
}