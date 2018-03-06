using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Windows.Forms;

namespace InnovationMembership
{
    class Email
    {
        /// <summary>
        /// Sends an e-mail message using the designated SMTP mail server.
        /// </summary>
        /// <param name="subject">The subject of the message being sent.</param>
        /// <param name="messageBody">The message body.</param>
        /// <param name="fromAddress">The sender's e-mail address.</param>
        /// <param name="toAddress">The recipient's e-mail address (separate multiple e-mail addresses
        /// with a semi-colon).</param>
        /// <param name="ccAddress">The address(es) to be CC'd (separate multiple e-mail addresses with
        /// a semi-colon).</param>
        /// <remarks>You must set the SMTP server within this method prior to calling.</remarks>
        /// <example>
        /// <code>
        ///   // Send a quick e-mail message
        ///   SendEmail.SendMessage("This is a Test", 
        ///                         "This is a test message...",
        ///                         "noboday@nowhere.com",
        ///                         "somebody@somewhere.com", 
        ///                         "ccme@somewhere.com");
        /// </code>
        /// </example>
        public static bool SendMessage(string subject, string messageBody, string fromAddress, string toAddress, string ccAddress, string bccAddress, string sAttachment)
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient("mail.coderdojoport.com");
            AlternateView avHtmlEmailBody = null;

            bool sendMessage = false;

            try
            {

                // Set the sender's address
                message.From = new MailAddress(fromAddress);

                // Allow multiple "To" addresses to be separated by a semi-colon
                if (toAddress.Trim().Length > 0)
                {
                    foreach (string addr in toAddress.Split(';'))
                    {
                        message.To.Add(new MailAddress(addr));
                    }
                }

                // Allow multiple "To" addresses to be separated by a semi-colon
                if (bccAddress.Trim().Length > 0)
                {
                    foreach (string addr in bccAddress.Split(';'))
                    {
                        message.Bcc.Add(new MailAddress(addr));
                    }
                }

                // Allow multiple "Cc" addresses to be separated by a semi-colon
                if (ccAddress.Trim().Length > 0)
                {
                    foreach (string addr in ccAddress.Split(';'))
                    {
                        message.CC.Add(new MailAddress(addr));
                    }
                }

                // Set the subject and message body text
                message.Subject = subject;
                message.IsBodyHtml = true;

                if (sAttachment.Trim().Length > 0)
                {
                    List<LinkedResource> inlineAttachments = new List<LinkedResource>();
                    LinkedResource inlineAttachment = null;

                    int i = 0;

                    foreach (string attm in sAttachment.Split(';'))
                    {

                        inlineAttachment = new LinkedResource(attm, MediaTypeNames.Image.Jpeg);

                        inlineAttachment.ContentId = Guid.NewGuid().ToString();
                        messageBody = messageBody.Replace("attachment_" + i.ToString(), inlineAttachment.ContentId);

                        inlineAttachments.Add(inlineAttachment);
                        i++;
                    }

                    avHtmlEmailBody = AlternateView.CreateAlternateViewFromString(messageBody, null, MediaTypeNames.Text.Html);

                    foreach (LinkedResource attachment in inlineAttachments)
                    {
                        avHtmlEmailBody.LinkedResources.Add(attachment);
                    }
                }

                //message.Body = messageBody;

                message.AlternateViews.Add(avHtmlEmailBody);

                // TODO: *** Modify for your SMTP server ***
                // Set the SMTP server to be used to send the message

                client.Credentials = new NetworkCredential("admin@coderdojoport.com", "Ireland1");
                
                // Send the e-mail message
                client.Send(message);

                // set the function success flag
                sendMessage = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error sending email", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return sendMessage;
        }

    }
}
