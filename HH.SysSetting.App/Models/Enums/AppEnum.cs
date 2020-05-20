using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.SysSetting.App.Models.Enums
{
    public class AppEnum
    {
        
    }
    /// <summary>
    /// 单个节点右键菜单
    /// </summary>
    public enum NodeMenu
    {
        /// <summary>
        /// 新增子菜单
        /// </summary>
        [Description("新增子菜单")]
        addchildren=0,
        /// <summary>
        /// 修改菜单
        /// </summary>
        [Description("修改菜单")]
        update=1,
        /// <summary>
        /// 删除菜单
        /// </summary>
        [Description("删除菜单")]
        remove=2,
        /// <summary>
        /// 新增同级菜单
        /// </summary>
        [Description("新增同级菜单")]
        add = 3,
        /// <summary>
        /// 新增功能
        /// </summary>
        [Description("新增功能")]
        addFunc = 4,
        /// <summary>
        /// 批量初始化功能
        /// </summary>
        [Description("批量初始化功能")]
        initFunc = 5
    }
    /// <summary>
    /// 菜单的checkbox
    /// </summary>
    public enum CheckBoxEnum
    {
        IsSysDefine = 11,
        IsVisibled = 12,
        IsEndGrade = 13,
        IsAuthority = 14
    }
}
