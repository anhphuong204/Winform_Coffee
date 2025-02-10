using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee.Class
{
	public class ControlResizer
	{ 
			private Dictionary<Control, (Size size, Point location)> initialControlSizes;
			private Size initialFormSize;
			private Form targetForm;

			public ControlResizer(Form form)
			{
				targetForm = form;
				initialFormSize = form.ClientSize;
				initialControlSizes = new Dictionary<Control, (Size, Point)>();

				// Lưu kích thước và vị trí ban đầu của tất cả control (bao gồm cả control con)
				SaveInitialControlSizes(form.Controls);

				// Đăng ký sự kiện Resize của form
				form.Resize += Form_Resize;
			}

			// Lưu kích thước và vị trí ban đầu của tất cả control
			private void SaveInitialControlSizes(Control.ControlCollection controls)
			{
				foreach (Control control in controls)
				{
					initialControlSizes[control] = (control.Size, control.Location);

					// Nếu control có các control con (ví dụ: Panel, GroupBox, TabControl...)
					if (control.Controls.Count > 0)
					{
						SaveInitialControlSizes(control.Controls);
					}
				}
			}

			// Hàm xử lý khi form thay đổi kích thước
			private void Form_Resize(object sender, EventArgs e)
			{
				if (targetForm.ClientSize.Width <= 0 || targetForm.ClientSize.Height <= 0) return;

				// Tính toán tỷ lệ thay đổi kích thước
				float scaleX = (float)targetForm.ClientSize.Width / initialFormSize.Width;
				float scaleY = (float)targetForm.ClientSize.Height / initialFormSize.Height;

				// Duyệt qua tất cả control và thay đổi kích thước, vị trí
				ResizeControls(targetForm.Controls, scaleX, scaleY);
			}

			// Thay đổi kích thước và vị trí của tất cả control
			private void ResizeControls(Control.ControlCollection controls, float scaleX, float scaleY)
			{
				foreach (Control control in controls)
				{
					if (initialControlSizes.ContainsKey(control))
					{
						var initialSize = initialControlSizes[control];

						// Cập nhật kích thước
						control.Size = new Size((int)(initialSize.size.Width * scaleX), (int)(initialSize.size.Height * scaleY));

						// Cập nhật vị trí
						control.Location = new Point((int)(initialSize.location.X * scaleX), (int)(initialSize.location.Y * scaleY));
					}

					// Nếu control có các control con
					if (control.Controls.Count > 0)
					{
					ResizeControls(control.Controls, scaleX, scaleY);
				}
			}
		}
	}
}
	
