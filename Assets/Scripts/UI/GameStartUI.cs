using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartUI : MonoBehaviour
{
    [Header("Game Start Screens")]
    public GameObject FFA_UI;
    public GameObject TeamSelect_UI;

    [Header("Team")]
    public Transform TeamsPanel;
    private List<GameObject> TeamTabs = new List<GameObject>();

    [Header("Prefabs")]
    public GameObject TeamTab_Prefab;

    // Start is called before the first frame update
    void Start()
    {
        SetupTeamUI(8, Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetupGameStart()
    {

    }

    void SetupTeamUI(int teamCount, Color teamColor)
    {
        for (int i = 0; i < teamCount; i++)
        {
            TeamJoinTab tab = Instantiate(TeamTab_Prefab, TeamsPanel).GetComponent<TeamJoinTab>();
            tab.SetTeam(i);


            TeamTabs.Add(tab.gameObject);
        }
    }
}
