﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindMurmur.Domain.Messages
{
    public class EEGDataCommand
    {
        public string CommandId { get; set; }
        public List<double> Values { get; set; }
    }

}
