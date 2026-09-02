using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;
public class UIEvents : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void CloseButton()
    {
        Application.Quit();
    }

    public void VolumeSlider(float value)
    {
        audioMixer.SetFloat("MasterVolume", value);
    }

}
