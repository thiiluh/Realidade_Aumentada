using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class controle : MonoBehaviour
{

   

    private Rigidbody rb;

   
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");

        
        Vector3 movement = new Vector3(x, 0.0f, y);

       
        rb.velocity = movement * 4f;

        if (x != 0 && y != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }

       
    }
}
