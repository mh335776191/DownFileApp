using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DownFileApp
{
    public class DownFilesInfo
    {
        /// <summary>
        /// 文件下载路径
        /// </summary>
        public string FileUrl { get; set; }
        /// <summary>
        /// 文件总大小
        /// </summary>
        public long FileLength { get; set; }
        /// <summary>
        /// 已下载文件大小
        /// </summary>
        public long FileCurrLength { get; set; }
        /// <summary>
        /// 下载进度百分比
        /// </summary>
        public decimal ProccessPercentage { get; set; }
        /// 下载进度事件
        /// </summary>
        public Action<string> DownProgressEvent;
    }
}
