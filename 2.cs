using UnityEngine;
using UnityEngine.UI;

public class a : MonoBehaviour
{
 int x = 0;
[Header("Image")]
[SerializeField] private Image img;

[Header("Sprites")]
[SerializeField] private Sprite[] sprite = new Sprite[6];

[Header("Slider")]
[SerializeField] public Slider slider1;

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
    img.sprite = sprite[x];




}
public void ChangeSprite1()
{
    if (x == 0)
    {
        button1.SetActive(true);
    }
    x -= 1;
    img.sprite = sprite[x];
}
}
