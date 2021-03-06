using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;
    public FloatValue heartContainers;
    public FloatValue currentPlayerHearts;

    // Start is called before the first frame update
    void Start()
    {
        InitHearts();
    }
    private void FixedUpdate()
    {
        UpdateHearts();
    }

    public void InitHearts(){
        for(int i = 0 ; i < heartContainers.RuntimeValue ; i++)
        {
            hearts[i].gameObject.SetActive(true);
            hearts[i].sprite = fullHeart;
        }
    }
    public void UpdateHearts()
    {
        float tempHealth = currentPlayerHearts.RuntimeValue / 2;
        for(int i = 0 ; i < heartContainers.initialValue; i++){
            if(i <= tempHealth-1)
            {
                hearts[i].sprite = fullHeart;
            }else if(i>= tempHealth)
            {
                hearts[i].sprite = emptyHeart;
            }else{
                hearts[i].sprite = halfHeart;
            }
        }
    }

}
