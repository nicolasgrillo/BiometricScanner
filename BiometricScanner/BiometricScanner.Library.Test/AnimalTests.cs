using BiometricScanner.Library.Interfaces;
using BiometricScanner.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiometricScanner.Library.Test
{
    [TestFixture]
    public class AnimalTests
    {
        private Horse _horse;
        private Shark _shark;
        private Human _human;
        private Robot _robot;

        [SetUp]
        protected void SetUp()
        {
            _horse = new Horse(1, "American");
            _shark = new Shark(2, "Great White");
            _human = new Human(3, "Jason");
            _robot = new Robot(4, "R2D2");
        }

        [Test]
        public void Horse_Should_Eat()
        {
            //Arrange
            string expected = "Eating grass...";

            //Act
            var result = _horse.Eat();

            //Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Horse_Should_Walk()
        {
            //Arrange
            string expected = "Galloping...";

            //Act
            var result = _horse.Walk();

            //Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Shark_Should_Eat()
        {
            //Arrange
            string expected = "Eating small fish...";

            //Act
            var result = _shark.Eat();

            //Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Horse_Should_Always_Eat()
        {
            //Arrange
            string expected = "Eating grass...";
            List <IAnimal> animals = new List<IAnimal> { _shark, _horse };

            ///Act
            var firstResult = _horse.Eat();

            var listResults = new List<string>();

            foreach (var animal in animals) {
                listResults.Add(animal.Eat());
            }

            //Assert
            Assert.AreEqual(expected, firstResult);
            Assert.That(listResults, Has.Member(expected));
        }

    }
}
