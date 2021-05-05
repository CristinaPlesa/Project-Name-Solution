using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName;

namespace ProjectName.Tests 
{
  [TestClass]
  public class ClassNameTests
  {
    // Test methods go here
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for a test, instantiating new classes, etc.
      Assert.AreEqual(10, (5 + 5));
    }
  }
}