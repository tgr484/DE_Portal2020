using DE_Portal.DAL.Models.KW4;
using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.Extensions
{
    public static class TicketCreatorNameExtension
    {
        static private string namePattern = "Name: <b>([^<]*)<\\/b>";

        public static string CreatorName(this Ticket ticket)
        {
            // By Default
            string result = String.Join(", ", ticket.EmailFrom);

            // Try to extract from body:
            // Name: <b>Anton Guryev</b>
            System.Text.RegularExpressions.Regex regExp = new System.Text.RegularExpressions.Regex(namePattern);

            if (regExp.IsMatch(ticket.Body))
            {
                var match = regExp.Match(ticket.Body);
                try
                {
                    result = match.Groups[1].Value;
                }
                catch { }
            }

            return result;
        }
    }
}
