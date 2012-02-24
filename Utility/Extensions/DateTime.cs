﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class DateTimeExtensions
    {
        public static DateTime ToDay(this DateTime container)
        {
            return new DateTime(container.Year, container.Month, container.Day);
        }
    }
}