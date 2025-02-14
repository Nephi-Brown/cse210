using System;
using System.Collections.Generic;

class Comment
{
    private string _accountName;
    private string _text;

    public Comment(string accountName, string text)
    {
        _accountName = accountName;
        _text = text;
    }

    public string CommenterName()
    {
        return _accountName;
    }

    public string CommentText()
    {
        return _text;
    }
}