using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMover1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.left * (5 * Time.deltaTime);
        if (gameObject.transform.position.x < -30) {
            Destroy(gameObject);
        }
    }
}
