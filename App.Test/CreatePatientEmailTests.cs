using NUnit.Framework;
using System.Text.RegularExpressions;

namespace App.Test
{
    [TestFixture]
    public sealed class IsEmailValidTests
    {
        [TestCase(null)]
        public void IsEmailValid_EmailIsNull_ReturnTrue(string email)
        {
            Assert.IsNull(email);
        }

        [TestCase("")]
        [TestCase("jawp.pl")]
        [TestCase("jawp.@pl")]
        [TestCase("@@wp.pl")]
        [TestCase(",.pl")]
        public void IsEmailValid_EmailIsNotValid_ReturnFalse(string email)
        {
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9]*[@][a-zA-Z0-9]*[.][a-zA-Z0-9]*$");

            bool isValid = regexEmail.IsMatch(email);

            Assert.IsFalse(isValid);
        }

        [TestCase("ja@wp.pl")]
        [TestCase("ja1@onet.pl")]
        [TestCase("11ja@gmail.com")]
        public void IsEmailValid_EmailIsValid_ReturnTrue(string email)
        {
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9]*[@][a-zA-Z0-9]*[.][a-zA-Z0-9]*$");

            bool isValid = regexEmail.IsMatch(email);

            Assert.IsTrue(isValid);
        }
    }
}