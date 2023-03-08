using System;
using System.Text;
using System.Text.RegularExpressions;
public static class MyTools {
    /// <summary>
    /// 录入当前时间，直接返回14:05:30字符串
    /// </summary>
    /// <param name="span">TimeSpan-当前或者是某个时间点</param>
    /// <returns></returns>
    public static string TimeToString(TimeSpan span) {
        return span.Hours.ToString("00") + ":" +
        span.Minutes.ToString("00") + ":" +
        span.Seconds.ToString("00");
    }
    /// <summary>
    /// 用于返回一个Unicode的普通文字值
    /// </summary>
    /// <param name="text">Unicode文字</param>
    /// <returns>普通文本</returns>
    public static String getNormalText(string text) {
        return Regex.Unescape(text);
    }
    /// <summary>
    /// 返回特定大小的字符数，用于长度受限的中文和英文(半截中文丢弃)
    /// 例如：ABCD==我是
    /// </summary>
    /// <param name="str">原始字符串</param>
    /// <param name="len">待取字符数</param>
    /// <returns></returns>
    public static string GetSubstringByLength(string str, int len) {//截取字符串指定字节数的内容，并返回实际截取的字节数
        if (str == null) return "";
        byte[] bytes = Encoding.Unicode.GetBytes(str);
        int n = 0;  //  表示当前的字节数
        int i = 0;  //  要截取的字节数
        for (; i < bytes.GetLength(0) && n < len; i++) {
            if (i % 2 == 0){//  偶数位置，如0、2、4等，为UCS2编码中两个字节的第一个字节
                n++;      //  在UCS2第一个字节时n加1
            } else {
                if (bytes[i] > 0){//  当UCS2编码的第二个字节大于0时，该UCS2字符为汉字，一个汉字算两个字节
                    n++;
                }
            }
        }
        //  如果i为奇数时，处理成偶数
        if (i % 2 == 1) {
            if (bytes[i] > 0) //  该UCS2字符是汉字时，去掉这个截一半的汉字
                i = i - 1;
            else
                i = i + 1;//  该UCS2字符是字母或数字，则保留该字符
        }
        len = i;
        return Encoding.Unicode.GetString(bytes, 0, i);
    }
}
