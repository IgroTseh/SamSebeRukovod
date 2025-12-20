using UnityEngine;
using UnityEngine.UI;

public class DialogSpriteClickUpdater : MonoBehaviour {
    [Header("UI элементы")]
    public Image playerSpeaker;
    public Image otherSpeaker;
    public Image dialogueBackground;
    public Image fadeImage;

    [Header("Все спрайты")]
    public Sprite[] allSprites; // Загружаешь все спрайты через инспектор по порядку

    private int clickCount = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleClick(clickCount);
            clickCount++;
        }
    }

    private void HandleClick(int clickNumber)
    {
        switch (clickNumber)
        {
            case 3: // Художник
                ChangeOtherSpeakerSprite(4);
                break;
                 
            case 7: // Налоговая
                ChangeOtherSpeakerSprite(6);
                break;

            case 11: // Айтишник
                ChangeOtherSpeakerSprite(8);
                break;

            case 15: // Конкурент
                ChangeOtherSpeakerSprite(15);
                break;

            case 21: // Экономист
                ChangeOtherSpeakerSprite(10);
                break;

            case 28: // Поставщик
                ChangeOtherSpeakerSprite(3);
                break;

            case 32: // Покупатель
                ChangeOtherSpeakerSprite(5);
                break;

            case 39:
                ChangeOtherSpeakerSprite(13);
                break;

            default:
                break;
        }
    }

    public void ChangePlayerSpeakerSprite(int index)
    {
        if (index >= 0 && index < allSprites.Length)
            playerSpeaker.sprite = allSprites[index];
        else
            Debug.LogWarning($"Нет спрайта с индексом {index}");
    }

    public void ChangeOtherSpeakerSprite(int index)
    {
        if (index >= 0 && index < allSprites.Length)
            otherSpeaker.sprite = allSprites[index];
        else
            Debug.LogWarning($"Нет спрайта с индексом {index}");
    }

    public void ChangeBackground(int index)
    {
        if (index >= 0 && index < allSprites.Length)
            dialogueBackground.sprite = allSprites[index];
        else
            Debug.LogWarning($"Нет спрайта с индексом {index}");
    }

    public void Fade()
    {
        if (fadeImage == null) return;

        fadeImage.gameObject.SetActive(true);
        fadeImage.color = new Color(0, 0, 0, 1);

        Invoke(nameof(EndFade), 0.5f);
    }

    private void EndFade()
    {
        if (fadeImage != null)
            fadeImage.gameObject.SetActive(false);
    }
}
