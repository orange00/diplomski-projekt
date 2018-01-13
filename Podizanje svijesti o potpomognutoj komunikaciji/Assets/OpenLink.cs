using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class OpenLink : MonoBehaviour {
    public void OpenFacebookHyperlink() {
        Application.OpenURL("https://www.facebook.com/ictaac");
    }
    public void OpenICTAACHyperlink()
    {
        Application.OpenURL("http://www.ict-aac.hr/index.php/hr/");
    }
}
