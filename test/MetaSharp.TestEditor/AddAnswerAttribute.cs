using System;
using System.Collections.Generic;
using Cometary;

namespace MetaSharp.TestEditor
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    public sealed class AddAnswersAttribute : CometaryAttribute
    {
        /// <inheritdoc />
        public override IEnumerable<CompilationEditor> Initialize()
        {
            yield return new AddAnswersEditor();
        }
    }
}