using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class RoundedCorners : MonoBehaviour
{
    [Range(0, 100)]
    public float cornerRadius = 20f; // Adjustable corner radius
    private Material roundedMaterial;

    private void Start()
    {
        // Create and assign a material with a shader for rounded corners
        roundedMaterial = new Material(Shader.Find("UI/RoundedCorners"));
        GetComponent<Image>().material = roundedMaterial;

        UpdateCornerRadius();
    }

    private void Update()
    {
        // Update corner radius in real-time if adjusted
        UpdateCornerRadius();
    }

    private void UpdateCornerRadius()
    {
        if (roundedMaterial != null)
        {
            roundedMaterial.SetFloat("_CornerRadius", cornerRadius);
        }
    }
}
