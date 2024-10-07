using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasselDriverPlayer : MonoBehaviour {

    private VasselDriver vasselDriver;

    private void Awake() {
        vasselDriver = GetComponent<VasselDriver>();
    }

    private void Update() {
        float forwardAmount = Input.GetAxisRaw("Vertical");
        float turnAmount = Input.GetAxisRaw("Horizontal");
        vasselDriver.SetInputs(forwardAmount, turnAmount);
    }

}
