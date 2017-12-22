using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace FinanceSys.PublicLibrary
{
    /// <summary>
    /// 获取系统版本名称
    /// </summary>
    public class Systems
    {
        ///根据User Agent获取操作系统名称
        /// <summary>
        /// 根据 User Agent 获取操作系统名称
        /// </summary>
        public static string GetOSNameByUserAgent(string userAgent)
        {
            string osVersion = "未知";

            if (userAgent.Contains("NT 6.0"))
            {
                osVersion = "Windows Vista/Server 2008";
            }
            else if (userAgent.Contains("NT 5.2"))
            {
                osVersion = "Windows Server 2003";
            }
            else if (userAgent.Contains("NT 5.1"))
            {
                osVersion = "Windows XP";
            }
            else if (userAgent.Contains("NT 5"))
            {
                osVersion = "Windows 2000";
            }
            else if (userAgent.Contains("NT 4"))
            {
                osVersion = "Windows NT4";
            }
            else if (userAgent.Contains("Me"))
            {
                osVersion = "Windows Me";
            }
            else if (userAgent.Contains("98"))
            {
                osVersion = "Windows 98";
            }
            else if (userAgent.Contains("95"))
            {
                osVersion = "Windows 95";
            }
            else if (userAgent.Contains("Mac"))
            {
                osVersion = "Mac";
            }
            else if (userAgent.Contains("Unix"))
            {
                osVersion = "UNIX";
            }
            else if (userAgent.Contains("Linux"))
            {
                osVersion = "Linux";
            }
            else if (userAgent.Contains("SunOS"))
            {
                osVersion = "SunOS";
            }
            return osVersion;
        }

        /// <summary>
        /// 系统数据初始化
        /// </summary>
        /// <returns></returns>
        public static bool SysInit()
        {
            string sql = "exec proc_Init";
            
            return DbHelperSQL.ExecuteCommand(sql) == -1;
        }
    }
}   
