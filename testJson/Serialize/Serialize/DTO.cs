using System;

public class Rootobject
{
    public Albums albums { get; set; }
    public string id { get; set; }
}

public class Albums
{
    public Datum[] data { get; set; }
    public Paging paging { get; set; }
}

public class Paging
{
    public Cursors cursors { get; set; }
}

public class Cursors
{
    public string before { get; set; }
    public string after { get; set; }
}

public class Datum
{
    public Photos photos { get; set; }
    public DateTime created_time { get; set; }
    public string id { get; set; }
}

public class Photos
{
    public Datum1[] data { get; set; }
    public Paging1 paging { get; set; }
}

public class Paging1
{
    public Cursors1 cursors { get; set; }
    public string next { get; set; }
}

public class Cursors1
{
    public string before { get; set; }
    public string after { get; set; }
}

public class Datum1
{
    public Image[] images { get; set; }
    public string name { get; set; }
    public Likes likes { get; set; }
    public string link { get; set; }
    public DateTime created_time { get; set; }
    public string id { get; set; }
    public Comments comments { get; set; }
}

public class Likes
{
    public Datum2[] data { get; set; }
    public Paging2 paging { get; set; }
}

public class Paging2
{
    public Cursors2 cursors { get; set; }
    public string next { get; set; }
}

public class Cursors2
{
    public string before { get; set; }
    public string after { get; set; }
}

public class Datum2
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Comments
{
    public Datum3[] data { get; set; }
    public Paging3 paging { get; set; }
}

public class Paging3
{
    public Cursors3 cursors { get; set; }
    public string next { get; set; }
}

public class Cursors3
{
    public string before { get; set; }
    public string after { get; set; }
}

public class Datum3
{
    public DateTime created_time { get; set; }
    public From from { get; set; }
    public string message { get; set; }
    public bool can_remove { get; set; }
    public int like_count { get; set; }
    public bool user_likes { get; set; }
    public string id { get; set; }
    public Message_Tags[] message_tags { get; set; }
}

public class From
{
    public string name { get; set; }
    public string id { get; set; }
    public string category { get; set; }
    public Category_List[] category_list { get; set; }
}

public class Category_List
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Message_Tags
{
    public string id { get; set; }
    public int length { get; set; }
    public string name { get; set; }
    public int offset { get; set; }
    public string type { get; set; }
}

public class Image
{
    public int height { get; set; }
    public string source { get; set; }
    public int width { get; set; }
}
