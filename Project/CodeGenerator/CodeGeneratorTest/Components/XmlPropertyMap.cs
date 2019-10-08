/************************************************************************************
 *      Copyright (C) 2019 FigKey,All Rights Reserved
 *      File:
 *				XmlPropertyMap.cs
 *      Description:
 *				 属性映射实体类
 *      Author:
 *				唐小东
 *				1297953037@qq.com
 *				http://www.figkey.com
 *      Finish DateTime:
 *				2019年09月26日
 *      History:
 ***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGeneratorTest.Components
{
    /// <summary>
    /// 属性映射实体类
    /// </summary>
    [Serializable]
    public class XmlPropertyMap
    {
        #region 私有字段

        private string propertyName;
        private string columnName;

        #endregion

        #region 构造方法

        public XmlPropertyMap() { }

        public XmlPropertyMap(string propertyName, string columnName)
        {
            this.propertyName = propertyName;
            this.columnName = columnName;
        }

        #endregion

        #region 公有属性

        /// <summary>
        /// 实体类的属性名称
        /// </summary>
        public string PropertyName
        {
            get { return propertyName; }
            set { propertyName = value; }
        }
        /// <summary>
        /// 对应表的列名称
        /// </summary>
        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        #endregion
    }
}
