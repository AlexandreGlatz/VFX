using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField] GameObject _object;

    [SerializeField] float _rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(0, _rotationSpeed, 0 );
        _object.transform.Rotate(target);
    }
}
