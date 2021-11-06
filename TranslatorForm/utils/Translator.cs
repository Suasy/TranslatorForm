using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TranslatorForm
{
    public class Translator
    {
        public RESTClient client { get; set; }
        public string q { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string appId { get; set; }
        public string salt { get; set; }
        public string secretKey { get; set; }
        public string sign { get; set; }

        public Translator()
        {
            client = new RESTClient();
            client.EndPoint = @"http://api.fanyi.baidu.com/";
            client.Method = EnumHttpVerb.POST;
            client.ContentType = "application/x-www-form-urlencoded";

            q = "你好，世界！";
            from = "zh";
            to = "en";
            appId = "20211104000991451";
            salt = (new Random()).Next(100000).ToString();
            secretKey = "VPER5DJZ846DTwe8Qo6V";
        }

        public string Translate()
        {
            sign = EncryptString(appId + q + salt + secretKey);
            client.PostData = String.Format("q={0}&from={1}&to={2}&appid={3}&salt={4}&sign={5}", q, from, to, appId, salt, sign);
            string resultPost = client.HttpRequest("api/trans/vip/translate?");
            ReturnInfo info = JsonConvert.DeserializeObject<ReturnInfo>(resultPost);

            if (info.trans_result == null)
                return "";

            return info.trans_result[0].dst;
        }

        public string Translate(string q)
        {
            this.q = q;
            return Translate();
        }

        public string Translate(string q, string from, string to)
        {
            this.q = q;
            this.from = from;
            this.to = to;
            return Translate();
        }

        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }
    }
}
