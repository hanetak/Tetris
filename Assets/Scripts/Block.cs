using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    //ブロックの色
    public Sprite[] color = new Sprite[9];


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //画像を設定
    public void SetState(GameManager.eBlockState state)
    {
        switch (state)
        {
            case GameManager.eBlockState.eNone:
                spriteRenderer.sprite = color[7];
                break;
            case GameManager.eBlockState.eFrame:
                spriteRenderer.sprite = color[8];
                break;
            case GameManager.eBlockState.eRed:
                spriteRenderer.sprite = color[0];
                break;
            case GameManager.eBlockState.eGreen:
                spriteRenderer.sprite = color[1];
                break;
            case GameManager.eBlockState.ePurple:
                spriteRenderer.sprite = color[2];
                break;
            case GameManager.eBlockState.eYellow:
                spriteRenderer.sprite = color[3];
                break;
            case GameManager.eBlockState.eSkyBlue:
                spriteRenderer.sprite = color[4];
                break;
            case GameManager.eBlockState.eBrue:
                spriteRenderer.sprite = color[5];
                break;
            case GameManager.eBlockState.eOrange:
                spriteRenderer.sprite = color[6];
                break;

        }

    }

}

