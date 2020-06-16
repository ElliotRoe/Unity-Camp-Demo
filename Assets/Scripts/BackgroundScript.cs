using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public float middlegroundSpeed;
    public float backgroundSpeed;

    Transform camTransform;

    GameObject backgroundWrapper;
    Transform wrapperT;
    Transform middleBack;
    Transform backBack;

    GameObject player;
    Transform playerT;
    Rigidbody2D playerRB;


    // Start is called before the first frame update
    void Start()
    {
        camTransform = GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerT = player.GetComponent<Transform>();
        playerRB = player.GetComponent<Rigidbody2D>();

        backgroundWrapper = GameObject.FindGameObjectWithTag("Background");
        wrapperT = backgroundWrapper.GetComponent<Transform>();
        middleBack = backgroundWrapper.GetComponentsInChildren<Transform>()[1];
        backBack = backgroundWrapper.GetComponentsInChildren<Transform>()[6];

        camTransform.position = new Vector3(playerT.position.x, playerT.position.y, -10f);
        wrapperT.position = new Vector3(playerT.position.x, playerT.position.y, -10f);


    }

    // Update is called once per frame
    void Update()
    {
        camTransform.position = new Vector3(playerT.position.x, playerT.position.y, -10f);
        wrapperT.position = new Vector2(playerT.position.x, playerT.position.y);

    }

    void FixedUpdate()
    {
        middleBack.localPosition = new Vector2(middleBack.localPosition.x - (playerRB.velocity.x * Time.fixedDeltaTime * middlegroundSpeed), middleBack.localPosition.y - (playerRB.velocity.y * Time.fixedDeltaTime * middlegroundSpeed));
        backBack.localPosition = new Vector2(backBack.localPosition.x - (playerRB.velocity.x * Time.fixedDeltaTime * backgroundSpeed), backBack.localPosition.y - (playerRB.velocity.y * Time.fixedDeltaTime * backgroundSpeed));

    }
}
