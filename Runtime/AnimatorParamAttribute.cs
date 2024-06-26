﻿using System;
using UnityEngine;

namespace Baracuda.Tools
{
    [AttributeUsage(AttributeTargets.Field)]
    public class AnimatorParamAttribute : PropertyAttribute
    {
        public readonly string AnimatorName;
        public readonly AnimatorControllerParameterType? ParameterType;

        public AnimatorParamAttribute(string animatorName, AnimatorControllerParameterType parameterType)
        {
            AnimatorName = animatorName;
            ParameterType = parameterType;
        }

        public AnimatorParamAttribute(string animatorName)
        {
            AnimatorName = animatorName;
            ParameterType = null;
        }
    }
}