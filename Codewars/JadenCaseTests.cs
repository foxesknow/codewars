using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Codewars;

[TestFixture]
public class JadenCaseTest
{
    [Test]
    public void FixedTest()
    {
        Assert.That("How can mirrors be real if our eyes aren't real".ToJadenCase(), Is.EqualTo("How Can Mirrors Be Real If Our Eyes Aren't Real"), "Strings didn't match.");
    }

    [Test]
    [TestCase("hello", "Hello")]
    [TestCase(" hello", " Hello")]
    [TestCase("  hello  ", "  Hello  ")]
    public void SingleWord(string value, string expected)
    {
        Assert.That(value.ToJadenCase(), Is.EqualTo(expected));
    }

    [Test]
    [TestCase("hello world", "Hello World")]
    public void TwoWords(string value, string expected)
    {
        Assert.That(value.ToJadenCase(), Is.EqualTo(expected));
    }
}
