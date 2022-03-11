using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FASE1 : MonoBehaviour
{
    public GameObject door1;
    // Start is called before the first frame update
    void Start()
    {
        door1 = GameObject.Find("door1");
    }

    public void door(){
        door1.transform.Rotate(0,180,0);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
