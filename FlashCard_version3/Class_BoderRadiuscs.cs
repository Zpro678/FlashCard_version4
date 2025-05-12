using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FlashCard_version3
{
    public class Class_BorderRadius
    {
        // Hàm tạo bo góc cho control
        public static void RoundCorners(Control control, int cornerRadius)
        {
            if (control == null) return;

            // Tạo đối tượng GraphicsPath để vẽ các góc bo tròn
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Góc trên trái
            path.AddArc(control.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Góc trên phải
            path.AddArc(control.Width - cornerRadius, control.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Góc dưới phải
            path.AddArc(0, control.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Góc dưới trái
            path.CloseFigure();

            // Đặt vùng hiển thị cho control
            control.Region = new Region(path);
        }
    }
}
