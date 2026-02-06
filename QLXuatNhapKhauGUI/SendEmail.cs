using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXuatNhapKhau
{
    public static class SendEmail
    {
        public static void SendMail(string recipientEmail, string account, string password)
        {
            string fromEmail = "adqltv112002@gmail.com";
            string pass = "cdlabyocsggvtlrd";

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(fromEmail, recipientEmail)
            {
                Subject = "Đăng ký thành công",
                Body = $"Chào bạn,\n\nChúc mừng bạn đã đăng ký thành công! Dưới đây là thông tin tài khoản của bạn:\n\n" +
                       $"Tài khoản: {account}\nMật khẩu: {password}\n\nHãy đổi mật khẩu ngay sau khi đăng nhập.\n\n" +
                       "Trân trọng,\nHệ thống quản lý xuất nhập khẩu."
            };

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential(fromEmail, pass)
            };

            try
            {
                smtp.Send(mail);
                MessageBox.Show("Đã gửi email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi gửi email: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SendTB(string recipientEmail, string subject, string notice)
        {
            string fromEmail = "adqltv112002@gmail.com";
            string pass = "cdlabyocsggvtlrd";

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(fromEmail, recipientEmail)
            {
                Subject = subject,
                Body = notice
            };

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential(fromEmail, pass)
            };

            try
            {
                smtp.Send(mail);
                MessageBox.Show("Đã gửi email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi gửi email: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
