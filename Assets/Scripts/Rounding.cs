using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Rounding : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var num = 6.583f;
        
        Debug.Log("Round value : " + Mathf.Round(num));
        Debug.Log("Floor value : " + Mathf.Floor(num));
        Debug.Log("Ceiling value : " + Mathf.Ceil(num));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
