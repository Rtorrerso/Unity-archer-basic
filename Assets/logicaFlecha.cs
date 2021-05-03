using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaFlecha : MonoBehaviour
{

    public GameObject flecha2;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag=="diana")
        {
            Debug.Log("choque con: " +other.gameObject.name);
            GameObject NewFlecha = Instantiate(flecha2,this.transform.position,this.transform.rotation) as GameObject;
            Destroy(this.gameObject,0.0f);
        }    
    }
                    
}
