using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
  public float speed = 20.0f;
  public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
      rotation = new Vector3(Random.Range(-10,10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        transform.Rotate(rotation, Space.World);
    }
}
