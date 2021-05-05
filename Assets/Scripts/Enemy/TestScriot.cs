using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TestScriot : MonoBehaviour
{
    [SerializeField] GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
