using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour
{
    Rigidbody rigidbody;
    ConstantForce force;
    Vector3 inicialPos;

    private void Awake() {
        this.rigidbody = GetComponent<Rigidbody>();
        this.force = GetComponent<ConstantForce>();
        inicialPos = this.rigidbody.position;
    }

    void Update()
    {
        Vector3 pos = inicialPos - this.rigidbody.position;
        ////pos.x = 0;
        ////pos.z = 0;
        //force.force = pos * 500;
        //Debug.Log(rigidbody.position);
    }
}
