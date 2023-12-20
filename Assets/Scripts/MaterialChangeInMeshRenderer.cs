using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Material[] originalMaterials;
    public Material newMaterial;
    public int materialArrayNumberChange;
    public Light streetLampSpotlight;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterials = meshRenderer.materials;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ChangeMaterial();
            if(streetLampSpotlight != null)
            {
                streetLampSpotlight.enabled = true;
            }
        }
    }

    // Function to change the material
    public void ChangeMaterial()
    {
        if(materialArrayNumberChange >= 0 && materialArrayNumberChange < originalMaterials.Length)
        {
            originalMaterials[materialArrayNumberChange] = newMaterial;
            meshRenderer.materials = originalMaterials;
        }
        else
        {
            Debug.Log("Invalid material index!");
        }
    }
}
