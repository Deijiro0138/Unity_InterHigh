using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Rankmanager1 : MonoBehaviour {
    private ranking1 lBoard;
    private Highscore1 currentHighScore;
    public GameObject[] top = new GameObject[5];
    public GameObject[] nei = new GameObject[5];
    string name;
    public static bool isScoreFetched1;
    public static bool isRankFetched1;
    public static bool isLeaderBoardFetched1;
    public static bool issearch1;
    // ボタンが押されると対応する変数がtrueになる
    private bool backButton;
    void Start()
    {
        
        lBoard = new ranking1();
        issearch1 = false;
        // フラグ初期化1
        isScoreFetched1 = false;
        isRankFetched1= false;
        isLeaderBoardFetched1 = false;

        // 現在のハイスコアを取得
        /*if (FindObjectOfType<UserAuth>() != null)
        {*/
            string name = FindObjectOfType<UserAuth>().currentPlayer();
            currentHighScore = this.gameObject.AddComponent<Highscore1>();
            currentHighScore.score = -1;
            currentHighScore.username = name;
            currentHighScore.fetch1();
        //}
    }

    void Update()
    {
        
        if (issearch1 == false)
        {
            for (int i = 0; i < 5; ++i)
            {
                top[i] = GameObject.Find("Top" + i);
                nei[i] = GameObject.Find("Neighbor" + i);
            }
            issearch1 = true;
        }
        // 現在のハイスコアの取得が完了したら1度だけ実行
        if (currentHighScore != null && currentHighScore.score != -1&&!isScoreFetched1)
        {
            lBoard.fetchRank(currentHighScore.score);
           isScoreFetched1 = true;
        }

        // 現在の順位の取得が完了したら1度だけ実行
        if (lBoard.currentRank != 0&&!isRankFetched1)
        {
            lBoard.fetchTopRankers();
            lBoard.fetchNeighbors();
            isRankFetched1 = true;
        }

        // ランキングの取得が完了したら1度だけ実行
        if (lBoard.topRankers != null && lBoard.neighbors != null&&!isLeaderBoardFetched1)
        {
            // 自分が1位のときと2位のときだけ順位表示を調整
            int offset = 2;
            if (lBoard.currentRank == 1) offset = 0;
            if (lBoard.currentRank == 2) offset = 1;
           /* if (lBoard.currentRank == 3) offset = 2;
            if (lBoard.currentRank == 4) offset = 3;
            if (lBoard.currentRank == 5) offset = 4;*/

            // 取得したトップ5ランキングを表示
            for (int i = 0; i < lBoard.topRankers.Count; ++i)
            {
                top[i].GetComponent<GUIText>().text = i + 1 + ". " + lBoard.topRankers[i].print();
            }

            // 取得したライバルランキングを表示
            for (int i = 0; i < lBoard.neighbors.Count; ++i)
            {
                nei[i].GetComponent<GUIText>().text = lBoard.currentRank - offset + i + ". " + lBoard.neighbors[i].print();
            }
            isLeaderBoardFetched1 = true;
        }
        name = Application.loadedLevelName;
    }

    /*void OnGUI()
    {
        drawMenu();
        // 戻るボタンが押されたら
        if (backButton)
            Application.LoadLevel("online");
    }

    private void drawMenu()
    {
        // ボタンの設置
        int btnW = 170, btnH = 30;
        GUI.skin.button.fontSize = 20;
        backButton = GUI.Button(new Rect(Screen.width * 1 / 2 - btnW * 1 / 2, Screen.height * 7 / 8 - btnH * 1 / 2, btnW, btnH), "Back");
        if (name != "LeaderBoard")
        {
            GameObject.Find("Back").GetComponent<UnityEngine.UI.Button>().enabled = false;
        }
    }*/
}