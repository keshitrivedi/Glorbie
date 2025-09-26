using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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
    public GameObject Player;

    public TextMeshProUGUI promptText;
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

        if (batteryScript.isCollected && Math.Sqrt(Math.Pow(Player.transform.position.x - Lights.transform.position.x, 2) + Math.Pow(Player.transform.position.z - Lights.transform.position.z, 2)) < 5f)
        {
            Debug.Log("light");
            lightMaterial.EnableKeyword("_EMISSION");
            lightMaterial.SetColor("_EmissionColor", Color.yellow * 100f);
            promptText.text = "Finally!";
        }

        if ((Math.Sqrt(Math.Pow(Player.transform.position.x - Lights.transform.position.x, 2) + Math.Pow(Player.transform.position.z - Lights.transform.position.z, 2)) < 10f) && batteryScript.isCollected == false)
        {
            promptText.text = "I must find the battery to light up the stall";
        }
        // else
        // {
        //     lightMaterial.SetColor("_EmissionColor", Color.black);
        // }
    }
}