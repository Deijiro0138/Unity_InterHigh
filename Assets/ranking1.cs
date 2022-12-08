using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;
public class ranking1 : MonoBehaviour
{
    public int currentRank = 0;
    public List<Highscore1> topRankers; //= null;
    public List<Highscore1> neighbors; //= null;
   /* void Start()
    {
        topRankers = null;
        neighbors = null;
    }*/
    // 現プレイヤーのハイスコアを受けとってランクを取得 ---------------
    public void fetchRank(int currentScore)
    {
        // データスコアの「HighScore」から検索
        NCMBQuery<NCMBObject> rankQuery = new NCMBQuery<NCMBObject>("HighScore1");
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
        NCMBQuery<NCMBObject> query1 = new NCMBQuery<NCMBObject>("HighScore1");
        query1.OrderByDescending("Score");
        query1.Limit = 5;
        query1.FindAsync((List<NCMBObject> objList, NCMBException e) => {

            if (e != null)
            {
                //検索失敗時の処理
            }
            else {
                //検索成功時の処理
                List<Highscore1> list = new List<Highscore1>();
                // 取得したレコードをHighScoreクラスとして保存
                foreach (NCMBObject obj in objList)
                {
                    int s = System.Convert.ToInt32(obj["Score"]);
                    string n = System.Convert.ToString(obj["Name"]);
                    Highscore1 h = new Highscore1();
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
        neighbors = new List<Highscore1>();

        // スキップする数を決める（ただし自分が1位か2位のときは調整する）
        int numSkip = currentRank - 3;
        if (numSkip < 0) numSkip = 0;

        // データストアの「HighScore」クラスから検索
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("HighScore1");
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

                List<Highscore1> list = new List<Highscore1>();
                // 取得したレコードをHighScoreクラスとして保存
                foreach (NCMBObject obj in objList)
                {
                    int s = System.Convert.ToInt32(obj["Score"]);
                    string n = System.Convert.ToString(obj["Name"]);
                   /* GameObject ob = new GameObject("haikei");
                    Highscore1 h = ob.AddComponent<Highscore1>();*/
                     Highscore1 h = new Highscore1();
                    h.username = n;
                    h.score = s;
                    list.Add(h);
                }
                neighbors = list;
            }
        });
    }
}
