using Sirenix.OdinInspector;
using System;

namespace Baracuda.Tools
{
    [EnableIf("@UnityEngine.Application.isPlaying")]
    [Button]
    [IncludeMyAttributes]
    public class RuntimeButtonAttribute : Attribute
    {
    }
}