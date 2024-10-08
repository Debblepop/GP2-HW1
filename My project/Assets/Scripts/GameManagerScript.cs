using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI Text;
    public int Score = 0;
    public float Timer = 6;
    public GameObject SamplePrefab;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Score: " + Score;

        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        if (Timer <= 0)
        {
            Sample();
            Timer = 6;
        }

        if (Score == 20)
        {
            SceneManager.LoadScene("You Win");
        }
    }
    void Sample()
    {
        Vector3 where = new Vector3(Random.Range(-8f, 8f), Random.Range(-5f, 5f), 0);
        Instantiate(SamplePrefab, where, Quaternion.identity);
    }
}
