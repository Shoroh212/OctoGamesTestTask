using System;
using System.Collections.Generic;

[Serializable]
public class PopupData
{
    public string Title;
    public string Message;

    public List<PopupButtonData> Buttons = new();
}


