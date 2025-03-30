using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Codewars;

[TestFixture]
public class DetectPangramTests
{
    [Test]
    public void SampleTests() 
    {
      Assert.That(DetectPangram.IsPangram("The quick brown fox jumps over the lazy dog."), Is.True);
    }

    [Test]
    [TestCase("hello")]
    [TestCase("abcdefghijklmnopqrstuvwxy")]
    public void NotPangram(string value) 
    {
      Assert.That(DetectPangram.IsPangram(value), Is.False);
    }

    [Test]
    [TestCase("abcdefghijklmnopqrstuvwxyz")]
    public void IsPangram(string value) 
    {
      Assert.That(DetectPangram.IsPangram(value), Is.True);
    }
}
