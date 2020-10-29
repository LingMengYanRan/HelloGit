using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("hujiahui");
    }
    // Start is called before the first frame update
    Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        Debug.Log("liwei修改");
        Debug.Log("liwei再次修改了");
        Debug.Log("hujiahui又修改了");
        Debug.Log("hujiahui用git了");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
