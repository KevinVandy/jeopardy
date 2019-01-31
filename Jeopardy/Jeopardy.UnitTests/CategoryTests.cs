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
        public void SetCategorySubtitle_SetNull_ReturnBlank()
        {
            Category category = new Category();

            category.Subtitle = "";

            Assert.AreEqual(category.Subtitle, " ");
        }
    }
}
