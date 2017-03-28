//==================================================
// 作 者：曾浩
// 日 期：2011/03/06
// 描 述：介绍本文件所要完成的功能以及背景信息等等
//==================================================

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using System.Data;

namespace EFWCoreLib.CoreFrame.Common
{
    /// <summary>
    /// Convert 的摘要说明
    /// </summary>
    public class ConvertExtend
    {
        /// <summary>
        /// 将Null值转换为指定值
        /// </summary>
        /// <param name="obj">待判断的值</param>
        /// <param name="nValue">指定值</param>
        /// <returns></returns>
        public static string IsNull(object obj, string nValue)
        {
            try
            {
                return Convert.ToString(obj).Trim() == "" ? nValue : obj.ToString().Trim();
            }
            catch (System.InvalidCastException err)
            {
                err.ToString();
                return "";
            }
            catch (System.Exception err)
            {
                err.ToString();
                return "";
            }
        }

        /// <summary>
        ///判断输入字符串是否为数字
        /// </summary>
        /// <param name="nValue">字符串</param>
        /// <returns></returns>
        public static bool IsNumeric(string nValue)
        {
            int i, iAsc, idecimal = 0;
            if (nValue.Trim() == "") return false;
            for (i = 0; i <= nValue.Length - 1; i++)
            {
                iAsc = (int)Convert.ToChar(nValue.Substring(i, 1));
                //'-'45 '.'46 '''0-9' 48-57
                if (iAsc == 45)
                {
                    if (nValue.Length == 1)//不能只有一个负号
                    {
                        return false;
                    }
                    if (i != 0)			//'-'不能在字符串中间
                    {
                        return false;
                    }
                }
                else if (iAsc == 46)
                {
                    idecimal++;
                    if (idecimal > 1)		//如果有两个以上的小数点
                        return false;
                }
                else if (iAsc < 48 || iAsc > 57)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        ///判断输入字符串是否为整数
        /// </summary>
        /// <param name="nValue">字符串</param>
        /// <returns></returns>
        public static bool IsInteger(string nValue)
        {
            int i, iAsc;
            if (nValue.Trim() == "") return false;
            for (i = 0; i <= nValue.Length - 1; i++)
            {
                iAsc = (int)Convert.ToChar(nValue.Substring(i, 1));
                //'-' 45 '0-9' 48-57
                if (iAsc == 45)
                {
                    if (nValue.Length == 1)//不能只有一个负号
                    {
                        return false;
                    }
                    if (i != 0)			//'-'不能在字符串中间
                    {
                        return false;
                    }
                }
                else if (iAsc < 48 || iAsc > 57)
                {
                    return false;
                }
            }
            return true;
        }

        public static string ToPassWord(string text)
        {
            DESEncryptor des = new DESEncryptor();
            des.InputString = text;
            des.DesEncrypt();
            return des.OutString;
        }
		/// <summary>
        /// 转换字符串
        /// </summary>
        /// <param name="val"></param>
        /// <param name="defaultVal"></param>
        /// <returns></returns>
		public static string ToString(object val, string defaultVal)
        {
            if (val == null || val.Equals(DBNull.Value))
                return defaultVal;

            if (val.ToString() == "")
                return defaultVal;

            return val.ToString();
        }

        public static int ToInt32(object val, int defaultVal)
        {
            if (val == null || val.Equals(DBNull.Value))
                return defaultVal;

            if (val.ToString() == "")
                return defaultVal;

            return Convert.ToInt32(Convert.ToDecimal(val));
        }

        public static decimal ToDecimal(object val, decimal defaultVal)
        {
            if (val.Equals(DBNull.Value) || val == null)
                return defaultVal;

            if (val.ToString() == "")
                return defaultVal;

            return Convert.ToDecimal(val);
        }

        public static decimal ToDecimal(object val, decimal replace, decimal result)
        {
            if (val == null)
                val = "";
            if (decimal.TryParse(val.ToString(), out result))
                return result;
            else
                return replace;
        }


        protected static object ConvertValue(string PropertyType, object value)
        {
            if (value.GetType().FullName == "System.Guid")
            {
                return value.ToString();
            }

            switch (PropertyType)
            {
                case "System.DBNull":
                    return null;
                case "System.Int32":
                    value = value == DBNull.Value ? 0 : value;
                    value = value == null ? 0 : value;
                    value = value.ToString().Trim() == "" ? 0 : value;
                    return Convert.ToInt32(value);
                case "System.Int64":
                    value = value == DBNull.Value ? 0 : value;
                    value = value == null ? 0 : value;
                    value = value.ToString().Trim() == "" ? 0 : value;
                    return Convert.ToInt64(value);
                case "System.Decimal":
                    value = value == DBNull.Value ? 0 : value;
                    value = value == null ? 0 : value;
                    value = value.ToString().Trim() == "" ? 0 : value;
                    return Convert.ToDecimal(value);
                case "System.DateTime":
                    value = value == DBNull.Value ? new DateTime() : value;
                    value = value == null ? new DateTime() : value;
                    value = value.ToString().Trim() == "" ? new DateTime() : value;
                    return Convert.ToDateTime(value);
            }


            value = value == DBNull.Value ? null : value;
            return value;
        }

        /*
        public static List<T> ToList<T>(DataTable table, AbstractDatabase Db, IUnityContainer container, ICacheManager cache, string pluginName, string unityname)
        {
            Type type = typeof(T);
            List<T> objects = new List<T>();
            T obj = FactoryModel.GetObject<T>(Db, container,cache,pluginName, unityname);

            if (table != null && table.Rows.Count > 0)
            {
                while (objects.Count < table.Rows.Count)
                {
                    objects.Add((T)((ICloneable)obj).Clone());
                }

                foreach (PropertyInfo property in type.GetProperties())
                {

                    if (table.Columns.IndexOf(property.Name) >= 0)
                    {
                        for (int index = 0; index < table.Rows.Count; index++)
                        {
                            object val = table.Rows[index][property.Name];
                            if (val == System.DBNull.Value) val = null;
                            property.SetValue((object)objects[index], ConvertValue(property.PropertyType.FullName,val), null);
                        }
                    }
                }
            }
            return objects;
        }
        */

        public static List<T> ToList<T>(DataTable table)
        {
            List<T> list = new List<T>();
            T obj = (T)System.Activator.CreateInstance(typeof(T));

            //列名
            string columnName;
            //属性名
            string propertyName;
            //列数量
            int column = table.Columns.Count;
            //属性数量
            int propertyNum = obj.GetType().GetProperties().Length;

            for (int m = 0; m < table.Rows.Count; m++)
            {
                T newobj = (T)System.Activator.CreateInstance(typeof(T));

                //遍历所有列
                for (int i = 0; i < column; i++)
                {
                    //遍历所有属性
                    for (int j = 0; j < propertyNum; j++)
                    {
                        columnName = table.Columns[i].ColumnName.ToUpper();
                        propertyName = newobj.GetType().GetProperties()[j].Name.ToUpper();
                        if (columnName == propertyName && newobj.GetType().GetProperties()[j].CanWrite)
                        {
                            string fullName = table.Rows[m][columnName].GetType().FullName;
                            object objectValue = table.Rows[m][i];
                            //如果datatable中的对应项是空类型
                            if (fullName == "System.DBNull")
                            {
                                newobj.GetType().GetProperties()[j].SetValue(newobj, null, null);
                            }
                            else
                            {
                                newobj.GetType().GetProperties()[j].SetValue(newobj, ConvertValue(newobj.GetType().GetProperties()[j].PropertyType.FullName, objectValue), null);
                            }
                        }
                    }
                }

                list.Add(newobj);

            }

            return list;
        }
        /// <summary>
        /// List转DataTable
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ToDataTable(IList list)
        {
            DataTable result = new DataTable();
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name, pi.PropertyType);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i], null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }
        /// <summary>
        /// List转DataTable，List无记录带结构
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(List<T> list)
        {
            if (list.Count == 0)
            {
                DataTable result = new DataTable();
                PropertyInfo[] propertys = typeof(T).GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name, pi.PropertyType);
                }
                return result;
            }
            else
                return ToDataTable(list as IList);
        }

        /*
        public static T ToObject<T>(DataTable dt, int Rowindex, AbstractDatabase Db, IUnityContainer container, ICacheManager cache, string pluginName, string unityname)
        {
            T obj = FactoryModel.GetObject<T>(Db, container, cache, pluginName, unityname);

            if (Rowindex >= dt.Rows.Count)
            {
                return obj;
            }
            //列名
            string columnName;
            //属性名
            string propertyName;
            //列数量
            int column = dt.Columns.Count;
            //属性数量
            int propertyNum = obj.GetType().GetProperties().Length;
            //遍历所有列
            for (int i = 0; i < column; i++)
            {
                //遍历所有属性
                for (int j = 0; j < propertyNum; j++)
                {
                    columnName = dt.Columns[i].ColumnName.ToUpper();
                    propertyName = obj.GetType().GetProperties()[j].Name.ToUpper();
                    if (columnName == propertyName)
                    {
                        string fullName = dt.Rows[Rowindex][columnName].GetType().FullName;
                        object objectValue = dt.Rows[Rowindex][i];
                        //如果datatable中的对应项是空类型
                        if (fullName == "System.DBNull")
                        {
                            obj.GetType().GetProperties()[j].SetValue(obj, null, null);
                        }
                        else
                        {
                            obj.GetType().GetProperties()[j].SetValue(obj, ConvertValue(obj.GetType().GetProperties()[j].PropertyType.FullName, objectValue), null);
                        }
                    }
                }
            }
            return obj;
        }
        */
        public static T ToObject<T>(DataTable dt, int Rowindex)
        {
            T obj = (T)System.Activator.CreateInstance(typeof(T));

            if (Rowindex >= dt.Rows.Count)
            {
                return obj;
            }
            //列名
            string columnName;
            //属性名
            string propertyName;
            //列数量
            int column = dt.Columns.Count;
            //属性数量
            int propertyNum = obj.GetType().GetProperties().Length;
            //遍历所有列
            for (int i = 0; i < column; i++)
            {
                //遍历所有属性
                for (int j = 0; j < propertyNum; j++)
                {
                    columnName = dt.Columns[i].ColumnName.ToUpper();
                    propertyName = obj.GetType().GetProperties()[j].Name.ToUpper();
                    if (columnName == propertyName && obj.GetType().GetProperties()[j].CanWrite)
                    {
                        string fullName = dt.Rows[Rowindex][columnName].GetType().FullName;
                        object objectValue = dt.Rows[Rowindex][i];
                        //如果datatable中的对应项是空类型
                        if (fullName == "System.DBNull")
                        {
                            obj.GetType().GetProperties()[j].SetValue(obj, null, null);
                        }
                        else
                        {
                            obj.GetType().GetProperties()[j].SetValue(obj, ConvertValue(obj.GetType().GetProperties()[j].PropertyType.FullName, objectValue), null);
                            //obj.GetType().GetProperties()[j].SetValue(obj, objectValue, null);
                        }
                    }
                }
            }
            return obj;
        }

        public static T ToObject<T>(Object in_obj)
        {
            T out_obj = (T)System.Activator.CreateInstance(typeof(T));

            int in_propertyNum = in_obj.GetType().GetProperties().Length;
            int out_propertyNum = out_obj.GetType().GetProperties().Length;
            string in_propertyName, out_propertyName;
            for (int i = 0; i < in_propertyNum; i++)
            {
                for (int j = 0; j < out_propertyNum; j++)
                {
                    in_propertyName = in_obj.GetType().GetProperties()[i].Name;
                    out_propertyName = out_obj.GetType().GetProperties()[j].Name;

                    if (in_propertyName == out_propertyName && out_obj.GetType().GetProperties()[j].CanWrite)
                    {
                        object obj = in_obj.GetType().GetProperties()[i].GetValue(in_obj, null);
                        out_obj.GetType().GetProperties()[j].SetValue(out_obj, ConvertValue(out_obj.GetType().GetProperties()[j].PropertyType.FullName, obj), null);
                    }
                }
            }

            return out_obj;
        }

        public static void ToObject(Object in_obj, Object out_obj)
        {
            //T out_obj = (T)System.Activator.CreateInstance(typeof(T));

            int in_propertyNum = in_obj.GetType().GetProperties().Length;
            int out_propertyNum = out_obj.GetType().GetProperties().Length;
            string in_propertyName, out_propertyName;
            for (int i = 0; i < in_propertyNum; i++)
            {
                for (int j = 0; j < out_propertyNum; j++)
                {
                    in_propertyName = in_obj.GetType().GetProperties()[i].Name;
                    out_propertyName = out_obj.GetType().GetProperties()[j].Name;

                    if (in_propertyName == out_propertyName && out_obj.GetType().GetProperties()[j].CanWrite)
                    {
                        object obj = in_obj.GetType().GetProperties()[i].GetValue(in_obj, null);
                        out_obj.GetType().GetProperties()[j].SetValue(out_obj, ConvertValue(out_obj.GetType().GetProperties()[j].PropertyType.FullName, obj), null);
                    }
                }
            }

            //return out_obj;
        }

        public static string UrlAddParams(string httpurl, string paramName, string paramValue)
        {
            if (httpurl.IndexOf('?') == -1)
            {
                httpurl += "?" + paramName + "=" + paramValue;
            }
            else
            {
                httpurl += "&" + paramName + "=" + paramValue;
            }
            return httpurl;
        }

        /// <summary>
        /// DataTable行数据转Dictionary
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="Rowindex"></param>
        /// <returns></returns>
        public static Dictionary<string, Object> ToDictionary(DataTable dt, int Rowindex)
        {
            if (Rowindex >= dt.Rows.Count)
            {
                return null;
            }
            Dictionary<string, Object> dic = new Dictionary<string, object>();
            //列数量
            int column = dt.Columns.Count;
            //遍历所有列
            for (int i = 0; i < column; i++)
            {
                string colname = dt.Columns[i].ColumnName;
                object objectValue = dt.Rows[Rowindex][i];
                dic.Add(colname, objectValue);
            }
            return dic;
        }

        /// <summary>
        /// 对象转Dictionary
        /// </summary>
        /// <param name="in_obj"></param>
        /// <returns></returns>
        public static Dictionary<string, Object> ToDictionary(Object in_obj)
        {
            if (in_obj == null) return null;
            Dictionary<string, Object> dic = new Dictionary<string, object>();
            int in_propertyNum = in_obj.GetType().GetProperties().Length;

            for (int i = 0; i < in_propertyNum; i++)
            {
                string in_propertyName = in_obj.GetType().GetProperties()[i].Name;
                object in_propertyValue = in_obj.GetType().GetProperties()[i].GetValue(in_obj, null);
                dic.Add(in_propertyName, in_propertyValue);
            }
            return dic;
        }


        #region 转换大写金额
        ///
        /// 数字字符串（根据支票显示,例如：700,显示为柒百圆整）
        /// 转换成中文大写后的字符串或者出错信息提示字符串
        public static string ConvertAmountInWords(decimal money)
        {
            string str = money.ToString();
            if (!IsPositveDecimal(str))
                return "零元";
            if (Double.Parse(str) > 999999999999.99)
                return "数字太大，无法换算，请输入一万亿元以下的金额";
            char[] ch = new char[1];
            ch[0] = '.'; //小数点
            string[] splitstr = null; //定义按小数点分割后的字符串数组
            splitstr = str.Split(ch[0]);//按小数点分割字符串
            if (splitstr.Length == 1) //只有整数部分
                return ConvertData(str) + "圆整";
            else //有小数部分
            {
                string rstr;
                rstr = ConvertData(splitstr[0]) + "圆";//转换整数部分
                rstr += ConvertXiaoShu(splitstr[1]);//转换小数部分
                return rstr;
            }
        }

        ///
        /// 判断是否是正数字字符串
        ///
        /// 判断字符串
        /// 如果是数字，返回true，否则返回false
        private static bool IsPositveDecimal(string str)
        {
            Decimal d;
            try
            {
                d = Decimal.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }
            if (d > 0)
                return true;
            else
                return false;
        }

        ///
        /// 转换数字（整数）
        ///
        /// 需要转换的整数数字字符串
        /// 转换成中文大写后的字符串
        private static string ConvertData(string str)
        {
            string tmpstr = "";
            string rstr = "";
            int strlen = str.Length;
            if (strlen <= 4)//数字长度小于四位
            {
                rstr = ConvertDigit(str);

            }
            else
            {
                if (strlen <= 8)//数字长度大于四位，小于八位
                {
                    tmpstr = str.Substring(strlen - 4, 4);//先截取最后四位数字
                    rstr = ConvertDigit(tmpstr);//转换最后四位数字
                    tmpstr = str.Substring(0, strlen - 4);//截取其余数字
                    //将两次转换的数字加上萬后相连接
                    rstr = String.Concat(ConvertDigit(tmpstr) + "萬", rstr);
                    rstr = rstr.Replace("零零", "零");
                }
                else
                    if (strlen <= 12)//数字长度大于八位，小于十二位
                {
                    tmpstr = str.Substring(strlen - 4, 4);//先截取最后四位数字
                    rstr = ConvertDigit(tmpstr);//转换最后四位数字
                    tmpstr = str.Substring(strlen - 8, 4);//再截取四位数字
                    rstr = String.Concat(ConvertDigit(tmpstr) + "萬", rstr);
                    tmpstr = str.Substring(0, strlen - 8);
                    rstr = String.Concat(ConvertDigit(tmpstr) + "億", rstr);
                    rstr = rstr.Replace("零億", "億");
                    rstr = rstr.Replace("零萬", "零");
                    rstr = rstr.Replace("零零", "零");
                    rstr = rstr.Replace("零零", "零");
                }
            }
            strlen = rstr.Length;
            if (strlen >= 2)
            {
                switch (rstr.Substring(strlen - 2, 2))
                {
                    case "佰零": rstr = rstr.Substring(0, strlen - 2) + "佰"; break;
                    case "仟零": rstr = rstr.Substring(0, strlen - 2) + "仟"; break;
                    case "萬零": rstr = rstr.Substring(0, strlen - 2) + "萬"; break;
                    case "億零": rstr = rstr.Substring(0, strlen - 2) + "億"; break;
                }
            }
            return rstr;
        }

        ///
        /// 转换数字（小数部分）
        ///
        /// 需要转换的小数部分数字字符串
        /// 转换成中文大写后的字符串
        private static string ConvertXiaoShu(string str)
        {
            int strlen = str.Length;
            string rstr;
            if (strlen == 1)
            {
                if (str == "0")
                    rstr = "整";
                else
                    rstr = ConvertChinese(str) + "角";
                return rstr;
            }
            else
            {
                string tmpstr = str.Substring(0, 1);
                rstr = ConvertChinese(tmpstr) + "角";
                tmpstr = str.Substring(1, 1);
                rstr += ConvertChinese(tmpstr) + "分";
                rstr = rstr.Replace("零分", "");
                rstr = rstr.Replace("零角", "");
                return rstr;
            }
        }

        ///
        /// 转换数字
        ///
        /// 转换的字符串（四位以内）
        ///
        private static string ConvertDigit(string str)
        {
            int strlen = str.Length;
            string rstr = "";
            switch (strlen)
            {
                case 1: rstr = ConvertChinese(str); break;
                case 2: rstr = Convert2Digit(str); break;
                case 3: rstr = Convert3Digit(str); break;
                case 4: rstr = Convert4Digit(str); break;
            }
            rstr = rstr.Replace("拾零", "拾");
            strlen = rstr.Length;
            return rstr;
        }

        ///
        /// 转换四位数字
        ///
        private static string Convert4Digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string str3 = str.Substring(2, 1);
            string str4 = str.Substring(3, 1);
            string rstring = "";
            rstring += ConvertChinese(str1) + "仟";
            rstring += ConvertChinese(str2) + "佰";
            rstring += ConvertChinese(str3) + "拾";
            rstring += ConvertChinese(str4);
            rstring = rstring.Replace("零仟", "零");
            rstring = rstring.Replace("零佰", "零");
            rstring = rstring.Replace("零拾", "零");
            rstring = rstring.Replace("零零", "零");
            rstring = rstring.Replace("零零", "零");
            rstring = rstring.Replace("零零", "零");
            return rstring;
        }

        ///
        /// 转换三位数字
        ///
        private static string Convert3Digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string str3 = str.Substring(2, 1);
            string rstring = "";
            rstring += ConvertChinese(str1) + "佰";
            rstring += ConvertChinese(str2) + "拾";
            rstring += ConvertChinese(str3);
            rstring = rstring.Replace("零佰", "零");
            rstring = rstring.Replace("零拾", "零");
            rstring = rstring.Replace("零零", "零");
            rstring = rstring.Replace("零零", "零");
            return rstring;
        }

        ///
        /// 转换二位数字
        ///
        private static string Convert2Digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string rstring = "";
            rstring += ConvertChinese(str1) + "拾";
            rstring += ConvertChinese(str2);
            rstring = rstring.Replace("零拾", "零");
            rstring = rstring.Replace("零零", "零");
            return rstring;
        }

        ///
        /// 将一位数字转换成中文大写数字
        ///
        private static string ConvertChinese(string str)
        {
            //"零壹贰叁肆伍陆柒捌玖拾佰仟萬億圆整角分"
            string cstr = "";
            switch (str)
            {
                case "0": cstr = "零"; break;
                case "1": cstr = "壹"; break;
                case "2": cstr = "贰"; break;
                case "3": cstr = "叁"; break;
                case "4": cstr = "肆"; break;
                case "5": cstr = "伍"; break;
                case "6": cstr = "陆"; break;
                case "7": cstr = "柒"; break;
                case "8": cstr = "捌"; break;
                case "9": cstr = "玖"; break;
            }
            return (cstr);
        }
        #endregion

    }
}
