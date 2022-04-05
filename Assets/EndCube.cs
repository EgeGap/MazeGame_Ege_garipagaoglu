using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EndCube : MonoBehaviour
{
    private static float zaman_end;
    void Update()
    {
        zaman_end = startCube.zaman;
    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);

    }
}
