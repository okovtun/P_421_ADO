using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.IO;

namespace Academy.Models
{
	class Human
	{
		internal int id;
		internal string last_name;
		internal string first_name;
		internal string middle_name;
		internal string birth_date;
		internal string email;
		internal string phone;
		internal Image photo;
		public Human
			(
			int id,
			string last_name, string first_name, string middle_name,
			string birth_date, string email, string phone, Image photo
			)
		{
			this.id = id;
			this.last_name = last_name;
			this.first_name = first_name;
			this.middle_name = middle_name;
			this.birth_date = birth_date;
			this.email = email;
			this.phone = phone;
			this.photo = photo;
		}
		public Human(object[] values)
		{
			this.id = (int)values[0];
			this.last_name		= values[1].ToString();
			this.first_name		= values[2].ToString();
			this.middle_name	= values[3].ToString();
			this.birth_date		= Convert.ToDateTime(values[4]).ToString("yyyy-MM-dd");
			this.email			= values[5].ToString();
			this.phone			= values[6].ToString();
			if (values[7] as byte[] != null)
			{
				MemoryStream ms = new MemoryStream(values[7] as byte[]);
				this.photo = Image.FromStream(ms);
				//ms.Dispose(); //https://stackoverflow.com/questions/22708150/a-generic-error-occurred-in-gdi-at-system-drawing-image-save
			}
		}
		public Human(Human other)
		{
			this.id = other.id;
			this.last_name = other.last_name;
			this.first_name = other.first_name;
			this.middle_name = other.middle_name;
			this.birth_date = other.birth_date;
			this.email = other.email;
			this.phone = other.phone;
			this.photo = other.photo;
			//CopyConstructor
		}

		public virtual string GetNames()
		{
			return "last_name,first_name,middle_name,birth_date,email,phone";
		}
		public virtual string GetValues()
		{
			return $"N'{last_name}',N'{first_name}',N'{middle_name}',N'{birth_date}',N'{email}',N'{phone}'";
		}
		public virtual string GetUpdateExpression()
		{
			return
$"last_name		=	N'{last_name}'," +
$"first_name	=	N'{first_name}'," +
$"middle_name	=	N'{middle_name}'," +
$"birth_date	=	N'{birth_date}'," +
$"email			=	N'{email}'," +
$"phone			=	N'{phone}'";
		}
		public byte[] SerializePhoto()
		{
			MemoryStream ms = new MemoryStream(photo.Width*photo.Height);
			photo.Save(ms, photo.RawFormat);
			byte[] raw_photo = ms.ToArray();
			//ms.Dispose();
			return raw_photo;
		}
	}
}
/*
----------------
System.Runtime.InteropServices.ExternalException
  HResult=0x80004005
  Message=A generic error occurred in GDI+.
  Source=System.Drawing
  StackTrace:
   at System.Drawing.Image.Save(Stream stream, ImageCodecInfo encoder, EncoderParameters encoderParams)
   at System.Drawing.Image.Save(Stream stream, ImageFormat format)
   at Academy.Models.Human.SerializePhoto() in C:\Users\User\source\repos\ADO_P_421\Academy\Models\Human.cs:line 88
   at Academy.StudentForm.btnOK_Click(Object sender, EventArgs e) in C:\Users\User\source\repos\ADO_P_421\Academy\StudentForm.cs:line 56
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.DebuggableCallback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)
   at System.Windows.Forms.UnsafeNativeMethods.DispatchMessageW(MSG& msg)
   at System.Windows.Forms.Application.ComponentManager.System.Windows.Forms.UnsafeNativeMethods.IMsoComponentManager.FPushMessageLoop(IntPtr dwComponentID, Int32 reason, Int32 pvLoopData)
   at System.Windows.Forms.Application.ThreadContext.RunMessageLoopInner(Int32 reason, ApplicationContext context)
   at System.Windows.Forms.Application.ThreadContext.RunMessageLoop(Int32 reason, ApplicationContext context)
   at System.Windows.Forms.Application.RunDialog(Form form)
   at System.Windows.Forms.Form.ShowDialog(IWin32Window owner)
   at System.Windows.Forms.Form.ShowDialog()
   at Academy.MainForm.dgvStudents_CellMouseDoubleClick(Object sender, DataGridViewCellMouseEventArgs e) in C:\Users\User\source\repos\ADO_P_421\Academy\MainForm.cs:line 150
   at System.Windows.Forms.DataGridView.OnCellMouseDoubleClick(DataGridViewCellMouseEventArgs e)
   at System.Windows.Forms.DataGridView.OnMouseDoubleClick(MouseEventArgs e)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.DataGridView.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.DebuggableCallback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)
   at System.Windows.Forms.UnsafeNativeMethods.DispatchMessageW(MSG& msg)
   at System.Windows.Forms.Application.ComponentManager.System.Windows.Forms.UnsafeNativeMethods.IMsoComponentManager.FPushMessageLoop(IntPtr dwComponentID, Int32 reason, Int32 pvLoopData)
   at System.Windows.Forms.Application.ThreadContext.RunMessageLoopInner(Int32 reason, ApplicationContext context)
   at System.Windows.Forms.Application.ThreadContext.RunMessageLoop(Int32 reason, ApplicationContext context)
   at System.Windows.Forms.Application.Run(Form mainForm)
   at Academy.Program.Main() in C:\Users\User\source\repos\ADO_P_421\Academy\Program.cs:line 19

----------------
 */
