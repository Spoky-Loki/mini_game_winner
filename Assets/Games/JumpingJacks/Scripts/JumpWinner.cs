using TMPro;
using UnityEngine;

public class JumpWinner : MonoBehaviour
{
    public GameObject playerLeft;
    public GameObject playerRight;
    public GameObject cm;

    private int scoreLeft;
    private int scoreRight;

    public TMP_Text WinnerText;

    void Update()
    {
        scoreLeft = playerLeft.GetComponent<LeftPlayer>().score;
        scoreRight = playerRight.GetComponent<RightPlayer>().score;
        if (!playerLeft.activeSelf && !playerRight.activeSelf)
        {
            cm.SetActive(true);
            if (scoreLeft > scoreRight)
                WinnerText.text = "����� ����� �������!";
            if (scoreLeft < scoreRight)
                WinnerText.text = "����� ������ �������!";
            if (scoreLeft == scoreRight)
                WinnerText.text = "�����";
            gameObject.SetActive(false);
        }
    }
}
