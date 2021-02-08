using System;
using static EventsAndDelegates.VideoEncoder;

namespace EventsAndDelegates
{
    partial class Program
    {
        public class MailService
        {
            public void OnVideoEncoded(object source, VideoEventArgs e)
            {
                System.Console.WriteLine("MailService : Sending an email..." + e.Video.Title);
            }
        }
    }
}
