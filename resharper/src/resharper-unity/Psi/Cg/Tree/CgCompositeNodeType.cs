﻿using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Unity.Psi.Cg.Tree
{
    public abstract class CgCompositeNodeType : CompositeNodeType
    {
        protected CgCompositeNodeType(string s, int index)
            : base(s, index)
        {
        }
    }
}