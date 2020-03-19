using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        public sealed class Mark
        {
            public string Subject { get; set; }

            public double Value { get; set; }

            public Mark(string subject, double value)
            {
                Subject = subject;
                Value = value;
            }

    }
}
