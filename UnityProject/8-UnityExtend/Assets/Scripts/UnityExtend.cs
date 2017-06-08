using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class UnityExtend
{

    public static void Ex_SetText(this Transform tran, string path, string text)
    {
        if (tran == null || string.IsNullOrEmpty(path)) return;
        Transform newT = tran.Find(path);
        if (newT == null) return;
        Text textComp = newT.GetComponent<Text>();
        if (textComp == null) return;
        textComp.text = text;
    }



}
