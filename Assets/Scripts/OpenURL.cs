using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{

    public string Url;

    public void Open()
    {
        Application.OpenURL(Url);
    }

    public void SendMail()
    {
        string email = "info@arealitystudios.nl";
        string subject = MyEscapeURL("Interest in AReality Studios");
        string body = MyEscapeURL("Beste/Dear AReality Studios,\r\n");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
}
