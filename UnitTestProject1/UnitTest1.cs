using System;
using say2EatTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyzeInput_IfClientWantToOrderPizzaWithOneAddon()
        {
            //arrange
            string input = "i want to order a pizza with black olives";
            string expected = "Your pizza with black olives,is on the way";

            //act            
            string actual = Program.AnalizeInput(input); 

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AnalyzeInput_IfClientWantToOrderToastWithOneAddon()
        {
            //arrange
            string input = "i want to order a toast with black olives";
            string expected = "Your toast with black olives,is on the way";

            //act            
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AnalyzeInput_IfStringEmpty() {
            //arrange
            string emptyLine = "";
            string expected = "Please try again";

            //act
            string actual = Program.AnalizeInput(emptyLine);
          
            //assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void AnalyzeInput_IfClientWantOnlyPizzaWithoutAddon() {
            //arrange
            string input = "i want a pizza";
            string expected = "Your pizza is on the way";

            //act
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AnalyzeInput_IfClientWantOnlyToastWithoutAddon()
        {
            //arrange
            string input = "i want a toast";
            string expected = "Your toast is on the way";

            //act
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AnalyzeInput_IfStringDoesNotHaveMaindish()
        {
            //arrange
            string input = "BKSCBKJBHHSc xjccvxjkc jcnzjk mushrooms";
            string expected = "Please try again";

            //act
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AnalyzeInput_MethodReturnIsNotNull() {
            //arrange
            string maindish = "Pizza";
           
            //act
            string value = Program.AnalizeInput(maindish);

            //assert
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void AnalyzeInput_IfClientWantToastWith2Addons() {
            //arrange
            string input = "I want a toast with extra cheese, mushrooms";
            string expected = "Your toast with extra cheese,mushrooms,is on the way";

            //act
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);        
        }

        [TestMethod]
        public void AnalyzeInput_IfClientWantPizzatWith2Addons()
        {
            //arrange
            string input = "I want a pizza with extra cheese, mushrooms";
            string expected = "Your pizza with extra cheese,mushrooms,is on the way";

            //act
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void AnalyzeInput_IfClientWantToastWith3Addons(){
            //arrange
            string input = "I want a toast with extra cheese, mushrooms, green olives";
            string expected = "Your toast with green olives,extra cheese,mushrooms,is on the way";

            //act
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AnalyzeInput_IfClientWantPizzaWith3Addons()
        {
            //arrange
            string input = "I want a pizza with extra cheese, mushrooms, green olives";
            string expected = "Your pizza with green olives,extra cheese,mushrooms,is on the way";

            //act
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AnalyzeInput_IfClientWantPizzaWith4Addons()
        {
            //arrange
            string input = "I want a pizza with extra cheese, mushrooms, green olives, black olives";
            string expected = "Your pizza with black olives,green olives,extra cheese,mushrooms,is on the way";

            //act
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AnalyzeInput_IfClientWantToastWith4Addons()
        {
            //arrange
            string input = "I want a toast with extra cheese, mushrooms, green olives, black olives";
            string expected = "Your toast with black olives,green olives,extra cheese,mushrooms,is on the way";

            //act
            string actual = Program.AnalizeInput(input);

            //assert
            Assert.AreEqual(actual, expected);
        }      

        
    }

}
