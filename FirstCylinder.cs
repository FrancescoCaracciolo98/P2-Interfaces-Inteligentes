using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCylinder : MonoBehaviour
{

    private Vector3 scaleVector;
    private GameObject player;
    float speed = 2f;

    void Start () {
        player = GameObject.FindGameObjectWithTag("MyCharacter");
    }

    void Update() {

    }

    void OnTriggerEnter(Collider other) {
        float scale = 0.2f;
        scaleVector = new Vector3(scale, 0, scale);
        if (other.gameObject.name == "MyCharacter") 
            transform.localScale += scaleVector;
    }
}



