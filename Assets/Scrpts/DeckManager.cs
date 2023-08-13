using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public CardDataBase[] data_card = new CardDataBase[0];
    public int[] probability = new int[0];
    int[] deck;
    int deck_len=0;
    void Start()
    {
        for(int i = 0; i < data_card.Length; i++)   //�m���ꐔ�v�Z
        {
            deck_len += probability[i];
        }

        deck = new int[deck_len];

        int nownum = 0;
        for (int i = 0; i < data_card.Length; i++)
        {
            for(int j = 0; j < probability[i]; j++)
            {
                deck[nownum] = i;
                nownum++;
            }
        }

        for(int i = 0; i < deck.Length; i++)
        {
            Debug.Log(deck[i]);
        }
    }

    void Update()
    {
        
    }
}
