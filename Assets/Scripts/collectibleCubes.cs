using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleCubes : MonoBehaviour
{
    [SerializeField]
    public collecter collecter;
    bool _isCollect;
    int index;
    void Start()
    {
        _isCollect = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isCollect == true) 
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    public bool Get_isCollect()
    {
        return _isCollect;
    }

    public void collectDo()
    {
        _isCollect = true;
    }

    public void indexMake(int index)
    {
        this.index = index;
    }

}
