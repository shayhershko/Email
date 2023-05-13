using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Email.Model
{
    public class EmailModel
    {
 
        // Emails Data
        public static List<Mail> GetEmails()
        {
            List<Mail> mails = new List<Mail>(){
            new Mail("John Smith", "Hello World", "john.smith@example.com", new DateTime(1989, 05, 01), "pack://application:,,,/Email;component/Resources/image1.jpg", "Hello, this is a test email."),
            new Mail("Mary Johnson", "Meeting Reminder", "mary.johnson@example.com", new DateTime(1600, 05, 02), "pack://application:,,,/Email;component/Resources/image2.jpg", "Hi,\n\nThis is a reminder that our team meeting is scheduled for tomorrow at 10 AM.\n\nPlease make sure to be on time. See you there!"),
            new Mail("Bob Jones", "Important Information", "bob.jones@example.com", new DateTime(2001, 05, 03), "pack://application:,,,/Email;component/Resources/image3.jpg", "Please review the attached document and provide feedback by the end of the day."),
            new Mail("Jane Doe", "Invitation", "jane.doe@example.com", new DateTime(2023, 05, 04), "pack://application:,,,/Email;component/Resources/image4.jpg", "You're invited to our company picnic next Saturday at the park."),
            new Mail("Tom Smith", "Question", "tom.smith@example.com", new DateTime(2015, 05, 05), "pack://application:,,,/Email;component/Resources/image5.jpg", "Can you clarify the requirements for the new project?"),
            new Mail("Sarah Johnson", "Project Update", "sarah.johnson@example.com", new DateTime(2023, 05, 06), "pack://application:,,,/Email;component/Resources/image7.jpg", "Here's the latest status update on the project."),
            new Mail("Mike Jones", "Reminder", "mike.jones@example.com", new DateTime(2222, 05, 07), "pack://application:,,,/Email;component/Resources/image8.jpg", "Don't forget to submit your timesheet by the end of the day."),
            new Mail("Amy Doe", "Thank You", "amy.doe@example.com", new DateTime(2022, 05, 08), "pack://application:,,,/Email;component/Resources/image9.jpg", "Thank you for your hard work on the project."),
            new Mail("David Lee", "Request for Proposal", "david.lee@example.com", new DateTime(2023, 05, 09), "pack://application:,,,/Email;component/Resources/image10.jpg", "Please provide a proposal for the new project by next Friday."),
            new Mail("Karen Brown", "Meeting Request", "karen.brown@example.com", new DateTime(2023, 05, 10), "pack://application:,,,/Email;component/Resources/image1.jpg", "Can we schedule a meeting to discuss the project next week?"),
            new Mail("Steve Wilson", "Approval Needed", "steve.wilson@example.com", new DateTime(2000, 05, 11), "pack://application:,,,/Email;component/Resources/image2.jpg", "We need your approval before we can move forward with the project."),
            new Mail("Rachel Green", "Job Offer", "rachel.green@example.com", new DateTime(1699, 05, 12), "pack://application:,,,/Email;component/Resources/image3.jpg", "We're pleased to offer you the position. Please let us know your decision."),
            new Mail("Tina Johnson", "Follow-Up", "tina.johnson@example.com", new DateTime(2023, 05, 14), "pack://application:,,,/Email;component/Resources/image5.jpg", "I just wanted to follow up on our conversation yesterday."),
            new Mail("Mark Jones", "Feedback", "mark.jones@example.com", new DateTime(2023, 05, 15), "pack://application:,,,/Email;component/Resources/image6.jpg", "We appreciate your feedback and will take it into consideration for future projects."),
            new Mail("George Lee", "Deadline Reminder", "george.lee@example.com", new DateTime(2008, 05, 17), "pack://application:,,,/Email;component/Resources/image7.jpg", "Hello,\n\nI wanted to provide some feedback on the new product.\n\nOverall, I think it's a great improvement, but I have a few suggestions to make it even better.\n\nPlease let me know if you're interested in hearing my feedback."),
            new Mail("Emily Brown", "Meeting Agenda", "emily.brown@example.com", new DateTime(2023, 05, 18), "pack://application:,,,/Email;component/Resources/image8.jpg", "Here's the agenda for the meeting tomorrow."),
            new Mail("Jack Wilson", "Information Request", "jack.wilson@example.com", new DateTime(2005, 05, 19), "pack://application:,,,/Email;component/Resources/image9.jpg", "Can you provide more information about the new project?"),
            new Mail("Olivia Green", "Congratulations", "olivia.green@example.com", new DateTime(2004, 05, 20), "pack://application:,,,/Email;component/Resources/image10.jpg", "Hi,\n\nThis is a reminder that our team meeting is scheduled for tomorrow at 10 AM.\n\nPlease make sure to be on time. See you there!")
            };
            return mails;
        }

   
    }
}
