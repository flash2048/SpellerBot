using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpellForBot;

namespace SpellerTests
{
    [TestClass]
    public class SpellBotTests
    {
        [TestMethod]
        public void TestMethod0()
        {
            var text = "";
            var result = SpellerForBot.Spell(text);
            Assert.AreEqual(result, "String is not correct");
        }
        [TestMethod]
        public void TestMethod1()
        {
            var text = "Это ошыбка!";
            var result = SpellerForBot.Spell(text);
            Assert.AreEqual(result, "Это **ошыбка**!\n\r**ошыбка**: ошибка");
        }
        [TestMethod]
        public void TestMethod2()
        {
            var text = "У лукаморья дуб залёный; Злотая цепь на дубе том.";
            var result = SpellerForBot.Spell(text);
            Assert.AreEqual(result, "У **лукаморья** дуб **залёный**; **Злотая** цепь на дубе том.\n\r**лукаморья**: лукоморья\n\r**залёный**: зеленый\n\r**Злотая**: Златая");
        }
    }
}
