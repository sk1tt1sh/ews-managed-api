﻿/*
 * Exchange Web Services Managed API
 *
 * Copyright (c) Microsoft Corporation
 * All rights reserved.
 *
 * MIT License
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Exchange.WebServices.Data.Misc
{
    class TransitionTime
    {
        public int Day { get; private set; }
        public DayOfWeek DayOfWeek { get; private set; }
        public bool IsFixedDateRule { get; private set; }
        public int Month { get; private set; }
        public DateTime TimeOfDay { get; private set; }
        public int Week { get; private set; }

        public static TransitionTime CreateFixedDateRule(
            DateTime timeOfDay,
            int month,
            int day)
        {
            TransitionTime transitionTime = new TransitionTime();
            transitionTime.IsFixedDateRule = true;
            transitionTime.TimeOfDay = timeOfDay;
            transitionTime.Month = month;
            transitionTime.Day = day;
            return transitionTime;
        }

        public static TransitionTime CreateFloatingDateRule(
            DateTime timeOfDay,
            int month,
            int week,
            DayOfWeek dayOfWeek)
        {
            TransitionTime transitionTime = new TransitionTime();
            transitionTime.IsFixedDateRule = false;
            transitionTime.TimeOfDay = timeOfDay;
            transitionTime.Month = month;
            transitionTime.Week = week;
            transitionTime.DayOfWeek = dayOfWeek;
            return transitionTime;
        }
    }
}
