using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaporStoreClubNamespace
{
    class RegistryWorker
    {
        private string c_k { get; set; }
        private string cl_k { get; set; }
        private string ApiLink { get; set; }
        
        private readonly string path = @"Software\Vapor Store Club";

        public RegistryWorker()
        {
            try
            {
                if (Registry.CurrentUser.OpenSubKey(path) == null)
                {
                    Registry.CurrentUser.CreateSubKey(path);
                    Registry.CurrentUser.CreateSubKey(path).SetValue("consumer_key", "");
                    Registry.CurrentUser.CreateSubKey(path).SetValue("closed_key", "");
                    Registry.CurrentUser.Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
        }

        public void AddData(Dictionary<string,string> Dictionary)
        {
            try
            {
                foreach(var keyValuePair in Dictionary)
                {
                    Registry.CurrentUser.CreateSubKey(path).SetValue(keyValuePair.Key, keyValuePair.Value);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
        }
        public void AddData(Dictionary<string, int> Dictionary)
        {
            try
            {
                foreach (var keyValuePair in Dictionary)
                {
                    Registry.CurrentUser.CreateSubKey(path).SetValue(keyValuePair.Key, keyValuePair.Value);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
        }


        public void RegisterKeyApi(string consumer_key, string closed_key,string Api)
        {
            try
            {
                c_k = consumer_key;
                cl_k = closed_key;
                ApiLink = Api;
                Registry.CurrentUser.CreateSubKey(path).SetValue("ApiLink", Api);
                Registry.CurrentUser.CreateSubKey(path).SetValue("consumer_key", consumer_key);
                Registry.CurrentUser.CreateSubKey(path).SetValue("closed_key", closed_key);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
        }

        public string[] GetData()
        {
            try
            {
                if (c_k == null)
                {
                    c_k = Registry.CurrentUser.OpenSubKey(path).GetValue("consumer_key", c_k).ToString();
                }
                if(cl_k == null)
                {
                    cl_k = Registry.CurrentUser.OpenSubKey(path).GetValue("closed_key", cl_k).ToString();
                }
                if(ApiLink == null)
                {
                    ApiLink = Registry.CurrentUser.OpenSubKey(path).GetValue("ApiLink", ApiLink).ToString();
                }
                string[] s = new string[3] { c_k, cl_k , ApiLink};

                return s;
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch(ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch(SecurityException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Data + "\n" + ex.Message.ToString());
            }

            return null;
        }
        public void SetData(string consumer_key, string closed_key, string Api)
        {
            Registry.CurrentUser.CreateSubKey(path).SetValue("ApiLink", Api);
            Registry.CurrentUser.CreateSubKey(path).SetValue("consumer_key", consumer_key);
            Registry.CurrentUser.CreateSubKey(path).SetValue("closed_key", closed_key);
        }
    }
}
