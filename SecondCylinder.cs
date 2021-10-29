using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCylinder : MonoBehaviour
{

    private GameObject player;
    public float distance = 4f;
    public float force = 100f;
    void Start() {
        player = GameObject.FindGameObjectWithTag("MyCharacter");
    }

    // Update is called once per frame
    void Update() {
        if (Vector3.Distance(transform.position, player.transform.position) < distance && Input.GetKey("space")) {
            Vector3 moveDir = transform.position - player.transform.position;
            moveDir.y = 0;
            transform.Translate(moveDir * force * Time.deltaTime);
        }        
    }

}
