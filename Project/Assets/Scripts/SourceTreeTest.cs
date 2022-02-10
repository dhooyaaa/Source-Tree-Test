using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceTreeTest : MonoBehaviour
{
    // Start is called before the first frame update

    public bool completeDone = false;
    public int sourcetree = 0;
    public float kkk ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void test()
    {
        int c = 1;
        kkk = 1.2f;
        Debug.Log($"c : {c}");
        Debug.Log($"kkk : {kkk}");

    }
}
