using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace Material.DAL
{
	/// <summary>
	/// 数据访问类:level4
	/// </summary>
	public partial class level4
	{
		public level4()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Material.Model.level4 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into level4(");
			strSql.Append("id4,level1_id,level2_id,level3_id,name,name2)");
			strSql.Append(" values (");
			strSql.Append("@id4,@level1_id,@level2_id,@level3_id,@name,@name2)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id4", DbType.Int32,8),
					new SQLiteParameter("@level1_id", DbType.Int32,8),
					new SQLiteParameter("@level2_id", DbType.Int32,8),
					new SQLiteParameter("@level3_id", DbType.Int32,8),
					new SQLiteParameter("@name", DbType.char,2147483647),
					new SQLiteParameter("@name2", DbType.char,2147483647)};
			parameters[0].Value = model.id4;
			parameters[1].Value = model.level1_id;
			parameters[2].Value = model.level2_id;
			parameters[3].Value = model.level3_id;
			parameters[4].Value = model.name;
			parameters[5].Value = model.name2;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Material.Model.level4 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update level4 set ");
			strSql.Append("id4=@id4,");
			strSql.Append("level1_id=@level1_id,");
			strSql.Append("level2_id=@level2_id,");
			strSql.Append("level3_id=@level3_id,");
			strSql.Append("name=@name,");
			strSql.Append("name2=@name2");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id4", DbType.Int32,8),
					new SQLiteParameter("@level1_id", DbType.Int32,8),
					new SQLiteParameter("@level2_id", DbType.Int32,8),
					new SQLiteParameter("@level3_id", DbType.Int32,8),
					new SQLiteParameter("@name", DbType.char,2147483647),
					new SQLiteParameter("@name2", DbType.char,2147483647)};
			parameters[0].Value = model.id4;
			parameters[1].Value = model.level1_id;
			parameters[2].Value = model.level2_id;
			parameters[3].Value = model.level3_id;
			parameters[4].Value = model.name;
			parameters[5].Value = model.name2;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from level4 ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Material.Model.level4 GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id4,level1_id,level2_id,level3_id,name,name2 from level4 ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			Material.Model.level4 model=new Material.Model.level4();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Material.Model.level4 DataRowToModel(DataRow row)
		{
			Material.Model.level4 model=new Material.Model.level4();
			if (row != null)
			{
				if(row["id4"]!=null && row["id4"].ToString()!="")
				{
					model.id4=int.Parse(row["id4"].ToString());
				}
				if(row["level1_id"]!=null && row["level1_id"].ToString()!="")
				{
					model.level1_id=int.Parse(row["level1_id"].ToString());
				}
				if(row["level2_id"]!=null && row["level2_id"].ToString()!="")
				{
					model.level2_id=int.Parse(row["level2_id"].ToString());
				}
				if(row["level3_id"]!=null && row["level3_id"].ToString()!="")
				{
					model.level3_id=int.Parse(row["level3_id"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["name2"]!=null)
				{
					model.name2=row["name2"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id4,level1_id,level2_id,level3_id,name,name2 ");
			strSql.Append(" FROM level4 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM level4 ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from level4 T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "level4";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

