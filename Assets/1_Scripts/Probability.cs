using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probability : MonoBehaviour
{
    [SerializeField]
    private GameObject success;
    [SerializeField]
    private GameObject faild;
    private Level level;
    private LikeAblity likeAblity;
    void Start()
    {
        level = GameObject.Find("GameManager").GetComponent<Level>();
        likeAblity = GameObject.Find("GameManager").GetComponent<LikeAblity>();
    }

    public void Fan()
    {
        Debug.Log("호출");
        float k = Mathf.Round(Random.Range(0.1f, 100.0f)*10f) / 10f;
        if(k >= level.probablity)
        {
            faild.SetActive(true);
            Invoke("Wait15SecFaild", 1.5f);
        }
        else
        {
            success.SetActive(true);
            Invoke("Wait15SecSuccess", 1.5f);
            likeAblity.LikeUp();
        }
    }

    void Wait15SecFaild()
    {
        faild.SetActive(false);
    }

    void Wait15SecSuccess()
    {
        success.SetActive(false);
    }
}
