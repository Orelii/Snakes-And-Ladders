using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    private int turnNumber = 0;
    int playerCount = 0;
    int playerSelectedCount;
    GameObject playermenupanel;
    GameObject colourmenupanel;
    GameObject dicepanel;
    Button colourbutton;
    Text header;
    public GameObject[] boardArray;

    // Start is called before the first frame update
    void Start()
    {
        boardArray = new GameObject[105] { GameObject.Find("BoardSpace"), GameObject.Find("BoardSpace (1)"), GameObject.Find("BoardSpace (2)"), GameObject.Find("BoardSpace (3)"), GameObject.Find("BoardSpace (4)"), GameObject.Find("BoardSpace (5)"), GameObject.Find("BoardSpace (6)"), GameObject.Find("BoardSpace (7)"), GameObject.Find("BoardSpace (8)"), GameObject.Find("BoardSpace (9)"), GameObject.Find("BoardSpace (10)"), GameObject.Find("BoardSpace (11)"), GameObject.Find("BoardSpace (12)"), GameObject.Find("BoardSpace (13)"), GameObject.Find("BoardSpace (14)"), GameObject.Find("BoardSpace (15)"), GameObject.Find("BoardSpace (16)"), GameObject.Find("BoardSpace (17)"), GameObject.Find("BoardSpace (18)"), GameObject.Find("BoardSpace (19)"), GameObject.Find("BoardSpace (20)"), GameObject.Find("BoardSpace (21)"), GameObject.Find("BoardSpace (22)"), GameObject.Find("BoardSpace (23)"), GameObject.Find("BoardSpace (24)"), GameObject.Find("BoardSpace (25)"), GameObject.Find("BoardSpace (26)"), GameObject.Find("BoardSpace (27)"), GameObject.Find("BoardSpace (28)"), GameObject.Find("BoardSpace (29)"), GameObject.Find("BoardSpace (30)"), GameObject.Find("BoardSpace (31)"), GameObject.Find("BoardSpace (32)"), GameObject.Find("BoardSpace (33)"), GameObject.Find("BoardSpace (34)"), GameObject.Find("BoardSpace (35)"), GameObject.Find("BoardSpace (36)"), GameObject.Find("BoardSpace (37)"), GameObject.Find("BoardSpace (38)"), GameObject.Find("BoardSpace (39)"), GameObject.Find("BoardSpace (40)"), GameObject.Find("BoardSpace (41)"), GameObject.Find("BoardSpace (42)"), GameObject.Find("BoardSpace (43)"), GameObject.Find("BoardSpace (44)"), GameObject.Find("BoardSpace (45)"), GameObject.Find("BoardSpace (46)"), GameObject.Find("BoardSpace (47)"), GameObject.Find("BoardSpace (48)"), GameObject.Find("BoardSpace (49)"), GameObject.Find("BoardSpace (50)"), GameObject.Find("BoardSpace (51)"), GameObject.Find("BoardSpace (52)"), GameObject.Find("BoardSpace (53)"), GameObject.Find("BoardSpace (54)"), GameObject.Find("BoardSpace (55)"), GameObject.Find("BoardSpace (56)"), GameObject.Find("BoardSpace (57)"), GameObject.Find("BoardSpace (58)"), GameObject.Find("BoardSpace (59)"), GameObject.Find("BoardSpace (60)"), GameObject.Find("BoardSpace (61)"), GameObject.Find("BoardSpace (62)"), GameObject.Find("BoardSpace (63)"), GameObject.Find("BoardSpace (64)"), GameObject.Find("BoardSpace (65)"), GameObject.Find("BoardSpace (66)"), GameObject.Find("BoardSpace (67)"), GameObject.Find("BoardSpace (68)"), GameObject.Find("BoardSpace (69)"), GameObject.Find("BoardSpace (70)"), GameObject.Find("BoardSpace (71)"), GameObject.Find("BoardSpace (72)"), GameObject.Find("BoardSpace (73)"), GameObject.Find("BoardSpace (74)"), GameObject.Find("BoardSpace (75)"), GameObject.Find("BoardSpace (76)"), GameObject.Find("BoardSpace (77)"), GameObject.Find("BoardSpace (78)"), GameObject.Find("BoardSpace (79)"), GameObject.Find("BoardSpace (80)"), GameObject.Find("BoardSpace (81)"), GameObject.Find("BoardSpace (82)"), GameObject.Find("BoardSpace (83)"), GameObject.Find("BoardSpace (84)"), GameObject.Find("BoardSpace (85)"), GameObject.Find("BoardSpace (86)"), GameObject.Find("BoardSpace (87)"), GameObject.Find("BoardSpace (88)"), GameObject.Find("BoardSpace (89)"), GameObject.Find("BoardSpace (90)"), GameObject.Find("BoardSpace (91)"), GameObject.Find("BoardSpace (92)"), GameObject.Find("BoardSpace (93)"), GameObject.Find("BoardSpace (94)"), GameObject.Find("BoardSpace (95)"), GameObject.Find("BoardSpace (96)"), GameObject.Find("BoardSpace (97)"), GameObject.Find("BoardSpace (98)"), GameObject.Find("BoardSpace (99)"), GameObject.Find("BoardSpace (98)"), GameObject.Find("BoardSpace (97)"), GameObject.Find("BoardSpace (96)"), GameObject.Find("BoardSpace (95)"), GameObject.Find("BoardSpace (94)") };
        colourmenupanel = GameObject.Find("ColourMenuPanel");
        playermenupanel = GameObject.Find("PlayerMenuPanel");
        colourmenupanel.SetActive(false);
        dicepanel = GameObject.Find("ButtonCanvas");
        dicepanel.SetActive(false);
        playerSelectedCount = 0;
    }

    #region Number of Players
    public void P2Select()
    {
        playerCount = 2;
        colourmenupanel.SetActive(true);
        playermenupanel.SetActive(false);
    }
    public void P3Select()
    {
        playerCount = 3;
        colourmenupanel.SetActive(true);
        playermenupanel.SetActive(false);
    }
    public void P4Select()
    {
        playerCount = 4;
        colourmenupanel.SetActive(true);
        playermenupanel.SetActive(false);
    }
    public void P5Select()
    {
        playerCount = 5;
        colourmenupanel.SetActive(true);
        playermenupanel.SetActive(false);
    }
    public void P6Select()
    {
        playerCount = 6;
        colourmenupanel.SetActive(true);
        playermenupanel.SetActive(false);
    }
    #endregion
    #region Player Colours
    public void BlueSel()
    {
        GameObject meeple = GameObject.FindGameObjectWithTag("Blue");
        header = GameObject.Find("ColourHeader").GetComponent<Text>();
        colourbutton = GameObject.Find("BlueSel").GetComponent<Button>();
        playerSelectedCount++;
        if (playerSelectedCount == playerCount)
        {
            colourmenupanel.SetActive(false);
            dicepanel.SetActive(true);
            GameObject[] hazardArray = GameObject.FindGameObjectsWithTag("LadderSnake");
            foreach (GameObject hazard in hazardArray)
            {
                hazard.GetComponent<SpriteRenderer>().forceRenderingOff = false;
            }
        }
        else
        {
            colourbutton.interactable = false;
            header.text = "Player " + (playerSelectedCount + 1) + " Colour";
        }
        meeple.GetComponent<Meeple>().priority = playerSelectedCount - 1;
        meeple.GetComponent<Meeple>().UpdatePriority();
        meeple.GetComponent<Meeple>().ArrangeStartingPositions();
    }
    public void RedSel()
    {
        GameObject meeple = GameObject.FindGameObjectWithTag("Red");
        header = GameObject.Find("ColourHeader").GetComponent<Text>();
        colourbutton = GameObject.Find("RedSel").GetComponent<Button>();
        playerSelectedCount++;
        if (playerSelectedCount == playerCount)
        {
            colourmenupanel.SetActive(false);
            dicepanel.SetActive(true);
            GameObject[] hazardArray = GameObject.FindGameObjectsWithTag("LadderSnake");
            foreach (GameObject hazard in hazardArray)
            {
                hazard.GetComponent<SpriteRenderer>().forceRenderingOff = false;
            }
        }
        else
        {
            colourbutton.interactable = false;
            header.text = "Player " + (playerSelectedCount + 1) + " Colour";
        }
        meeple.GetComponent<Meeple>().priority = playerSelectedCount - 1;
        meeple.GetComponent<Meeple>().UpdatePriority();
        meeple.GetComponent<Meeple>().ArrangeStartingPositions();
    }
    public void GreenSel()
    {
        GameObject meeple = GameObject.FindGameObjectWithTag("Green");
        header = GameObject.Find("ColourHeader").GetComponent<Text>();
        colourbutton = GameObject.Find("GreenSel").GetComponent<Button>();
        playerSelectedCount++;
        if (playerSelectedCount == playerCount)
        {
            colourmenupanel.SetActive(false);
            dicepanel.SetActive(true);
            GameObject[] hazardArray = GameObject.FindGameObjectsWithTag("LadderSnake");
            foreach (GameObject hazard in hazardArray)
            {
                hazard.GetComponent<SpriteRenderer>().forceRenderingOff = false;
            }
        }
        else
        {
            colourbutton.interactable = false;
            header.text = "Player " + (playerSelectedCount + 1) + " Colour";
        }
        meeple.GetComponent<Meeple>().priority = playerSelectedCount - 1;
        meeple.GetComponent<Meeple>().UpdatePriority();
        meeple.GetComponent<Meeple>().ArrangeStartingPositions();
    }
    public void YellowSel()
    {
        GameObject meeple = GameObject.FindGameObjectWithTag("Yellow");
        header = GameObject.Find("ColourHeader").GetComponent<Text>();
        colourbutton = GameObject.Find("YellowSel").GetComponent<Button>();
        playerSelectedCount++;
        if (playerSelectedCount == playerCount)
        {
            colourmenupanel.SetActive(false);
            dicepanel.SetActive(true);
            GameObject[] hazardArray = GameObject.FindGameObjectsWithTag("LadderSnake");
            foreach (GameObject hazard in hazardArray)
            {
                hazard.GetComponent<SpriteRenderer>().forceRenderingOff = false;
            }
        }
        else
        {
            colourbutton.interactable = false;
            header.text = "Player " + (playerSelectedCount + 1) + " Colour";
        }
        meeple.GetComponent<Meeple>().priority = playerSelectedCount - 1;
        meeple.GetComponent<Meeple>().UpdatePriority();
        meeple.GetComponent<Meeple>().ArrangeStartingPositions();
    }
    public void PurpleSel()
    {
        GameObject meeple = GameObject.FindGameObjectWithTag("Purple");
        header = GameObject.Find("ColourHeader").GetComponent<Text>();
        colourbutton = GameObject.Find("PurpleSel").GetComponent<Button>();
        playerSelectedCount++;
        if (playerSelectedCount == playerCount)
        {
            colourmenupanel.SetActive(false);
            dicepanel.SetActive(true);
            GameObject[] hazardArray = GameObject.FindGameObjectsWithTag("LadderSnake");
            foreach (GameObject hazard in hazardArray)
            {
                hazard.GetComponent<SpriteRenderer>().forceRenderingOff = false;
            }
        }
        else
        {
            colourbutton.interactable = false;
            header.text = "Player " + (playerSelectedCount + 1) + " Colour";
        }
        meeple.GetComponent<Meeple>().priority = playerSelectedCount - 1;
        meeple.GetComponent<Meeple>().UpdatePriority();
        meeple.GetComponent<Meeple>().ArrangeStartingPositions();
    }
    public void WhiteSel()
    {
        GameObject meeple = GameObject.FindGameObjectWithTag("White");
        header = GameObject.Find("ColourHeader").GetComponent<Text>();
        colourbutton = GameObject.Find("WhiteSel").GetComponent<Button>();
        playerSelectedCount++;
        if (playerSelectedCount == playerCount)
        {
            colourmenupanel.SetActive(false);
            dicepanel.SetActive(true);
            GameObject[] hazardArray = GameObject.FindGameObjectsWithTag("LadderSnake");
            foreach (GameObject hazard in hazardArray)
            {
                hazard.GetComponent<SpriteRenderer>().forceRenderingOff = false;
            }
        }
        else
        {
            colourbutton.interactable = false;
            header.text = "Player " + (playerSelectedCount + 1) + " Colour";
        }
        meeple.GetComponent<Meeple>().priority = playerSelectedCount - 1;
        meeple.GetComponent<Meeple>().UpdatePriority();
        meeple.GetComponent<Meeple>().ArrangeStartingPositions();
    }
    #endregion
    public void RollDice()
    {
        GameObject dice = GameObject.FindGameObjectWithTag("Die");
        dice.GetComponent<Dice>().DiceRoll(DetermineLowestPriority(), false);
    }
    public GameObject DetermineLowestPriority()
    {
        GameObject currentDude;
        #region define meeple
        GameObject red = GameObject.FindGameObjectWithTag("Red");
        GameObject blue = GameObject.FindGameObjectWithTag("Blue");
        GameObject green = GameObject.FindGameObjectWithTag("Green");
        GameObject yellow = GameObject.FindGameObjectWithTag("Yellow");
        GameObject purple = GameObject.FindGameObjectWithTag("Purple");
        GameObject white = GameObject.FindGameObjectWithTag("White");
        #endregion
        currentDude = red;
        GameObject[] meeple = new GameObject[] { red, yellow, green, blue, purple, white };
        foreach (GameObject merson in meeple)
        {
            if (merson.GetComponent<Meeple>().priority == 0)
            {
                currentDude = merson;
            }
        }
        return currentDude;
    }
    public void CyclePriority()
    {
        #region define meeple
        GameObject red = GameObject.FindGameObjectWithTag("Red");
        GameObject blue = GameObject.FindGameObjectWithTag("Blue");
        GameObject green = GameObject.FindGameObjectWithTag("Green");
        GameObject yellow = GameObject.FindGameObjectWithTag("Yellow");
        GameObject purple = GameObject.FindGameObjectWithTag("Purple");
        GameObject white = GameObject.FindGameObjectWithTag("White");
        #endregion
        GameObject[] meeple = new GameObject[] { red, yellow, green, blue, purple, white };
        foreach (GameObject merson in meeple)
        {
            if (merson.GetComponent<Meeple>().priority != null)
            {
                if (merson.GetComponent<Meeple>().priority == 0)
                {
                    merson.GetComponent<Meeple>().priority = playerSelectedCount - 1;
                }
                else
                {
                    merson.GetComponent<Meeple>().priority--;
                }
            }
        }
        red.GetComponent<Meeple>().UpdatePriority();
    }
}
