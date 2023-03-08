using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

class MyHttp
{
    public static int endIndex;
    public static String CookieString = "";
    public static String myHttpStringGet(String url) {
        return myHttpStringGet(url, "", "");
    }
    public static String myHttpStringGet(String url, String charset) {
        return myHttpStringGet(url, charset, "");
    }
    public static String myHttpStringGet(String url, String charset, String refer)
    {
        return myHttpStringGet(url, charset, refer, null);
    }
    public static String myHttpStringGet(String url, String charset, String refer, ArrayList headers) {
        String outStr = "";
        try {
            HttpWebRequest httpWebReq = (HttpWebRequest)WebRequest.Create(url);
            httpWebReq.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:42.0) Gecko/20100101 Firefox/42.0";
            httpWebReq.Accept = "*/*";
            httpWebReq.Proxy = null;
            if (!refer.Equals(""))
                httpWebReq.Referer = refer;
            if (!CookieString.Equals(""))
                SetHeaderValue(httpWebReq.Headers, "Cookie", CookieString);
            if (headers != null) {
                foreach (String one in headers) {
                    int index = one.IndexOf(":");
                    if (index > 0) {
                        String[] per = new String[2];
                        per[0] = one.Substring(0, index);
                        per[1] = one.Substring(index + 1).Trim();
                        SetHeaderValue(httpWebReq.Headers, per[0], per[1]);
                    }
                }
            }
            HttpWebResponse response = (HttpWebResponse)httpWebReq.GetResponse();
            Stream stream = response.GetResponseStream();
            CookieString += getCookieString(response.Cookies) + ";";
            CookieString += response.Headers["set-cookie"] + ";";
            StreamReader streamReader;
            if (charset.Equals("")) {
                streamReader = new StreamReader(stream);
            } else {
                streamReader = new StreamReader(stream, Encoding.GetEncoding(charset));
            }
            outStr = streamReader.ReadToEnd();
            streamReader.Close();
            stream.Close();
            response.Close();
            httpWebReq.Abort();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        return outStr;
    }

    private static void SetHeaderValue(WebHeaderCollection headers, string v, object p)
    {
        throw new NotImplementedException();
    }
    public static String myHttpStringPost(String url, String charset, String PostData) {
        return myHttpStringPost(url, charset, PostData, null);
    }
    public static String myHttpStringPost(String url, String charset, String PostData, ArrayList headers)
    {
        String outStr = "";
        try
        {
            HttpWebRequest httpWebReq = (HttpWebRequest)WebRequest.Create(url);
            httpWebReq.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:42.0) Gecko/20100101 Firefox/42.0";
            httpWebReq.Accept = "*/*";
            httpWebReq.Proxy = null;
            httpWebReq.Method = "POST";
            if (!CookieString.Equals(""))
                SetHeaderValue(httpWebReq.Headers, "Cookie", CookieString);
            if (headers != null)
            {
                foreach (String one in headers)
                {
                    int index = one.IndexOf(":");
                    if (index > 0)
                    {
                        String[] per = new String[2];
                        per[0] = one.Substring(0, index);
                        per[1] = one.Substring(index + 1).Trim();
                        SetHeaderValue(httpWebReq.Headers, per[0], per[1]);
                    }
                }
            }
            byte[] bs = Encoding.UTF8.GetBytes(PostData);
            httpWebReq.ContentLength = bs.Length;
            httpWebReq.ContentType = "application/x-www-form-urlencoded";
            using (Stream reqStream = httpWebReq.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
                reqStream.Close();
            }

            HttpWebResponse response = (HttpWebResponse)httpWebReq.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream, Encoding.GetEncoding(charset));
            CookieString += getCookieString(response.Cookies)+";";
            CookieString += response.Headers["set-cookie"]+";";
            outStr = streamReader.ReadToEnd();
            streamReader.Close();
            stream.Close();
            response.Close();
            httpWebReq.Abort();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return outStr;
    }
    public static Result MyHttpDownload(String url) {
        WebClient client = new WebClient();
        Stream str = client.OpenRead(url);
        MemoryStream stmMemory = new MemoryStream();
        byte[] buffer = new byte[64 * 1024];
        int i;
        while ((i = str.Read(buffer, 0, buffer.Length)) > 0) {
            stmMemory.Write(buffer, 0, i);
        }
        byte[] arraryByte = stmMemory.ToArray();
        stmMemory.Close();
        str.Close();
        endIndex = arraryByte.Length;
        return new Result(arraryByte, arraryByte.Length);
    }
    private static void SetHeaderValue(WebHeaderCollection header, string name, string value) {
        var property = typeof(WebHeaderCollection).GetProperty("InnerCollection",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        if (property != null) {
            var collection = property.GetValue(header, null) as NameValueCollection;
            collection[name] = value;
        }
    }
    public class Result {
        public Result(byte[] rr, int end) {
            this.result = rr;
            this.length = end;
        }
        public byte[] result;
        public int length;
    }
    private static String getCookieString(CookieCollection cc)
    {
        StringBuilder cookie = new StringBuilder();
        foreach (Cookie item in cc)
        {
            cookie.Append(item.Name + "=" + item.Value + ";");
        }
        return cookie.ToString();
    }
}

