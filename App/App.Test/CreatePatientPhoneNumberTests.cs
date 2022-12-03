using NUnit.Framework;
using System.Text.RegularExpressions;

namespace App.Test
{
    [TestFixture]
    public sealed class IsPhoneNumerValidTests
    {
        [TestCase(null)]
        public void IsPhoneNumberValid_PhoneNumberIsNull_ReturnTrue(string phoneNumber)
        {
            Assert.IsNull(phoneNumber);
        }

        [TestCase("")]
        [TestCase("45454545")]
        [TestCase("1111111111")]
        [TestCase("12345678a")]
        [TestCase("123123,12")]
        public void PhoneNumberValid_PhoneNumberIsNotValid_ReturnFalse(string phoneNumber)
        {
            Regex regexPhoneNumber = new Regex(@"^[0-9]{9}$");

            bool isValid = regexPhoneNumber.IsMatch(phoneNumber);

            Assert.IsFalse(isValid);
        }

        [TestCase("456445566")]
        [TestCase("000000000")]
        [TestCase("999999999")]
        public void PhoneNumberValid_PhoneNumberIsValid_ReturnTrue(string phoneNumber)
        {
            Regex regexPhoneNumber = new Regex(@"^[0-9]{9}$");

            bool isValid = regexPhoneNumber.IsMatch(phoneNumber);

            Assert.IsTrue(isValid);
        }
    }
}
