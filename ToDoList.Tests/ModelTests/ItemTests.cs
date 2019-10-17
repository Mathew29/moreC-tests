using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      string result = newItem.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
      public void SetDescription_SetDescription_String()
      {
        string description = "Walk the dog.";
        Item newItem = new Item(description);

        string updatedDescription = "Do the dishes";
        newItem.Description = updatedDescription;
        string result = newItem.Description;

        Assert.AreEqual(updatedDescription, result);
      }

  }
}
