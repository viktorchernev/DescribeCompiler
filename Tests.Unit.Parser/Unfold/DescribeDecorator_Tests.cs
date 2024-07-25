using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Parser
{
    [TestFixture]
    public class DescribeDecorator_Tests
    {
        [Test]
        public void DescribeDecorator_DefaultValues_ShouldBeEmpty()
        {
            // Arrange
            var decorator = new DescribeDecorator();

            // Act & Assert
            Assert.AreEqual(default(string), decorator.Name, "Name should be default value (empty string)");
            Assert.IsNull(decorator.Value, "Value should be null by default");
            Assert.IsNull(decorator.Category, "Category should be null by default");
        }

        [Test]
        public void DescribeDecorator_SetProperties_ShouldReturnExpectedValues()
        {
            // Arrange
            var decorator = new DescribeDecorator();
            var name = "DecoratorName";
            var value = "DecoratorValue";
            var category = "DecoratorCategory";

            // Act
            decorator.Name = name;
            decorator.Value = value;
            decorator.Category = category;

            // Assert
            Assert.AreEqual(name, decorator.Name, "Name should return the set value");
            Assert.AreEqual(value, decorator.Value, "Value should return the set value");
            Assert.AreEqual(category, decorator.Category, "Category should return the set value");
        }
    }
}
