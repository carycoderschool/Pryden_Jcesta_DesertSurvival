using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public Sprite full_heart;
    public Sprite half_heart;
    public Sprite empty_heart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Healthupdater(int HP)
    {
        if (HP == 1)
        {
            heart1.sprite = half_heart;
            heart2.sprite = empty_heart;
            heart3.sprite = empty_heart;
        }

        if (HP == 0)
        {
            heart1.sprite = empty_heart;
            heart2.sprite = empty_heart;
            heart3.sprite = empty_heart;
        }

        if (HP == 2)
        {
            heart1.sprite = full_heart;
            heart2.sprite = empty_heart;
            heart3.sprite = empty_heart;
        }

        if (HP == 3)
        {
            heart1.sprite = full_heart;
            heart2.sprite = half_heart;
            heart3.sprite = empty_heart;
        }

        if (HP == 4)
        {
            heart1.sprite = full_heart;
            heart2.sprite = full_heart;
            heart3.sprite = empty_heart;
        }

        if (HP == 5)
        {
            heart1.sprite = full_heart;
            heart2.sprite = full_heart;
            heart3.sprite = half_heart;
        }

        if (HP == 6)
        {
            heart1.sprite = full_heart;
            heart2.sprite = full_heart;
            heart3.sprite = full_heart;
        }

    }
}
