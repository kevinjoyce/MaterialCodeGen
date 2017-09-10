using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace Material.DAL
{
	/// <summary>
	/// 数据访问类:level3
	/// </summary>
	public partial class level3
	{
		public level3()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Material.Model.level3 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into level3(");
			strSql.Append("name,level2_id,id3,level1_id)");
			strSql.Append(" values (");
			strSql.Append("@name,@level2_id,@id3,@level1_id)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@name", DbType.String,2147483647),
					new SQLiteParameter("@level2_id", DbType.Int32,8),
					new SQLiteParameter("@id3", DbType.Int32,8),
					new SQLiteParameter("@level1_id", DbType.Int32,8)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.level2_id;
			parameters[2].Value = model.id3;
			parameters[3].Value = model.level1_id;

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
		public bool Update(Material.Model.level3 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update level3 set ");
			strSql.Append("name=@name,");
			strSql.Append("level2_id=@level2_id,");
			strSql.Append("id3=@id3,");
			strSql.Append("level1_id=@level1_id");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@name", DbType.String,2147483647),
					new SQLiteParameter("@level2_id", DbType.Int32,8),
					new SQLiteParameter("@id3", DbType.Int32,8),
					new SQLiteParameter("@level1_id", DbType.Int32,8)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.level2_id;
			parameters[2].Value = model.id3;
			parameters[3].Value = model.level1_id;

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
			strSql.Append("delete from level3 ");
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
		public Material.Model.level3 GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select name,level2_id,id3,level1_id from level3 ");
			strSql.Append(" where ");
			SQLiteParameter[] parameters = {
			};

			Material.Model.level3 model=new Material.Model.level3();
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
		public Material.Model.level3 DataRowToModel(DataRow row)
		{
			Material.Model.level3 model=new Material.Model.level3();
			if (row != null)
			{
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["level2_id"]!=null && row["level2_id"].ToString()!="")
				{
					model.level2_id=int.Parse(row["level2_id"].ToString());
				}
				if(row["id3"]!=null && row["id3"].ToString()!="")
				{
					model.id3=int.Parse(row["id3"].ToString());
				}
				if(row["level1_id"]!=null && row["level1_id"].ToString()!="")
				{
					model.level1_id=int.Parse(row["level1_id"].ToString());
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
			strSql.Append("select name,level2_id,id3,level1_id ");
			strSql.Append(" FROM level3 ");
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
			strSql.Append("select count(1) FROM level3 ");
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
			strSql.Append(")AS Row, T.*  from level3 T ");
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
			parameters[0].Value = "level3";
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

