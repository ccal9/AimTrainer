using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    [Header("Set in Inspector")]
    public GameObject targetPrefab;
    public int maxTargets = 7;
    public int maxScale = 3;
    public float frequency ;
    public float speed;

    private List<GameObject> Targets;
    // Start is called before the first frame update
    void Start()
    {
        Targets = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
