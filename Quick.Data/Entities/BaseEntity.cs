﻿/* ==============================================================================
* 命名空间：Quick.Data.Entities
* 类 名 称：BaseEntity
* 创 建 者：Qing
* 创建时间：2018-06-17 21:47:11
* CLR 版本：4.0.30319.42000
* 保存的文件名：BaseEntity
* 文件版本：V1.0.0.0
*
* 功能描述：N/A 
*
* 修改历史：
*
*
* ==============================================================================
*         CopyRight @ 班纳工作室 2018. All rights reserved
* ==============================================================================*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Data.Entities
{
    /** C#中泛型类型参数的约束：
     * ===============================================================================================================
     * |       约束      |                                   说明                                                    |
     * |=============================================================================================================|
     * |   T：strut      | 类型参数必须是值类型。 可以指定除 Nullable 以外的任何值类型。                             |
     * |-------------------------------------------------------------------------------------------------------------|             
     * |   T：class      | 类型参数必须是引用类型；这一点也适用于任何类、接口、委托或数组类型。                      |
     * |-------------------------------------------------------------------------------------------------------------| 
     * |   T：new()      | 类型参数必须具有无参数的公共构造函数。 当与其他约束一起使用时，new() 约束必须最后指定。   |
     * |-------------------------------------------------------------------------------------------------------------|
     * |   T：<基类名>   | 类型参数必须是指定的基类或派生自指定的基类。                                              |
     * |-------------------------------------------------------------------------------------------------------------|
     * |   T：<接口名称> | 类型参数必须是指定的接口或实现指定的接口。 可以指定多个接口约束。 约束接口也可以是泛型的。|
     * |-------------------------------------------------------------------------------------------------------------|
     * |   T：U          | 为 T 提供的类型参数必须是为 U 提供的参数或派生自为 U 提供的参数。                         |
     * ===============================================================================================================
    */
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreateTime = DateTime.Now;
            IsDeleted = false;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }

        [Required]
        [Display(Name = "是否删除")]
        public bool IsDeleted { get; set; }
    }
}
