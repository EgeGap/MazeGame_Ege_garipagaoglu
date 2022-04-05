using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeShow : MonoBehaviour
{
    private static float zaman_end;
    public Text Finish;


    void Update()
    {
        zaman_end = startCube.zaman;
        Finish.text = "The passing time: " + zaman_end.ToString();
    }

}

