using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;

namespace VendingSystem_BusinessDataLogic
{
    public class Vending_Email_Notif
    {
       
        public void SendTransactionReceipt(string customerName, string itemName, double price, double change)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Food Vending Machine", "no-reply@foodvending.com"));
            message.To.Add(new MailboxAddress("Admin", "concepciondeng25@gmail.com")); 
            message.Subject = "Transaction Receipt - Food Vending Machine";

            message.Body = new TextPart("plain")
            {
                Text = $"Hello Admin,\n\n" +
                       $"A new transaction has been completed.\n\n" +
                       $"Customer: {customerName}\n" +
                       $"Item Purchased: {itemName}\n" +
                       $"Price: ₱{price:F2}\n" +
                       $"Remaining Balance: ₱{change:F2}\n" +
                       $"Date/Time: {DateTime.Now}\n\n" +
                       $"Regards,\nFood Vending Machine System"
            };

            SendEmail(message);
        }

        public void SendLowStockAlert(string itemName, int remainingQty)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Food Vending Machine", "no-reply@foodvending.com"));
            message.To.Add(new MailboxAddress("Admin", "concepciondeng25@gmail.com"));
            message.Subject = $"⚠️ Low Stock Alert: {itemName}";

            message.Body = new TextPart("plain")
            {
                Text = $"Hello Admin,\n\n" +
                       $"The following item is running low on stock:\n" +
                       $"Item: {itemName}\n" +
                       $"Remaining Quantity: {remainingQty}\n\n" +
                       $"Please restock soon.\n\n" +
                       $"Regards,\nFood Vending Machine System"
            };

            SendEmail(message);
        }

      
        private void SendEmail(MimeMessage message)
        {
            var smtpHost = "sandbox.smtp.mailtrap.io";
            var smtpPort = 2525;
            var smtpUser = "4bbfc23aff2809"; 
            var smtpPass = "b64b6f96d9189d";

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(smtpHost, smtpPort, SecureSocketOptions.StartTls);
                    client.Authenticate(smtpUser, smtpPass);
                    client.Send(message);
                    Console.WriteLine("Email sent successfully!");
                }
                catch (Exception ex) { 
                
                    Console.WriteLine($"Failed to send email: {ex.Message}");
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
}
