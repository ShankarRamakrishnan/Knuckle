using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace Knuckle.Javascript.Tests
{
    public class LexicalAnalyzerTest
    {
        [Fact]
        public void ShouldReadALineOfJSCodeAndFormSyntaxTree()
        {
            var x = new LexicalAnalyzer();
            var syntaxTree = x.Lex("var x = 5 ; ");
            Assert.NotNull(syntaxTree);
        }
    }
}
