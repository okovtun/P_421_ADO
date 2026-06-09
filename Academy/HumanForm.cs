using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Academy
{
	public partial class HumanForm : Form
	{
		internal Models.Human human;
		public HumanForm()
		{
			InitializeComponent();
		}
		protected virtual void Compress()
		{
			//Упаковывает пользовательские данные из формы в объект класса 'Human':
			human = new Models.Human
				(
				Convert.ToInt32(labelID.Text == "" ? "0" : labelID.Text.Split(':').Last()),
				tbLastName.Text,
				tbFirstName.Text,
				tbMiddleName.Text,
				dtpBirthDate.Value.ToString("yyyy-MM-dd"),
				tbEmail.Text,
				tbPhone.Text,
				pictureBoxPhoto.Image
				);
		}
		protected virtual void Extract()
		{
			this.labelID.Text = $"ID:{human.id}";
			this.tbLastName.Text	=	human.last_name;
			this.tbFirstName.Text	=	human.first_name;
			this.tbMiddleName.Text	=	human.middle_name;
			this.dtpBirthDate.Value =	Convert.ToDateTime(human.birth_date);
			this.tbEmail.Text		=	human.email;
			this.tbPhone.Text		=	human.phone;
			this.pictureBoxPhoto.Image =	human.photo;
		}

		protected virtual void btnOK_Click(object sender, EventArgs e)
		{
			Compress();
		}

		private void pictureBoxPhoto_MouseHover(object sender, EventArgs e)
		{
			ToolTip tt = new ToolTip();
			tt.SetToolTip(pictureBoxPhoto,"Для выбора фото сделайте двойной шелчек мышью");
		}

		private void pictureBoxPhoto_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = 
"All image files|*.bmp;*.png;*.jpg;*.jpeg;*.svg;*.jfif;*.webp|BMP files|*.bmp|PNG files|*.png|JPG files|*.jpg;*.jpeg|All files|*.*";
			if (dialog.ShowDialog() == DialogResult.OK)
				pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);
		}
	}
}
