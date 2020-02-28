using System;
using System.Collections.Generic;
using System.Text;

namespace MetaSharp
{
    /// <summary>
    /// Responsible for handling how <see cref="ICodeGenerator"/>s should be called.
    /// </summary>
    public interface IGeneratorService
    {
        bool ExecuteCodeGenerators();
    }
}
