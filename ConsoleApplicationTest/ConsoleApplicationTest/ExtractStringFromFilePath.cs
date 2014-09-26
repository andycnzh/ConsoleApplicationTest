using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class FilePathRoute
    {
        /// <summary>
        /// 正则获取文件路径
        /// </summary>
        /// <param name="strRoute">完整文件名</param>
        /// <param name="rType">要获取路径类型</param>
        /// <returns></returns>
        public static string GetPartFromFilePath(string strRoute, RouteType rType)
        {
            string strResult = string.Empty;

            Regex regex = new Regex(@"^(?<fpath>([a-zA-Z]:\\)([\s\.\-\w]+\\)*)(?<fname>[\w]+)(?<namext>(\.[\w]+)*)(?<suffix>\.[\w]+)");

            Match result = regex.Match(strRoute);

            if (result.Success)
            {
                switch (rType)
                {
                    case RouteType.NameOnly:
                        strResult = result.Result("${fname}") + result.Result("${namext}"); break;
                    case RouteType.FileName:
                        strResult = result.Result("${fname}") + result.Result("${namext}") + result.Result("${suffix}"); break;
                    case RouteType.FileSuffix:
                        strResult = result.Result("${suffix}"); break;
                    case RouteType.PathExceptName:
                        strResult = result.Result("${fpath}"); break;
                    case RouteType.PathExceptSuffix:
                        strResult = result.Result("${fpath}") + result.Result("${fname}") + result.Result("${namext}"); break;
                    default:
                        strResult = strRoute; break;
                }
            }

            return strResult;
        }
    }

    /// <summary>
    /// 路径分类
    /// </summary>
    public enum RouteType
    {
        /// <summary>
        /// 仅文件名
        /// </summary>
        NameOnly = 0,
        /// <summary>
        /// 文件名（包括后缀）
        /// </summary>
        FileName = 1,
        /// <summary>
        /// 仅后缀名（包括.）
        /// </summary>
        FileSuffix = 2,
        /// <summary>
        /// 除文件名之外的路径
        /// </summary>
        PathExceptName = 3,
        /// <summary>
        /// 除后缀之外的路径
        /// </summary>
        PathExceptSuffix = 4
    }
}
