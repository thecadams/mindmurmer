﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindMurmur.Domain.Messages
{
    public class MeditationStateCommand
    {
        public string CommandId { get; set; }
        public Int32 State { get; set; }
    }

}
