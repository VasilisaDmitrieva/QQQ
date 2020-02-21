using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public float sensitivity = 1F;
    private Camera goCamera;
    private Vector3 MousePos;
    private Vector3 SaveMouse;
    private Vector3 SaveFor;
    private Vector3 SaveUp;
    private float   MyAngle = 0F;
    private int Istab;
    // Start is called before the first frame update
    void Start()
    { 
      goCamera = GetComponent<Camera>();
      SaveFor = goCamera.transform.forward;
      SaveUp = goCamera.transform.up;      
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.P))
      {
        goCamera.transform.forward = SaveFor;
        goCamera.transform.up = SaveUp;
      }

      if ((Istab == 0) && Input.GetMouseButtonDown(1))
      {
        Istab = 1;
        SaveMouse = Input.mousePosition;
      }
      
      if (Input.GetMouseButtonUp(1))
      {
        Istab = 0;
        SaveMouse = Input.mousePosition;
      }
      
      if (Input.GetMouseButton(1))
        MousePos = Input.mousePosition;        
    }

    void FixedUpdate() 
    {
      Vector3 Delta = MousePos - SaveMouse;
      goCamera.transform.Rotate(new Vector3(-Delta[1] * 0.01f, -Delta[0] * 0.01f, 0));
    }
}
