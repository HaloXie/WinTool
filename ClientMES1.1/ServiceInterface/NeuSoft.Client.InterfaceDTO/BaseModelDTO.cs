using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO
{
    [Serializable]
    public class BaseModelDTO
    {
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool? IsDelete { get => isDelete; set => isDelete = value; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool? IsActive { get => isActive; set => isActive = value; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateBy { get => createBy; set => createBy = value; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdateBy { get => updateBy; set => updateBy = value; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get => createTime; set => createTime = value; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateTime { get => updateTime; set => updateTime = value; }
        /// <summary>
        /// 业务单元guid
        /// </summary>
        public string BusinessUnitGuid { get => businessUnitGuid; set => businessUnitGuid = value; }
        /// <summary>
        /// 业务组guid
        /// </summary>
        public string BusinessGroupGuid { get => businessGroupGuid; set => businessGroupGuid = value; }
        /// <summary>
        /// 版本号
        /// </summary>
        public int? VersionNum { get => versionNum; set => versionNum = value; }
        private bool? isDelete;
        private bool? isActive;
        private string createBy;
        private string updateBy;
        private DateTime? createTime;
        private DateTime? updateTime;
        private string businessUnitGuid;
        private string businessGroupGuid;
        private int? versionNum;
    }
}
