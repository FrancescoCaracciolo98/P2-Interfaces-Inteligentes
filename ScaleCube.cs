using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCube : MonoBehaviour
{

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        float scale = 0.2f;
        Vector3 scaleVector = new Vector3(scale, scale, scale);
        if (other.gameObject.name == "MyCharacter") {
            if (transform.localScale.x >= scaleVector.x) transform.localScale -= scaleVector;
        } else if (other.gameObject.name == "SecondCharacter") {
            transform.localScale += scaleVector;
        }
    }
}
