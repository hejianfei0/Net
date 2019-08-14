using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSharpNet.Http
{
    public class HttpHelper
    {

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="url"></param>
        /// <param name="targetFile"></param>
        public void DownloadAsync(string url, string targetFile)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public string Get(string url)
        {
            return "";
        }


        public T Post<T>(string url, string body) where T : class
        {

            return (T)(new object());
        }

        public T Post<T>(string url, Object obj) where T : class
        {
            if (obj == null)
            {
                return Post<T>(url, "");
            }
            string json = JsonConvert.SerializeObject(obj);
            return Post<T>(url, json);
        }

        public bool UploadAsync(string url,string path)
        {
            if (!File.Exists(path))
                return false;
            return true;
        }

        public bool UploadAsync(string url,Stream stream)
        {
            return true;
        }
    }
}
