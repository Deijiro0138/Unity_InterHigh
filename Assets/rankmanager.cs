using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class rankmanager : MonoBehaviour {
    private ranking lBoard = new ranking();
    private HighScore currentHighScore;
    public GameObject[] top = new GameObject[5];
    public GameObject[] nei = new GameObject[5];
    string name;
    public static bool isScoreFetched;
    public static bool isRankFetched;
   public static bool isLeaderBoardFetched;
    public static bool issearch;
    // ボタンが押されると対応する変数がtrueになる
    private bool backButton;
    void Start()
    {
        lBoard = new ranking();
        issearch = false;
        // テキストを表示するゲームオブジェクトを取得
       /*for (int i = 0; i < 5; ++i)
        {
            top[i] = GameObject.Find("Top" + i);
            nei[i] = GameObject.Find("Neighbor" + i);
        }*/

        // フラグ初期化
        isScoreFetched = false;
        isRankFetched = false;
        isLeaderBoardFetched = false;

        // 現在のハイスコアを取得
        /*if (FindObjectOfType<UserAuth>() != null)
        {*/
            string name = FindObjectOfType<UserAuth>().currentPlayer();
            currentHighScore = this.gameObject.AddComponent<HighScore>();
            currentHighScore.score = -1;
            currentHighScore.username = name;
            currentHighScore.fetch();
       // }
    }

    void Update()
    {
        if (issearch == false)
        {
            for (int i = 0; i < 5; ++i)
            {
                top[i] = GameObject.Find("Top" + i);
                nei[i] = GameObject.Find("Neighbor" + i);
            }
            issearch = true;
        }
        // 現在のハイスコアの取得が完了したら1度だけ実行
        if (currentHighScore != null && currentHighScore.score != -1&&!isScoreFetched)
        {
            lBoard.fetchRank(currentHighScore.score);
            isScoreFetched = true;
        }

        // 現在の順位の取得が完了したら1度だけ実行
        if (lBoard.currentRank != 0&&!isRankFetched)
        {
            lBoard.fetchTopRankers();
            lBoard.fetchNeighbors();
            isRankFetched = true;
        }

        // ランキングの取得が完了したら1度だけ実行
        if (lBoard.topRankers != null && lBoard.neighbors != null&&!isLeaderBoardFetched)
        {
            // 自分が1位のときと2位のときだけ順位表示を調整
            int offset = 2;
            if (lBoard.currentRank == 1) offset = 0;
            if (lBoard.currentRank == 2) offset = 1;
            /*if (lBoard.currentRank == 3) offset = 2;
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
            isLeaderBoardFetched = true;
        }
        name = Application.loadedLevelName;
    }

   /* void OnGUI()
    {
        drawMenu();
        // 戻るボタンが押されたら
        if (backButton)
            Application.LoadLevel("rankselect");
    }

    private void drawMenu()
    {
        // ボタンの設置
        int btnW = 170, btnH = 30;
        GUI.skin.button.fontSize = 20;
        backButton = GUI.Button(new Rect(Screen.width * 1 / 2 - btnW * 1 / 2, Screen.height * 7 / 8 - btnH * 1 / 2, btnW, btnH), "Back");
        /*if (name != "LeaderBoard")
        {
            GameObject.Find("Back").GetComponent<UnityEngine.UI.Button>().enabled = false;
        }
    }*/
}