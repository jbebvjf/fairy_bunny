using UnityEngine;
using UnityEngine.UI;

public class ChangeImage: MonoBehaviour
{
    int x = 0;
    [Header("Image")]
    [SerializeField] private Image img;

    [Header("Sprites")]
    [SerializeField] private Sprite[] sprite = new Sprite[7];

    [Header("Slider")]
    [SerializeField] public Slider slider1;

    [Header("Sounds")]
    [SerializeField] private AudioClip[] sounds = new AudioClip[7];
    private AudioSource audioSrc => GetComponent<AudioSource>();

    [SerializeField] private GameObject button;
    [SerializeField] private GameObject button1;


    public void buttons()
    {
        if (x == 0)
        {
            button1.SetActive(false);
            button.SetActive(true);
        }
        else if (x == 6)
        {
            button.SetActive(false);
            button1.SetActive(true);
        }
        else
        {
            button1.SetActive(true);
            button.SetActive(true);
        }
    }
    public void ChangeSprite()
    {
        x += 1;
        audioSrc.enabled = false;
        img.sprite = sprite[x];
        audioSrc.enabled = true;
        audioSrc.PlayOneShot(sounds[x]);


        
        
    }
    public void ChangeSprite1()
    {
        if (x == 0)
        {
            button1.SetActive(true);
        }
        x -= 1;
        audioSrc.enabled = false;
        img.sprite = sprite[x];
        audioSrc.enabled = true;
        audioSrc.PlayOneShot(sounds[x]);
    }

    public void Stop1()
        {
            audioSrc.enabled = false;
        }
    void Update()
    {
        audioSrc.volume = slider1.value;
    }
    public void first()
    {
        audioSrc.PlayOneShot(sounds[0]);
    }
}
