using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public GameObject sampleText;
    public GameObject sampleTextBackdrop;


    public void onFontSizeChanged()
    {
        var fontSize = GetComponent<Slider>().value;
        sampleText.GetComponent<TMPro.TextMeshProUGUI>().fontSize = (int)fontSize;
    }

    public void onColorButtonClicked()
    {
        TextOptions.TextColor = gameObject.name.Substring(4);
        AssignTextAreaColors();
    }

    public void onDarkModeToggle()
    {
        TextOptions.InDarkMode = !TextOptions.InDarkMode;
        AssignTextAreaColors();
    }

    private void AssignTextAreaColors()
    {
        if (string.IsNullOrEmpty(TextOptions.TextColor)) TextOptions.TextColor = "Gray";

        var color = TextOptions.InDarkMode ? TextPalette.Color[TextOptions.TextColor].Dark : TextPalette.Color[TextOptions.TextColor].Light;
        sampleText.GetComponent<TMPro.TextMeshProUGUI>().color = color;

        if (sampleTextBackdrop)
        {
            var textBackdropColor = TextOptions.InDarkMode ? TextPalette.Color["Backdrop"].Dark : TextPalette.Color["Backdrop"].Light;
            sampleTextBackdrop.GetComponent<CanvasRenderer>().SetColor(textBackdropColor);
        }
    }
}
