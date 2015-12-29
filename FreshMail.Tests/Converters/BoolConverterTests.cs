using System;
using FreshMail.Converters;
using Newtonsoft.Json;
using NUnit.Framework;

namespace FreshMail.Tests.Converters
{
    [TestFixture]
    public class BoolConverterTests
    {
        [Test]
        public void True_Is_Serialized_To_One()
        {
            string serializedObject = JsonConvert.SerializeObject(true, new BoolConverter());
            Assert.That(serializedObject, Is.EqualTo("1"));
        }

        [Test]
        public void False_Is_Serialized_To_Zero()
        {
            string serializedObject = JsonConvert.SerializeObject(false, new BoolConverter());
            Assert.That(serializedObject, Is.EqualTo("0"));
        }

        [Test]
        public void One_Is_Deserialized_To_True()
        {
            bool deserializeObject = JsonConvert.DeserializeObject<bool>("1", new BoolConverter());
            Assert.That(deserializeObject, Is.True);
        }

        [Test]
        public void Zero_Is_Deserialized_To_False()
        {
            bool deserializeObject = JsonConvert.DeserializeObject<bool>("0", new BoolConverter());
            Assert.That(deserializeObject, Is.False);
        }

        [Test]
        public void Incorrect_Value_Exception_Is_Thrown()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => JsonConvert.DeserializeObject<bool>("2", new BoolConverter()));
        }
    }
}