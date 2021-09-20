using UnityEngine;

public class InputHandler
{
    public int GetOptionByKey()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            return 0;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            return 1;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            return 2;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            return 3;
        }

        return -1;
    }
}
