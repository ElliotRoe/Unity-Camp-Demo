using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUpScript : MonoBehaviour
{

    UnityEngine.Experimental.Rendering.LWRP.Light2D light2d;
    GameObject gate;

    void Start()
    {
        light2d = GetComponent<UnityEngine.Experimental.Rendering.LWRP.Light2D>();
        gate = GameObject.FindGameObjectWithTag("Gate");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine("glowUp");
        gate.SetActive(false);
    }

    IEnumerator glowUp()
    {
        while (light2d.intensity < 10)
        {
            light2d.intensity += 0.1f;
            yield return new WaitForEndOfFrame();
        }
    }
}
