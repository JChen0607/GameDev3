using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image HeartPrefab;
    public Sprite FullHeart;
    public Sprite EmptyHeart;

    private List<Image> hearts = new List<Image>();
    

    public void SetMaxHeart(int MaxHearts)
    {
        foreach(Image heart in hearts)
        {
            Destroy(heart.gameObject);
        }
        hearts.Clear();

        for (int i = 0; i < MaxHearts; i ++)
        {
            Image newHeart = Instantiate(HeartPrefab, transform);
            newHeart.sprite = FullHeart;
            newHeart.color = Color.white;
            hearts.Add(newHeart);
        }
    }

    public void UpdateHearts (int currentHealth)
    {
        for (int i = 0; i < hearts.Count; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = FullHeart;
                hearts[i].color = Color.white;

            }
            else
            {

                hearts[i].sprite = EmptyHeart;
                hearts[i].color = Color.black;
            }
        }
    }
}
