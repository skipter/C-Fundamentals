namespace DatabaseTests
{
    using _01.Database;
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class DBTests
    {

        private const int ArraySize = 16;
        private const int InitialArrayInedx = -1;

        [Test]
        public void EmptyConstructorShoudInitData()
        {
            Database db = new Database(); //we call empty constructor

            Type type = typeof(Database);

            var field = (int[])type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "data")
                .GetValue(db);

            var lenght = field.Length;

            Assert.That(lenght, Is.EqualTo(ArraySize));

        }

        [Test]
        public void EmptyConstructorShoudInitIndexToMinusOne()
        {
            Database db = new Database(); //we call empty constructor

            Type type = typeof(Database);

            var indexValue = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(db);


            Assert.That(indexValue, Is.EqualTo(InitialArrayInedx), "Internal Array is null.");

        }

        [Test]
        public void CtorShouldThrowExeptionInvalidOperationExeptionWithKargerArray()
        {
            int[] arr = new int[ArraySize + 1];

            Assert.Throws<InvalidOperationException>(() => new Database(arr));
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 13 })]
        [TestCase(new int[] { 13, 42, 69 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void CtorShouldSetINdexCorrectly(int[] values)
        {
            Database db = new Database(values);

            int expectedIndex = values.Length - 1;

            Type type = typeof(Database);

            var indexValue = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(db);

            Assert.That(indexValue, Is.EqualTo(expectedIndex));
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
        public void AddShouldIncreaseCorrectly(int[] values)
        {
            Database db = new Database(values);

            Type type = typeof(Database);

            db.Add(16);

            var index = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(db);

            int expectedIndex = values.Length;

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        public void AddWhenDatabaseIsFullShouldThrowInvalidOperationExeption()
        {
            int[] arr = new int[16];
            Database db = new Database(arr);

            Assert.Throws<InvalidOperationException>(() => db.Add(1));
        }

        [Test]
        public void RemoveShouldDecreaseIndex()
        {
            int[] arr = new int[10];

            Database db = new Database(arr);

            Type type = typeof(Database);

            db.Remove();

            var index = (int)type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(db);

            int expectedIndex = arr.Length - 2;

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        public void RemoveFromEmptyDatabaseShouldThrowInvalidOperationExeption()
        {
            Database db = new Database();

            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }
    }
}
