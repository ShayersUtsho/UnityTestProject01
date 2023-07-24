using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utha : MonoBehaviour
{
    public float speed = 5;
    public Vector3 position;
    public Quaternion rotation;
    public Vector3 scale;
    public bool plane_mode = false;
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
/*        Debug.Log(position);
        Debug.Log(rotation);
        Debug.Log(scale);*/


        if (Input.GetKey(KeyCode.Space)) 
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift)) 
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;

        float angleXZ = transform.rotation.eulerAngles.y;
        Debug.Log(angleXZ);
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(1 * (float)System.Math.Sin(angleXZ * 3.14159265f / 180), 0, 1 * (float)System.Math.Cos(angleXZ * 3.14159265f / 180)) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(-1 * (float)System.Math.Sin(angleXZ * 3.14159265f / 180), 0, -1 * (float)System.Math.Cos(angleXZ * 3.14159265f / 180)) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Q))
            transform.position += new Vector3(-1 * (float)System.Math.Sin((angleXZ + 90) * 3.14159265f / 180), 0, -1 * (float)System.Math.Cos((angleXZ + 90) * 3.14159265f / 180)) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.E))
            transform.position += new Vector3(1 * (float)System.Math.Sin((angleXZ + 90) * 3.14159265f / 180), 0, 1 * (float)System.Math.Cos((angleXZ + 90) * 3.14159265f / 180)) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, rotation.eulerAngles.y - 45 * speed * Time.deltaTime, transform.rotation.eulerAngles.z);
        if (Input.GetKey(KeyCode.D))
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, rotation.eulerAngles.y + 45 * speed * Time.deltaTime, transform.rotation.eulerAngles.z);


        position = transform.position;
        scale = transform.localScale;
        rotation = transform.rotation;
    }
}
