using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FASE2 : MonoBehaviour
{
    public GameObject door;
    public GameObject bola;


    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("door3");
        bola = GameObject.Find("bola");

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("balde"))
        {
            door.transform.Rotate(0,180,0);
            Debug.Log(" cesta");
        }
        else if (collision.gameObject.CompareTag("chao"))
        {
            bola.transform.position = new Vector3(-0.62f, 0.838f, 19.054f);
            Rigidbody bolaRB = bola.GetComponent<Rigidbody>();
            bolaRB.isKinematic = true;
            bolaRB.velocity = Vector3.zero;
            bolaRB.isKinematic = false;
            Debug.Log(" err");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
