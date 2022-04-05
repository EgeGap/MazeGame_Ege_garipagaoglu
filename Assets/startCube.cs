using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class startCube : MonoBehaviour
{
    Collider player;
    public static float zaman;
    public static float time = 0;
    bool enter = true;

    void Start()
    {
        player = GetComponent<Collider>();
        Debug.Log("When you enter the maze you will see the start of time!!!!! (If you wait too long, the entrance will be closed.)");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            Debug.Log("Your time has begun: " + time);
            time = zaman;
        }
    }

    void Update()
    {
        if (zaman > 5)
        {
            player.isTrigger = false;
        }
        zaman += Time.deltaTime;
    }
}
