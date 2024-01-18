using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapStrength;
    public logicscript Logic;
    public bool birdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdAlive)
        {
            myrigidbody.velocity = Vector2.up * flapStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
        {
        Logic.gameOver();
        birdAlive = false;
        
        }
}
