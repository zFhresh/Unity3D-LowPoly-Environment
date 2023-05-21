using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    [SerializeField] GameObject[] FrontObjects;
    [SerializeField] List<Material> FrontMaterials;
    private void Awake() {
        for (int i = 0; i < FrontObjects.Length; i++)
        {
            FrontMaterials.Add(FrontObjects[i].GetComponent<Renderer>().material);
        }
    }
    void Start()
    {
        
    }
    float Targetalpha = 1;
    void Alpha() {
        foreach (Material item in FrontMaterials) {
            item.SetFloat("_AlphaValue", Mathf.Lerp(item.GetFloat("_AlphaValue"), Targetalpha, Time.deltaTime * 1.3f));
        }
    }
    public void SetAlpha(float _alpha) {
        Targetalpha = _alpha;
    }
    // Update is called once per frame
    void Update()
    {
        Alpha();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            SetAlpha(0.2f);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            SetAlpha(1);
        }
    }

}
