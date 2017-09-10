using System;
namespace Material.Model
{
	/// <summary>
	/// level2:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class level2
	{
		public level2()
		{}
		#region Model
		private string _name;
		private int? _level1_id;
		private int? _id2;
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
		public int? level1_id
		{
			set{ _level1_id=value;}
			get{return _level1_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? id2
		{
			set{ _id2=value;}
			get{return _id2;}
		}
		#endregion Model

	}
}

