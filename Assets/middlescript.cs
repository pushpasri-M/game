using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class middlescript : MonoBehaviour
{
    public logicscript Logic;

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
        { 
        if (collision.gameObject.layer == 3)
        {
            Logic.addscore(5);
        }
           
        }
    
}
