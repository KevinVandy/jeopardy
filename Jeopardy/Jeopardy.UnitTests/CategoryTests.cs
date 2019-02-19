using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jeopardy.UnitTests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void SetCategoryIndex_Set0_Return0()
        {
            int index = 0;
            Category category = new Category();

            category.Index = index;

            Assert.AreEqual(category.Index, index);
        }

        [TestMethod]
        public void SetCategoryIndex_Set2_Return2()
        {
            int index = 2;
            Category category = new Category();

            category.Index = index;

            Assert.AreEqual(category.Index, index);
        }

        [TestMethod]
        public void SetCategoryIndex_Set7_Return7()
        {
            int index = 7;
            Category category = new Category();

            category.Index = index;

            Assert.AreEqual(category.Index, index);
        }

        [TestMethod]
        public void SetCategoryIndex_Set8_Return0()
        {
            int index = 8;
            Category category = new Category();

            category.Index = index;

            Assert.AreEqual(category.Index, 0);
        }

        [TestMethod]
        public void SetCategoryTitle_SetLength7_ReturnLength7()
        {
            Category category = new Category();

            category.Title = "MyTitle";

            Assert.AreEqual(category.Title, "MyTitle");
        }

        [TestMethod]
        public void SetCategoryTitle_SetLength1_ReturnLength1()
        {
            Category category = new Category();

            category.Title = "A";

            Assert.AreEqual(category.Title, "A");
        }

        [TestMethod]
        public void SetCategoryTitle_SetLength202_ReturnLength202()
        {
            Category category = new Category();

            category.Title = "Nature's first green is gold, her hardest hue to hold. Her early leaf's a flower, but only so an hour. Then leaf subsides to leaf, so Eden sank to grief. So dawn goes down to day, Nothing Gold Can Stay.";

            Assert.AreEqual(category.Title, "Nature's first green is gold, her hardest hue to hold. Her early leaf's a flower, but only so an hour. Then leaf subsides to leaf, so Eden sank to grief. So dawn goes down to day, Nothing Gold Can Stay.");
        }

        [TestMethod]
        public void SetCategoryTitle_SetNull_ReturnDefault()
        {
            Category category = new Category();

            category.Title = "";

            Assert.AreEqual(category.Title, " ");
        }

        [TestMethod]
        public void SetCategorySubtitle_SetLength25_ReturnLength25()
        {
            Category category = new Category();

            category.Subtitle = "This is a JoJo reference.";

            Assert.AreEqual(category.Subtitle, "This is a JoJo reference.");
        }

        [TestMethod]
        public void SetCategorySubtitle_SetLength1_ReturnLength1()
        {
            Category category = new Category();

            category.Subtitle = "B";

            Assert.AreEqual(category.Subtitle, "B");
        }

        [TestMethod]
        public void SetCategorySubtitle_SetNull_ReturnBlank()
        {
            Category category = new Category();

            category.Subtitle = "";

            Assert.AreEqual(category.Subtitle, " ");
        }

        [TestMethod]
        public void SetBlankCategory_ReturnBlank()
        {
            Category category = new Category();

            category.CreateBlankCategory(1, 0);

            Assert.AreEqual(category.Subtitle, "");
            Assert.AreEqual(category.Title, "Category 1");
        }




    }
}
