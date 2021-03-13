using System;
using System.Collections.Generic; 

namespace DesignPatterns.Proxy.Practical
{
public class Video {
    public string Id;
    public string Title;
    public string Data;

    public Video(string id, string title) {
        this.Id = id;
        this.Title = title;
        this.Data = "Random video.";
    }
}
}