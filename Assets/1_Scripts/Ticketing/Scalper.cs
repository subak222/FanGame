using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalper : MonoBehaviour
{
    [SerializeField]
    private GameObject scalper;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Failbuy()
    {
        yield return StartCoroutine(Save.instance.DeleteInfo());
        Application.Quit();
    }

    public void PressYes()
    {
        scalper.SetActive(false);
        int k = Random.Range(0, 101);
        if (k <= 30)
        {
            int l = Random.Range(0, 3);
            if (l == 0)
            {
                User.fanmeetingA++;
            }
            else if (l == 1)
            {
                User.fanmeetingB++;
            }
            else
            {
                User.fanmeetingC++;
            }
        }
        else
        {
            Debug.Log("�� ������ ���� ������");
            // delete
            StartCoroutine(Failbuy());
        }
    }

    public void PressNo()
    {
        scalper.SetActive(false);
    }
}