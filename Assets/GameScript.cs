using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public LayerMask LayerM;
    public GameObject GameOverPanel;

    private Vector3 m_Scale;

    private Collider[] colls;

    void Start()
    {
        m_Scale = new Vector3(12, 0.8f, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        colls = Physics.OverlapBox(transform.position, m_Scale, Quaternion.identity,LayerM);

        if (colls.Length > 0) 
        {
            GameOver();
        }

    }

    private void GameOver()
    {

        GameOverPanel.SetActive(true);
    }

}
