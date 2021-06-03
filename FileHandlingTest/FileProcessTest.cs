using FileHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileHandlingTest
{
    [TestClass]
    public class FileProcessTest
    {
        #region Generic
        [TestMethod]
        public void FileNameDoesExists()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fileProcessCall;

            //Act
            fileProcessCall = fp.FileExists(@"d:\tec\test.txt");
            
            //Assert 
            Assert.IsTrue(fileProcessCall);
        }

        [TestMethod]
        public void FileNameDoesNotExists()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fileProcessCall;

            //Act
            fileProcessCall = fp.FileExists(@"d:\tec\testFalse.txt");
            
            //Assert 
            Assert.IsFalse(fileProcessCall);
        }

        [TestMethod]
        public void FileNameNullOrEmptyThorwsArgumentNullException()
        {
            //Arrange
            FileProcess fp = new FileProcess();

            //Act
            try
            {
                fp.FileExists("");
            }
            catch (System.ArgumentNullException)
            {
                //throw;
                return;
            }

            //Assert
            Assert.Fail("Call to FileExists did not throw an ArgumentException");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingAttribute()
        {
            //Arrange
            FileProcess fp = new FileProcess();

            //Act
            fp.FileExists("");

        }
        #endregion

        [TestMethod]
        public void FileContentEqual()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            string fileContent;
            string testString = "abekat";

            //Act
            fileContent = fp.FileContent(@"d:\tec\test.txt").Trim();

            //Assert 
            Assert.AreEqual(fileContent, testString);
        }

        [TestMethod]
        public void FileNotEmpty()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            string fileContent;
            string testString = "";

            //Act
            fileContent = fp.FileContent(@"d:\tec\test.txt").Trim();

            //Assert 
            Assert.AreNotEqual(fileContent, testString);
        }
    }
}
