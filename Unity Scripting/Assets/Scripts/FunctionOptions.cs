using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionOptions : MonoBehaviour
{
    public int number;
    
    // Start is called before the first frame update
    void Start()
    {
        number = MathExample(7);
    }

    public int MathExample(int value)
    {
        return value + 3;
    }
 
}
