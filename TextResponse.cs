﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc_server_Server
{
    public class TextResponse : IResponse<string>
    {
        public Status Status { get; set; }

        public string Message { get; set; }

        public TextResponse()
        {
            Status = Status.OK;
        }
    }
}
