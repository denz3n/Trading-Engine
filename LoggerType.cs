﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Logging
{
    public enum LoggerType
    {
        Text,
        Database, //Not implementing the rest yet
        Trace,
        Console,
    }
}
