using System;
using static EventsAndDelegates.VideoEncoder;

namespace EventsAndDelegates
{
    partial class Program
    {
        public class MessageService
        {
            public void OnVideoEncoded(object source, VideoEventArgs e)
            {
                System.Console.WriteLine("MailService : Sending an text message..." + e.Video.Title);
            }
        }
    }
}
