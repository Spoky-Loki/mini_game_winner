using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CubeTowerCubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject StartCube;
    private GameObject LastCube;

    public AudioSource pop;

    private int level = 0;
    private Vector3 pos1 = new Vector3(0, 0.5f, -7);
    private Vector3 pos2 = new Vector3(-7, 0.5f, 0);

    public bool isEnd = false;

    public int Score = 0;
    public GameObject ScoreText;

    private void Start()
    {
        LastCube = StartCube;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isEnd)
        {
            pop.Play();
            LastCube.GetComponent<CubeTowerMovingCube>().Stop();
            if (!isEnd)
                SpawnCube();

            ScoreText.GetComponent<Text>().text = "Score: " + Score.ToString();
            Score++;
        }
    }

    public void SpawnCube()
    {
        var cube = Instantiate(cubePrefab);
        cube.GetComponent<CubeTowerMovingCube>().spawner = gameObject.GetComponent<CubeTowerCubeSpawner>();
        cube.GetComponent<CubeTowerMovingCube>().LastCube = LastCube.transform;
        cube.transform.localScale = LastCube.transform.localScale;
        cube.GetComponent<CubeTowerMovingCube>().moveSpeed += level;
        LastCube = cube;
        //transform.position = level % 2 == 0 ? pos1 : pos2;
        cube.transform.position = new Vector3
            (transform.position.x, transform.position.y + 0.5f * level, transform.position.z);
        //cube.transform.rotation = Quaternion.Euler(0, level % 2 == 0 ? 0 : 90, 0);
        level++;
    }

    public void End()
    {
        isEnd = true;

        ScoreText.GetComponent<RectTransform>().anchoredPosition = new Vector2(-100, -130);
        ScoreText.GetComponent<RectTransform>().offsetMin += new Vector2(-120, 296);
        ScoreText.GetComponent<RectTransform>().offsetMax -= new Vector2(120, -296);

        Invoke("GameIsOver", 2);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, cubePrefab.transform.localScale);
    }

    public void GameIsOver()
    {
        BasicValues bv = GameObject.Find("NotDestroy(Clone)").GetComponent<BasicValues>();

        int x = Score;

        if (x > 8)
        {
            if (x <= 9)
                bv.ChooseBonus(1);
            if (x <= 10)
                bv.ChooseBonus(2);
            if (x <= 12)
                bv.ChooseBonus(3);
            if (x <= 14)
                bv.ChooseBonus(4);
            if (x <= 15 || bv.playersCount == 1)
                bv.ChooseBonus(5);
            else
                bv.ChooseBonus(6);
        }

        bv.MenuOrBoard();
    }
}
