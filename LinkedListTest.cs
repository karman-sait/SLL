// Name: Kiru and Karman, Date: 4/4/23, Program Description: Implementation of a linked list ADT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Tests
{
    public class LinkedListTest
    {
        private SLL list;

        [SetUp]
        public void Setup()
        {
            // Initializes the linked list
            list = new SLL();
        }

        [Test]
        public void TestEmptyLinkedList()
        {
            // Now checking if the linked list is empty initially
            Assert.IsTrue(list.IsEmpty());
            Assert.AreEqual(0, list.Count());
        }

        [Test]
        public void TestPrepend()
        {
            // Add given item to the beginning of the list
            list.AddFirst(new User(1, "John Doe", "john.doe@example.com", "password"));
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual(1, list.Count());
            Assert.AreEqual("John Doe", list.GetValue(0).Name);
        }

        [Test]
        public void TestAppend()
        {
            // Add another item to the end of the list
            list.AddLast(new User(2, "Jane Smith", "jane.smith@example.com", "password123"));
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual(1, list.Count());
            Assert.AreEqual("Jane Smith", list.GetValue(0).Name);
        }

        [Test]
        public void TestInsertAtIndex()
        {
            // Insert an item at a specific index
            list.AddFirst(new User(1, "John Doe", "john.doe@example.com", "password"));
            list.AddLast(new User(3, "David Brown", "david.brown@example.com", "password456"));
            list.Add(new User(2, "Jane Smith", "jane.smith@example.com", "password123"), 1);
            Assert.AreEqual(3, list.Count());
            Assert.AreEqual("Jane Smith", list.GetValue(1).Name);
        }

        [Test]
        public void TestReplace()
        {
            // Replace an item in the list
            list.AddFirst(new User(1, "John Doe", "john.doe@example.com", "password"));
            list.Replace(new User(1, "John Smith", "john.smith@example.com", "newpassword"), 0);
            Assert.AreEqual("John Smith", list.GetValue(0).Name);
        }

        [Test]
        public void TestDeleteFromBeginning()
        {
            // Remove an item from the beginning of the list
            list.AddFirst(new User(1, "John Doe", "john.doe@example.com", "password"));
            list.AddLast(new User(2, "Jane Smith", "jane.smith@example.com", "password123"));
            list.RemoveFirst();
            Assert.AreEqual(1, list.Count());
            Assert.AreEqual("Jane Smith", list.GetValue(0).Name);
        }

        [Test]
        public void TestDeleteFromEnd()
        {
            // Remove an item from the end of the list
            list.AddFirst(new User(1, "John Doe", "john.doe@example.com", "password"));
            list.AddLast(new User(2, "Jane Smith", "jane.smith@example.com", "password123"));
            list.RemoveLast();
            Assert.AreEqual(1, list.Count());
            Assert.AreEqual("John Doe", list.GetValue(0).Name);
        }

        [Test]
        public void TestDeleteFromMiddle()
        {
            // Remove an item from the middle of the list
            list.AddFirst(new User(1, "John Doe", "john.doe@example.com", "password"));
            list.AddLast(new User(3, "David Brown", "david.brown@example.com", "password456"));
            list.Add(new User(2, "Jane Smith", "jane.smith@example.com", "password123"), 1);
            list.Remove(1);
            Assert.AreEqual(2, list.Count());
            Assert.AreEqual("David Brown", list.GetValue(1).Name);
        }

        [Test]
        public void TestFindAndRetrieve()
        {
            // Search and retrieve an existing item
            User user = new User(1, "John Doe", "john.doe@example.com", "password");
            list.AddFirst(user);
            Assert.IsTrue(list.Contains(user));
            Assert.AreEqual(0, list.IndexOf(user));
            Assert.AreEqual(user, list.GetValue(0));
        }

        [Test]
        public void TestAdditionalFunctionality()
        {
            // Test for additional function of joining lists
            SLL list1 = new SLL();
            list1.AddLast(new User(1, "John Doe", "john.doe@example.com", "password"));
            SLL list2 = new SLL();
            list2.AddLast(new User(2, "Jane Smith", "jane.smith@example.com", "password123"));

            SLL result = list.Join(list1, list2);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("John Doe", result.GetValue(0).Name);
            Assert.AreEqual("Jane Smith", result.GetValue(1).Name);
        }
    }
}

