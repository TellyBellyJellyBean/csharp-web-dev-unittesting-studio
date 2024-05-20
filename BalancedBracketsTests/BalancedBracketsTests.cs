namespace BalancedBracketsTests;
using BalancedBrackets;

[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.
    [TestMethod]
   public void OnlyBracketsReturnsTrue() 
   {
      Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
   }

    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(true, true);
    }

    [TestMethod]

    public void EmptyStringReturnTrue()
    {
        //Arrange
        string testStr = "";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

        //Assert
        Assert.IsTrue(actual);
    }
    [TestMethod]

    public void BracketsWithinStringReturnTrue()
    {
        //Arrange
        string testStr = "Launch[Code]";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);
    }
    [TestMethod]

    public void BracketsClosedBeforeStringReturnTrue()
    {
        //Arrange
        string testStr = "[]LaunchCode";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);
    }
    [TestMethod]

    public void OnlyOpenBracketWithStringReturnsFalse()
    {
        //Arrange
        string testStr = "[LaunchCode";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsFalse(actual);
    }
    [TestMethod]

    public void OnlyOpenBracketReturnsFalse()
    {
        //Arrange
        string testStr = "[";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsFalse(actual);
    }
    public void OnlyClosedBracketReturnsFalse()
    {
        //Arrange
        string testStr = "]";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsFalse(actual);
    }
    [TestMethod]

    public void BracketsUnclosedReturnFalse()
    {
        //Arrange
        string testStr = "][";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsFalse(actual);
    }

    [TestMethod]

    public void BracketsAroundBracketsReturnTrue()
    {
        //Arrange
        string testStr = "[[]]";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);
    }
    [TestMethod]

    public void UnclosedBracketsAroundBracketsReturnFalse()
    {
        //Arrange
        string testStr = "][][";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsFalse(actual);
    }
    [TestMethod]

    public void BracketsAroundStringReturnTrue()
    {
        //Arrange
        string testStr = "[LaunchCode]";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);
    }
    // [TestMethod]

    // public void BracketsAroundStringReturnTrue()
    // {
    //     //Arrange
    //     string testStr = "[LaunchCode]";
    //     //Act
    //     bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
    //     //Assert
    //     Assert.IsTrue(actual);
    // }

}
