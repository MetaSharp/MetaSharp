using NUnit.Framework;
using MetaSharp.TestEditor;


namespace MetaSharp.TestEditor.Tests
{
    public class AddAnswerTest
    {

        [Test]
        public void TestAnswer()
        {
            Assert.AreEqual(42, Answers.LifeTheUniverseAndEverything);
        }
    }
}