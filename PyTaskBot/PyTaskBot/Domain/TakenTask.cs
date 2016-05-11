﻿using System;

namespace PyTaskBot.Domain
{
    public class TakenTask
    {
        public Student Student { get; set; }
        public DateTime TakenDate { get; set; }
        public DateTime LastSubmitDate { get; set; }
        public int Points { get; set; }
        public string Comment { get; set; }
        public StudyYear StudyYear { get; set; }
    }
}