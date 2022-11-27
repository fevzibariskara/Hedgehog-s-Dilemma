using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerDetector : MonoBehaviour
{
    public Text scoreText;

    [SerializeField] private float _scoreAmount, _scoreIncreasedPerSecond;

    private void Start()
    {
        _scoreAmount = 0;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            collision.attachedRigidbody.transform.localScale += new Vector3(0.005f, 0.005f, 0);
        }

        if (collision.transform.tag == "Enemy")
        {
            scoreText.text = (int)_scoreAmount + " Oxytocin";
            _scoreAmount += _scoreIncreasedPerSecond * Time.deltaTime;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Penalty")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }

}
