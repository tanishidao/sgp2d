using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCon : MonoBehaviour
{
    private float xValue;
    private float yValue;
    public GameObject dMH;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        xValue =  Input.GetAxis("Horizontal");
       yValue = Input.GetAxis("Vertical");
        gameObject.transform.Translate(xValue* 0.03f, 0,0);
        gameObject.transform.Translate(0,yValue * 0.03f, 0);
        dMH.transform.Rotate(0,0,5);
    }
    private void FixedUpdate()
    {
        if(xValue == 0)
        {
        
        }
    }
}
