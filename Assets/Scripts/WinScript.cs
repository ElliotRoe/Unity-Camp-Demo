using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameObject win;

    void Start()
    {
        //death = GameObject.FindGameObjectWithTag("DeathUI");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine("playWinScene");
    }

    IEnumerator playWinScene()
    {
        win.SetActive(true);
        yield return new WaitForSeconds(2f);
        UnityEditor.EditorApplication.isPlaying = false;
        print("Quit");
    }
}
