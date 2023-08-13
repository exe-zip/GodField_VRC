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
        for(int i = 0; i < data_card.Length; i++)   //Šm—¦•ê”ŒvŽZ
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

        for(int i = 0; i < 10; i++)
        {
            Debug.Log(Draw().name);
        }
    }

    public CardDataBase Draw()
    {
        return data_card[deck[Random.Range(0, deck_len)]];
    }

    void Update()
    {
        
    }
}
