﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UnityIoC
{
    [Flags]
    public enum When
    {
        BeforeResolve = 1 << 0,
        AfterResolve = 1 << 1,
        BeforeUpdate = 1 << 2,
        AfterUpdate = 1 << 3,
        BeforeDelete = 1 << 4,
        AfterDelete = 1 << 5,
        All = BeforeResolve | AfterResolve| BeforeUpdate | AfterUpdate | BeforeDelete | AfterDelete
    }

    public class ValidState
    {
        public delegate bool Predicator(ref object obj);

        public Predicator predicator;
        public string message;
        public When when;
    }
}