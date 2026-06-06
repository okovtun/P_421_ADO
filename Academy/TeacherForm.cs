using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class TeacherForm : HumanForm
	{
		Models.Teacher teacher;
		public TeacherForm()
		{
			InitializeComponent();
			this.Text = "Добавление преподавателя";
		}

		//protected override void Compress()
		//{
		//	base.Compress();
		//	teacher.work_since = dtpWorkSince.Value.ToString();
		//	teacher.rate = mtbRate.Text;
		//}
		protected override void Exctract()
		{
			base.Exctract();
			dtpWorkSince.Value = Convert.ToDateTime(teacher.work_since);
			mtbRate.Text = teacher.rate;
		}
		protected override void btnOK_Click(object sender, EventArgs e)
		{
			base.btnOK_Click(sender, e);
			teacher = new Models.Teacher(human, dtpWorkSince.Value.ToString("yyyy-MM-dd"), mtbRate.Text);
			if (teacher.id == 0) teacher.id = Convert.ToInt32
				(
					DataBase.Connector.Scalar
					(
						  $"INSERT Teachers({teacher.GetNames()}) VALUES({teacher.GetValues()});SELECT SCOPE_IDENTITY()"
					)
				);
			else DataBase.Connector.Update("Teachers", teacher.GetUpdateExpression(), $"teacher_id={teacher.id}");

			if (pictureBoxPhoto.Image != null)
				DataBase.Connector.UploadPhoto(teacher.SerializePhoto(), teacher.id, "photo", "Teachers");
		}
	}
}
