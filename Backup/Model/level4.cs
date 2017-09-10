using System;
namespace Material.Model
{
	/// <summary>
	/// level4:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class level4
	{
		public level4()
		{}
		#region Model
		private int? _id4;
		private int? _level1_id;
		private int? _level2_id;
		private int? _level3_id;
		private string _name;
		private string _name2;
		/// <summary>
		/// 
		/// </summary>
		public int? id4
		{
			set{ _id4=value;}
			get{return _id4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? level1_id
		{
			set{ _level1_id=value;}
			get{return _level1_id;}
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
		public int? level3_id
		{
			set{ _level3_id=value;}
			get{return _level3_id;}
		}
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
		public string name2
		{
			set{ _name2=value;}
			get{return _name2;}
		}
		#endregion Model

	}
}

