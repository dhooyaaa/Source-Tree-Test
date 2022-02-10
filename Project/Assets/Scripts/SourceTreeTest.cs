using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceTreeTest : MonoBehaviour
{
    // Start is called before the first frame update

    public bool completeDone = false;
    public int sourcetree = 0;
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
        Debug.Log($"c : {c}");
        Debug.Log($"sourcetree : {sourcetree}");

    }
}
