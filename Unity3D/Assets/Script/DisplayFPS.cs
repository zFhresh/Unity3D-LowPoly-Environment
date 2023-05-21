using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayFPS : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI text;
    void Start()
    {
        InvokeRepeating("DisplayFPSF", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void DisplayFPSF()
    {
        float fps = 1 / Time.deltaTime;
        text.text = "FPS: " + fps.ToString("F0");
    }
}
