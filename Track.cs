using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
   public class Track
{

    private string _title;
    private string _artist;

    public string Title 
    { 
        get { return _title; } 
    }
    public string Artist 
    { 
        get { return _artist; } 
    }

    public Track(string title, string artist)
    {
        _title = title;
        _artist = artist;
    }
}
}
