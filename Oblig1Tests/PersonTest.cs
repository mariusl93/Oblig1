using NUnit.Framework;
using Oblig_1;

namespace Oblig1Tests
{
    public class PersonTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() {Id = 23, FirstName = "Per"},
                Mother = new Person() {Id = 29, FirstName = "Lise"},
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        
        [Test]
        public void TestSomeFields()
        {
            var p = new Person
            {
                Id = 25,
                FirstName = "Robert",
                BirthYear = 1993
                

            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Robert (Id=25) Født: 1993";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}




/*Hvis ingen av feltene er fylt ut, skal den samme metoden returnere dette:

public void TestNoFields()
{
    var p = new Person
    {
        Id = 1,
    };

    var actualDescription = p.GetDescription();
    var expectedDescription = "(Id=1)";

    Assert.AreEqual(expectedDescription, actualDescription);
}

Lag selv en test til hvor noen felt (i tillegg til Id) er satt men ikke alle.*/ 