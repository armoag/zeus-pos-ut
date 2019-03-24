using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeus;

namespace ZeusUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string networkInstrument = "Intel(R) Dual Band Wireless-AC 8265";
            Utilities.GetMacAddress(networkInstrument, out var address);
            var key = Utilities.HashLicense(address, "LicenseTest");

            int numeroEsperado = 5;
            var inventario = Zeus.InventoryBase.GetInstance(@"C:\Projects\seiya-pos\Data\Inventario.csv");
            var numero = inventario.GetLastItemNumber();
            if (numero != numeroEsperado)
                throw new Exception("error en numero de inv");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Test part list read method
            var parts = CarPart.ReadPartsFile();
            CarPart.WritePartsFile(Constants.DataFolderPath + "Newlistparts.csv", parts);

        }
    }
}
