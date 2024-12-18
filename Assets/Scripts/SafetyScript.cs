using UnityEngine;
using UnityEngine.UI;

public class SafetyScript : MonoBehaviour
{
    [SerializeField]
    private GameObject Selection_Button;
    void Start()
    {
        Toggle toggle = Selection_Button.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggle);
        });
    }

    void ToggleValueChanged(Toggle change)
    {
       Debug.Log("State changed - " +  change);
    }
}
