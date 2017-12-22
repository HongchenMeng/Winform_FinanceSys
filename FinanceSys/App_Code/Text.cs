using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.Security;
using System.Text;

namespace FinanceSys.App_Code
{
    public class Text
    {
        //加密方法16位
        public static string MD516(string str)
        {
            return MD5(str, 16);
        }
        //加密方法32位
        public static string MD532(string str)
        {
            return MD5(str, 32);
        }
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">加密的字符</param>
        /// <param name="dig">位数,16、32可选</param>
        /// <returns></returns>
        private static string MD5(string str, int dig)
        {
            if (dig == 32)
            {
               
                return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower();
            }
            else
            {
                return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower().Substring(8, 16);
            }
        }
        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string SubString(string str, int len)
        {
            if (!string.IsNullOrEmpty(str))
                return str.Substring(len);
            else
                return "";
        }
        /// <summary>
        /// 截断sourceString指定的内容,返回截断后的内容
        /// </summary>
        /// <param name="sourceString">需判断截断的内容</param>
        /// <param name="length">截取长度</param>
        /// <returns>string</returns>
        public static string CutoffStr(string sourceString, int length)
        {
            return CutString(sourceString, length, "...");
        }
        /// <summary>
        /// 截断sourceString指定的内容,返回截断后的内容
        /// </summary>
        /// <param name="sourceString">需判断截断的内容</param>
        /// <param name="length">截取长度</param>
        /// <returns>string</returns>
        public static string SplitBolStr(string sourceString, int length)
        {
            return CutString(sourceString, length, "**");
        }
        public static int GetLength(string sourceString)
        {
            int length = 0;
            char[] chars = sourceString.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                byte[] bytes = Encoding.Default.GetBytes(chars, i, 1);
                length += bytes.Length;
            }

            return length;
        }

        public static string Substring(string sourceString, int length)
        {
            int length1 = 0;
            int length2 = 0;
            char[] chars = sourceString.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                byte[] bytes = Encoding.Default.GetBytes(chars, i, 1);
                length1 += bytes.Length;
                length2 = i + 1;

                if (length1 == length)
                {
                    break;
                }
                else if (length1 > length)
                {
                    length2 += -1;
                    break;
                }
            }

            return sourceString.Substring(0, length2);
        }

        /// <summary>
        /// 截断sourceString指定的内容，返回截断后的内容，并以ellipsis填充到末尾
        /// </summary>
        /// <param name="sourceString"></param>
        /// <param name="length"></param>
        /// <param name="ellipsis"></param>
        /// <returns></returns>
        public static string CutString(string sourceString, int length, string ellipsis)
        {
            string output = string.Empty;

            if (length > 0 && !string.IsNullOrEmpty(sourceString))
            {
                int sourceLength = GetLength(sourceString);

                if (sourceLength > length)
                {
                    if (ellipsis.Length > length)
                    {
                        output = sourceString;
                    }
                    else
                    {
                        output = Substring(sourceString, length - ellipsis.Length) + ellipsis;
                    }
                }
                else
                {
                    output = sourceString;
                }
            }

            return output;
        }
    }
}
