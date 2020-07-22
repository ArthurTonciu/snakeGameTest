using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerColider : MonoBehaviour
{
    public Text text;
    public int score;
    public GameObject deadMenu;
    public GameObject Player;
    public GameObject clon;
    public GameObject clon1;
    public GameObject clon2;
    public GameObject clon3;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
        if (score == 1)
        {
            clon.GetComponent<MeshRenderer>().enabled = true;
        }
        if (score == 2)
        {
            clon1.GetComponent<MeshRenderer>().enabled = true;
        }
        if (score == 3)
        {
            clon2.GetComponent<MeshRenderer>().enabled = true;
        }
        if (score == 4)
        {
            clon3.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void OnCollisionEnter(Collision Boxenemy)
    {
        if (Boxenemy.collider.GetComponent<enemy>())
        {
            Time.timeScale = 0;
            deadMenu.SetActive(true);
            Player.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coins"))
        {
            Destroy(other.gameObject);
            score++;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
