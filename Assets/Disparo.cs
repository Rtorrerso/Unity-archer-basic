using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject flecha;
    public GameObject flecha2;
    public Transform  NDisparo;
    public float vel;
    public Animator FAnimator;
    
    
        
    
    // Start is called before the first frame update
    void Start()
    {
        vel = 1000f;
        FAnimator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonUp("Fire1"))
        {
            FAnimator.CrossFadeInFixedTime("Shoot",0.1f);
            //FDisparo();
              
        }
    }

    public void FDisparo()
    {
            GameObject Nflecha =  Instantiate(flecha,NDisparo.position,NDisparo.rotation);
            Nflecha.transform.Rotate(-90,180,0);
            
            //var RBFlecha = Nflecha.GetComponent<Rigidbody>();
            var RBFlecha = Nflecha.GetComponent<Rigidbody>();
            RBFlecha.AddForce(0,0,vel*Time.deltaTime,ForceMode.Impulse);
    
    }

}
