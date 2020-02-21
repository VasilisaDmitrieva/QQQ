using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    public GameObject go;
    public float sensitivity = 1F;
    private Camera  goCamera;
    private Vector3  MousePos;
    private float   MyAngle = 0F;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
      goCamera = GetComponent<Camera>();
      go = goCamera.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.W))
        Player.transform.position += new Vector3 ((float)(Player.transform.forward[0] * Time.deltaTime * 10), (float)(Player.transform.forward[1] * Time.deltaTime * 10), (float)(Player.transform.forward[2] * Time.deltaTime * 10));
      if (Input.GetKey(KeyCode.S))
        Player.transform.position -= new Vector3 ((float)(Player.transform.forward[0] * Time.deltaTime * 10), (float)(Player.transform.forward[1] * Time.deltaTime * 10), (float)(Player.transform.forward[2] * Time.deltaTime * 10));
      if (Input.GetKey(KeyCode.Q))
        Player.transform.position += new Vector3 ((float)(Player.transform.up[0] * Time.deltaTime * 10), (float)(Player.transform.up[1] * Time.deltaTime * 10), (float)(Player.transform.up[2] * Time.deltaTime * 10));     
      if (Input.GetKey(KeyCode.E))
        Player.transform.position -= new Vector3 ((float)(Player.transform.up[0] * Time.deltaTime * 10), (float)(Player.transform.up[1] * Time.deltaTime * 10), (float)(Player.transform.up[2] * Time.deltaTime * 10));     
      if (Input.GetKey(KeyCode.D))
        Player.transform.position += new Vector3 ((float)(Player.transform.right[0] * Time.deltaTime * 10), (float)(Player.transform.right[1] * Time.deltaTime * 10), (float)(Player.transform.right[2] * Time.deltaTime * 10));     
      if (Input.GetKey(KeyCode.A))
        Player.transform.position -= new Vector3 ((float)(Player.transform.right[0] * Time.deltaTime * 10), (float)(Player.transform.right[1] * Time.deltaTime * 10), (float)(Player.transform.right[2] * Time.deltaTime * 10));     
    }

    void FixedUpdate () 
    {
      if ( Input.GetMouseButton(1) )
       {
        MyAngle = 0;
        MyAngle = sensitivity * ((MousePos[0]-(Screen.width / 2)) / Screen.width);
        goCamera.transform.RotateAround(go.transform.position, goCamera.transform.up, MyAngle);
        MyAngle = sensitivity * ((MousePos[1]-(Screen.height / 2)) / Screen.height);
        goCamera.transform.RotateAround(go.transform.position, goCamera.transform.right, -MyAngle);
       }
    }
}
