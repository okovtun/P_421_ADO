using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Academy.Models
{
	class Teacher:Human
	{
		internal string work_since;
		internal string rate;
		public Teacher
			(
			int id,
			string last_name, string first_name, string middle_name,
			string birth_date, string email, string phone, Image photo,
			string work_sonce, string rate
			):base(id,last_name,first_name,middle_name,birth_date,email,phone,photo)
		{
			this.work_since = work_since;
			this.rate = rate;
		}
		public Teacher(Human human, string work_since, string rate) : base(human)
		{
			this.work_since = work_since;
			this.rate = rate;
		}
		public Teacher(object[] values) : base(values)
		{
			this.work_since = values[8].ToString();
			this.rate = values[9].ToString();
		}

		public override string GetNames()
		{
			return base.GetNames()+",work_since,rate";
		}
		public override string GetValues()
		{
			return base.GetValues() + $",N'{work_since}',{rate}";
		}
		public override string GetUpdateExpression()
		{
			return base.GetUpdateExpression()+$"work_since=N'{work_since}',rate={rate}";
		}
	}
}
