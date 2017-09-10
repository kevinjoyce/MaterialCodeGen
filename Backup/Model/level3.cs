using System;
namespace Material.Model
{
	/// <summary>
	/// level3:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class level3
	{
		public level3()
		{}
		#region Model
		private string _name;
		private int? _level2_id;
		private int? _id3;
		private int? _level1_id;
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? level2_id
		{
			set{ _level2_id=value;}
			get{return _level2_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? id3
		{
			set{ _id3=value;}
			get{return _id3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? level1_id
		{
			set{ _level1_id=value;}
			get{return _level1_id;}
		}
		#endregion Model

	}
}

