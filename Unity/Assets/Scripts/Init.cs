using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class Global
{
    // field
    public static int[] Field;
}

public class Init : MonoBehaviour
{
    public GameObject block;

    void Start()
    {
        int i, j, k;
        float s = 2;
        int s1 = 3, s2 = 3, s3 = 3; 

        Global.Field = new int[s1 * s2 * s3];
        for (i = 0; i < s1 * s2 * s3; i++)
          Global.Field[i] = Random.Range(0, 2);

        for (i = 0; i < s1; i++)
          for (j = 0; j < s2; j++)
            for (k = 0; k < s3; k++)
            {
              if (Global.Field[i * s2 * s1 + j * s2 + k] == 1)
                Instantiate(block, new Vector3(i * s, j * s, k * s), Quaternion.identity);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
