using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cameracontrol : MonoBehaviour
{
    public float posY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}
