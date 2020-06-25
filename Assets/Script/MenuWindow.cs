using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWindow : MonoBehaviour
{
    void OnGUI()
    {
        // ラベルを表示する
        GUI.Label(new Rect(10, 10, 100, 100), "W,A,S,D,で移動できるよ");
    }
}

