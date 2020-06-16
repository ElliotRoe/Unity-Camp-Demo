using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DeathScript : MonoBehaviour
{
    public GameObject death;

    void Start()
    {
        //death = GameObject.FindGameObjectWithTag("DeathUI");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine("playDeathScene");
    }

    IEnumerator playDeathScene()
    {
        death.SetActive(true);
        yield return new WaitForSeconds(5f);
        UnityEditor.EditorApplication.isPlaying = false;
        print("Quit");
    }

}
