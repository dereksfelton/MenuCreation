using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioSource ambientSound; 

    public void onVolumeChange()
    {
        ambientSound.volume = GetComponent<Slider>().value;
    }
}
