using System;
using System.Diagnostics;

namespace Baracuda.Tools
{
    [Conditional("UNITY_EDITOR")]
    public class ExitFoldoutAttribute : Attribute
    {
    }
}