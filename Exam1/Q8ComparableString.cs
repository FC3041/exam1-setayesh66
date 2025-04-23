namespace Exam1;

public class Q8StringLengthComparer: IComparer<string>
{
    public string str{get; set;}
    // public Q8StringLengthComparer(string Str)
    // {
    //     str=Str;
    // }

    public int Compare(string? x, string? y)
    {
        if ((x==null && y==null))
        {
            return 0;
        }
        if (x==null && y!=null)
        {
            return -1;
        }
        if (x!=null && y==null)
        {
            return 1;
        }
        if ((x.Length==y.Length))
        {
            return x.CompareTo(y);
        }

        return x.Length.CompareTo(y.Length);
    }

}

public class Q8ComparableString: IComparer<string>
{
    public string str{get; set;}
    public Q8ComparableString(string Str)
    {
        str=Str;
    }

    public int Compare(string? x, string? y)
    {
        if ((x==null && y==null))
        {
            return 0;
        }
        if (x==null && y!=null)
        {
            return -1;
        }
        if (x!=null && y==null)
        {
            return 1;
        }
        if ((x.Length==y.Length))
        {
            return x.CompareTo(y);
        }

        return x.Length.CompareTo(y.Length);
    }

    public static bool operator >(Q8ComparableString x, Q8ComparableString y)
    {
        if (x.str==null && y.str!=null)
        {
            return false;
        }
        if (x.str!=null && y.str==null)
        {
            return true;
        }
        if (x.str.Length>y.str.Length)
        {
            return true;
        }
        if (x.str.Length==y.str.Length)
        {
            if (x.str.CompareTo(y.str)>0)
            {
                return true;
            }
            
        }
        return false;
    }
    public static bool operator <(Q8ComparableString x, Q8ComparableString y)
    {
        if (x.str==null && y.str!=null)
        {
            return true;
        }
        if (x.str!=null && y.str==null)
        {
            return false;
        }
        if (x.str.Length>y.str.Length)
        {
            return false;
        }
        if (x.str.Length==y.str.Length)
        {
            if (x.str.CompareTo(y.str)>0)
            {
                return false;
            }
            
        }
        return true;
    }

    public static bool operator ==(Q8ComparableString x, Q8ComparableString y)
    {
        if ((x.str==null && y.str==null))
        {
            return true;
        }
        // if (x.str.Length==y.str.Length)
        // {
        //     return true;
        // }
        if ((x.str==y.str) && (x.str.Length==y.str.Length))
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(Q8ComparableString x, Q8ComparableString y)
    {
        if ((x.str==null && y.str==null))
        {
            return false;
        }
        // if (x.str.Length==y.str.Length)
        // {
        //     return false;
        // }
        if ((x.str==y.str) && (x.str.Length==y.str.Length))
        {
            return false;
        }
        return true;
    }
}