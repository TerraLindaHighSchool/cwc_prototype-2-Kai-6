using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float horizontalInput;
  public float speed = 10.0f;
  public float xRange = 10;
  public GameObject[] projectilePrefabs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(transform.position.x < -xRange) {
          transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange) {
          transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space)) {
          int rand = Mathf.FloorToInt(Random.Range(0, projectilePrefabs.Length - 0.1111f));
          Instantiate(projectilePrefabs[rand], new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.Euler(0, 0, 0));
        }
    }
}
