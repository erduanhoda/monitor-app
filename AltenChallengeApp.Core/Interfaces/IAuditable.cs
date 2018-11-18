﻿using System;

namespace AltenChallengeApp.Core.Interfaces
{
    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }
        Guid CreatedBy { get; set; }
        DateTime UpdatedAt { get; set; }
        Guid UpdatedBy { get; set; }
        bool IsDeleted { get; set; }
    }
}
