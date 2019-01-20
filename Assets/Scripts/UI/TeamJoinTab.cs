using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamJoinTab : MonoBehaviour
{
    public int Team = 0;
    public Image Flag;
    public Text TeamName;
    public Text PlayerCount;

    public void SetTeam(int team)
    {
        Team = team;
    }

    public void JoinTeam()
    {
        //NETCODE TO JOIN TEAM
    }
}
