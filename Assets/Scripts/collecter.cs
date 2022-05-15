using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collecter : MonoBehaviour
{
    GameObject mainCube;
    int yukseklik;
    void Start()
    {
        mainCube = GameObject.Find("mainCube");
        
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);     //çarptýðýmýz kübün altýmýzda olmasýný istiyoruz.
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectible" && other.gameObject.GetComponent<collectibleCubes>().Get_isCollect()==false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<collectibleCubes>().collectDo();
            other.gameObject.GetComponent<collectibleCubes>().indexMake(yukseklik);
            other.gameObject.transform.parent = mainCube.transform;   //çarptýðýmýz küp mainCube etiketi altýna girecek
        }
    }
}
