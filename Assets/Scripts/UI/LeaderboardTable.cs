/* Jazmin Fazzolari, 30.06.2022 */
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class LeaderboardTable : MonoBehaviour
{
    /* Variables */
    [SerializeField] private GameManager gameManager;

    [Header("Current Game")]
    [SerializeField] private TMP_Text currentScoreText;

    [Header("Leaderboard Parameters")]
    [SerializeField] private Transform leaderboardContainer;
    [SerializeField] private Transform leaderboardTemplate;

    [Tooltip("The maximum amount of entries to be displayed.")]
    [Range(0, 8)]
    [SerializeField] private int maxEntries = 3;
    [Tooltip("The maximum amount of characters allowed in the players name.")]
    [Range(1, 16)]
    [SerializeField] private int nameCharacterLength = 3;

    [Header("Highscore Entry Parameters")]
    [SerializeField] private TMP_Text rankText;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text nameText;

    /* Private Variables */
    private List<Transform> leaderboardEntryTransformList;

    private string jsonLEADERBOARD = "leaderboardTable";

    /// <summary>
    /// Awake
    /// </summary>
    private void Awake()
    {
        leaderboardTemplate.gameObject.SetActive(false); //Hide default template

        /* Initialise Leaderboard */
        string jsonString = PlayerPrefs.GetString(jsonLEADERBOARD); //Find the leaderboard
        Leaderboard leaderboard = JsonUtility.FromJson<Leaderboard>(jsonString); //Load the leaderboard

        SortDescending(leaderboard);

        /* Cycle Leaderboard List Entries */
        int i = 0;
        leaderboardEntryTransformList = new List<Transform>();
        foreach (LeaderboardEntry entry in leaderboard.leaderboardEntryList)
        {
            InstantiateLeaderboardEntry(entry, leaderboardContainer, leaderboardEntryTransformList, i); //Creates a new entry
            i++;
        }
    }

    /// <summary>
    /// Sort the leaderboard list in descending order (highest to lowest)
    /// </summary>
    private void SortDescending(Leaderboard lb)
    {
        for (int i = 0; i < lb.leaderboardEntryList.Count; i++)
        {
            for (int j = i + 1; j < lb.leaderboardEntryList.Count; j++)
            {
                /* Compare Scores */
                if (lb.leaderboardEntryList[j].playerScore > lb.leaderboardEntryList[i].playerScore)
                {
                    /* Swap Scores */
                    LeaderboardEntry temp = lb.leaderboardEntryList[i]; //Cache entry i
                    lb.leaderboardEntryList[i] = lb.leaderboardEntryList[j]; //Copy entry j into entry i
                    lb.leaderboardEntryList[j] = temp; //Copy cache entry i into entry j
                }
            }
        }
    }

    /// <summary>
    /// Creates new leaderboard entry and adds it to the leaderboard
    /// </summary>
    /// <param name="lbEntry">The leaderboard entry</param>
    /// <param name="lbContainer">Container to add leaderboard entry to</param>
    /// <param name="lbTransformsList">List that the instantiated leaderboard entry's transform is added to</param>
    private void InstantiateLeaderboardEntry(LeaderboardEntry lbEntry, Transform lbContainer, List<Transform> lbTransformsList, int index)
    {
        /* Populate Text Fields */
        int rank = index + 1;

        rankText.text = rank.ToString("00"); //Display rank
        scoreText.text = lbEntry.playerScore.ToString("0000"); //Display highscore
        nameText.text = lbEntry.playerName.Substring(0, nameCharacterLength); //Display name (truncates)

        /* Instantiate Entry */
        Transform entryTransform = Instantiate(leaderboardTemplate, lbContainer); //Instantiate a new template as achild of the container

        entryTransform.gameObject.SetActive(true); //Enable the new entry
    }

    /// <summary>
    /// Call this function to add a new entry after each game
    /// </summary>
    /// <param name="score">The players highscore</param>
    /// <param name="name">The players name</param>
    private void AddLeaderboardEntry(int score, string name)
    {
        /* Create Entry Object */
        LeaderboardEntry lbEntry = new LeaderboardEntry() { playerScore = score, playerName = name };

        /* Load */
        string jsonString = PlayerPrefs.GetString(jsonLEADERBOARD); //Find the stored playerPref
        Leaderboard leaderboard = JsonUtility.FromJson<Leaderboard>(jsonString); //Retrieve it from the JSON file

        /* Add Entry to List */
        leaderboard.leaderboardEntryList.Add(lbEntry);

        /* Save */
        string json = JsonUtility.ToJson(leaderboard); //Convert leaderboard entry list into a JSON string
        PlayerPrefs.SetString(jsonLEADERBOARD, json); //Store the leaderboard (as a JSON string) using playerPrefs under "leaderboardTable"
        PlayerPrefs.Save(); //Save

        Debug.Log(PlayerPrefs.GetString(jsonLEADERBOARD));

    }

    /// <summary>
    /// Private class representing a leaderboard entry.
    /// </summary>
    [System.Serializable]
    private class LeaderboardEntry
    {
        public int playerScore;
        public string playerName;
    }

    /// <summary>
    /// Contains list of leaderboard entries
    /// </summary>
    private class Leaderboard
    {
        public List<LeaderboardEntry> leaderboardEntryList;
    }
}
