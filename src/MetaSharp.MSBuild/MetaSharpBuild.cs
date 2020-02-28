using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Build.Utilities;

namespace MetaSharp.MSBuild
{
    public sealed class MetaSharpBuild : Task
    {
        public override bool Execute()
        {
            Log.LogError("Hello from metasharp build task");

            return false;
        }
    }
}
