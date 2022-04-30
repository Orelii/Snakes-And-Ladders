using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meeple : MonoBehaviour
{
    public int turn = 0;
    public int? priority;
    public int currentSpace = -1;
    public GameObject uno;
    public GameObject dos;
    public GameObject tres;
    public GameObject cuatro;
    public GameObject cinco;
    public GameObject seis;
    public Color colour;
    GameObject info;
    Button DiceButton;

    void Start()
    {
        info = GameObject.FindGameObjectWithTag("Info");
    }

    public void ArrangeStartingPositions()
    {
        switch (priority)
        {
            case 0:
                transform.position = new Vector3(-5.5f, -4.44f, -1);
                break;
            case 1:
                transform.position = new Vector3(-6.5f, -4, -1);
                break;
            case 2:
                transform.position = new Vector3(-5.5f, -3.44f, -1);
                break;
            case 3:
                transform.position = new Vector3(-6.5f, -3, -1);
                break;
            case 4:
                transform.position = new Vector3(-5.5f, -2.44f, -1);
                break;
            case 5:
                transform.position = new Vector3(-6.5f, -2, -1);
                break;
            default:
                transform.position = new Vector3(1.5f, 6.5f, -1);
                break;
        }
    }

    public void UpdatePriority()
    {
        #region define meeple
        GameObject red = GameObject.FindGameObjectWithTag("Red");
        GameObject blue = GameObject.FindGameObjectWithTag("Blue");
        GameObject green = GameObject.FindGameObjectWithTag("Green");
        GameObject yellow = GameObject.FindGameObjectWithTag("Yellow");
        GameObject purple = GameObject.FindGameObjectWithTag("Purple");
        GameObject white = GameObject.FindGameObjectWithTag("White");
        #endregion
        if (red.GetComponent<Meeple>().priority != null)
        {
            switch (red.GetComponent<Meeple>().priority)
            {
                case 0:
                    uno.SetActive(true);
                    uno.GetComponent<SpriteRenderer>().color = red.GetComponent<Meeple>().colour;
                    break;
                case 1:
                    dos.SetActive(true);
                    dos.GetComponent<SpriteRenderer>().color = red.GetComponent<Meeple>().colour;
                    break;
                case 2:
                    tres.SetActive(true);
                    tres.GetComponent<SpriteRenderer>().color = red.GetComponent<Meeple>().colour;
                    break;
                case 3:
                    cuatro.SetActive(true);
                    cuatro.GetComponent<SpriteRenderer>().color = red.GetComponent<Meeple>().colour;
                    break;
                case 4:
                    cinco.SetActive(true);
                    cinco.GetComponent<SpriteRenderer>().color = red.GetComponent<Meeple>().colour;
                    break;
                case 5:
                    seis.SetActive(true);
                    seis.GetComponent<SpriteRenderer>().color = red.GetComponent<Meeple>().colour;
                    break;
            }
        }
        if (blue.GetComponent<Meeple>().priority != null)
        {
            switch (blue.GetComponent<Meeple>().priority)
            {
                case 0:
                    uno.SetActive(true);
                    uno.GetComponent<SpriteRenderer>().color = blue.GetComponent<Meeple>().colour;
                    break;
                case 1:
                    dos.SetActive(true);
                    dos.GetComponent<SpriteRenderer>().color = blue.GetComponent<Meeple>().colour;
                    break;
                case 2:
                    tres.SetActive(true);
                    tres.GetComponent<SpriteRenderer>().color = blue.GetComponent<Meeple>().colour;
                    break;
                case 3:
                    cuatro.SetActive(true);
                    cuatro.GetComponent<SpriteRenderer>().color = blue.GetComponent<Meeple>().colour;
                    break;
                case 4:
                    cinco.SetActive(true);
                    cinco.GetComponent<SpriteRenderer>().color = blue.GetComponent<Meeple>().colour;
                    break;
                case 5:
                    seis.SetActive(true);
                    seis.GetComponent<SpriteRenderer>().color = blue.GetComponent<Meeple>().colour;
                    break;
            }
        }
        if (green.GetComponent<Meeple>().priority != null)
        {
            switch (green.GetComponent<Meeple>().priority)
            {
                case 0:
                    uno.SetActive(true);
                    uno.GetComponent<SpriteRenderer>().color = green.GetComponent<Meeple>().colour;
                    break;
                case 1:
                    dos.SetActive(true);
                    dos.GetComponent<SpriteRenderer>().color = green.GetComponent<Meeple>().colour;
                    break;
                case 2:
                    tres.SetActive(true);
                    tres.GetComponent<SpriteRenderer>().color = green.GetComponent<Meeple>().colour;
                    break;
                case 3:
                    cuatro.SetActive(true);
                    cuatro.GetComponent<SpriteRenderer>().color = green.GetComponent<Meeple>().colour;
                    break;
                case 4:
                    cinco.SetActive(true);
                    cinco.GetComponent<SpriteRenderer>().color = green.GetComponent<Meeple>().colour;
                    break;
                case 5:
                    seis.SetActive(true);
                    seis.GetComponent<SpriteRenderer>().color = green.GetComponent<Meeple>().colour;
                    break;
            }
        }
        if (yellow.GetComponent<Meeple>().priority != null)
        {
            switch (yellow.GetComponent<Meeple>().priority)
            {
                case 0:
                    uno.SetActive(true);
                    uno.GetComponent<SpriteRenderer>().color = yellow.GetComponent<Meeple>().colour;
                    break;
                case 1:
                    dos.SetActive(true);
                    dos.GetComponent<SpriteRenderer>().color = yellow.GetComponent<Meeple>().colour;
                    break;
                case 2:
                    tres.SetActive(true);
                    tres.GetComponent<SpriteRenderer>().color = yellow.GetComponent<Meeple>().colour;
                    break;
                case 3:
                    cuatro.SetActive(true);
                    cuatro.GetComponent<SpriteRenderer>().color = yellow.GetComponent<Meeple>().colour;
                    break;
                case 4:
                    cinco.SetActive(true);
                    cinco.GetComponent<SpriteRenderer>().color = yellow.GetComponent<Meeple>().colour;
                    break;
                case 5:
                    seis.SetActive(true);
                    seis.GetComponent<SpriteRenderer>().color = yellow.GetComponent<Meeple>().colour;
                    break;
            }
        }
        if (purple.GetComponent<Meeple>().priority != null)
        {
            switch (purple.GetComponent<Meeple>().priority)
            {
                case 0:
                    uno.SetActive(true);
                    uno.GetComponent<SpriteRenderer>().color = purple.GetComponent<Meeple>().colour;
                    break;
                case 1:
                    dos.SetActive(true);
                    dos.GetComponent<SpriteRenderer>().color = purple.GetComponent<Meeple>().colour;
                    break;
                case 2:
                    tres.SetActive(true);
                    tres.GetComponent<SpriteRenderer>().color = purple.GetComponent<Meeple>().colour;
                    break;
                case 3:
                    cuatro.SetActive(true);
                    cuatro.GetComponent<SpriteRenderer>().color = purple.GetComponent<Meeple>().colour;
                    break;
                case 4:
                    cinco.SetActive(true);
                    cinco.GetComponent<SpriteRenderer>().color = purple.GetComponent<Meeple>().colour;
                    break;
                case 5:
                    seis.SetActive(true);
                    seis.GetComponent<SpriteRenderer>().color = purple.GetComponent<Meeple>().colour;
                    break;
            }
        }
        if (white.GetComponent<Meeple>().priority != null)
        {
            switch (white.GetComponent<Meeple>().priority)
            {
                case 0:
                    uno.SetActive(true);
                    uno.GetComponent<SpriteRenderer>().color = white.GetComponent<Meeple>().colour;
                    break;
                case 1:
                    dos.SetActive(true);
                    dos.GetComponent<SpriteRenderer>().color = white.GetComponent<Meeple>().colour;
                    break;
                case 2:
                    tres.SetActive(true);
                    tres.GetComponent<SpriteRenderer>().color = white.GetComponent<Meeple>().colour;
                    break;
                case 3:
                    cuatro.SetActive(true);
                    cuatro.GetComponent<SpriteRenderer>().color = white.GetComponent<Meeple>().colour;
                    break;
                case 4:
                    cinco.SetActive(true);
                    cinco.GetComponent<SpriteRenderer>().color = white.GetComponent<Meeple>().colour;
                    break;
                case 5:
                    seis.SetActive(true);
                    seis.GetComponent<SpriteRenderer>().color = white.GetComponent<Meeple>().colour;
                    break;
            }
        }
    }

    public void Move(int amount, GameObject merson)
    {
        DiceButton = GameObject.FindGameObjectWithTag("DiceButton").GetComponent<Button>();
        GameObject[] boardArray = info.GetComponent<GameState>().boardArray;
        GameObject nextSpace = boardArray.GetValue(currentSpace + amount) as GameObject;
        StartCoroutine(MoveToPosition(merson, nextSpace, 2.4f));
        print("Merson: " + merson.name);
        print("Dice Result: " + amount);
        print("Current Space: " + (currentSpace + 1));
        print("Board Action: " + nextSpace.GetComponent<BoardSpace>().action);
        print("Board Action Number: " + nextSpace.GetComponent<BoardSpace>().actionNum);
        print("------------------------------------");
        switch (nextSpace.GetComponent<BoardSpace>().action)
        {
            case 1:
                nextSpace = boardArray.GetValue(nextSpace.GetComponent<BoardSpace>().actionNum - 1) as GameObject;
                StartCoroutine(WaitABit(merson, nextSpace, boardArray));
                break;
            case 2:
                nextSpace = boardArray.GetValue(nextSpace.GetComponent<BoardSpace>().actionNum - 1) as GameObject;
                StartCoroutine(WaitABit(merson, nextSpace, boardArray));
                break;
            default:
                DiceButton.interactable = true;
                break;
        }
        currentSpace += amount;

    }

    public IEnumerator MoveToPosition(GameObject merson, GameObject nextSpace, float timeToMove)
    {
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            merson.transform.position = Vector2.Lerp(merson.transform.position, nextSpace.transform.position, t);
            yield return null;
        }
    }

    public IEnumerator WaitABit(GameObject merson, GameObject nextSpace, GameObject[] boardArray)
    {
        DiceButton = GameObject.FindGameObjectWithTag("DiceButton").GetComponent<Button>();
        yield return new WaitForSeconds(1.2f);
        GameObject onSpace = boardArray[merson.GetComponent<Meeple>().currentSpace];
        nextSpace = boardArray[onSpace.GetComponent<BoardSpace>().actionNum - 1];
        merson.GetComponent<Meeple>().currentSpace = nextSpace.GetComponent<BoardSpace>().spaceNumber - 1;
        StartCoroutine(MoveToPosition(merson, nextSpace, 1.2f));
        DiceButton.interactable = true;
    }
}
