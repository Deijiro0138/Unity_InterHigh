using UnityEngine;

public class DemoOwnershipGui : MonoBehaviour
{
    public GUISkin Skin;
    public bool TransferOwnershipOnRequest = true;

    public void OnOwnershipRequest(object[] viewAndPlayer)
    {
        PhotonView view = viewAndPlayer[0] as PhotonView;
        PhotonPlayer requestingPlayer = viewAndPlayer[1] as PhotonPlayer;

        Debug.Log("OnOwnershipRequest(): Player " + requestingPlayer + " requests ownership of: " + view + ".");
        if (this.TransferOwnershipOnRequest)
        {
            view.TransferOwnership(requestingPlayer.ID);
        }
    }


    #region Unity

    public void OnGUI()
    {
        GUI.skin = this.Skin;
        GUILayout.BeginArea(new Rect(Screen.width - 200, 0, 200, Screen.height));
        {
            string label = TransferOwnershipOnRequest ? "passing objects" : "rejecting to pass";
            if (GUILayout.Button(label))
            {
                this.TransferOwnershipOnRequest = !this.TransferOwnershipOnRequest;
            }
        }
        GUILayout.EndArea();



        if (PhotonNetwork.inRoom)
        {
            int playerNr = PhotonNetwork.player.ID;
            string playerIsMaster = PhotonNetwork.player.isMasterClient ? "(master) " : "";
            string playerColor = PlayerVariables.GetColorName(PhotonNetwork.player.ID);
            GUILayout.Label(string.Format("player {0}, {1} {2}(you)", playerNr, playerColor, playerIsMaster));

            foreach (PhotonPlayer otherPlayer in PhotonNetwork.otherPlayers)
            {
                playerNr = otherPlayer.ID;
                playerIsMaster = otherPlayer.isMasterClient ? "(master)" : "";
                playerColor = PlayerVariables.GetColorName(otherPlayer.ID);
                GUILayout.Label(string.Format("player {0}, {1} {2}", playerNr, playerColor, playerIsMaster));
            }

            if (PhotonNetwork.inRoom && PhotonNetwork.otherPlayers.Length == 0)
            {
                GUILayout.Label("Join more clients to switch object-control.");
            }
        }
        else
        {
            GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
        }
    }

    #endregion
}