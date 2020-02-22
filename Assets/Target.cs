using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    
    GameObject target;
    private Vector3 scaling;
      
    

    private void Awake()
    {
        scaling = new Vector3(1.5f, 1.5f, 1.5f);
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }

     void OnMouseDown()
    {
        Destroy(this.gameObject);
        AimTrainer.score += 1;

        ScoreCounter.scoreText.text = "Score: " + AimTrainer.score.ToString();
    }

    public void FixedUpdate()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
        this.transform.localScale += scaling * Time.deltaTime; 
        
        //this.transform.localScale -= scaling * Time.deltaTime;
                  
    }
    
}
