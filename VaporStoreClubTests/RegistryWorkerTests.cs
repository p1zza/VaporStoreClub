using VaporStoreClubNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VaporStoreClubNamespace.Tests
{
    [TestClass()]
    public class RegistryWorkerTests
    {
#if DEBUG
        private RegistryWorker registryWorker { get; set; }
        private string path { get; set; }

        [TestInitialize()]
        public void RegistryWorkerTestInitialise()
        {
            registryWorker = new RegistryWorker();
            path = registryWorker.GetPath();
        }

        [TestMethod()]
        public void TryPathIsNull()
        {
            Assert.IsNotNull(registryWorker.GetPath());
        }
        [TestMethod()]
        public void RegistryWorkerTest()
        {
            Assert.IsNotNull(registryWorker);
            Assert.IsNotNull(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path),"Невозможно открыть директорию реестра {0}",path);
            Assert.IsNotNull(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path).GetValue("consumer_key"), "Невозможно получить consumer_key");
            Assert.IsNotNull(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path).GetValue("closed_key"), "Невозможно получить closed_key");
            Microsoft.Win32.Registry.CurrentUser.Close();
        }

        [TestMethod()]
        public void AddIntStringDataTest()
        {
           
            Dictionary<string,int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs.Add("key", 123);
            registryWorker.AddData(keyValuePairs);
            Assert.IsNotNull(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(path).GetValue("key"), "Невозможно получить данные из реестра");
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey(path).DeleteValue("key");
            Microsoft.Win32.Registry.CurrentUser.Close();

        }

        [TestMethod()]
        public void AddDataTest1()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("stringkey", "string");
            registryWorker.AddData(keyValuePairs);
            Assert.IsNotNull(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(path).GetValue("stringkey"), "Невозможно получить данные из реестра");
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey(path).DeleteValue("stringkey");
            Microsoft.Win32.Registry.CurrentUser.Close();
        }


        [TestMethod()]
        public void GetDataTest()
        {
            string[] s = registryWorker.GetData();
            Assert.IsNotNull(s,"Метод GetData вернул массив NULL");
            Assert.IsNotNull(s[0], "Первый параметр равен null");
            Assert.IsNotNull(s[1], "Второй параметр равен null");
            Assert.IsNotNull(s[2], "Третий параметр равен null");
        }


        [TestCleanup()]
        public void TestCleanup()
        {
            GC.Collect();
        }
#endif
    }
}