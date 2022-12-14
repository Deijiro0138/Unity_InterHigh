using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;
public class ranking : MonoBehaviour {
    public int currentRank = 0;
    public List<HighScore> topRankers;
    public List<HighScore> neighbors;
    /*void Start()
    /*{
        topRankers = null;
        neighbors = null;
    }*/

    // 現プレイヤーのハイスコアを受けとってランクを取得 ---------------
    public void fetchRank(int currentScore)
    {
        // データスコアの「HighScore」から検索
        NCMBQuery<NCMBObject> rankQuery = new NCMBQuery<NCMBObject>("HighScore");
        rankQuery.WhereGreaterThan("Score", currentScore);
        rankQuery.CountAsync((int count, NCMBException e) => {

            if (e != null)
            {
                //件数取得失敗
            }
            else {
                //件数取得成功
                currentRank = count + 1; // 自分よりスコアが上の人がn人いたら自分はn+1位
            }
        });
    }

    // サーバーからトップ5を取得 ---------------    
    public void fetchTopRankers()
    {
        // データストアの「HighScore」クラスから検索
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("HighScore");
        query.OrderByDescending("Score");
        query.Limit = 5;
        query.FindAsync((List<NCMBObject> objList, NCMBException e) => {

            if (e != null)
            {
                //検索失敗時の処理
            }
            else {
                //検索成功時の処理
                List<HighScore> list = new List<HighScore>();
                // 取得したレコードをHighScoreクラスとして保存
                foreach (NCMBObject obj in objList)
                {
                    int s = System.Convert.ToInt32(obj["Score"]);
                    string n = System.Convert.ToString(obj["Name"]);
                    HighScore h = new HighScore();
                    h.username = n;
                    h.score = s;
                    list.Add(h);
                }
                topRankers = list;
            }
        });
    }

    // サーバーからrankの前後2件を取得 ---------------
    public void fetchNeighbors()
    {
        neighbors = new List<HighScore>();

        // スキップする数を決める（ただし自分が1位か2位のときは調整する）
        int numSkip = currentRank - 3;
        if (numSkip < 0) numSkip = 0;

        // データストアの「HighScore」クラスから検索
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("HighScore");
        query.OrderByDescending("Score");
        query.Skip = numSkip;
        query.Limit = 5;
        query.FindAsync((List<NCMBObject> objList, NCMBException e) => {

            if (e != null)
            {
                //検索失敗時の処理
            }
            else {
                //検索成功時の処理

                List<HighScore> list = new List<HighScore>();
                // 取得したレコードをHighScoreクラスとして保存
                foreach (NCMBObject obj in objList)
                {
                    int s = System.Convert.ToInt32(obj["Score"]);
                    string n = System.Convert.ToString(obj["Name"]);
                    /*GameObject ob = new GameObject("haikei");
                    HighScore h = ob.AddComponent<HighScore>();*/
                    HighScore h=new HighScore();
                    h.username = n;
                    h.score = s;
                    list.Add(h);
                }
                neighbors = list;
            }
        });
    }
}
