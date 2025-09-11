using System;
using Unity.VisualScripting;
using UnityEngine;

public class StallLightningManager : MonoBehaviour
{
    public GameObject Battery;
    private Battery batteryScript;
    private MeshRenderer batteryMesh;
    private Collider batteryCollider;
    private Light lightScript;
    public GameObject Lights;
    private MeshRenderer lightMesh;
    private Material lightMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        batteryScript = Battery.GetComponent<Battery>();
        batteryMesh = Battery.GetComponent<MeshRenderer>();
        batteryCollider = Battery.GetComponent<Collider>();
        lightScript = Lights.GetComponent<Light>();
        lightMesh = Lights.GetComponent<MeshRenderer>();
        lightMaterial = lightMesh.material;
        lightMaterial.SetColor("_EmissionColor", Color.black);
    }

    // Update is called once per frame
    void Update()
    {
        if (batteryScript.isCollected)
        {
            Debug.Log("Battery collected");
            batteryMesh.enabled = false;
            batteryCollider.enabled = false;
        }

        if (batteryScript.isCollected && Math.Sqrt(Math.Pow(Battery.transform.position.x - Lights.transform.position.x, 2) + Math.Pow(Battery.transform.position.z - Lights.transform.position.z, 2)) < 10f)
        {
            Debug.Log("light");
            lightMaterial.EnableKeyword("_EMISSION");
            lightMaterial.SetColor("_EmissionColor", Color.yellow * 100f);
        }
        // else
        // {
        //     lightMaterial.SetColor("_EmissionColor", Color.black);
        // }
    }
}