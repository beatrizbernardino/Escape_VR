using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ligaGravidade : MonoBehaviour
{



    void OnDetachedFromHand(Hand hand) {

        gameObject.GetComponent<Rigidbody>().isKinematic = false;

    }


}
