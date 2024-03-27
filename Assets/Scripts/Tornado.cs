using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tornado : MonoBehaviour
{
    public GameObject tornadoGameObject;
    public float time = 3;
    public bool left = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (time <= 0)
        {
            left = !left;
            time = 3;
        }
        if (left)
        {
            tornadoGameObject.transform.position += new Vector3(0.05f, 0, 0);
        }
        else
        {
            tornadoGameObject.transform.position -= new Vector3(0.05f, 0, 0);
        }
        time -= Time.deltaTime;
        
    }
}
