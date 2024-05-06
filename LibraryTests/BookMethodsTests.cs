using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    [TestClass]
    public class BookMethodsTests
    {
        [TestMethod]
        public void PageTextExceeds300()
        {
          
            int result  = Library.Pages.PageWatcher(330);
                //The desired results and the actual results are compared.

                Assert.AreEqual(330, result);

            
        }
        [TestMethod]
        public void PageTextNotExceeds300()
        {
            int result  = Library.Pages.PageWatcher(250);
                //The desired results and the actual results are compared.

                Assert.AreEqual(250, result);

            
        }
    }
}