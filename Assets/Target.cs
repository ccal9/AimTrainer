using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    AimTrainer score;
    AimTrainer targetCount;
    AimTrainer targetsHit;
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void OnClick()
    {
        //scoreCounter.score += 10;
        //scoreCounter.targetsHit +=1;
        Destroy(gameObject);
    }

    public void FixedUpdate()
    {
 
        Vector3 pos = transform.position;
        //pos = 
        //Vector3 scale = transform.localScale;
        
        //while(scale.x < 3){
            
            
       // }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
