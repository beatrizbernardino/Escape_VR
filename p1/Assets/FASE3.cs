using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FASE3 : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("door2");
    }

    public Text texto;
    int[] state = {0, 0, 0, 0, 0, 0};
    int[] input_order = {1,2,3,4,5,6};
    int index = 0;

    public void b1(){
        state[index] = 1;
        index++;
    }

    public void b2(){
        state[index] = 2;
        index++;
    }

    public void b3(){
        state[index] = 3;
        index++;
    }

    public void b4(){
        state[index] = 4;
        index++;
    }

    public void b5(){
        state[index] = 5;
        index++;
    }

    public void b6(){
        state[index] = 6;
        index++;
    }

    public void Reset(){
        index = 0;
        texto.text=" ";
    }

    

    // Update is called once per frame
    void Update()
    {

        if (index == 6){
            index = 0;
            Debug.Log("entrou");

            int errou = 0;
            for(int i = 0; i < 6; i++){
                Debug.Log(state[i]);
                if(state[i] != input_order[i]) 
                    errou = 1;
            }
            if(errou == 0){
                Debug.Log("uhull");
                texto.text = "Acertou";
                door.transform.Rotate(0,180,0);
            }
            else{
                Debug.Log("tururu");
                texto.text = "Errou";
            }


        }
             
        
    }
}
