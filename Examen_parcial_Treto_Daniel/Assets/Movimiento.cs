using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
  
    public float velocidad = 80.0F; 
    public float posibilidad = 100.0F; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * velocidad * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * posibilidad * Time.deltaTime, 0);
     

    }


    

}
