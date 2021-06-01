using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] GameObject ItemPanel;
    // Start is called before the first frame update
    void Start()
    {
        ItemPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("i"))
        {
            ItemPanel.SetActive(!ItemPanel.activeSelf);
        }
    }
}
