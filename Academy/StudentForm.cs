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
	public partial class StudentForm : HumanForm
	{
		Models.Student student;
		public StudentForm()
		{
			//Default constructor - это конструктор, который может быть вызван без параметров.
			InitializeComponent();
			this.Text = "Добавление студента";
			//cbGroup.DataSource = DataBase.Connector.Select($"SELECT group_id,group_name FROM Groups");
			//cbGroup.DisplayMember = "group_name";
			//cbGroup.ValueMember = "group_id";
			DataBase.LoadComboBoxFromBase(cbGroup, "Groups");
		}
		public StudentForm(int id) : this()
			//:this() - делегирует (вызывает) конструктор по умолчанию.
		{
			DataTable data = DataBase.Connector.Load("*", "Students", $"stud_id={id}");
			this.Text = "Редактирование студента";
			//TODO: Extract student's data to Form;
			human = student = new Models.Student(data.Rows[0].ItemArray);
			Exctract();
		}
		protected override void Exctract()
		{
			base.Exctract();
			cbGroup.SelectedValue = student.group;
		}
		protected override void btnOK_Click(object sender, EventArgs e)
		{
			base.btnOK_Click(sender, e);
			student = new Models.Student(human, (int)cbGroup.SelectedValue);
			if (student.id == 0) student.id = Convert.ToInt32
  (
  DataBase.Connector.Scalar
	  (
		  $"INSERT Students({student.GetNames()}) VALUES({student.GetValues()});SELECT SCOPE_IDENTITY();"   //Возвращает ID последней созданной записи
	  )
  );
			else DataBase.Connector.Update
				(
					"Students",
					student.GetUpdateExpression(),
					$"stud_id={student.id}"
				);
			if (pictureBoxPhoto.Image != null)
				DataBase.Connector.UploadPhoto(student.SerializePhoto(), student.id, "photo", "Students");
		}
	}
}
