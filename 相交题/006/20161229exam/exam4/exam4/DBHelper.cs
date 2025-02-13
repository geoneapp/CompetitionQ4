﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace exam4
{
    public class DBHelper
    {
        #region  全局变量
        public static SqlConnection My_con;  //定义一个SqlConnection类型的公共变量My_con，用于判断数据库是否连接成功

        //public static string M_str_sqlcon = "Server=.;Database=GeoneMap;Trusted_Connection=SSPI";
        //public static string M_str_sqlcon = "server=127.0.0.1;database=GeoneMap;uid=sa;pwd=123456"; 

        public static string M_str_sqlcon;

        public static string minX1;
        public static string minY1;
        public static string maxX1;
        public static string maxY1;

        public static string minX2;
        public static string minY2;
        public static string maxX2;
        public static string maxY2;
        #endregion
        static DBHelper()
        {
        }

        #region  建立数据库连接
        /// <summary>
        /// 建立数据库连接.
        /// </summary>
        /// <returns>返回SqlConnection对象</returns>
        public static SqlConnection getcon()
        {
            My_con = new SqlConnection(M_str_sqlcon);   //用SqlConnection对象与指定的数据库相连接
            My_con.Open();  //打开数据库连接
            return My_con;  //返回SqlConnection对象的信息
        }
        #endregion

        #region  关闭数据库连接
        /// <summary>
        /// 关闭于数据库的连接.
        /// </summary>
        public static void con_close()
        {
            if (My_con.State == ConnectionState.Open)   //判断是否打开与数据库的连接
            {
                My_con.Close();   //关闭数据库的连接
                My_con.Dispose();   //释放My_con变量的所有空间
            }
        }
        #endregion

        #region  读取指定表中的信息
        /// <summary>
        /// 读取指定表中的信息.
        /// </summary>
        /// <param name="SQLstr">SQL语句</param>
        /// <returns>返回bool型</returns>
        public static SqlDataReader getcom(string SQLstr)
        {
            getcon();   //打开与数据库的连接
            SqlCommand My_com = My_con.CreateCommand(); //创建一个SqlCommand对象，用于执行SQL语句
            My_com.CommandText = SQLstr;    //获取指定的SQL语句
            SqlDataReader My_read = My_com.ExecuteReader(); //执行SQL语名句，生成一个SqlDataReader对象
            return My_read;
        }
        #endregion

        #region 执行SqlCommand命令
        /// <summary>
        /// 执行SqlCommand
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        public static void getsqlcom(string SQLstr)
        {
            getcon();   //打开与数据库的连接
            SqlCommand SQLcom = new SqlCommand(SQLstr, My_con); //创建一个SqlCommand对象，用于执行SQL语句
            SQLcom.ExecuteNonQuery();   //执行SQL语句
            SQLcom.Dispose();   //释放所有空间
            //con_close();    //调用con_close()方法，关闭与数据库的连接
        }
        #endregion

        #region  创建DataSet对象
        /// <summary>
        /// 创建一个DataSet对象
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        /// <param name="M_str_table">表名</param>
        /// <returns>返回DataSet对象</returns>
        public static DataSet getDataSet(string SQLstr, string tableName)
        {
            getcon();   //打开与数据库的连接

            //SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);  //创建一个SqlDataAdapter对象，并获取指定数据表的信息
            //DataSet My_DataSet = new DataSet(); //创建DataSet对象
            //SQLda.Fill(My_DataSet, tableName);  //通过SqlDataAdapter对象的Fill()方法，将数据表信息添加到DataSet对象中
            ////con_close();    //关闭数据库的连接
            //return My_DataSet;  //返回DataSet对象的信息

            SqlDataAdapter SQLda = new SqlDataAdapter();
            SQLda.SelectCommand = new SqlCommand();
            SQLda.SelectCommand.CommandText = SQLstr;
            SQLda.SelectCommand.CommandTimeout = 500;
            SQLda.SelectCommand.Connection = My_con;
            DataSet My_DataSet = new DataSet(); //创建DataSet对象
            SQLda.Fill(My_DataSet, tableName);  //通过SqlDataAdapter对象的Fill()方法，将数据表信息添加到DataSet对象中
            //con_close();    //关闭数据库的连接
            return My_DataSet;  //返回DataSet对象的信息
        }
        #endregion

    }
}
