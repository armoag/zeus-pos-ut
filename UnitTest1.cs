using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ZeusUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numeroEsperado = 5;
            var inventario = Athena.InventoryBase.GetInstance(@"C:\Projects\seiya-pos\Data\Inventario.csv");
            var numero = inventario.GetLastItemNumber();
            if (numero != numeroEsperado)
                throw new Exception("error en numero de inv");
        }

        [TestMethod]
        public void TestMethod2()
        {


        }
    }
}
