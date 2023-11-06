using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FanMeetingRank : MonoBehaviour
{
    [SerializeField]
    private Text Rank;
    [SerializeField]
    private Text TicketPrice;
    [SerializeField]
    private Probability probability;
    [SerializeField]
    private Money money;
    [SerializeField]
    private FanMeetingLock fanMeetingLock;
    [SerializeField]
    private GameObject warning;

    private char[] rank = { 'A', 'B', 'C' };

    private int a;

    private void Start()
    {
    }

    private void Update()
    {
        
    }

    public void Open()
    {
        int k = Random.Range(1, 101);
        Debug.Log(k);
        if ( k <= 10)
        {
            Rank.text = rank[0].ToString();
            Price(rank[0]);
            a = 0;
        }
        else if (k <= 40)
        {
            Rank.text = rank[1].ToString();
            Price(rank[1]);
            a = 1;
        }
        else
        {
            Rank.text = rank[2].ToString();
            Price(rank[2]);
            a = 2;
        }

    }

    private void Price(char k)
    {
        if (k == rank[0]) TicketPrice.text = "30����";
        else if (k == rank[1]) TicketPrice.text = "20����";
        else TicketPrice.text = "10����";
    }

    public void BuyTicket()
    {
        if (a == 0)
        {
            if (money.coin > 300000)
            {
                money.coin -= 300000;
                fanMeetingLock.OnClick();
                probability.Fan();
            }
            else
            {
                warning.SetActive(true);
                Invoke("Wait", 1.5f);
            }
        }
        else if (a == 1)
        {
            if (money.coin > 200000)
            {
                money.coin -= 200000;
                fanMeetingLock.OnClick();
                probability.Fan();

            }
            else
            {
                warning.SetActive(true);
                Invoke("Wait", 1.5f);
            }
        }
        else if (a == 2)
        {
            if (money.coin > 100000)
            {
                money.coin -= 100000;
                fanMeetingLock.OnClick();
                probability.Fan();

            }
            else
            {
                warning.SetActive(true);
                Invoke("Wait", 1.5f);
            }
        }
    }

    void Wait()
    {
        warning.SetActive(false);
    }
}