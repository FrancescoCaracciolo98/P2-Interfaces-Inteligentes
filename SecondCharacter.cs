using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCharacter : MonoBehaviour
{
    public float speedMovement = 10f;
    // Update is called once per frame
    void Update() {
        if (Input.GetKey("i"))
            transform.Translate(0, 0, Time.deltaTime * speedMovement);
        if (Input.GetKey("k"))
            transform.Translate(0, 0, Time.deltaTime * -speedMovement);
        if (Input.GetKey("l"))
            transform.Translate(Time.deltaTime * speedMovement, 0, 0);
        if (Input.GetKey("j"))
            transform.Translate(Time.deltaTime * -speedMovement, 0, 0);
        // transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * speedMovement);
        // transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speedMovement);
    }
}
