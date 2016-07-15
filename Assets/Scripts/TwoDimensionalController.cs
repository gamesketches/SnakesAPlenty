using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TwoDimensionalController : MonoBehaviour
{
    public float speed = 3f;
    public float upTurnTime = 3.0f;
    public float leftTurnTime = 3.0f;
    public float downTurnTime = 3.0f;
    public float rightTurnTime = 3.0f;
    Rigidbody2D _rigidBody;
    public float anglarSpeed = 90f; //degree per seconds
    List<int> inputStack;

    string debugStarter, debugEnder;

    public int player = 0;

    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.velocity = transform.up;
        inputStack = new List<int>();
        inputStack.Add(0);

        debugEnder = "</color>";
        if (player == 0)
        {
            debugStarter = "<color=red>";
        }
        else if (player == 1)
            debugStarter = "<color=purple>";
        else if (player == 2)
            debugStarter = "<color=yellow>";
        else if (player == 3)
            debugStarter = "<color=blue>";
    }

    enum DirectionalKey
    {
        Left, Right, Up, Down
    }

    bool GetKeyDown(DirectionalKey directionalKey)
    {
        if (directionalKey == DirectionalKey.Up)
        {
            if (player == 0)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                    return true;
                else return false;
            }
            else if (player == 1)
            {
                if (Input.GetKeyDown(KeyCode.W))
                    return true;
                else return false;
            }
            else if (player == 2)
            {
                if (Input.GetKeyDown(KeyCode.T))
                    return true;
                else return false;
            }
            else if (player == 3)
            {
                if (Input.GetKeyDown(KeyCode.I))
                    return true;
                else return false;
            }
            else return false;
        }
        else if (directionalKey == DirectionalKey.Down)
        {
            if (player == 0)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                    return true;
                else return false;
            }
            else if (player == 1)
            {
                if (Input.GetKeyDown(KeyCode.S))
                    return true;
                else return false;
            }
            else if (player == 2)
            {
                if (Input.GetKeyDown(KeyCode.G))
                    return true;
                else return false;
            }
            else if (player == 3)
            {
                if (Input.GetKeyDown(KeyCode.K))
                    return true;
                else return false;
            }
            else return false;
        }
        else if (directionalKey == DirectionalKey.Left)
        {
            if (player == 0)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                    return true;
                else return false;
            }
            else if (player == 1)
            {
                if (Input.GetKeyDown(KeyCode.A))
                    return true;
                else return false;
            }
            else if (player == 2)
            {
                if (Input.GetKeyDown(KeyCode.F))
                    return true;
                else return false;
            }
            else if (player == 3)
            {
                if (Input.GetKeyDown(KeyCode.J))
                    return true;
                else return false;
            }
            else return false;
        }
        else if (directionalKey == DirectionalKey.Right)
        {
            if (player == 0)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                    return true;
                else return false;
            }
            else if (player == 1)
            {
                if (Input.GetKeyDown(KeyCode.D))
                    return true;
                else return false;
            }
            else if (player == 2)
            {
                if (Input.GetKeyDown(KeyCode.H))
                    return true;
                else return false;
            }
            else if (player == 3)
            {
                if (Input.GetKeyDown(KeyCode.L))
                    return true;
                else return false;
            }
            else return false;
        }
        else
            return false;

    }

	bool GetKey(DirectionalKey directionalKey)
    {
        if (directionalKey == DirectionalKey.Up)
        {
            if (player == 0)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                    return true;
                else return false;
            }
            else if (player == 1)
            {
                if (Input.GetKey(KeyCode.W))
                    return true;
                else return false;
            }
            else if (player == 2)
            {
                if (Input.GetKey(KeyCode.T))
                    return true;
                else return false;
            }
            else if (player == 3)
            {
                if (Input.GetKey(KeyCode.I))
                    return true;
                else return false;
            }
            else return false;
        }
        else if (directionalKey == DirectionalKey.Down)
        {
            if (player == 0)
            {
                if (Input.GetKey(KeyCode.DownArrow))
                    return true;
                else return false;
            }
            else if (player == 1)
            {
                if (Input.GetKey(KeyCode.S))
                    return true;
                else return false;
            }
            else if (player == 2)
            {
                if (Input.GetKey(KeyCode.G))
                    return true;
                else return false;
            }
            else if (player == 3)
            {
                if (Input.GetKey(KeyCode.K))
                    return true;
                else return false;
            }
            else return false;
        }
        else if (directionalKey == DirectionalKey.Left)
        {
            if (player == 0)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                    return true;
                else return false;
            }
            else if (player == 1)
            {
                if (Input.GetKey(KeyCode.A))
                    return true;
                else return false;
            }
            else if (player == 2)
            {
                if (Input.GetKey(KeyCode.F))
                    return true;
                else return false;
            }
            else if (player == 3)
            {
                if (Input.GetKey(KeyCode.J))
                    return true;
                else return false;
            }
            else return false;
        }
        else if (directionalKey == DirectionalKey.Right)
        {
            if (player == 0)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                    return true;
                else return false;
            }
            else if (player == 1)
            {
                if (Input.GetKey(KeyCode.D))
                    return true;
                else return false;
            }
            else if (player == 2)
            {
                if (Input.GetKey(KeyCode.H))
                    return true;
                else return false;
            }
            else if (player == 3)
            {
                if (Input.GetKey(KeyCode.L))
                    return true;
                else return false;
            }
            else return false;
        }
        else
            return false;

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log (_rigidBody.velocity);


        Vector3 direction = Vector3.zero;
        int currentDirect = inputStack[inputStack.Count - 1];
        if (GetKeyDown(DirectionalKey.Left))
        {
            if (currentDirect != 1)
            {
                Debug.Log(debugStarter + "player" + player + " add left!" + debugEnder);
                inputStack.Add(1);
            }
        }
        else if (GetKeyDown(DirectionalKey.Right))
        {
            if (currentDirect != 2)
            {
                Debug.Log(debugStarter + "player" + player + " add right!" + debugEnder);
                inputStack.Add(2);
            }
        }
        else if (GetKeyDown(DirectionalKey.Up))
        {
            if (currentDirect != 3)
            {
                Debug.Log(debugStarter + "player" + player + " add up!" + debugEnder);
                inputStack.Add(3);
            }
        }
        else if (GetKeyDown(DirectionalKey.Down))
        {
            if (currentDirect != 4)
            {
                Debug.Log(debugStarter + "player" + player + " add down!" + debugEnder);
                inputStack.Add(4);
            }
        }

        while (inputStack.Count > 1)
        {
            currentDirect = inputStack[inputStack.Count - 1];
            if (currentDirect == 1)
            {
                if (!GetKey(DirectionalKey.Left))
                    inputStack.RemoveAt(inputStack.Count - 1);
                else
                    break;
            }
            if (currentDirect == 2)
            {
                if (!GetKey(DirectionalKey.Right))
                    inputStack.RemoveAt(inputStack.Count - 1);
                else
                    break;
            }
            if (currentDirect == 3)
            {
                if (!GetKey(DirectionalKey.Up))
                    inputStack.RemoveAt(inputStack.Count - 1);
                else
                    break;
            }
            if (currentDirect == 4)
            {
                if (!GetKey(DirectionalKey.Down))
                    inputStack.RemoveAt(inputStack.Count - 1);
                else
                    break;
            }

        }
        currentDirect = inputStack[inputStack.Count - 1];

        if (currentDirect == 0)
            direction = Vector2.zero;
        else if (currentDirect == 1)
            direction = Vector2.left;
        else if (currentDirect == 2)
            direction = Vector2.right;
        else if (currentDirect == 3)
            direction = Vector2.up;
        else if (currentDirect == 4)
            direction = Vector2.down;


        _rigidBody.velocity = Quaternion.Euler(0f, 0f, isTurnLeft(_rigidBody.velocity, direction) * anglarSpeed * Time.deltaTime * 75f) * _rigidBody.velocity.normalized * speed;

    }

    private int isTurnLeft(Vector2 vec1, Vector2 vec2)
    {
        Vector3 _vec1 = vec1.normalized;
        Vector3 _vec2 = vec2.normalized;
        Vector3 _cross = Vector3.Cross(_vec1, _vec2);
        if (_cross.z > 0.01f)
            return 1;
        else if (_cross.z < -0.01f)
            return -1;
        else return 0;
    }
}
