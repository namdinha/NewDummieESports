using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveTest : MonoBehaviour
{
    private CharacterJoint[] joints;

    [SerializeField]
    private Rigidbody head;
    [SerializeField]
    private Rigidbody spine;
    [SerializeField]
    private Rigidbody hips;
    [SerializeField]
    private Rigidbody leftLeg;
    [SerializeField]
    private Rigidbody rightLeg;
    [SerializeField]
    private Rigidbody leftKnee;
    [SerializeField]
    private Rigidbody rightKnee;

    private void Awake() {
        //joints = GetComponentsInChildren<CharacterJoint>();
        //foreach (CharacterJoint joint in joints) {
        //    joint.connectedmassscale = 1;
        //}
        //leftKnee.mass += 20;
        //rightKnee.mass += 20;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            //foreach (CharacterJoint joint in joints) {
            //    joint.connectedMassScale += 10;
            //}
            leftKnee.AddRelativeForce(new Vector3(0, 1, 0));
        }
        else if (Input.GetButtonDown("Fire2")) {
            //foreach (CharacterJoint joint in joints) {
            //    joint.connectedMassScale -= 10;
            //}
        }

        
    }
}
