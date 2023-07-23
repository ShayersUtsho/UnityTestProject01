using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utha : MonoBehaviour
{
    public float speed = 5;
    public Vector3 position;
    public Quaternion rotation;
    public Vector3 scale;
    private void Awake()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Started");
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = position;
        transform.localScale = scale;
        transform.rotation = rotation;
        Debug.Log(position);
        Debug.Log(rotation);
        Debug.Log(scale);
        if (Input.GetKey(KeyCode.Space))                                    transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift))                                transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))       transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))     transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))     transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))    transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;


        position = transform.position;
        scale = transform.localScale;
        rotation = transform.rotation;
    }
}
