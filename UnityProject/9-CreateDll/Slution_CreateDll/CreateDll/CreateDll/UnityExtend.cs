using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace CreateDll
{
    public static class UnityExtend
    {
        /// <summary>
        /// Change Child Text
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="path">Child Path</param>
        /// <param name="text">Text Value</param>
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
}
