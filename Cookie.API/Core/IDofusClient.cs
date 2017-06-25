﻿using System;
using Cookie.API.Protocol;
using Cookie.Core;

namespace Cookie.API.Core
{
    public interface IDofusClient
    {
        void Register(Type type);
        void Send(NetworkMessage message);
        void Log(string text, LogMessageType type = LogMessageType.Default);
    }
}