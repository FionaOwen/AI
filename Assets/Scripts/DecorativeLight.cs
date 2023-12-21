using UnityEngine;

public class DecorativeLight : MonoBehaviour
{
    public float minEmission = 0.5f; // Minimum emission intensity
    public float maxEmission = 1.5f; // Maximum emission intensity
    public float pulseSpeed = 1.0f; // Speed of the pulsating effect
    public int materialIndexToChange;

    private Material[] materials;
    private Color baseColors;
    private float currentIntensity;


    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            materials = renderer.materials;
            
            baseColors = materials[materialIndexToChange].GetColor("_EmissionMap");
          

            currentIntensity = minEmission;
        }
        else
        {
            Debug.LogError("DecorativeLight script requires a Renderer component with materials that support emission.");
            enabled = false; // Disable the script if the required components are not present.
        }
    }

    void Update()
    {
        // Calculate the pulsating effect
        currentIntensity = Mathf.PingPong(Time.time * pulseSpeed, 1.0f);

            // Calculate the final emission color for each material
            Color finalColor = baseColors * Mathf.LinearToGammaSpace(Mathf.Lerp(minEmission, maxEmission, currentIntensity));

            // Set the emission color in the material
            materials[materialIndexToChange].SetColor("_EmissionMap", finalColor);
        

        // Ensure changes are applied immediately
        ApplyMaterialChanges();
    }

    void ApplyMaterialChanges()
    {
        foreach (var material in materials)
        {
            material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;
        }
    }
}
