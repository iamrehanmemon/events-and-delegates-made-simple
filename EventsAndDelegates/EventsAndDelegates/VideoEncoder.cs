using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {   
        public class VideoEventArgs : EventArgs
        {
            public Video Video { get; set; }
        }

        //1- Define a Delegate
        //2- Define an event basedon that delegate
        //3- Raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;
        
        
        //EventHandler
        //EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        //3- Raise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this,new VideoEventArgs() { Video =  video });

            //VideoEncoded?.Invoke(this, EventArgs.Empty);

        }
    }
}
