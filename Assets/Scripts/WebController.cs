using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebController : MonoBehaviour
{
    public void OpenWebSite(string webPageAddress)
    {
        if (webPageAddress != null)
            Application.OpenURL(webPageAddress);
    }
}
