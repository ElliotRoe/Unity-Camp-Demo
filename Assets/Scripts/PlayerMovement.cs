using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D charController;

    public float speed = 1;

    float horAxiz = 0f;

    bool canJump = false;

    AudioSource source;

    bool canMove = false;
    int direction = 0;

    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine("main");
    }

    void Update()
    {
        horAxiz = Input.GetAxisRaw("Horizontal") * (speed * 10);

        if (Input.GetButtonDown("Jump"))
        {
            canJump = true;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove)
        {
            charController.Move(direction, false, false);
        }

    }

    void move(float dist)
    {
        float time = Mathf.Abs(dist);
        //false = left 
        //true = right 
        direction = (int)(dist / Mathf.Abs(dist));
        StartCoroutine(movement(time));
    }

    void jump()
    {
        charController.Move(0, false, true);
    }

    void say(string message)
    {
        print(message);
    }

    void sound()
    {
        source.Play();
    }

    IEnumerator movement(float t)
    {
        canMove = true;
        yield return new WaitForSeconds(t);
        canMove = false;
    }

    IEnumerator main()
    {
        yield return new WaitForSeconds(1);

        //PUT CODE BELOW HERE

        say("Hello!");




















    }
}
