using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform Player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent <Transform> ();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w")) {
            Player.Translate (new Vector3(0, 0, -speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s")) {
            Player.Translate (new Vector3(0, 0, speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")) {
            Player.Translate (new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) {
            Player.Translate (new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
    }
}
