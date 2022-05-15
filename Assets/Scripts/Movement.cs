using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float leftRightSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * leftRightSpeed * Time.deltaTime;
        this.transform.Translate(yatayEksen, 0, forwardSpeed * Time.deltaTime);
    }
}
