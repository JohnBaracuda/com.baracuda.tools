﻿using Sirenix.OdinInspector;
using System;

namespace Baracuda.Tools
{
    [ReadOnly]
    [ShowInInspector]
    [IncludeMyAttributes]
    public class ReadonlyInspectorAttribute : Attribute
    {
    }

    [ReadOnly]
    [ShowInInspector]
    [IncludeMyAttributes]
    public class DebugAttribute : Attribute
    {
    }
}