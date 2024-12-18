using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class RoundedTMPImage : MonoBehaviour
{
    [Range(0, 100)]
    public float cornerRadius = 20f; // Radius for rounding corners
    private Material roundedMaterial;

    private void Awake()
    {
        // Create or assign the rounded corners material
        if (!roundedMaterial)
        {
            roundedMaterial = new Material(Shader.Find("UI/RoundedCorners"));
        }

        GetComponent<Image>().material = roundedMaterial;
        UpdateCornerRadius();
    }

    private void Update()
    {
        // Update corner radius dynamically if it's changed
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
