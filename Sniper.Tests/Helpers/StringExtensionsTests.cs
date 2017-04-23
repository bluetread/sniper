using System;
using Xunit;

namespace Sniper.Tests.Helpers
{
    public class StringExtensionsTests
    {
        public class TheToRubyCaseMethod
        {
            [Theory]
            [InlineData("Id", "id")]
            [InlineData("FirstName", "first_name")]
            public void ConvertsPascalToRuby(string source, string expected)
            {
                Assert.Equal(expected, source.ToRubyCase());
            }

            [Fact]
            public void EnsuresArgumentsNotNullOrEmpty()
            {
                string nullString = null;
                Assert.Throws<ArgumentNullException>(() => nullString.ToRubyCase());
                Assert.Throws<ArgumentException>(() => "".ToRubyCase());
            }
        }

        public class TheExpandUriTemplateMethod
        {
            [Theory]
            [InlineData("https://host.com/path?name=other", "https://host.com/path?name=other")]
            [InlineData("https://host.com/path?name=example name.txt", "https://host.com/path{?name}")]
            [InlineData("https://host.com/path", "https://host.com/path{?other}")]
            [InlineData("https://host.com/path?name=example name.txt&label=labeltext", "https://host.com/path{?name,label}")]
            [InlineData("https://host.com/path?name=example name.txt&label=labeltext", "https://host.com/path{?name,label,other}")]
            public void ExpandsUriTemplates(string expected, string template)
            {
                Assert.Equal(expected, template.ExpandUriTemplate(new { name = "example name.txt", label = "labeltext" }).ToString());
            }
        }
    }
}
