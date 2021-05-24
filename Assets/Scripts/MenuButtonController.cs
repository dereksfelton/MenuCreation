using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    private TMPro.TextMeshProUGUI textChild;
    private Vector4 aqua;
    private Vector4 yellow;

    public void Start()
    {
        textChild = gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>();
        aqua = new Vector4(112.0f / 255.0f, 255.0f / 255.0f, 244.0f / 255.0f, 1.0f);
        yellow = new Vector4(255.0f / 255.0f, 255.0f / 255.0f, 112.0f / 255.0f, 1.0f);
    }

    public void onPointerEnter()
    {
        textChild.color = yellow;
    }

    public void onPointerExit()
    {
        textChild.color = aqua;
    }

    public void onQuit()
    {
        Application.Quit();
    }
}
