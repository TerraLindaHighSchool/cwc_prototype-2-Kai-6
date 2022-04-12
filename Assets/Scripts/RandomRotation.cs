using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
  public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = new Vector3(Random.Range(-10,10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation, Space.World);
    }
}
